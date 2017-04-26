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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.outputPane = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.submitOutput = new System.Windows.Forms.Button();
            this.queriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainwindowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainwindowBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dbNameLabel = new System.Windows.Forms.Label();
            this.dbIPLabel = new System.Windows.Forms.Label();
            this.dbUNameLabel = new System.Windows.Forms.Label();
            this.dbPassLabel = new System.Windows.Forms.Label();
            this.dbNameTextBox = new System.Windows.Forms.TextBox();
            this.dbIPTextBox = new System.Windows.Forms.TextBox();
            this.dbUNameTextBox = new System.Windows.Forms.TextBox();
            this.dbPassTextBox = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1262, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(18, 20);
            this.toolStripStatusLabel1.Text = "C";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(178, 20);
            this.toolStripStatusLabel2.Text = "MySQL Connection Status";
            // 
            // outputPane
            // 
            this.outputPane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPane.BackColor = System.Drawing.SystemColors.WindowText;
            this.outputPane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPane.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPane.ForeColor = System.Drawing.Color.Lime;
            this.outputPane.Location = new System.Drawing.Point(0, 93);
            this.outputPane.Name = "outputPane";
            this.outputPane.ReadOnly = true;
            this.outputPane.Size = new System.Drawing.Size(1259, 387);
            this.outputPane.TabIndex = 0;
            this.outputPane.Text = "Welcome to the PINV system";
            this.outputPane.UseWaitCursor = true;
            this.outputPane.WordWrap = false;
            this.outputPane.ZoomFactor = 1.2F;
            this.outputPane.TextChanged += new System.EventHandler(this.outputPane_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.submitOutput);
            this.panel1.Controls.Add(this.outputPane);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 483);
            this.panel1.TabIndex = 2;
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
            this.comboBox1.Location = new System.Drawing.Point(137, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(814, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Select a Query";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // submitOutput
            // 
            this.submitOutput.Location = new System.Drawing.Point(6, 65);
            this.submitOutput.Name = "submitOutput";
            this.submitOutput.Size = new System.Drawing.Size(125, 23);
            this.submitOutput.TabIndex = 1;
            this.submitOutput.Text = "Submit Query";
            this.submitOutput.UseVisualStyleBackColor = true;
            this.submitOutput.Click += new System.EventHandler(this.submitOutput_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 80F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 162);
            this.label1.TabIndex = 3;
            this.label1.Text = "PINV";
            // 
            // dbNameLabel
            // 
            this.dbNameLabel.AutoSize = true;
            this.dbNameLabel.Font = new System.Drawing.Font("Impact", 16F);
            this.dbNameLabel.ForeColor = System.Drawing.Color.Snow;
            this.dbNameLabel.Location = new System.Drawing.Point(362, 40);
            this.dbNameLabel.Name = "dbNameLabel";
            this.dbNameLabel.Size = new System.Drawing.Size(190, 34);
            this.dbNameLabel.TabIndex = 4;
            this.dbNameLabel.Text = "Database Name";
            this.dbNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // dbIPLabel
            // 
            this.dbIPLabel.AutoSize = true;
            this.dbIPLabel.Font = new System.Drawing.Font("Impact", 16F);
            this.dbIPLabel.ForeColor = System.Drawing.Color.Snow;
            this.dbIPLabel.Location = new System.Drawing.Point(362, 77);
            this.dbIPLabel.Name = "dbIPLabel";
            this.dbIPLabel.Size = new System.Drawing.Size(148, 34);
            this.dbIPLabel.TabIndex = 5;
            this.dbIPLabel.Text = "Database IP";
            this.dbIPLabel.Click += new System.EventHandler(this.dbIPLabel_Click);
            // 
            // dbUNameLabel
            // 
            this.dbUNameLabel.AutoSize = true;
            this.dbUNameLabel.Font = new System.Drawing.Font("Impact", 16F);
            this.dbUNameLabel.ForeColor = System.Drawing.Color.Snow;
            this.dbUNameLabel.Location = new System.Drawing.Point(362, 114);
            this.dbUNameLabel.Name = "dbUNameLabel";
            this.dbUNameLabel.Size = new System.Drawing.Size(136, 34);
            this.dbUNameLabel.TabIndex = 6;
            this.dbUNameLabel.Text = "User Name";
            this.dbUNameLabel.Click += new System.EventHandler(this.dbUNameLabel_Click);
            // 
            // dbPassLabel
            // 
            this.dbPassLabel.AutoSize = true;
            this.dbPassLabel.Font = new System.Drawing.Font("Impact", 16F);
            this.dbPassLabel.ForeColor = System.Drawing.Color.Snow;
            this.dbPassLabel.Location = new System.Drawing.Point(362, 151);
            this.dbPassLabel.Name = "dbPassLabel";
            this.dbPassLabel.Size = new System.Drawing.Size(181, 34);
            this.dbPassLabel.TabIndex = 7;
            this.dbPassLabel.Text = "User Password";
            this.dbPassLabel.Click += new System.EventHandler(this.dbPassLabel_Click);
            // 
            // dbNameTextBox
            // 
            this.dbNameTextBox.Location = new System.Drawing.Point(587, 47);
            this.dbNameTextBox.Name = "dbNameTextBox";
            this.dbNameTextBox.Size = new System.Drawing.Size(263, 22);
            this.dbNameTextBox.TabIndex = 8;
            this.dbNameTextBox.TextChanged += new System.EventHandler(this.dbNameTextBox_TextChanged);
            // 
            // dbIPTextBox
            // 
            this.dbIPTextBox.Location = new System.Drawing.Point(587, 84);
            this.dbIPTextBox.Name = "dbIPTextBox";
            this.dbIPTextBox.Size = new System.Drawing.Size(263, 22);
            this.dbIPTextBox.TabIndex = 9;
            this.dbIPTextBox.TextChanged += new System.EventHandler(this.dbIPTextBox_TextChanged);
            // 
            // dbUNameTextBox
            // 
            this.dbUNameTextBox.Location = new System.Drawing.Point(587, 121);
            this.dbUNameTextBox.Name = "dbUNameTextBox";
            this.dbUNameTextBox.Size = new System.Drawing.Size(263, 22);
            this.dbUNameTextBox.TabIndex = 10;
            this.dbUNameTextBox.TextChanged += new System.EventHandler(this.dbUNameTextBox_TextChanged);
            // 
            // dbPassTextBox
            // 
            this.dbPassTextBox.Location = new System.Drawing.Point(587, 158);
            this.dbPassTextBox.Name = "dbPassTextBox";
            this.dbPassTextBox.Size = new System.Drawing.Size(263, 22);
            this.dbPassTextBox.TabIndex = 3;
            this.dbPassTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.dbPassTextBox.UseSystemPasswordChar = true;
            this.dbPassTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dbPassTextBox_MaskInputRejected);
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dbPassTextBox);
            this.Controls.Add(this.dbUNameTextBox);
            this.Controls.Add(this.dbIPTextBox);
            this.Controls.Add(this.dbNameTextBox);
            this.Controls.Add(this.dbPassLabel);
            this.Controls.Add(this.dbUNameLabel);
            this.Controls.Add(this.dbIPLabel);
            this.Controls.Add(this.dbNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "mainwindow";
            this.Text = "PINV - Personal Inventory System";
            this.Load += new System.EventHandler(this.mainwindow_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainwindowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainwindowBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.RichTextBox outputPane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button submitOutput;
        private System.Windows.Forms.BindingSource queriesBindingSource;
        private System.Windows.Forms.BindingSource mainwindowBindingSource;
        private System.Windows.Forms.BindingSource queriesBindingSource1;
        private System.Windows.Forms.BindingSource mainwindowBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dbNameLabel;
        private System.Windows.Forms.Label dbIPLabel;
        private System.Windows.Forms.Label dbUNameLabel;
        private System.Windows.Forms.Label dbPassLabel;
        private System.Windows.Forms.MaskedTextBox dbPassTextBox;
        private System.Windows.Forms.TextBox dbNameTextBox;
        private System.Windows.Forms.TextBox dbIPTextBox;
        private System.Windows.Forms.TextBox dbUNameTextBox;
    }
}

