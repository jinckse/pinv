﻿using pinv;
using pinv.SQLQueries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PINV
{
    public partial class mainwindow : Form
    {
        DBTalker dbCon = DBTalker.Instance();

        public mainwindow()
        {
            InitializeComponent();
        }

        #region Fields

        public static string queryOption = null;
        private List<string> exampleQueries = Inventory.GetExampleQueries();

        #endregion Fields

        private void mainwindow_Load(object sender, EventArgs e)
        {
            /// Disable purchase info options by default
            supplierComboBox_LI.Hide();
            priceComboBox_LI.Hide();
            purchaseDateComboBox_LI.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void outputPane_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitOutput_Click(object sender, EventArgs e)
        {
            outputPane.AppendText("\n");
            outputPane.AppendText("Querying Database...\n");

            var inv = Inventory.Instance();
            List<string> output = new List<string>();

            output = inv.RetrieveRecords(dbCon, queryOption, true);

            outputPane.AppendText("Result set for query: " + queryOption);

            try
            {
                for (int i = 0; i < output.Count; i++)
                {
                    output[i] = String.Format("{0,-25}", output[i]);
                }

                outputPane.AppendText("\nDatabase returned:\n");

                output.ForEach(outputPane.AppendText);
            }
            catch (NullReferenceException ex)
            {
                outputPane.AppendText("\nERROR: A problem occurred while reading from database");
                outputPane.AppendText("\nAre you connected?");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryOption = comboBox1.Text.Substring(0, 2);

            if (queryOption.Equals("Q1"))
            {
                queryOption = SQLQueries.Queries.q1; 
            }
            else if (queryOption.Equals("Q2"))
            {
                queryOption = SQLQueries.Queries.q2;
            }
            else if (queryOption.Equals("Q3"))
            {
                queryOption = SQLQueries.Queries.q3;
            }
            else if (queryOption.Equals("Q4"))
            {
                queryOption = SQLQueries.Queries.q4;
            }
            else if (queryOption.Equals("Q5"))
            {
                queryOption = SQLQueries.Queries.q5;
            }
            else if (queryOption.Equals("Q6"))
            {
                queryOption = SQLQueries.Queries.q6;
            }
            else
            {
                /// Should never get here
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dbPassLabel_Click(object sender, EventArgs e)
        {

        }

        private void dbUNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void dbIPLabel_Click(object sender, EventArgs e)
        {

        }

        private void dbNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dbIPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dbUNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dbPassTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Populate connection information using text fields
            dbCon.DatabaseName = dbNameTextBox.Text;
            dbCon.DatabaseIP = dbIPTextBox.Text;
            dbCon.DatabaseUID = dbUNameTextBox.Text;
            dbCon.DatabasePass = dbPassTextBox.Text;
            
            // Check if we are already connected
            if (dbCon.IsConnected())
            {
                // Notify user
                outputPane.AppendText("\nAlready connected to database: " + dbCon.DatabaseName);
                outputPane.AppendText("\nPlease disconnect the current session");
            }
            else
            {
                // Otherwise connect to desired database
                outputPane.AppendText("\nAttempting to connect to database: " + dbCon.DatabaseName);
                if (dbCon.OpenConnection())
                {
                    outputPane.AppendText("\nConnection successful!");
                    connectionToolStripStatusLabel.Text = "MySQL Connection Status: Connected";
                    connectionToolStripStatusLabel.ForeColor = Color.Green;
                }
                else
                {
                    outputPane.AppendText("\nCouldn't connect to database: " + dbCon.DatabaseName);
                    outputPane.AppendText("\nCheck your connection parameters");
                }
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {

        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            QueryBuilder qb = new QueryBuilder();
            bool firstWhereEntry = true;

            /// Build Query and send to database
            qb.SelectStr = "select *";
            qb.WhereStr = "where";

            /// We always use these items when viewing items
            if (!nameComboBox_LI.Text.Contains("Select"))
            {
                if (!firstWhereEntry)
                {
                    qb.WhereStr += " and";
                    qb.WhereStr += (" Name='" + (nameComboBox_LI.Text + "'"));
                }
                else
                {
                    qb.WhereStr += (" Name='" + (nameComboBox_LI.Text + "'"));
                    firstWhereEntry = false;
                }
            }

            if (!typeComboBox_LI.Text.Contains("Select"))
            {
                if (!firstWhereEntry)
                {
                    qb.WhereStr += " and";
                    qb.WhereStr += (" Type='" + (typeComboBox_LI.Text + "'"));
                }
                else
                {
                    qb.WhereStr += (" Type='" + (typeComboBox_LI.Text + "'"));
                    firstWhereEntry = false;
                }
            }

            if (!supplierComboBox_LI.Text.Contains("Select"))
            {
                if (!firstWhereEntry)
                {
                    qb.WhereStr += " and";
                    qb.WhereStr += (" Supplier='" + (supplierComboBox_LI.Text + "'"));
                }
                else
                {
                    qb.WhereStr += (" Supplier='" + (supplierComboBox_LI.Text + "'"));
                    firstWhereEntry = false;
                }
            }

            if (!priceComboBox_LI.Text.Contains("Select"))
            {
                /// < $1.00
                if (priceComboBox_LI.Text.Contains("< $1.00"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" Price < 1.00");
                    }
                    else
                    {
                        qb.WhereStr += (" Price < 1.00");
                        firstWhereEntry = false;
                    }
                }
                /// > 10.00
                else if (priceComboBox_LI.Text.Contains("> 10.00"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" Price > 10.00");
                    }
                    else
                    {
                        qb.WhereStr += (" Price > 10.00");
                        firstWhereEntry = false;
                    }
                }
                /// $1.00 - $5.00
                else if (priceComboBox_LI.Text.Contains("$1.00 - $5.00"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" Price between 1 and 5");
                    }
                    else
                    {
                        qb.WhereStr += (" Price between 1 and 5");
                        firstWhereEntry = false;
                    }
                }
                /// $5.00 - $10.00
                else if (priceComboBox_LI.Text.Contains("$5.00 - $10.00"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" Price between 5 and 10");
                    }
                    else
                    {
                        qb.WhereStr += (" Price between 5 and 10");
                        firstWhereEntry = false;
                    }
                }
                else
                {

                }
            }

            if (!purchaseDateComboBox_LI.Text.Contains("Select"))
            {
                if (!firstWhereEntry)
                {
                    qb.WhereStr += " and";
                    qb.WhereStr += (" PDate='" + (purchaseDateComboBox_LI.Text + "'"));
                }
                else
                {
                    qb.WhereStr += (" PDate='" + (purchaseDateComboBox_LI.Text + "'"));
                    firstWhereEntry = false;
                }
            }

            /// Component radio button is selected
            if (componentRadioButton.Checked)
            {
                if (!resistanceComboBox.Text.Contains("Select"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" Resist='" + (resistanceComboBox.Text + "'"));
                    }
                    else
                    {
                        qb.WhereStr += (" Resist='" + (resistanceComboBox.Text + "'"));
                        firstWhereEntry = false;
                    }
                }
                
                if (!capacitanceComboBox.Text.Contains("Select"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" Capac='" + (capacitanceComboBox.Text + "'"));
                    }
                    else
                    {
                        qb.WhereStr += (" Capac='" + (capacitanceComboBox.Text + "'"));
                        firstWhereEntry = false;
                    }
                }

                if (!voltageComboBox.Text.Contains("Select"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" Voltage='" + (voltageComboBox.Text + "'"));
                    }
                    else
                    {
                        qb.WhereStr += (" Voltage='" + (voltageComboBox.Text + "'"));
                        firstWhereEntry = false;
                    }
                }

                if (!amperageComboBox.Text.Contains("Select"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" Amper='" + (amperageComboBox.Text + "'"));
                    }
                    else
                    {
                        qb.WhereStr += (" Amper='" + (amperageComboBox.Text + "'"));
                        firstWhereEntry = false;
                    }
                }
            }

            /// Tool radio button is selected
            if (toolRadioButton.Checked)
            {
                if (!cDateComboBox.Text.Contains("Select"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" CalibrationDate='" + (cDateComboBox.Text + "'"));
                    }
                    else
                    {
                        qb.WhereStr += (" CalibrationDate='" + (cDateComboBox.Text + "'"));
                        firstWhereEntry = false;
                    }
                }

                if (!statusComboBox.Text.Contains("Select"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" Status='" + (statusComboBox.Text + "'"));
                    }
                    else
                    {
                        qb.WhereStr += (" Status='" + (statusComboBox.Text + "'"));
                        firstWhereEntry = false;
                    }
                }
            }

            /// If no selections were made in the main options use wildcard
            /// Right now this is catching any insstance where specilized options
            /// were made. This is messy and should be handled with a dialog message
            if (nameComboBox_LI.Text.Contains("Select")
                && typeComboBox_LI.Text.Contains("Select")
                && supplierComboBox_LI.Text.Contains("Select")
                && priceComboBox_LI.Text.Contains("Select")
                && purchaseDateComboBox_LI.Text.Contains("Select")
                && resistanceComboBox.Text.Contains("Select")
                && capacitanceComboBox.Text.Contains("Select")
                && voltageComboBox.Text.Contains("Select")
                && amperageComboBox.Text.Contains("Select")
                && cDateComboBox.Text.Contains("Select")
                && statusComboBox.Text.Contains("Select"))
            {
                qb.WhereStr = "";
            }

            qb.FromStr = "from ITEM";
            
            if (includePaymentInfoCheckBox.Checked)
            {
                qb.JoinOpsStr = "join PURCHASE_INFO on (INum = INo)"; 
            }

            /// Send query to database
            var inv = Inventory.Instance();
            List<string> output = new List<string>();
            string query = qb.BuildLocateItemQuery();

            try
            {
                output = inv.RetrieveRecords(dbCon, query);

                /// Populate and show results form
                ViewItemResults irForm = new ViewItemResults();

                for (int i = 0; i < output.Count; i++)
                {
                    if (includePaymentInfoCheckBox.Checked)
                    {
                        if ((i % 21) == 0 && i != 0)
                        {
                            irForm.viewItemResultsRichTextBox.AppendText("\n");
                        }
                    }
                    else
                    {
                        if ((i % 17) == 0 && i != 0)
                        {
                            irForm.viewItemResultsRichTextBox.AppendText("\n");
                        }
                    }

                    if (output[i] == "")
                    {
                        irForm.viewItemResultsRichTextBox.AppendText("N/A" + ",");
                    }
                    else
                    {
                        irForm.viewItemResultsRichTextBox.AppendText(output[i] + ",");
                    }
                }

                //output.ForEach(irForm.viewItemResultsRichTextBox.AppendText);
                irForm.Show();
            }
            catch (NullReferenceException ex)
            {
                outputPane.AppendText("\nERROR: A problem occurred reading the database");
                outputPane.AppendText("\nAre you connected?");
            }
        }

        private void componentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            /// Hide the others
            toolAttrGroupBox.Hide();
            lComponentAttrGroupBox.Hide();

            statusComboBox.Hide();
            cDateComboBox.Hide();

            lengthComboBox.Hide();
            protocolComboBox.Hide();
            gaugeComboBox.Hide();

            /// When this option is selected show the "Component Attributes" control group
            resistanceComboBox.Show();
            capacitanceComboBox.Show();
            voltageComboBox.Show();
            amperageComboBox.Show();

            componentAttrGroupBox.Show();
        }

        private void toolRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            /// Hide the others
            componentAttrGroupBox.Hide();

            /// When this option is selected show the "Component Attributes" control group
            componentAttrGroupBox.Show();
            lComponentAttrGroupBox.Show();

            lengthComboBox.Hide();
            protocolComboBox.Hide();
            gaugeComboBox.Hide();

            resistanceComboBox.Hide();
            capacitanceComboBox.Hide();
            voltageComboBox.Hide();
            amperageComboBox.Hide();

            cDateComboBox.Show();
            statusComboBox.Show();

            toolAttrGroupBox.Show();
        }

        private void lComponentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            /// Hide the others
            toolAttrGroupBox.Hide();

            statusComboBox.Hide();
            cDateComboBox.Hide();

            resistanceComboBox.Hide();
            capacitanceComboBox.Hide();
            voltageComboBox.Hide();
            amperageComboBox.Hide();

            /// When this option is selected show the "Component Attributes" control group
            lengthComboBox.Show();
            protocolComboBox.Show();
            gaugeComboBox.Show();

            lComponentAttrGroupBox.Show();
        }

        private void includePaymentInfoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!includePaymentInfoCheckBox.Checked)
            {
                supplierComboBox_LI.Hide();
                priceComboBox_LI.Hide();
                purchaseDateComboBox_LI.Hide();
            }
            else
            {
                supplierComboBox_LI.Show();
                priceComboBox_LI.Show();
                purchaseDateComboBox_LI.Show();
            }
        }
    }
}
