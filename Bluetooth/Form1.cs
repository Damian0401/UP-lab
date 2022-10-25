using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Radios;

namespace Test
{
    public partial class FormMain : Form
    {
        private int _dotCounter = 0;
        private readonly List<BluetoothDeviceInfo> _bluetoothDeviceInfos;
        private BluetoothDeviceInfo _selectedBluetoothDevice;
        public FormMain()
        {
            InitializeComponent();
            _bluetoothDeviceInfos = new List<BluetoothDeviceInfo>();
        }

        private async void button_scan_Click(object sender, EventArgs e)
        {
            await GetBluetoothDevicesAsync();
            RepaintDevicesGrid();
            dataGridView_scan.ClearSelection();
        }

        private void timer_waiting_Tick(object sender, EventArgs e)
        {
            if (_dotCounter == 0)
            {
                label_waiting.Text = "waiting";
                _dotCounter++;
                return;
            }

            _dotCounter++;

            if (_dotCounter > 3)
            {
                _dotCounter = 0;
            }

            label_waiting.Text = label_waiting.Text + ".";
        }

        private async Task GetBluetoothDevicesAsync()
        {
            button_scan.Enabled = false;
            timer_waiting.Start();
            var client = new BluetoothClient();
            BluetoothDeviceInfo[] devices = await Task.Factory.StartNew(() => client.DiscoverDevices());
            timer_waiting.Stop();
            label_waiting.Text = "";
            _dotCounter = 0;
            button_scan.Enabled = true;
            _bluetoothDeviceInfos.Clear();
            _bluetoothDeviceInfos.AddRange(devices);
        }

        private void dataGridView_scan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = dataGridView_scan.CurrentCell.RowIndex;
            var selectedRow = dataGridView_scan.Rows[rowIndex];
            var deviceAddress = selectedRow.Cells[1].Value.ToString();
            _selectedBluetoothDevice = _bluetoothDeviceInfos
                .FirstOrDefault(x => x.DeviceAddress.ToString()
                    .Equals(deviceAddress));

            if (_selectedBluetoothDevice is null)
            {
                MessageBox.Show("Device not found");
                dataGridView_scan.ClearSelection();
                return;
            }

            RepaintSelectedDevice();
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            var columnNames = new List<string>
            {
                "deviceName",
                "deviceAddress",
                "lastSeen",
                "lastUsed",
                "remembered",
            };
            columnNames.ForEach(x => dataGridView_scan.Columns.Add(x, x));
            dataGridView_scan.ReadOnly = true;
            dataGridView_scan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_scan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView_scan.RowHeadersVisible = false;
            dataGridView_scan.AllowUserToAddRows = false;
            await InitializeBluetooth();
        }

        private async Task InitializeBluetooth()
        {
            var result = await Radio.RequestAccessAsync();
            if (result == RadioAccessStatus.Allowed)
            {
                var bluetoothRadios = await Radio.GetRadiosAsync();
                var bluetooth = bluetoothRadios.FirstOrDefault(radio => radio.Kind == RadioKind.Bluetooth);
                if (bluetooth != null && bluetooth.State != RadioState.On)
                    await bluetooth.SetStateAsync(RadioState.On);
            }
        }

        private void RepaintDevicesGrid()
        {
            dataGridView_scan.Rows.Clear();
            foreach (BluetoothDeviceInfo device in _bluetoothDeviceInfos)
            {
                string[] row = new string[]
                {
                    device.DeviceName.ToString(),
                    device.DeviceAddress.ToString(),
                    device.LastSeen.ToString(),
                    device.LastUsed.ToString(),
                    device.Remembered.ToString()
                };
                dataGridView_scan.Rows.Add(row);
            }
        }

        private void RepaintSelectedDevice()
        {
            if (_selectedBluetoothDevice is null)
            {
                textBox_selectedDeviceName.Text = "";
                textBox_selectedDeviceIsConnected.Text = "";
                textBox_selectedDeviceIsAuthorized.Text = "";
                button_cancelSelectedDevice.Enabled = false;
                button_pair.Enabled = false;
                button_send.Enabled = false;
                return;
            }

            textBox_selectedDeviceName.Text = _selectedBluetoothDevice.DeviceName;
            textBox_selectedDeviceIsAuthorized.Text = _selectedBluetoothDevice.Authenticated.ToString();
            textBox_selectedDeviceIsConnected.Text = _selectedBluetoothDevice.Connected.ToString();
            button_cancelSelectedDevice.Enabled = true;
            button_pair.Enabled = !_selectedBluetoothDevice.Authenticated;
            button_send.Enabled = _selectedBluetoothDevice.Authenticated;
        }

        private void button_cancelSelectedDevice_Click(object sender, EventArgs e)
        {
            dataGridView_scan.ClearSelection();
            _selectedBluetoothDevice = null;
            RepaintSelectedDevice();
        }

        private async void button_pair_Click(object sender, EventArgs e)
        {
            if (_selectedBluetoothDevice is null)
            {
                return;
            }

            var result = await Task.Factory
                .StartNew(() => BluetoothSecurity
                    .PairRequest(_selectedBluetoothDevice.DeviceAddress, null));

            await GetBluetoothDevicesAsync();
            _selectedBluetoothDevice = _bluetoothDeviceInfos
                .FirstOrDefault(x => x.DeviceAddress.Equals(_selectedBluetoothDevice.DeviceAddress));
            RepaintSelectedDevice();
            RepaintDevicesGrid();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (_selectedBluetoothDevice is null)
            {
                return;
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "allowed files|*.txt;*.png;*.jpg;*.jpeg";
                openFileDialog.RestoreDirectory = true;

                openFileDialog.FileOk += delegate (object s, CancelEventArgs ev)
                {
                    var size = new FileInfo(openFileDialog.FileName).Length;
                    if (size > 5000000)
                    {
                        MessageBox.Show("File size is too big");
                        ev.Cancel = true;
                    }
                };
                
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("File not selected");
                    return;
                }

                var pureFileName = openFileDialog.FileName
                    .Split('\\')
                    .Last();

                Uri uri = new Uri($"obex://{_selectedBluetoothDevice.DeviceAddress}/{pureFileName}");

                var request = new ObexWebRequest(uri);

                try
                {
                    request.ReadFile(openFileDialog.FileName);
                    var response = (ObexWebResponse)request.GetResponse();
                    MessageBox.Show("File sent successfuly");
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File does not exist");
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to send file");
                }
            }
        }

        private void CloseBluetooth()
        {
            Task.Run(async () =>
            {
                var result = await Radio.RequestAccessAsync();
                if (result == RadioAccessStatus.Allowed)
                {
                    var bluetoothRadios = await Radio.GetRadiosAsync();
                    var bluetooth = bluetoothRadios.FirstOrDefault(radio => radio.Kind == RadioKind.Bluetooth);
                    if (bluetooth != null && bluetooth.State == RadioState.On)
                        await bluetooth.SetStateAsync(RadioState.Off);
                }
            }).Wait();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseBluetooth();
        }
    }
}
