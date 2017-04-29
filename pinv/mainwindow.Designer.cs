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
            this.debugCheckbox = new System.Windows.Forms.CheckBox();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.updateItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.viewItemButton = new System.Windows.Forms.Button();
            this.locateItemButton = new System.Windows.Forms.Button();
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
            this.statusLog.Controls.Add(this.debugCheckbox);
            this.statusLog.Controls.Add(this.deleteItemButton);
            this.statusLog.Controls.Add(this.updateItemButton);
            this.statusLog.Controls.Add(this.addItemButton);
            this.statusLog.Controls.Add(this.viewItemButton);
            this.statusLog.Controls.Add(this.locateItemButton);
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
            // deleteItemButton
            // 
            this.deleteItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteItemButton.Font = new System.Drawing.Font("Impact", 12F);
            this.deleteItemButton.ForeColor = System.Drawing.Color.Snow;
            this.deleteItemButton.Location = new System.Drawing.Point(816, 86);
            this.deleteItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(101, 28);
            this.deleteItemButton.TabIndex = 13;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = false;
            // 
            // updateItemButton
            // 
            this.updateItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateItemButton.Font = new System.Drawing.Font("Impact", 12F);
            this.updateItemButton.ForeColor = System.Drawing.Color.Snow;
            this.updateItemButton.Location = new System.Drawing.Point(710, 86);
            this.updateItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateItemButton.Name = "updateItemButton";
            this.updateItemButton.Size = new System.Drawing.Size(101, 28);
            this.updateItemButton.TabIndex = 12;
            this.updateItemButton.Text = "Update Item";
            this.updateItemButton.UseVisualStyleBackColor = false;
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addItemButton.Font = new System.Drawing.Font("Impact", 12F);
            this.addItemButton.ForeColor = System.Drawing.Color.Snow;
            this.addItemButton.Location = new System.Drawing.Point(604, 86);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(101, 28);
            this.addItemButton.TabIndex = 11;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            // 
            // viewItemButton
            // 
            this.viewItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.viewItemButton.Font = new System.Drawing.Font("Impact", 12F);
            this.viewItemButton.ForeColor = System.Drawing.Color.Snow;
            this.viewItemButton.Location = new System.Drawing.Point(498, 86);
            this.viewItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewItemButton.Name = "viewItemButton";
            this.viewItemButton.Size = new System.Drawing.Size(101, 28);
            this.viewItemButton.TabIndex = 10;
            this.viewItemButton.Text = "View Item";
            this.viewItemButton.UseVisualStyleBackColor = false;
            // 
            // locateItemButton
            // 
            this.locateItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.locateItemButton.Font = new System.Drawing.Font("Impact", 12F);
            this.locateItemButton.ForeColor = System.Drawing.Color.Snow;
            this.locateItemButton.Location = new System.Drawing.Point(393, 86);
            this.locateItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.locateItemButton.Name = "locateItemButton";
            this.locateItemButton.Size = new System.Drawing.Size(101, 28);
            this.locateItemButton.TabIndex = 9;
            this.locateItemButton.Text = "Locate Item";
            this.locateItemButton.UseVisualStyleBackColor = false;
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
            this.outputPane.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPane.ForeColor = System.Drawing.Color.Lime;
            this.outputPane.Location = new System.Drawing.Point(24, 86);
            this.outputPane.Margin = new System.Windows.Forms.Padding(2);
            this.outputPane.Name = "outputPane";
            this.outputPane.ReadOnly = true;
            this.outputPane.Size = new System.Drawing.Size(361, 283);
            this.outputPane.TabIndex = 0;
            this.outputPane.Text = "Welcome to the PINV system";
            this.outputPane.UseWaitCursor = true;
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "mainwindow";
            this.Text = "PINV - Personal Inventory System";
            this.Load += new System.EventHandler(this.mainwindow_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusLog.ResumeLayout(false);
            this.statusLog.PerformLayout();
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
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button updateItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button viewItemButton;
        private System.Windows.Forms.Button locateItemButton;
        private System.Windows.Forms.CheckBox debugCheckbox;
    }
}

