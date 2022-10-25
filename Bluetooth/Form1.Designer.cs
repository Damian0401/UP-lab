
namespace Test
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_scan = new System.Windows.Forms.DataGridView();
            this.button_scan = new System.Windows.Forms.Button();
            this.label_waiting = new System.Windows.Forms.Label();
            this.timer_waiting = new System.Windows.Forms.Timer(this.components);
            this.label_devices = new System.Windows.Forms.Label();
            this.groupBox_selectedDevice = new System.Windows.Forms.GroupBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_pair = new System.Windows.Forms.Button();
            this.button_cancelSelectedDevice = new System.Windows.Forms.Button();
            this.label_selectedDeviceIsConnected = new System.Windows.Forms.Label();
            this.textBox_selectedDeviceIsConnected = new System.Windows.Forms.TextBox();
            this.label_selectedDeviceIsAuthorized = new System.Windows.Forms.Label();
            this.textBox_selectedDeviceIsAuthorized = new System.Windows.Forms.TextBox();
            this.label_selectedDeviceName = new System.Windows.Forms.Label();
            this.textBox_selectedDeviceName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scan)).BeginInit();
            this.groupBox_selectedDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_scan
            // 
            this.dataGridView_scan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_scan.Location = new System.Drawing.Point(13, 42);
            this.dataGridView_scan.Name = "dataGridView_scan";
            this.dataGridView_scan.RowHeadersWidth = 51;
            this.dataGridView_scan.RowTemplate.Height = 24;
            this.dataGridView_scan.Size = new System.Drawing.Size(538, 226);
            this.dataGridView_scan.TabIndex = 0;
            this.dataGridView_scan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_scan_CellContentClick);
            // 
            // button_scan
            // 
            this.button_scan.Location = new System.Drawing.Point(390, 279);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(161, 25);
            this.button_scan.TabIndex = 1;
            this.button_scan.Text = "Scan for devices";
            this.button_scan.UseVisualStyleBackColor = true;
            this.button_scan.Click += new System.EventHandler(this.button_scan_Click);
            // 
            // label_waiting
            // 
            this.label_waiting.AutoSize = true;
            this.label_waiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_waiting.Location = new System.Drawing.Point(12, 279);
            this.label_waiting.Name = "label_waiting";
            this.label_waiting.Size = new System.Drawing.Size(0, 20);
            this.label_waiting.TabIndex = 2;
            // 
            // timer_waiting
            // 
            this.timer_waiting.Interval = 500;
            this.timer_waiting.Tick += new System.EventHandler(this.timer_waiting_Tick);
            // 
            // label_devices
            // 
            this.label_devices.AutoSize = true;
            this.label_devices.Location = new System.Drawing.Point(13, 23);
            this.label_devices.Name = "label_devices";
            this.label_devices.Size = new System.Drawing.Size(62, 17);
            this.label_devices.TabIndex = 3;
            this.label_devices.Text = "Devices:";
            // 
            // groupBox_selectedDevice
            // 
            this.groupBox_selectedDevice.Controls.Add(this.label_selectedDeviceIsConnected);
            this.groupBox_selectedDevice.Controls.Add(this.button_send);
            this.groupBox_selectedDevice.Controls.Add(this.textBox_selectedDeviceIsConnected);
            this.groupBox_selectedDevice.Controls.Add(this.label_selectedDeviceIsAuthorized);
            this.groupBox_selectedDevice.Controls.Add(this.button_pair);
            this.groupBox_selectedDevice.Controls.Add(this.textBox_selectedDeviceIsAuthorized);
            this.groupBox_selectedDevice.Controls.Add(this.label_selectedDeviceName);
            this.groupBox_selectedDevice.Controls.Add(this.textBox_selectedDeviceName);
            this.groupBox_selectedDevice.Location = new System.Drawing.Point(557, 42);
            this.groupBox_selectedDevice.Name = "groupBox_selectedDevice";
            this.groupBox_selectedDevice.Size = new System.Drawing.Size(239, 226);
            this.groupBox_selectedDevice.TabIndex = 4;
            this.groupBox_selectedDevice.TabStop = false;
            this.groupBox_selectedDevice.Text = "Selected device";
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(22, 183);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(80, 25);
            this.button_send.TabIndex = 8;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_pair
            // 
            this.button_pair.Enabled = false;
            this.button_pair.Location = new System.Drawing.Point(136, 183);
            this.button_pair.Name = "button_pair";
            this.button_pair.Size = new System.Drawing.Size(80, 25);
            this.button_pair.TabIndex = 7;
            this.button_pair.Text = "Pair";
            this.button_pair.UseVisualStyleBackColor = true;
            this.button_pair.Click += new System.EventHandler(this.button_pair_Click);
            // 
            // button_cancelSelectedDevice
            // 
            this.button_cancelSelectedDevice.Enabled = false;
            this.button_cancelSelectedDevice.Location = new System.Drawing.Point(638, 278);
            this.button_cancelSelectedDevice.Name = "button_cancelSelectedDevice";
            this.button_cancelSelectedDevice.Size = new System.Drawing.Size(135, 26);
            this.button_cancelSelectedDevice.TabIndex = 6;
            this.button_cancelSelectedDevice.Text = "Deselect device";
            this.button_cancelSelectedDevice.UseVisualStyleBackColor = true;
            this.button_cancelSelectedDevice.Click += new System.EventHandler(this.button_cancelSelectedDevice_Click);
            // 
            // label_selectedDeviceIsConnected
            // 
            this.label_selectedDeviceIsConnected.AutoSize = true;
            this.label_selectedDeviceIsConnected.Location = new System.Drawing.Point(133, 108);
            this.label_selectedDeviceIsConnected.Name = "label_selectedDeviceIsConnected";
            this.label_selectedDeviceIsConnected.Size = new System.Drawing.Size(90, 17);
            this.label_selectedDeviceIsConnected.TabIndex = 5;
            this.label_selectedDeviceIsConnected.Text = "IsConnected:";
            // 
            // textBox_selectedDeviceIsConnected
            // 
            this.textBox_selectedDeviceIsConnected.Enabled = false;
            this.textBox_selectedDeviceIsConnected.Location = new System.Drawing.Point(136, 128);
            this.textBox_selectedDeviceIsConnected.Name = "textBox_selectedDeviceIsConnected";
            this.textBox_selectedDeviceIsConnected.Size = new System.Drawing.Size(80, 22);
            this.textBox_selectedDeviceIsConnected.TabIndex = 4;
            // 
            // label_selectedDeviceIsAuthorized
            // 
            this.label_selectedDeviceIsAuthorized.AutoSize = true;
            this.label_selectedDeviceIsAuthorized.Location = new System.Drawing.Point(19, 108);
            this.label_selectedDeviceIsAuthorized.Name = "label_selectedDeviceIsAuthorized";
            this.label_selectedDeviceIsAuthorized.Size = new System.Drawing.Size(90, 17);
            this.label_selectedDeviceIsAuthorized.TabIndex = 3;
            this.label_selectedDeviceIsAuthorized.Text = "IsAuthorized:";
            // 
            // textBox_selectedDeviceIsAuthorized
            // 
            this.textBox_selectedDeviceIsAuthorized.Enabled = false;
            this.textBox_selectedDeviceIsAuthorized.Location = new System.Drawing.Point(22, 128);
            this.textBox_selectedDeviceIsAuthorized.Name = "textBox_selectedDeviceIsAuthorized";
            this.textBox_selectedDeviceIsAuthorized.Size = new System.Drawing.Size(80, 22);
            this.textBox_selectedDeviceIsAuthorized.TabIndex = 2;
            // 
            // label_selectedDeviceName
            // 
            this.label_selectedDeviceName.AutoSize = true;
            this.label_selectedDeviceName.Location = new System.Drawing.Point(19, 30);
            this.label_selectedDeviceName.Name = "label_selectedDeviceName";
            this.label_selectedDeviceName.Size = new System.Drawing.Size(49, 17);
            this.label_selectedDeviceName.TabIndex = 1;
            this.label_selectedDeviceName.Text = "Name:";
            // 
            // textBox_selectedDeviceName
            // 
            this.textBox_selectedDeviceName.Enabled = false;
            this.textBox_selectedDeviceName.Location = new System.Drawing.Point(22, 50);
            this.textBox_selectedDeviceName.Name = "textBox_selectedDeviceName";
            this.textBox_selectedDeviceName.Size = new System.Drawing.Size(194, 22);
            this.textBox_selectedDeviceName.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 329);
            this.Controls.Add(this.button_cancelSelectedDevice);
            this.Controls.Add(this.groupBox_selectedDevice);
            this.Controls.Add(this.label_devices);
            this.Controls.Add(this.label_waiting);
            this.Controls.Add(this.button_scan);
            this.Controls.Add(this.dataGridView_scan);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scan)).EndInit();
            this.groupBox_selectedDevice.ResumeLayout(false);
            this.groupBox_selectedDevice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_scan;
        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.Label label_waiting;
        private System.Windows.Forms.Timer timer_waiting;
        private System.Windows.Forms.Label label_devices;
        private System.Windows.Forms.GroupBox groupBox_selectedDevice;
        private System.Windows.Forms.TextBox textBox_selectedDeviceName;
        private System.Windows.Forms.Label label_selectedDeviceIsConnected;
        private System.Windows.Forms.TextBox textBox_selectedDeviceIsConnected;
        private System.Windows.Forms.Label label_selectedDeviceIsAuthorized;
        private System.Windows.Forms.TextBox textBox_selectedDeviceIsAuthorized;
        private System.Windows.Forms.Label label_selectedDeviceName;
        private System.Windows.Forms.Button button_cancelSelectedDevice;
        private System.Windows.Forms.Button button_pair;
        private System.Windows.Forms.Button button_send;
    }
}

