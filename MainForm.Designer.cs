namespace Serial_Terminal
{
    public partial class MainForm
    {
        
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabSerialComm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbConnectedTimeValue = new System.Windows.Forms.Label();
            this.lbTimeConnectedText = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbParity = new System.Windows.Forms.Label();
            this.lbStopBits = new System.Windows.Forms.Label();
            this.cbDatabits = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.lbDatabits = new System.Windows.Forms.Label();
            this.lbStopBitText = new System.Windows.Forms.Label();
            this.lbBaudRateText = new System.Windows.Forms.Label();
            this.lblCOMSelection = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.lbConnectedStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cbCOMPorts = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbBytesReceivedText = new System.Windows.Forms.Label();
            this.lbBytesReceivedValue = new System.Windows.Forms.Label();
            this.tabSerialComm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSerialComm
            // 
            this.tabSerialComm.AccessibleName = "";
            this.tabSerialComm.Controls.Add(this.tabPage1);
            this.tabSerialComm.Controls.Add(this.tabPage2);
            this.tabSerialComm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSerialComm.Location = new System.Drawing.Point(0, 0);
            this.tabSerialComm.Name = "tabSerialComm";
            this.tabSerialComm.SelectedIndex = 0;
            this.tabSerialComm.Size = new System.Drawing.Size(800, 450);
            this.tabSerialComm.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbBytesReceivedValue);
            this.groupBox1.Controls.Add(this.lbBytesReceivedText);
            this.groupBox1.Controls.Add(this.lbConnectedTimeValue);
            this.groupBox1.Controls.Add(this.lbTimeConnectedText);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbParity);
            this.groupBox1.Controls.Add(this.lbStopBits);
            this.groupBox1.Controls.Add(this.cbDatabits);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.lbDatabits);
            this.groupBox1.Controls.Add(this.lbStopBitText);
            this.groupBox1.Controls.Add(this.lbBaudRateText);
            this.groupBox1.Controls.Add(this.lblCOMSelection);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.cbStopBits);
            this.groupBox1.Controls.Add(this.lbConnectedStatus);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.cbCOMPorts);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.cbBaudRate);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Terminal";
            // 
            // lbConnectedTimeValue
            // 
            this.lbConnectedTimeValue.AutoSize = true;
            this.lbConnectedTimeValue.Location = new System.Drawing.Point(722, 71);
            this.lbConnectedTimeValue.Name = "lbConnectedTimeValue";
            this.lbConnectedTimeValue.Size = new System.Drawing.Size(13, 15);
            this.lbConnectedTimeValue.TabIndex = 23;
            this.lbConnectedTimeValue.Text = "0";
            // 
            // lbTimeConnectedText
            // 
            this.lbTimeConnectedText.AutoSize = true;
            this.lbTimeConnectedText.Location = new System.Drawing.Point(614, 71);
            this.lbTimeConnectedText.Name = "lbTimeConnectedText";
            this.lbTimeConnectedText.Size = new System.Drawing.Size(101, 15);
            this.lbTimeConnectedText.TabIndex = 22;
            this.lbTimeConnectedText.Text = "Time Connected :";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear Window";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 23);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Location = new System.Drawing.Point(19, 159);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(37, 15);
            this.lbParity.TabIndex = 19;
            this.lbParity.Text = "Pairty";
            // 
            // lbStopBits
            // 
            this.lbStopBits.AutoSize = true;
            this.lbStopBits.Location = new System.Drawing.Point(19, 203);
            this.lbStopBits.Name = "lbStopBits";
            this.lbStopBits.Size = new System.Drawing.Size(53, 15);
            this.lbStopBits.TabIndex = 17;
            this.lbStopBits.Text = "Data Bits";
            // 
            // cbDatabits
            // 
            this.cbDatabits.FormattingEnabled = true;
            this.cbDatabits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cbDatabits.Location = new System.Drawing.Point(19, 221);
            this.cbDatabits.Name = "cbDatabits";
            this.cbDatabits.Size = new System.Drawing.Size(121, 23);
            this.cbDatabits.TabIndex = 16;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(539, 21);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // lbDatabits
            // 
            this.lbDatabits.Location = new System.Drawing.Point(0, 0);
            this.lbDatabits.Name = "lbDatabits";
            this.lbDatabits.Size = new System.Drawing.Size(100, 23);
            this.lbDatabits.TabIndex = 18;
            // 
            // lbStopBitText
            // 
            this.lbStopBitText.AutoSize = true;
            this.lbStopBitText.Location = new System.Drawing.Point(19, 115);
            this.lbStopBitText.Name = "lbStopBitText";
            this.lbStopBitText.Size = new System.Drawing.Size(48, 15);
            this.lbStopBitText.TabIndex = 11;
            this.lbStopBitText.Text = "Stop Bit";
            // 
            // lbBaudRateText
            // 
            this.lbBaudRateText.AutoSize = true;
            this.lbBaudRateText.Location = new System.Drawing.Point(19, 71);
            this.lbBaudRateText.Name = "lbBaudRateText";
            this.lbBaudRateText.Size = new System.Drawing.Size(60, 15);
            this.lbBaudRateText.TabIndex = 10;
            this.lbBaudRateText.Text = "Baud Rate";
            // 
            // lblCOMSelection
            // 
            this.lblCOMSelection.AutoSize = true;
            this.lblCOMSelection.Location = new System.Drawing.Point(19, 27);
            this.lblCOMSelection.Name = "lblCOMSelection";
            this.lblCOMSelection.Size = new System.Drawing.Size(60, 15);
            this.lblCOMSelection.TabIndex = 9;
            this.lblCOMSelection.Text = "COM Port";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbParity.Location = new System.Drawing.Point(19, 177);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 23);
            this.cbParity.TabIndex = 8;
            this.cbParity.SelectedIndexChanged += new System.EventHandler(this.cbParity_SelectedIndexChanged);
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbStopBits.Location = new System.Drawing.Point(19, 133);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(121, 23);
            this.cbStopBits.TabIndex = 7;
            this.cbStopBits.SelectedIndexChanged += new System.EventHandler(this.cbStopBits_SelectedIndexChanged);
            // 
            // lbConnectedStatus
            // 
            this.lbConnectedStatus.AutoSize = true;
            this.lbConnectedStatus.Location = new System.Drawing.Point(46, 312);
            this.lbConnectedStatus.Name = "lbConnectedStatus";
            this.lbConnectedStatus.Size = new System.Drawing.Size(79, 15);
            this.lbConnectedStatus.TabIndex = 5;
            this.lbConnectedStatus.Text = "Disconnected";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(87, 286);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cbCOMPorts
            // 
            this.cbCOMPorts.FormattingEnabled = true;
            this.cbCOMPorts.Location = new System.Drawing.Point(19, 45);
            this.cbCOMPorts.Name = "cbCOMPorts";
            this.cbCOMPorts.Size = new System.Drawing.Size(121, 23);
            this.cbCOMPorts.TabIndex = 3;
            this.cbCOMPorts.SelectedIndexChanged += new System.EventHandler(this.cbCOMPorts_SelectedIndexChanged);
            this.cbCOMPorts.Click += new System.EventHandler(this.cbCOMPorts_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(183, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 316);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(19, 89);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 23);
            this.cbBaudRate.TabIndex = 1;
            this.cbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbBaudRate_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 286);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbBytesReceivedText
            // 
            this.lbBytesReceivedText.AutoSize = true;
            this.lbBytesReceivedText.Location = new System.Drawing.Point(618, 92);
            this.lbBytesReceivedText.Name = "lbBytesReceivedText";
            this.lbBytesReceivedText.Size = new System.Drawing.Size(91, 15);
            this.lbBytesReceivedText.TabIndex = 24;
            this.lbBytesReceivedText.Text = "Bytes Received :";
            // 
            // lbBytesReceivedValue
            // 
            this.lbBytesReceivedValue.AutoSize = true;
            this.lbBytesReceivedValue.Location = new System.Drawing.Point(722, 92);
            this.lbBytesReceivedValue.Name = "lbBytesReceivedValue";
            this.lbBytesReceivedValue.Size = new System.Drawing.Size(13, 15);
            this.lbBytesReceivedValue.TabIndex = 25;
            this.lbBytesReceivedValue.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabSerialComm);
            this.Name = "MainForm";
            this.Text = "Serial Terminal";
            this.tabSerialComm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private TabControl tabSerialComm;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        public ComboBox cbCOMPorts;
        private RichTextBox richTextBox1;
        public ComboBox cbBaudRate;
        private Button btnConnect;
        private Button btnDisconnect;
        private Label lbConnectedStatus;
        private Button btnExport;
        private Label lbDatabits;
        private Label lbStopBitText;
        private Label lbBaudRateText;
        private Label lblCOMSelection;
        private Label lbStopBits;
        private Label lbParity;
        public ComboBox cbParity;
        public ComboBox cbStopBits;
        public ComboBox cbDatabits;
        private PictureBox pictureBox1;
        private Button btnClear;
        private System.Windows.Forms.Timer timer1;
        private Label lbConnectedTimeValue;
        private Label lbTimeConnectedText;
        private Label lbBytesReceivedValue;
        private Label lbBytesReceivedText;
    }
}