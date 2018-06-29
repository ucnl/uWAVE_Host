namespace uWAVE_Host
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.connectBtn = new System.Windows.Forms.ToolStripButton();
            this.settingsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.infoBtn = new System.Windows.Forms.ToolStripButton();
            this.isRawModeOnlyBtn = new System.Windows.Forms.ToolStripButton();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectionStateLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.actionLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.rawModePanel = new System.Windows.Forms.Panel();
            this.rawDataSendBtn = new System.Windows.Forms.Button();
            this.rawDataInputTxb = new System.Windows.Forms.TextBox();
            this.rawDataInputContextMnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generateDatetimeStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomString16BytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomString32BytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawModeHistoryTxb = new System.Windows.Forms.RichTextBox();
            this.rawModeToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.rawHistoryClearBtn = new System.Windows.Forms.ToolStripButton();
            this.rawHistoryExportBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.rawHistoryExportToPlainTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawHistoryCopyToClipboardBtn = new System.Windows.Forms.ToolStripButton();
            this.commandPanel = new System.Windows.Forms.Panel();
            this.commandTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.devInfoGetLbl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsRxIDCbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.settingsTxIDCbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.settingsApplyLbl = new System.Windows.Forms.LinkLabel();
            this.remoteQueryLbl = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.targetRxIDCbx = new System.Windows.Forms.ComboBox();
            this.queryIDCbx = new System.Windows.Forms.ComboBox();
            this.systemLbl = new System.Windows.Forms.Label();
            this.coreLbl = new System.Windows.Forms.Label();
            this.acBaudrateLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalChannelsLbl = new System.Windows.Forms.Label();
            this.commandToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.historyTxb = new System.Windows.Forms.RichTextBox();
            this.historyToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.historyClearBtn = new System.Windows.Forms.ToolStripButton();
            this.historyExportBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.historyExportToPlainTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyCopyToClipboardBtn = new System.Windows.Forms.ToolStripButton();
            this.mainToolStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.rawModePanel.SuspendLayout();
            this.rawDataInputContextMnu.SuspendLayout();
            this.rawModeToolStrip.SuspendLayout();
            this.commandPanel.SuspendLayout();
            this.commandTableLayout.SuspendLayout();
            this.commandToolStrip.SuspendLayout();
            this.historyToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectBtn,
            this.settingsBtn,
            this.toolStripSeparator1,
            this.infoBtn,
            this.isRawModeOnlyBtn});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(680, 25);
            this.mainToolStrip.TabIndex = 0;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // connectBtn
            // 
            this.connectBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.connectBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectBtn.Image = ((System.Drawing.Image)(resources.GetObject("connectBtn.Image")));
            this.connectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(67, 22);
            this.connectBtn.Text = "CONNECT";
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(63, 22);
            this.settingsBtn.Text = "SETTINGS";
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // infoBtn
            // 
            this.infoBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.infoBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBtn.Image = ((System.Drawing.Image)(resources.GetObject("infoBtn.Image")));
            this.infoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(38, 22);
            this.infoBtn.Text = "INFO";
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // isRawModeOnlyBtn
            // 
            this.isRawModeOnlyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.isRawModeOnlyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isRawModeOnlyBtn.Image = ((System.Drawing.Image)(resources.GetObject("isRawModeOnlyBtn.Image")));
            this.isRawModeOnlyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.isRawModeOnlyBtn.Name = "isRawModeOnlyBtn";
            this.isRawModeOnlyBtn.Size = new System.Drawing.Size(73, 22);
            this.isRawModeOnlyBtn.Text = "RAW MODE";
            this.isRawModeOnlyBtn.Click += new System.EventHandler(this.isRawModeOnlyBtn_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.connectionStateLbl,
            this.toolStripStatusLabel2,
            this.actionLbl});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 378);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(680, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel1.Text = "CONNECTION:";
            // 
            // connectionStateLbl
            // 
            this.connectionStateLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectionStateLbl.Name = "connectionStateLbl";
            this.connectionStateLbl.Size = new System.Drawing.Size(51, 17);
            this.connectionStateLbl.Text = "CLOSED";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel2.Text = "ACTION:";
            // 
            // actionLbl
            // 
            this.actionLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionLbl.Name = "actionLbl";
            this.actionLbl.Size = new System.Drawing.Size(32, 17);
            this.actionLbl.Text = "IDLE";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 25);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.rawModePanel);
            this.mainSplitContainer.Panel1.Controls.Add(this.commandPanel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.historyTxb);
            this.mainSplitContainer.Panel2.Controls.Add(this.historyToolStrip);
            this.mainSplitContainer.Size = new System.Drawing.Size(680, 353);
            this.mainSplitContainer.SplitterDistance = 228;
            this.mainSplitContainer.SplitterWidth = 3;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // rawModePanel
            // 
            this.rawModePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawModePanel.Controls.Add(this.rawDataSendBtn);
            this.rawModePanel.Controls.Add(this.rawDataInputTxb);
            this.rawModePanel.Controls.Add(this.rawModeHistoryTxb);
            this.rawModePanel.Controls.Add(this.rawModeToolStrip);
            this.rawModePanel.Location = new System.Drawing.Point(272, 2);
            this.rawModePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rawModePanel.Name = "rawModePanel";
            this.rawModePanel.Size = new System.Drawing.Size(406, 224);
            this.rawModePanel.TabIndex = 1;
            // 
            // rawDataSendBtn
            // 
            this.rawDataSendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rawDataSendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawDataSendBtn.Location = new System.Drawing.Point(347, 202);
            this.rawDataSendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rawDataSendBtn.Name = "rawDataSendBtn";
            this.rawDataSendBtn.Size = new System.Drawing.Size(56, 20);
            this.rawDataSendBtn.TabIndex = 3;
            this.rawDataSendBtn.Text = "SEND";
            this.rawDataSendBtn.UseVisualStyleBackColor = true;
            this.rawDataSendBtn.Click += new System.EventHandler(this.rawDataSendBtn_Click);
            // 
            // rawDataInputTxb
            // 
            this.rawDataInputTxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawDataInputTxb.ContextMenuStrip = this.rawDataInputContextMnu;
            this.rawDataInputTxb.Location = new System.Drawing.Point(2, 202);
            this.rawDataInputTxb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rawDataInputTxb.MaxLength = 128;
            this.rawDataInputTxb.Name = "rawDataInputTxb";
            this.rawDataInputTxb.Size = new System.Drawing.Size(341, 20);
            this.rawDataInputTxb.TabIndex = 2;
            this.rawDataInputTxb.TextChanged += new System.EventHandler(this.rawDataInputTxb_TextChanged);
            // 
            // rawDataInputContextMnu
            // 
            this.rawDataInputContextMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateDatetimeStringToolStripMenuItem,
            this.randomString16BytesToolStripMenuItem,
            this.randomString32BytesToolStripMenuItem});
            this.rawDataInputContextMnu.Name = "rawDataInputContextMnu";
            this.rawDataInputContextMnu.Size = new System.Drawing.Size(210, 70);
            // 
            // generateDatetimeStringToolStripMenuItem
            // 
            this.generateDatetimeStringToolStripMenuItem.Name = "generateDatetimeStringToolStripMenuItem";
            this.generateDatetimeStringToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.generateDatetimeStringToolStripMenuItem.Text = "Generate date-time string";
            this.generateDatetimeStringToolStripMenuItem.Click += new System.EventHandler(this.generateDatetimeStringToolStripMenuItem_Click);
            // 
            // randomString16BytesToolStripMenuItem
            // 
            this.randomString16BytesToolStripMenuItem.Name = "randomString16BytesToolStripMenuItem";
            this.randomString16BytesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.randomString16BytesToolStripMenuItem.Text = "Random string 16 bytes";
            this.randomString16BytesToolStripMenuItem.Click += new System.EventHandler(this.randomString16BytesToolStripMenuItem_Click);
            // 
            // randomString32BytesToolStripMenuItem
            // 
            this.randomString32BytesToolStripMenuItem.Name = "randomString32BytesToolStripMenuItem";
            this.randomString32BytesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.randomString32BytesToolStripMenuItem.Text = "Random string 32 bytes";
            this.randomString32BytesToolStripMenuItem.Click += new System.EventHandler(this.randomString32BytesToolStripMenuItem_Click);
            // 
            // rawModeHistoryTxb
            // 
            this.rawModeHistoryTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawModeHistoryTxb.Location = new System.Drawing.Point(2, 23);
            this.rawModeHistoryTxb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rawModeHistoryTxb.Name = "rawModeHistoryTxb";
            this.rawModeHistoryTxb.ReadOnly = true;
            this.rawModeHistoryTxb.Size = new System.Drawing.Size(402, 176);
            this.rawModeHistoryTxb.TabIndex = 1;
            this.rawModeHistoryTxb.Text = "";
            this.rawModeHistoryTxb.TextChanged += new System.EventHandler(this.rawModeHistoryTxb_TextChanged);
            // 
            // rawModeToolStrip
            // 
            this.rawModeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripSeparator4,
            this.rawHistoryClearBtn,
            this.rawHistoryExportBtn,
            this.rawHistoryCopyToClipboardBtn});
            this.rawModeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.rawModeToolStrip.Name = "rawModeToolStrip";
            this.rawModeToolStrip.Size = new System.Drawing.Size(406, 25);
            this.rawModeToolStrip.TabIndex = 0;
            this.rawModeToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(101, 22);
            this.toolStripLabel3.Text = "RAW DATA MODE";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // rawHistoryClearBtn
            // 
            this.rawHistoryClearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rawHistoryClearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rawHistoryClearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawHistoryClearBtn.Image = ((System.Drawing.Image)(resources.GetObject("rawHistoryClearBtn.Image")));
            this.rawHistoryClearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rawHistoryClearBtn.Name = "rawHistoryClearBtn";
            this.rawHistoryClearBtn.Size = new System.Drawing.Size(46, 22);
            this.rawHistoryClearBtn.Text = "CLEAR";
            this.rawHistoryClearBtn.Click += new System.EventHandler(this.rawHistoryClearBtn_Click);
            // 
            // rawHistoryExportBtn
            // 
            this.rawHistoryExportBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rawHistoryExportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rawHistoryExportBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawHistoryExportToPlainTextToolStripMenuItem});
            this.rawHistoryExportBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawHistoryExportBtn.Image = ((System.Drawing.Image)(resources.GetObject("rawHistoryExportBtn.Image")));
            this.rawHistoryExportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rawHistoryExportBtn.Name = "rawHistoryExportBtn";
            this.rawHistoryExportBtn.Size = new System.Drawing.Size(62, 22);
            this.rawHistoryExportBtn.Text = "EXPORT";
            // 
            // rawHistoryExportToPlainTextToolStripMenuItem
            // 
            this.rawHistoryExportToPlainTextToolStripMenuItem.Name = "rawHistoryExportToPlainTextToolStripMenuItem";
            this.rawHistoryExportToPlainTextToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.rawHistoryExportToPlainTextToolStripMenuItem.Text = "TO PLAIN TEXT...";
            this.rawHistoryExportToPlainTextToolStripMenuItem.Click += new System.EventHandler(this.rawHistoryExportToPlainTextToolStripMenuItem_Click);
            // 
            // rawHistoryCopyToClipboardBtn
            // 
            this.rawHistoryCopyToClipboardBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rawHistoryCopyToClipboardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rawHistoryCopyToClipboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawHistoryCopyToClipboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("rawHistoryCopyToClipboardBtn.Image")));
            this.rawHistoryCopyToClipboardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rawHistoryCopyToClipboardBtn.Name = "rawHistoryCopyToClipboardBtn";
            this.rawHistoryCopyToClipboardBtn.Size = new System.Drawing.Size(42, 22);
            this.rawHistoryCopyToClipboardBtn.Text = "COPY";
            this.rawHistoryCopyToClipboardBtn.Click += new System.EventHandler(this.rawHistoryCopyToClipboardBtn_Click);
            // 
            // commandPanel
            // 
            this.commandPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.commandPanel.Controls.Add(this.commandTableLayout);
            this.commandPanel.Controls.Add(this.commandToolStrip);
            this.commandPanel.Location = new System.Drawing.Point(2, 2);
            this.commandPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commandPanel.Name = "commandPanel";
            this.commandPanel.Size = new System.Drawing.Size(266, 224);
            this.commandPanel.TabIndex = 0;
            // 
            // commandTableLayout
            // 
            this.commandTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandTableLayout.ColumnCount = 3;
            this.commandTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.commandTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.commandTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.commandTableLayout.Controls.Add(this.label2, 0, 1);
            this.commandTableLayout.Controls.Add(this.label3, 0, 2);
            this.commandTableLayout.Controls.Add(this.label5, 0, 3);
            this.commandTableLayout.Controls.Add(this.devInfoGetLbl, 2, 0);
            this.commandTableLayout.Controls.Add(this.label1, 1, 0);
            this.commandTableLayout.Controls.Add(this.settingsRxIDCbx, 1, 7);
            this.commandTableLayout.Controls.Add(this.label7, 0, 7);
            this.commandTableLayout.Controls.Add(this.label6, 0, 6);
            this.commandTableLayout.Controls.Add(this.settingsTxIDCbx, 1, 6);
            this.commandTableLayout.Controls.Add(this.label9, 1, 5);
            this.commandTableLayout.Controls.Add(this.label8, 1, 8);
            this.commandTableLayout.Controls.Add(this.settingsApplyLbl, 2, 5);
            this.commandTableLayout.Controls.Add(this.remoteQueryLbl, 2, 8);
            this.commandTableLayout.Controls.Add(this.label10, 0, 9);
            this.commandTableLayout.Controls.Add(this.label11, 0, 10);
            this.commandTableLayout.Controls.Add(this.targetRxIDCbx, 1, 9);
            this.commandTableLayout.Controls.Add(this.queryIDCbx, 1, 10);
            this.commandTableLayout.Controls.Add(this.systemLbl, 1, 1);
            this.commandTableLayout.Controls.Add(this.coreLbl, 1, 2);
            this.commandTableLayout.Controls.Add(this.acBaudrateLbl, 1, 3);
            this.commandTableLayout.Controls.Add(this.label4, 0, 4);
            this.commandTableLayout.Controls.Add(this.totalChannelsLbl, 1, 4);
            this.commandTableLayout.Location = new System.Drawing.Point(2, 23);
            this.commandTableLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commandTableLayout.Name = "commandTableLayout";
            this.commandTableLayout.RowCount = 12;
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.commandTableLayout.Size = new System.Drawing.Size(261, 198);
            this.commandTableLayout.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Core";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(2, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Acoustic baudrate";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // devInfoGetLbl
            // 
            this.devInfoGetLbl.AutoSize = true;
            this.devInfoGetLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devInfoGetLbl.Location = new System.Drawing.Point(213, 0);
            this.devInfoGetLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.devInfoGetLbl.Name = "devInfoGetLbl";
            this.devInfoGetLbl.Size = new System.Drawing.Size(78, 13);
            this.devInfoGetLbl.TabIndex = 9;
            this.devInfoGetLbl.TabStop = true;
            this.devInfoGetLbl.Text = "GET";
            this.devInfoGetLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devInfoGetLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.devInfoGetLbl_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(99, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEVICE INFO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsRxIDCbx
            // 
            this.settingsRxIDCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsRxIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsRxIDCbx.FormattingEnabled = true;
            this.settingsRxIDCbx.Location = new System.Drawing.Point(99, 108);
            this.settingsRxIDCbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsRxIDCbx.Name = "settingsRxIDCbx";
            this.settingsRxIDCbx.Size = new System.Drawing.Size(110, 21);
            this.settingsRxIDCbx.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(2, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rx ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(2, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tx ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsTxIDCbx
            // 
            this.settingsTxIDCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTxIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsTxIDCbx.FormattingEnabled = true;
            this.settingsTxIDCbx.Location = new System.Drawing.Point(99, 83);
            this.settingsTxIDCbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsTxIDCbx.Name = "settingsTxIDCbx";
            this.settingsTxIDCbx.Size = new System.Drawing.Size(110, 21);
            this.settingsTxIDCbx.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(99, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "SETTINGS";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(99, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "QUERY REMOTE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsApplyLbl
            // 
            this.settingsApplyLbl.AutoSize = true;
            this.settingsApplyLbl.Location = new System.Drawing.Point(213, 68);
            this.settingsApplyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.settingsApplyLbl.Name = "settingsApplyLbl";
            this.settingsApplyLbl.Size = new System.Drawing.Size(41, 13);
            this.settingsApplyLbl.TabIndex = 10;
            this.settingsApplyLbl.TabStop = true;
            this.settingsApplyLbl.Text = "APPLY";
            this.settingsApplyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsApplyLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.settingsApplyLbl_LinkClicked);
            // 
            // remoteQueryLbl
            // 
            this.remoteQueryLbl.AutoSize = true;
            this.remoteQueryLbl.Location = new System.Drawing.Point(213, 131);
            this.remoteQueryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.remoteQueryLbl.Name = "remoteQueryLbl";
            this.remoteQueryLbl.Size = new System.Drawing.Size(45, 13);
            this.remoteQueryLbl.TabIndex = 14;
            this.remoteQueryLbl.TabStop = true;
            this.remoteQueryLbl.Text = "QUERY";
            this.remoteQueryLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.remoteQueryLbl_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(2, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Target Rx ID";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(2, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Query";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // targetRxIDCbx
            // 
            this.targetRxIDCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetRxIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetRxIDCbx.FormattingEnabled = true;
            this.targetRxIDCbx.Location = new System.Drawing.Point(99, 146);
            this.targetRxIDCbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.targetRxIDCbx.Name = "targetRxIDCbx";
            this.targetRxIDCbx.Size = new System.Drawing.Size(110, 21);
            this.targetRxIDCbx.TabIndex = 17;
            // 
            // queryIDCbx
            // 
            this.queryIDCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryIDCbx.FormattingEnabled = true;
            this.queryIDCbx.Location = new System.Drawing.Point(99, 171);
            this.queryIDCbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queryIDCbx.Name = "queryIDCbx";
            this.queryIDCbx.Size = new System.Drawing.Size(110, 21);
            this.queryIDCbx.TabIndex = 18;
            // 
            // systemLbl
            // 
            this.systemLbl.AutoSize = true;
            this.systemLbl.Location = new System.Drawing.Point(99, 13);
            this.systemLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.systemLbl.Name = "systemLbl";
            this.systemLbl.Size = new System.Drawing.Size(43, 13);
            this.systemLbl.TabIndex = 19;
            this.systemLbl.Text = "no data";
            // 
            // coreLbl
            // 
            this.coreLbl.AutoSize = true;
            this.coreLbl.Location = new System.Drawing.Point(99, 26);
            this.coreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coreLbl.Name = "coreLbl";
            this.coreLbl.Size = new System.Drawing.Size(43, 13);
            this.coreLbl.TabIndex = 20;
            this.coreLbl.Text = "no data";
            // 
            // acBaudrateLbl
            // 
            this.acBaudrateLbl.AutoSize = true;
            this.acBaudrateLbl.Location = new System.Drawing.Point(99, 39);
            this.acBaudrateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.acBaudrateLbl.Name = "acBaudrateLbl";
            this.acBaudrateLbl.Size = new System.Drawing.Size(43, 13);
            this.acBaudrateLbl.TabIndex = 21;
            this.acBaudrateLbl.Text = "no data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total channels";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalChannelsLbl
            // 
            this.totalChannelsLbl.AutoSize = true;
            this.totalChannelsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalChannelsLbl.Location = new System.Drawing.Point(99, 52);
            this.totalChannelsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalChannelsLbl.Name = "totalChannelsLbl";
            this.totalChannelsLbl.Size = new System.Drawing.Size(110, 16);
            this.totalChannelsLbl.TabIndex = 23;
            this.totalChannelsLbl.Text = "no data";
            this.totalChannelsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // commandToolStrip
            // 
            this.commandToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripSeparator3});
            this.commandToolStrip.Location = new System.Drawing.Point(0, 0);
            this.commandToolStrip.Name = "commandToolStrip";
            this.commandToolStrip.Size = new System.Drawing.Size(266, 25);
            this.commandToolStrip.TabIndex = 0;
            this.commandToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(108, 22);
            this.toolStripLabel2.Text = "COMMAND MODE";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // historyTxb
            // 
            this.historyTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyTxb.Location = new System.Drawing.Point(2, 23);
            this.historyTxb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.historyTxb.MaxLength = 65536;
            this.historyTxb.Name = "historyTxb";
            this.historyTxb.ReadOnly = true;
            this.historyTxb.Size = new System.Drawing.Size(677, 101);
            this.historyTxb.TabIndex = 1;
            this.historyTxb.Text = "";
            this.historyTxb.TextChanged += new System.EventHandler(this.historyTxb_TextChanged);
            // 
            // historyToolStrip
            // 
            this.historyToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.historyClearBtn,
            this.historyExportBtn,
            this.historyCopyToClipboardBtn});
            this.historyToolStrip.Location = new System.Drawing.Point(0, 0);
            this.historyToolStrip.Name = "historyToolStrip";
            this.historyToolStrip.Size = new System.Drawing.Size(680, 25);
            this.historyToolStrip.TabIndex = 0;
            this.historyToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 22);
            this.toolStripLabel1.Text = "HISORY WINDOW";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // historyClearBtn
            // 
            this.historyClearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.historyClearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historyClearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyClearBtn.Image = ((System.Drawing.Image)(resources.GetObject("historyClearBtn.Image")));
            this.historyClearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.historyClearBtn.Name = "historyClearBtn";
            this.historyClearBtn.Size = new System.Drawing.Size(46, 22);
            this.historyClearBtn.Text = "CLEAR";
            this.historyClearBtn.Click += new System.EventHandler(this.historyClearBtn_Click);
            // 
            // historyExportBtn
            // 
            this.historyExportBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.historyExportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historyExportBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyExportToPlainTextToolStripMenuItem});
            this.historyExportBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyExportBtn.Image = ((System.Drawing.Image)(resources.GetObject("historyExportBtn.Image")));
            this.historyExportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.historyExportBtn.Name = "historyExportBtn";
            this.historyExportBtn.Size = new System.Drawing.Size(62, 22);
            this.historyExportBtn.Text = "EXPORT";
            // 
            // historyExportToPlainTextToolStripMenuItem
            // 
            this.historyExportToPlainTextToolStripMenuItem.Name = "historyExportToPlainTextToolStripMenuItem";
            this.historyExportToPlainTextToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.historyExportToPlainTextToolStripMenuItem.Text = "TO PLAIN TEXT...";
            this.historyExportToPlainTextToolStripMenuItem.Click += new System.EventHandler(this.toPlainTextToolStripMenuItem_Click);
            // 
            // historyCopyToClipboardBtn
            // 
            this.historyCopyToClipboardBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.historyCopyToClipboardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historyCopyToClipboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyCopyToClipboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("historyCopyToClipboardBtn.Image")));
            this.historyCopyToClipboardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.historyCopyToClipboardBtn.Name = "historyCopyToClipboardBtn";
            this.historyCopyToClipboardBtn.Size = new System.Drawing.Size(42, 22);
            this.historyCopyToClipboardBtn.Text = "COPY";
            this.historyCopyToClipboardBtn.Click += new System.EventHandler(this.historyCopyToClipboardBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "uWAVE Host";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.rawModePanel.ResumeLayout(false);
            this.rawModePanel.PerformLayout();
            this.rawDataInputContextMnu.ResumeLayout(false);
            this.rawModeToolStrip.ResumeLayout(false);
            this.rawModeToolStrip.PerformLayout();
            this.commandPanel.ResumeLayout(false);
            this.commandPanel.PerformLayout();
            this.commandTableLayout.ResumeLayout(false);
            this.commandTableLayout.PerformLayout();
            this.commandToolStrip.ResumeLayout(false);
            this.commandToolStrip.PerformLayout();
            this.historyToolStrip.ResumeLayout(false);
            this.historyToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ToolStripButton connectBtn;
        private System.Windows.Forms.ToolStripButton settingsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton infoBtn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel connectionStateLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel actionLbl;
        private System.Windows.Forms.RichTextBox historyTxb;
        private System.Windows.Forms.ToolStrip historyToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton historyClearBtn;
        private System.Windows.Forms.ToolStripDropDownButton historyExportBtn;
        private System.Windows.Forms.ToolStripMenuItem historyExportToPlainTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton historyCopyToClipboardBtn;
        private System.Windows.Forms.ToolStripButton isRawModeOnlyBtn;
        private System.Windows.Forms.Panel rawModePanel;
        private System.Windows.Forms.ToolStrip rawModeToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel commandPanel;
        private System.Windows.Forms.ToolStrip commandToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button rawDataSendBtn;
        private System.Windows.Forms.TextBox rawDataInputTxb;
        private System.Windows.Forms.RichTextBox rawModeHistoryTxb;
        private System.Windows.Forms.TableLayoutPanel commandTableLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox settingsTxIDCbx;
        private System.Windows.Forms.ComboBox settingsRxIDCbx;
        private System.Windows.Forms.LinkLabel devInfoGetLbl;
        private System.Windows.Forms.LinkLabel settingsApplyLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel remoteQueryLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox targetRxIDCbx;
        private System.Windows.Forms.ComboBox queryIDCbx;
        private System.Windows.Forms.Label systemLbl;
        private System.Windows.Forms.Label coreLbl;
        private System.Windows.Forms.Label acBaudrateLbl;
        private System.Windows.Forms.ToolStripButton rawHistoryClearBtn;
        private System.Windows.Forms.ToolStripDropDownButton rawHistoryExportBtn;
        private System.Windows.Forms.ToolStripButton rawHistoryCopyToClipboardBtn;
        private System.Windows.Forms.ToolStripMenuItem rawHistoryExportToPlainTextToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip rawDataInputContextMnu;
        private System.Windows.Forms.ToolStripMenuItem generateDatetimeStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomString16BytesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomString32BytesToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalChannelsLbl;
    }
}

