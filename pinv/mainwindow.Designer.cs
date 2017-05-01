namespace PINV
{
    partial class mainwindow
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLog = new System.Windows.Forms.Panel();
            this.chooseDatabaseActionGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteItemRadioButton = new System.Windows.Forms.RadioButton();
            this.updateItemRadioButton = new System.Windows.Forms.RadioButton();
            this.addItemRadioButton = new System.Windows.Forms.RadioButton();
            this.locateItemRadioButton = new System.Windows.Forms.RadioButton();
            this.viewItemRadioButton = new System.Windows.Forms.RadioButton();
            this.locateItemGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateTotalQuantityButton = new System.Windows.Forms.Button();
            this.calculateTotalPriceButton = new System.Windows.Forms.Button();
            this.totalQuantityLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalQuantityTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.includePaymentInfoCheckBox = new System.Windows.Forms.CheckBox();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.descendingRadioButton = new System.Windows.Forms.RadioButton();
            this.ascendingRadioButton = new System.Windows.Forms.RadioButton();
            this.purchaseDateComboBox_LI = new System.Windows.Forms.ComboBox();
            this.priceComboBox_LI = new System.Windows.Forms.ComboBox();
            this.supplierComboBox_LI = new System.Windows.Forms.ComboBox();
            this.lComponentRadioButton = new System.Windows.Forms.RadioButton();
            this.toolRadioButton = new System.Windows.Forms.RadioButton();
            this.componentRadioButton = new System.Windows.Forms.RadioButton();
            this.typeComboBox_LI = new System.Windows.Forms.ComboBox();
            this.nameComboBox_LI = new System.Windows.Forms.ComboBox();
            this.componentAttrGroupBox = new System.Windows.Forms.GroupBox();
            this.amperageComboBox = new System.Windows.Forms.ComboBox();
            this.voltageComboBox = new System.Windows.Forms.ComboBox();
            this.capacitanceComboBox = new System.Windows.Forms.ComboBox();
            this.resistanceComboBox = new System.Windows.Forms.ComboBox();
            this.lComponentAttrGroupBox = new System.Windows.Forms.GroupBox();
            this.protocolComboBox = new System.Windows.Forms.ComboBox();
            this.lengthComboBox = new System.Windows.Forms.ComboBox();
            this.gaugeComboBox = new System.Windows.Forms.ComboBox();
            this.toolAttrGroupBox = new System.Windows.Forms.GroupBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.cDateComboBox = new System.Windows.Forms.ComboBox();
            this.debugCheckbox = new System.Windows.Forms.CheckBox();
            this.activityPaneLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.submitOutput = new System.Windows.Forms.Button();
            this.outputPane = new System.Windows.Forms.RichTextBox();
            this.queriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainwindowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainwindowBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PINVLabel = new System.Windows.Forms.Label();
            this.dbNameLabel = new System.Windows.Forms.Label();
            this.dbIPLabel = new System.Windows.Forms.Label();
            this.dbUNameLabel = new System.Windows.Forms.Label();
            this.dbPassLabel = new System.Windows.Forms.Label();
            this.dbNameTextBox = new System.Windows.Forms.TextBox();
            this.dbIPTextBox = new System.Windows.Forms.TextBox();
            this.dbUNameTextBox = new System.Windows.Forms.TextBox();
            this.dbPassTextBox = new System.Windows.Forms.MaskedTextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.statusLog.SuspendLayout();
            this.chooseDatabaseActionGroupBox.SuspendLayout();
            this.locateItemGroupBox.SuspendLayout();
            this.sortGroupBox.SuspendLayout();
            this.componentAttrGroupBox.SuspendLayout();
            this.lComponentAttrGroupBox.SuspendLayout();
            this.toolAttrGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainwindowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainwindowBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(946, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "PINVStatusStrip";
            // 
            // connectionToolStripStatusLabel
            // 
            this.connectionToolStripStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.connectionToolStripStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.connectionToolStripStatusLabel.Name = "connectionToolStripStatusLabel";
            this.connectionToolStripStatusLabel.Size = new System.Drawing.Size(223, 17);
            this.connectionToolStripStatusLabel.Text = "MySQL Connection Status: Disconnected";
            // 
            // statusLog
            // 
            this.statusLog.AutoScroll = true;
            this.statusLog.AutoSize = true;
            this.statusLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statusLog.Controls.Add(this.chooseDatabaseActionGroupBox);
            this.statusLog.Controls.Add(this.locateItemGroupBox);
            this.statusLog.Controls.Add(this.debugCheckbox);
            this.statusLog.Controls.Add(this.activityPaneLabel);
            this.statusLog.Controls.Add(this.comboBox1);
            this.statusLog.Controls.Add(this.submitOutput);
            this.statusLog.Controls.Add(this.outputPane);
            this.statusLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLog.Location = new System.Drawing.Point(0, 133);
            this.statusLog.Margin = new System.Windows.Forms.Padding(2);
            this.statusLog.Name = "statusLog";
            this.statusLog.Size = new System.Drawing.Size(946, 392);
            this.statusLog.TabIndex = 2;
            // 
            // chooseDatabaseActionGroupBox
            // 
            this.chooseDatabaseActionGroupBox.Controls.Add(this.deleteItemRadioButton);
            this.chooseDatabaseActionGroupBox.Controls.Add(this.updateItemRadioButton);
            this.chooseDatabaseActionGroupBox.Controls.Add(this.addItemRadioButton);
            this.chooseDatabaseActionGroupBox.Controls.Add(this.locateItemRadioButton);
            this.chooseDatabaseActionGroupBox.Controls.Add(this.viewItemRadioButton);
            this.chooseDatabaseActionGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chooseDatabaseActionGroupBox.Location = new System.Drawing.Point(393, 67);
            this.chooseDatabaseActionGroupBox.Name = "chooseDatabaseActionGroupBox";
            this.chooseDatabaseActionGroupBox.Size = new System.Drawing.Size(523, 52);
            this.chooseDatabaseActionGroupBox.TabIndex = 16;
            this.chooseDatabaseActionGroupBox.TabStop = false;
            this.chooseDatabaseActionGroupBox.Text = "Choose Database Action";
            // 
            // deleteItemRadioButton
            // 
            this.deleteItemRadioButton.AutoSize = true;
            this.deleteItemRadioButton.Location = new System.Drawing.Point(387, 19);
            this.deleteItemRadioButton.Name = "deleteItemRadioButton";
            this.deleteItemRadioButton.Size = new System.Drawing.Size(79, 17);
            this.deleteItemRadioButton.TabIndex = 4;
            this.deleteItemRadioButton.Text = "Delete Item";
            this.deleteItemRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateItemRadioButton
            // 
            this.updateItemRadioButton.AutoSize = true;
            this.updateItemRadioButton.Location = new System.Drawing.Point(291, 19);
            this.updateItemRadioButton.Name = "updateItemRadioButton";
            this.updateItemRadioButton.Size = new System.Drawing.Size(83, 17);
            this.updateItemRadioButton.TabIndex = 3;
            this.updateItemRadioButton.Text = "Update Item";
            this.updateItemRadioButton.UseVisualStyleBackColor = true;
            // 
            // addItemRadioButton
            // 
            this.addItemRadioButton.AutoSize = true;
            this.addItemRadioButton.Location = new System.Drawing.Point(200, 19);
            this.addItemRadioButton.Name = "addItemRadioButton";
            this.addItemRadioButton.Size = new System.Drawing.Size(67, 17);
            this.addItemRadioButton.TabIndex = 2;
            this.addItemRadioButton.Text = "Add Item";
            this.addItemRadioButton.UseVisualStyleBackColor = true;
            // 
            // locateItemRadioButton
            // 
            this.locateItemRadioButton.AutoSize = true;
            this.locateItemRadioButton.Location = new System.Drawing.Point(107, 19);
            this.locateItemRadioButton.Name = "locateItemRadioButton";
            this.locateItemRadioButton.Size = new System.Drawing.Size(81, 17);
            this.locateItemRadioButton.TabIndex = 1;
            this.locateItemRadioButton.Text = "Locate Item";
            this.locateItemRadioButton.UseVisualStyleBackColor = true;
            this.locateItemRadioButton.CheckedChanged += new System.EventHandler(this.locateItemRadioButton_CheckedChanged);
            // 
            // viewItemRadioButton
            // 
            this.viewItemRadioButton.AutoSize = true;
            this.viewItemRadioButton.Checked = true;
            this.viewItemRadioButton.Location = new System.Drawing.Point(16, 19);
            this.viewItemRadioButton.Name = "viewItemRadioButton";
            this.viewItemRadioButton.Size = new System.Drawing.Size(71, 17);
            this.viewItemRadioButton.TabIndex = 0;
            this.viewItemRadioButton.TabStop = true;
            this.viewItemRadioButton.Text = "View Item";
            this.viewItemRadioButton.UseVisualStyleBackColor = true;
            this.viewItemRadioButton.CheckedChanged += new System.EventHandler(this.viewItemRadioButton_CheckedChanged);
            // 
            // locateItemGroupBox
            // 
            this.locateItemGroupBox.Controls.Add(this.calculateTotalQuantityButton);
            this.locateItemGroupBox.Controls.Add(this.calculateTotalPriceButton);
            this.locateItemGroupBox.Controls.Add(this.totalQuantityLabel);
            this.locateItemGroupBox.Controls.Add(this.totalPriceLabel);
            this.locateItemGroupBox.Controls.Add(this.totalQuantityTextBox);
            this.locateItemGroupBox.Controls.Add(this.totalPriceTextBox);
            this.locateItemGroupBox.Controls.Add(this.includePaymentInfoCheckBox);
            this.locateItemGroupBox.Controls.Add(this.generateReportButton);
            this.locateItemGroupBox.Controls.Add(this.sortGroupBox);
            this.locateItemGroupBox.Controls.Add(this.purchaseDateComboBox_LI);
            this.locateItemGroupBox.Controls.Add(this.priceComboBox_LI);
            this.locateItemGroupBox.Controls.Add(this.supplierComboBox_LI);
            this.locateItemGroupBox.Controls.Add(this.lComponentRadioButton);
            this.locateItemGroupBox.Controls.Add(this.toolRadioButton);
            this.locateItemGroupBox.Controls.Add(this.componentRadioButton);
            this.locateItemGroupBox.Controls.Add(this.typeComboBox_LI);
            this.locateItemGroupBox.Controls.Add(this.nameComboBox_LI);
            this.locateItemGroupBox.Controls.Add(this.componentAttrGroupBox);
            this.locateItemGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.locateItemGroupBox.Location = new System.Drawing.Point(393, 119);
            this.locateItemGroupBox.Name = "locateItemGroupBox";
            this.locateItemGroupBox.Size = new System.Drawing.Size(524, 250);
            this.locateItemGroupBox.TabIndex = 15;
            this.locateItemGroupBox.TabStop = false;
            this.locateItemGroupBox.Text = "View an Item in the System";
            // 
            // calculateTotalQuantityButton
            // 
            this.calculateTotalQuantityButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateTotalQuantityButton.Location = new System.Drawing.Point(317, 181);
            this.calculateTotalQuantityButton.Name = "calculateTotalQuantityButton";
            this.calculateTotalQuantityButton.Size = new System.Drawing.Size(75, 23);
            this.calculateTotalQuantityButton.TabIndex = 17;
            this.calculateTotalQuantityButton.Text = "Calculate";
            this.calculateTotalQuantityButton.UseVisualStyleBackColor = true;
            this.calculateTotalQuantityButton.Click += new System.EventHandler(this.calculateTotalQuantityButton_Click);
            // 
            // calculateTotalPriceButton
            // 
            this.calculateTotalPriceButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateTotalPriceButton.Location = new System.Drawing.Point(317, 205);
            this.calculateTotalPriceButton.Name = "calculateTotalPriceButton";
            this.calculateTotalPriceButton.Size = new System.Drawing.Size(75, 23);
            this.calculateTotalPriceButton.TabIndex = 14;
            this.calculateTotalPriceButton.Text = "Calculate";
            this.calculateTotalPriceButton.UseVisualStyleBackColor = true;
            this.calculateTotalPriceButton.Click += new System.EventHandler(this.calculateTotalPriceButton_Click);
            // 
            // totalQuantityLabel
            // 
            this.totalQuantityLabel.AutoSize = true;
            this.totalQuantityLabel.Location = new System.Drawing.Point(166, 186);
            this.totalQuantityLabel.Name = "totalQuantityLabel";
            this.totalQuantityLabel.Size = new System.Drawing.Size(73, 13);
            this.totalQuantityLabel.TabIndex = 16;
            this.totalQuantityLabel.Text = "Total Quantity";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(166, 210);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(58, 13);
            this.totalPriceLabel.TabIndex = 13;
            this.totalPriceLabel.Text = "Total Price";
            // 
            // totalQuantityTextBox
            // 
            this.totalQuantityTextBox.Location = new System.Drawing.Point(248, 183);
            this.totalQuantityTextBox.Name = "totalQuantityTextBox";
            this.totalQuantityTextBox.Size = new System.Drawing.Size(63, 20);
            this.totalQuantityTextBox.TabIndex = 15;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(248, 207);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(63, 20);
            this.totalPriceTextBox.TabIndex = 12;
            // 
            // includePaymentInfoCheckBox
            // 
            this.includePaymentInfoCheckBox.AutoSize = true;
            this.includePaymentInfoCheckBox.Location = new System.Drawing.Point(169, 228);
            this.includePaymentInfoCheckBox.Name = "includePaymentInfoCheckBox";
            this.includePaymentInfoCheckBox.Size = new System.Drawing.Size(160, 17);
            this.includePaymentInfoCheckBox.TabIndex = 11;
            this.includePaymentInfoCheckBox.Text = "Include Payment Infomration";
            this.includePaymentInfoCheckBox.UseVisualStyleBackColor = true;
            this.includePaymentInfoCheckBox.CheckedChanged += new System.EventHandler(this.includePaymentInfoCheckBox_CheckedChanged);
            // 
            // generateReportButton
            // 
            this.generateReportButton.BackColor = System.Drawing.Color.Blue;
            this.generateReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateReportButton.Font = new System.Drawing.Font("Impact", 15F);
            this.generateReportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generateReportButton.Location = new System.Drawing.Point(6, 183);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(157, 61);
            this.generateReportButton.TabIndex = 9;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = false;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.descendingRadioButton);
            this.sortGroupBox.Controls.Add(this.ascendingRadioButton);
            this.sortGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.sortGroupBox.Location = new System.Drawing.Point(423, 189);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(95, 55);
            this.sortGroupBox.TabIndex = 8;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sort Results";
            // 
            // descendingRadioButton
            // 
            this.descendingRadioButton.AutoSize = true;
            this.descendingRadioButton.Checked = true;
            this.descendingRadioButton.Location = new System.Drawing.Point(10, 32);
            this.descendingRadioButton.Name = "descendingRadioButton";
            this.descendingRadioButton.Size = new System.Drawing.Size(82, 17);
            this.descendingRadioButton.TabIndex = 1;
            this.descendingRadioButton.TabStop = true;
            this.descendingRadioButton.Text = "Descending";
            this.descendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // ascendingRadioButton
            // 
            this.ascendingRadioButton.AutoSize = true;
            this.ascendingRadioButton.Location = new System.Drawing.Point(10, 16);
            this.ascendingRadioButton.Name = "ascendingRadioButton";
            this.ascendingRadioButton.Size = new System.Drawing.Size(75, 17);
            this.ascendingRadioButton.TabIndex = 0;
            this.ascendingRadioButton.Text = "Ascending";
            this.ascendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // purchaseDateComboBox_LI
            // 
            this.purchaseDateComboBox_LI.CausesValidation = false;
            this.purchaseDateComboBox_LI.FormattingEnabled = true;
            this.purchaseDateComboBox_LI.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "Before 2012",
            "Before 2017",
            "Select Item Purchase Date"});
            this.purchaseDateComboBox_LI.Location = new System.Drawing.Point(6, 77);
            this.purchaseDateComboBox_LI.Name = "purchaseDateComboBox_LI";
            this.purchaseDateComboBox_LI.Size = new System.Drawing.Size(154, 21);
            this.purchaseDateComboBox_LI.Sorted = true;
            this.purchaseDateComboBox_LI.TabIndex = 7;
            this.purchaseDateComboBox_LI.Text = "Select Item Purchase Date";
            // 
            // priceComboBox_LI
            // 
            this.priceComboBox_LI.CausesValidation = false;
            this.priceComboBox_LI.FormattingEnabled = true;
            this.priceComboBox_LI.Items.AddRange(new object[] {
            "$1.00 - $5.00",
            "$5.00 - $10.00",
            "< $1.00",
            "> $10.00",
            "Select Item Price"});
            this.priceComboBox_LI.Location = new System.Drawing.Point(387, 50);
            this.priceComboBox_LI.Name = "priceComboBox_LI";
            this.priceComboBox_LI.Size = new System.Drawing.Size(121, 21);
            this.priceComboBox_LI.Sorted = true;
            this.priceComboBox_LI.TabIndex = 6;
            this.priceComboBox_LI.Text = "Select Item Price";
            // 
            // supplierComboBox_LI
            // 
            this.supplierComboBox_LI.CausesValidation = false;
            this.supplierComboBox_LI.FormattingEnabled = true;
            this.supplierComboBox_LI.Items.AddRange(new object[] {
            "AliExpress",
            "Fry\'s Electronics",
            "Harbor Freight",
            "Jameco",
            "Private",
            "Select Item Supplier"});
            this.supplierComboBox_LI.Location = new System.Drawing.Point(260, 50);
            this.supplierComboBox_LI.Name = "supplierComboBox_LI";
            this.supplierComboBox_LI.Size = new System.Drawing.Size(121, 21);
            this.supplierComboBox_LI.Sorted = true;
            this.supplierComboBox_LI.TabIndex = 5;
            this.supplierComboBox_LI.Text = "Select Item Supplier";
            // 
            // lComponentRadioButton
            // 
            this.lComponentRadioButton.AutoSize = true;
            this.lComponentRadioButton.Location = new System.Drawing.Point(317, 19);
            this.lComponentRadioButton.Name = "lComponentRadioButton";
            this.lComponentRadioButton.Size = new System.Drawing.Size(109, 17);
            this.lComponentRadioButton.TabIndex = 4;
            this.lComponentRadioButton.TabStop = true;
            this.lComponentRadioButton.Text = "Large Component";
            this.lComponentRadioButton.UseVisualStyleBackColor = true;
            this.lComponentRadioButton.CheckedChanged += new System.EventHandler(this.lComponentRadioButton_CheckedChanged);
            // 
            // toolRadioButton
            // 
            this.toolRadioButton.AutoSize = true;
            this.toolRadioButton.Location = new System.Drawing.Point(175, 19);
            this.toolRadioButton.Name = "toolRadioButton";
            this.toolRadioButton.Size = new System.Drawing.Size(46, 17);
            this.toolRadioButton.TabIndex = 3;
            this.toolRadioButton.TabStop = true;
            this.toolRadioButton.Text = "Tool";
            this.toolRadioButton.UseVisualStyleBackColor = true;
            this.toolRadioButton.CheckedChanged += new System.EventHandler(this.toolRadioButton_CheckedChanged);
            // 
            // componentRadioButton
            // 
            this.componentRadioButton.AutoSize = true;
            this.componentRadioButton.Checked = true;
            this.componentRadioButton.Location = new System.Drawing.Point(16, 19);
            this.componentRadioButton.Name = "componentRadioButton";
            this.componentRadioButton.Size = new System.Drawing.Size(79, 17);
            this.componentRadioButton.TabIndex = 2;
            this.componentRadioButton.TabStop = true;
            this.componentRadioButton.Text = "Component";
            this.componentRadioButton.UseVisualStyleBackColor = true;
            this.componentRadioButton.CheckedChanged += new System.EventHandler(this.componentRadioButton_CheckedChanged);
            // 
            // typeComboBox_LI
            // 
            this.typeComboBox_LI.CausesValidation = false;
            this.typeComboBox_LI.FormattingEnabled = true;
            this.typeComboBox_LI.Items.AddRange(new object[] {
            "Ceramic",
            "Deadblow",
            "Electrolytic",
            "Manual",
            "Module",
            "Rosin-Core",
            "Select Item Type",
            "Select Item Type",
            "Stranded-Core",
            "Through-Hole",
            "Type-A",
            "Type-B",
            "Type-C"});
            this.typeComboBox_LI.Location = new System.Drawing.Point(133, 50);
            this.typeComboBox_LI.Name = "typeComboBox_LI";
            this.typeComboBox_LI.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox_LI.Sorted = true;
            this.typeComboBox_LI.TabIndex = 1;
            this.typeComboBox_LI.Text = "Select Item Type";
            // 
            // nameComboBox_LI
            // 
            this.nameComboBox_LI.CausesValidation = false;
            this.nameComboBox_LI.FormattingEnabled = true;
            this.nameComboBox_LI.Items.AddRange(new object[] {
            "Cable",
            "Capacitor",
            "Hammer",
            "Multimeter",
            "Resistor",
            "Select Item Name",
            "Solder",
            "TFT Display",
            "Transistor",
            "Wire"});
            this.nameComboBox_LI.Location = new System.Drawing.Point(6, 50);
            this.nameComboBox_LI.Name = "nameComboBox_LI";
            this.nameComboBox_LI.Size = new System.Drawing.Size(121, 21);
            this.nameComboBox_LI.Sorted = true;
            this.nameComboBox_LI.TabIndex = 0;
            this.nameComboBox_LI.Text = "Select Item Name";
            // 
            // componentAttrGroupBox
            // 
            this.componentAttrGroupBox.Controls.Add(this.amperageComboBox);
            this.componentAttrGroupBox.Controls.Add(this.voltageComboBox);
            this.componentAttrGroupBox.Controls.Add(this.capacitanceComboBox);
            this.componentAttrGroupBox.Controls.Add(this.resistanceComboBox);
            this.componentAttrGroupBox.Controls.Add(this.lComponentAttrGroupBox);
            this.componentAttrGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.componentAttrGroupBox.Location = new System.Drawing.Point(6, 104);
            this.componentAttrGroupBox.Name = "componentAttrGroupBox";
            this.componentAttrGroupBox.Size = new System.Drawing.Size(512, 73);
            this.componentAttrGroupBox.TabIndex = 10;
            this.componentAttrGroupBox.TabStop = false;
            this.componentAttrGroupBox.Text = "Component Attirbutes";
            // 
            // amperageComboBox
            // 
            this.amperageComboBox.FormattingEnabled = true;
            this.amperageComboBox.Items.AddRange(new object[] {
            "Select Amperage (A)",
            "0.25",
            "0.5",
            "1.25",
            "1"});
            this.amperageComboBox.Location = new System.Drawing.Point(387, 20);
            this.amperageComboBox.Name = "amperageComboBox";
            this.amperageComboBox.Size = new System.Drawing.Size(121, 21);
            this.amperageComboBox.TabIndex = 3;
            this.amperageComboBox.Text = "Select Amperage (A)";
            // 
            // voltageComboBox
            // 
            this.voltageComboBox.FormattingEnabled = true;
            this.voltageComboBox.Items.AddRange(new object[] {
            "Select Voltage (V)",
            "5",
            "6",
            "9",
            "12",
            "20"});
            this.voltageComboBox.Location = new System.Drawing.Point(260, 19);
            this.voltageComboBox.Name = "voltageComboBox";
            this.voltageComboBox.Size = new System.Drawing.Size(121, 21);
            this.voltageComboBox.TabIndex = 2;
            this.voltageComboBox.Text = "Select Voltage (V)";
            // 
            // capacitanceComboBox
            // 
            this.capacitanceComboBox.FormattingEnabled = true;
            this.capacitanceComboBox.Items.AddRange(new object[] {
            "Select Capacitance",
            "1",
            "100",
            "0.1",
            "0.001",
            ".000001"});
            this.capacitanceComboBox.Location = new System.Drawing.Point(133, 20);
            this.capacitanceComboBox.Name = "capacitanceComboBox";
            this.capacitanceComboBox.Size = new System.Drawing.Size(121, 21);
            this.capacitanceComboBox.TabIndex = 1;
            this.capacitanceComboBox.Text = "Select Capacitance (F)";
            // 
            // resistanceComboBox
            // 
            this.resistanceComboBox.FormattingEnabled = true;
            this.resistanceComboBox.Items.AddRange(new object[] {
            "Select Resistance",
            "1",
            "1000",
            "2",
            "2000",
            "10",
            "10000",
            "100",
            "100000",
            "15",
            "15000",
            "22",
            "22000",
            "33",
            "33000",
            "47",
            "47000",
            "68",
            "68000"});
            this.resistanceComboBox.Location = new System.Drawing.Point(6, 20);
            this.resistanceComboBox.Name = "resistanceComboBox";
            this.resistanceComboBox.Size = new System.Drawing.Size(121, 21);
            this.resistanceComboBox.TabIndex = 0;
            this.resistanceComboBox.Text = "Select Resistance (Ω)";
            // 
            // lComponentAttrGroupBox
            // 
            this.lComponentAttrGroupBox.Controls.Add(this.protocolComboBox);
            this.lComponentAttrGroupBox.Controls.Add(this.lengthComboBox);
            this.lComponentAttrGroupBox.Controls.Add(this.gaugeComboBox);
            this.lComponentAttrGroupBox.Controls.Add(this.toolAttrGroupBox);
            this.lComponentAttrGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lComponentAttrGroupBox.Location = new System.Drawing.Point(0, 0);
            this.lComponentAttrGroupBox.Name = "lComponentAttrGroupBox";
            this.lComponentAttrGroupBox.Size = new System.Drawing.Size(512, 73);
            this.lComponentAttrGroupBox.TabIndex = 12;
            this.lComponentAttrGroupBox.TabStop = false;
            this.lComponentAttrGroupBox.Text = "Large Component Attirbutes";
            this.lComponentAttrGroupBox.Visible = false;
            // 
            // protocolComboBox
            // 
            this.protocolComboBox.FormattingEnabled = true;
            this.protocolComboBox.Items.AddRange(new object[] {
            "Select Protocol",
            "USB ",
            "I2C",
            "SPI",
            "USART"});
            this.protocolComboBox.Location = new System.Drawing.Point(260, 20);
            this.protocolComboBox.Name = "protocolComboBox";
            this.protocolComboBox.Size = new System.Drawing.Size(121, 21);
            this.protocolComboBox.TabIndex = 4;
            this.protocolComboBox.Text = "Select Protocol";
            // 
            // lengthComboBox
            // 
            this.lengthComboBox.FormattingEnabled = true;
            this.lengthComboBox.Items.AddRange(new object[] {
            "Select Length (ft)",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.lengthComboBox.Location = new System.Drawing.Point(133, 20);
            this.lengthComboBox.Name = "lengthComboBox";
            this.lengthComboBox.Size = new System.Drawing.Size(121, 21);
            this.lengthComboBox.TabIndex = 1;
            this.lengthComboBox.Text = "Select Length (ft)";
            // 
            // gaugeComboBox
            // 
            this.gaugeComboBox.FormattingEnabled = true;
            this.gaugeComboBox.Items.AddRange(new object[] {
            "Select Gauge (AWG)",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.gaugeComboBox.Location = new System.Drawing.Point(6, 20);
            this.gaugeComboBox.Name = "gaugeComboBox";
            this.gaugeComboBox.Size = new System.Drawing.Size(121, 21);
            this.gaugeComboBox.TabIndex = 0;
            this.gaugeComboBox.Text = "Select Gauge (AWG)";
            // 
            // toolAttrGroupBox
            // 
            this.toolAttrGroupBox.Controls.Add(this.statusComboBox);
            this.toolAttrGroupBox.Controls.Add(this.cDateComboBox);
            this.toolAttrGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolAttrGroupBox.Location = new System.Drawing.Point(0, 0);
            this.toolAttrGroupBox.Name = "toolAttrGroupBox";
            this.toolAttrGroupBox.Size = new System.Drawing.Size(512, 73);
            this.toolAttrGroupBox.TabIndex = 11;
            this.toolAttrGroupBox.TabStop = false;
            this.toolAttrGroupBox.Text = "Tool Attirbutes";
            this.toolAttrGroupBox.Visible = false;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Select Status",
            "Availible",
            "Repair",
            "Junked"});
            this.statusComboBox.Location = new System.Drawing.Point(144, 20);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 1;
            this.statusComboBox.Text = "Select Status";
            // 
            // cDateComboBox
            // 
            this.cDateComboBox.FormattingEnabled = true;
            this.cDateComboBox.Items.AddRange(new object[] {
            "Select Calibration Date",
            "< 1 Month",
            "> 1 Month",
            "> 6 Months",
            "> 1 Year"});
            this.cDateComboBox.Location = new System.Drawing.Point(6, 20);
            this.cDateComboBox.Name = "cDateComboBox";
            this.cDateComboBox.Size = new System.Drawing.Size(132, 21);
            this.cDateComboBox.TabIndex = 0;
            this.cDateComboBox.Text = "Select Calibration Date";
            // 
            // debugCheckbox
            // 
            this.debugCheckbox.AutoSize = true;
            this.debugCheckbox.Location = new System.Drawing.Point(24, 373);
            this.debugCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.debugCheckbox.Name = "debugCheckbox";
            this.debugCheckbox.Size = new System.Drawing.Size(58, 17);
            this.debugCheckbox.TabIndex = 14;
            this.debugCheckbox.Text = "Debug";
            this.debugCheckbox.UseVisualStyleBackColor = true;
            // 
            // activityPaneLabel
            // 
            this.activityPaneLabel.AutoSize = true;
            this.activityPaneLabel.Font = new System.Drawing.Font("Impact", 12F);
            this.activityPaneLabel.ForeColor = System.Drawing.Color.Snow;
            this.activityPaneLabel.Location = new System.Drawing.Point(23, 67);
            this.activityPaneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activityPaneLabel.Name = "activityPaneLabel";
            this.activityPaneLabel.Size = new System.Drawing.Size(76, 20);
            this.activityPaneLabel.TabIndex = 3;
            this.activityPaneLabel.Text = "Status Log";
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Q1: How many 1 Ohm, 0.25 watt resistors do I have, and what\'s thier total cost?",
            "Q2: What is everything I have stored in a bin, purchased before 2017?",
            "Q3: Do I have any three-foot USB cables, and when did I purchase them?",
            "Q4: Where can I find a 3 foot USB Type-C cable?",
            "Q5: Where have I stored the elast expensive capacitors I own?",
            "Q6: How many resistors do I have stored in the system?"});
            this.comboBox1.Location = new System.Drawing.Point(143, 33);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(774, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Select a Sample Query";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // submitOutput
            // 
            this.submitOutput.Location = new System.Drawing.Point(24, 33);
            this.submitOutput.Margin = new System.Windows.Forms.Padding(2);
            this.submitOutput.Name = "submitOutput";
            this.submitOutput.Size = new System.Drawing.Size(115, 19);
            this.submitOutput.TabIndex = 1;
            this.submitOutput.Text = "Submit Sample Query";
            this.submitOutput.UseVisualStyleBackColor = true;
            this.submitOutput.Click += new System.EventHandler(this.submitOutput_Click);
            // 
            // outputPane
            // 
            this.outputPane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPane.BackColor = System.Drawing.SystemColors.WindowText;
            this.outputPane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPane.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputPane.Font = new System.Drawing.Font("Courier New", 7F);
            this.outputPane.ForeColor = System.Drawing.Color.Lime;
            this.outputPane.Location = new System.Drawing.Point(24, 86);
            this.outputPane.Margin = new System.Windows.Forms.Padding(2);
            this.outputPane.Name = "outputPane";
            this.outputPane.ReadOnly = true;
            this.outputPane.Size = new System.Drawing.Size(361, 283);
            this.outputPane.TabIndex = 0;
            this.outputPane.Text = "Welcome to the PINV system";
            this.outputPane.WordWrap = false;
            this.outputPane.ZoomFactor = 1.2F;
            this.outputPane.TextChanged += new System.EventHandler(this.outputPane_TextChanged);
            // 
            // queriesBindingSource
            // 
            this.queriesBindingSource.DataSource = typeof(PINV.SQLQueries.Queries);
            // 
            // mainwindowBindingSource
            // 
            this.mainwindowBindingSource.DataSource = typeof(PINV.mainwindow);
            // 
            // queriesBindingSource1
            // 
            this.queriesBindingSource1.DataSource = typeof(PINV.SQLQueries.Queries);
            // 
            // mainwindowBindingSource1
            // 
            this.mainwindowBindingSource1.DataSource = typeof(PINV.mainwindow);
            // 
            // PINVLabel
            // 
            this.PINVLabel.AutoSize = true;
            this.PINVLabel.Font = new System.Drawing.Font("Impact", 90F);
            this.PINVLabel.ForeColor = System.Drawing.Color.Lime;
            this.PINVLabel.Location = new System.Drawing.Point(-1, 19);
            this.PINVLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PINVLabel.Name = "PINVLabel";
            this.PINVLabel.Size = new System.Drawing.Size(285, 145);
            this.PINVLabel.TabIndex = 3;
            this.PINVLabel.Text = "PINV";
            // 
            // dbNameLabel
            // 
            this.dbNameLabel.AutoSize = true;
            this.dbNameLabel.Font = new System.Drawing.Font("Impact", 16F);
            this.dbNameLabel.ForeColor = System.Drawing.Color.Snow;
            this.dbNameLabel.Location = new System.Drawing.Point(272, 32);
            this.dbNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dbNameLabel.Name = "dbNameLabel";
            this.dbNameLabel.Size = new System.Drawing.Size(151, 27);
            this.dbNameLabel.TabIndex = 4;
            this.dbNameLabel.Text = "Database Name";
            this.dbNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // dbIPLabel
            // 
            this.dbIPLabel.AutoSize = true;
            this.dbIPLabel.Font = new System.Drawing.Font("Impact", 16F);
            this.dbIPLabel.ForeColor = System.Drawing.Color.Snow;
            this.dbIPLabel.Location = new System.Drawing.Point(272, 63);
            this.dbIPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dbIPLabel.Name = "dbIPLabel";
            this.dbIPLabel.Size = new System.Drawing.Size(117, 27);
            this.dbIPLabel.TabIndex = 5;
            this.dbIPLabel.Text = "Database IP";
            this.dbIPLabel.Click += new System.EventHandler(this.dbIPLabel_Click);
            // 
            // dbUNameLabel
            // 
            this.dbUNameLabel.AutoSize = true;
            this.dbUNameLabel.Font = new System.Drawing.Font("Impact", 16F);
            this.dbUNameLabel.ForeColor = System.Drawing.Color.Snow;
            this.dbUNameLabel.Location = new System.Drawing.Point(272, 93);
            this.dbUNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dbUNameLabel.Name = "dbUNameLabel";
            this.dbUNameLabel.Size = new System.Drawing.Size(108, 27);
            this.dbUNameLabel.TabIndex = 6;
            this.dbUNameLabel.Text = "User Name";
            this.dbUNameLabel.Click += new System.EventHandler(this.dbUNameLabel_Click);
            // 
            // dbPassLabel
            // 
            this.dbPassLabel.AutoSize = true;
            this.dbPassLabel.Font = new System.Drawing.Font("Impact", 16F);
            this.dbPassLabel.ForeColor = System.Drawing.Color.Snow;
            this.dbPassLabel.Location = new System.Drawing.Point(272, 123);
            this.dbPassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dbPassLabel.Name = "dbPassLabel";
            this.dbPassLabel.Size = new System.Drawing.Size(144, 27);
            this.dbPassLabel.TabIndex = 7;
            this.dbPassLabel.Text = "User Password";
            this.dbPassLabel.Click += new System.EventHandler(this.dbPassLabel_Click);
            // 
            // dbNameTextBox
            // 
            this.dbNameTextBox.Location = new System.Drawing.Point(440, 38);
            this.dbNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbNameTextBox.Name = "dbNameTextBox";
            this.dbNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.dbNameTextBox.TabIndex = 8;
            this.dbNameTextBox.Text = "PINV";
            this.dbNameTextBox.TextChanged += new System.EventHandler(this.dbNameTextBox_TextChanged);
            // 
            // dbIPTextBox
            // 
            this.dbIPTextBox.Location = new System.Drawing.Point(440, 68);
            this.dbIPTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbIPTextBox.Name = "dbIPTextBox";
            this.dbIPTextBox.Size = new System.Drawing.Size(198, 20);
            this.dbIPTextBox.TabIndex = 9;
            this.dbIPTextBox.Text = "104.185.154.255";
            this.dbIPTextBox.TextChanged += new System.EventHandler(this.dbIPTextBox_TextChanged);
            // 
            // dbUNameTextBox
            // 
            this.dbUNameTextBox.Location = new System.Drawing.Point(440, 98);
            this.dbUNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbUNameTextBox.Name = "dbUNameTextBox";
            this.dbUNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.dbUNameTextBox.TabIndex = 10;
            this.dbUNameTextBox.Text = "guest";
            this.dbUNameTextBox.TextChanged += new System.EventHandler(this.dbUNameTextBox_TextChanged);
            // 
            // dbPassTextBox
            // 
            this.dbPassTextBox.Location = new System.Drawing.Point(440, 128);
            this.dbPassTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbPassTextBox.Name = "dbPassTextBox";
            this.dbPassTextBox.Size = new System.Drawing.Size(198, 20);
            this.dbPassTextBox.TabIndex = 3;
            this.dbPassTextBox.Text = "cse3330";
            this.dbPassTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.dbPassTextBox.UseSystemPasswordChar = true;
            this.dbPassTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dbPassTextBox_MaskInputRejected);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.connectButton.Font = new System.Drawing.Font("Impact", 20F);
            this.connectButton.ForeColor = System.Drawing.Color.White;
            this.connectButton.Location = new System.Drawing.Point(675, 32);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(242, 49);
            this.connectButton.TabIndex = 11;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.Red;
            this.disconnectButton.Font = new System.Drawing.Font("Impact", 20F);
            this.disconnectButton.ForeColor = System.Drawing.Color.White;
            this.disconnectButton.Location = new System.Drawing.Point(675, 102);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(242, 49);
            this.disconnectButton.TabIndex = 12;
            this.disconnectButton.Text = "DISCONNECT";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.dbPassTextBox);
            this.Controls.Add(this.dbUNameTextBox);
            this.Controls.Add(this.dbIPTextBox);
            this.Controls.Add(this.dbNameTextBox);
            this.Controls.Add(this.dbPassLabel);
            this.Controls.Add(this.dbUNameLabel);
            this.Controls.Add(this.dbIPLabel);
            this.Controls.Add(this.dbNameLabel);
            this.Controls.Add(this.PINVLabel);
            this.Controls.Add(this.statusLog);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "mainwindow";
            this.Text = "PINV - Personal Inventory System";
            this.Load += new System.EventHandler(this.mainwindow_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusLog.ResumeLayout(false);
            this.statusLog.PerformLayout();
            this.chooseDatabaseActionGroupBox.ResumeLayout(false);
            this.chooseDatabaseActionGroupBox.PerformLayout();
            this.locateItemGroupBox.ResumeLayout(false);
            this.locateItemGroupBox.PerformLayout();
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            this.componentAttrGroupBox.ResumeLayout(false);
            this.lComponentAttrGroupBox.ResumeLayout(false);
            this.toolAttrGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainwindowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainwindowBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionToolStripStatusLabel;
        private System.Windows.Forms.Panel statusLog;
        private System.Windows.Forms.Button submitOutput;
        private System.Windows.Forms.BindingSource queriesBindingSource;
        private System.Windows.Forms.BindingSource mainwindowBindingSource;
        private System.Windows.Forms.BindingSource queriesBindingSource1;
        private System.Windows.Forms.BindingSource mainwindowBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label PINVLabel;
        private System.Windows.Forms.Label dbNameLabel;
        private System.Windows.Forms.Label dbIPLabel;
        private System.Windows.Forms.Label dbUNameLabel;
        private System.Windows.Forms.Label dbPassLabel;
        private System.Windows.Forms.MaskedTextBox dbPassTextBox;
        private System.Windows.Forms.TextBox dbNameTextBox;
        private System.Windows.Forms.TextBox dbIPTextBox;
        private System.Windows.Forms.TextBox dbUNameTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label activityPaneLabel;
        private System.Windows.Forms.RichTextBox outputPane;
        private System.Windows.Forms.CheckBox debugCheckbox;
        private System.Windows.Forms.GroupBox locateItemGroupBox;
        private System.Windows.Forms.ComboBox nameComboBox_LI;
        private System.Windows.Forms.ComboBox typeComboBox_LI;
        private System.Windows.Forms.RadioButton lComponentRadioButton;
        private System.Windows.Forms.RadioButton toolRadioButton;
        private System.Windows.Forms.RadioButton componentRadioButton;
        private System.Windows.Forms.ComboBox purchaseDateComboBox_LI;
        private System.Windows.Forms.ComboBox priceComboBox_LI;
        private System.Windows.Forms.ComboBox supplierComboBox_LI;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.RadioButton descendingRadioButton;
        private System.Windows.Forms.RadioButton ascendingRadioButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.GroupBox componentAttrGroupBox;
        private System.Windows.Forms.ComboBox protocolComboBox;
        private System.Windows.Forms.ComboBox amperageComboBox;
        private System.Windows.Forms.ComboBox voltageComboBox;
        private System.Windows.Forms.ComboBox capacitanceComboBox;
        private System.Windows.Forms.ComboBox resistanceComboBox;
        private System.Windows.Forms.GroupBox toolAttrGroupBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox cDateComboBox;
        private System.Windows.Forms.GroupBox lComponentAttrGroupBox;
        private System.Windows.Forms.ComboBox lengthComboBox;
        private System.Windows.Forms.ComboBox gaugeComboBox;
        private System.Windows.Forms.GroupBox chooseDatabaseActionGroupBox;
        private System.Windows.Forms.RadioButton deleteItemRadioButton;
        private System.Windows.Forms.RadioButton updateItemRadioButton;
        private System.Windows.Forms.RadioButton addItemRadioButton;
        private System.Windows.Forms.RadioButton locateItemRadioButton;
        private System.Windows.Forms.RadioButton viewItemRadioButton;
        public System.Windows.Forms.CheckBox includePaymentInfoCheckBox;
        private System.Windows.Forms.Button calculateTotalPriceButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Button calculateTotalQuantityButton;
        private System.Windows.Forms.Label totalQuantityLabel;
        private System.Windows.Forms.TextBox totalQuantityTextBox;
    }
}

