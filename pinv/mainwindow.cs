using pinv;
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
        QueryBuilder qb = new QueryBuilder();

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
            bool firstWhereEntry = true;

            /// Build Query and send to database
            qb.SelectStr = "select *";
            qb.WhereStr = "where";

            /// Sort results alphabetically by name
            if (ascendingRadioButton.Checked)
            {
                qb.AggregateOpsStr = "group by IType having Amount > 0 order by Name asc";
            }
            else
            {
                qb.AggregateOpsStr = "group by IType having Amount > 0 order by Name desc";
            }

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
                    qb.WhereStr += (" IType='" + (typeComboBox_LI.Text + "'"));
                }
                else
                {
                    qb.WhereStr += (" IType='" + (typeComboBox_LI.Text + "'"));
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
                /// Sort results numerically by price
                if (ascendingRadioButton.Checked)
                {
                    qb.AggregateOpsStr = "group by IType having Amount > 0 order by Price asc";
                }
                else
                {
                    qb.AggregateOpsStr = "group by IType having Amount > 0 order by Price desc";
                }

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
                /// 2012
                if (purchaseDateComboBox_LI.Text.Contains("2012"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" year(PDate) = 2012");
                    }
                    else
                    {
                        qb.WhereStr += (" year(PDate) = 2012");
                        firstWhereEntry = false;
                    }
                }
                /// 2013
                else if (purchaseDateComboBox_LI.Text.Contains("2013"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" year(PDate) = 2013");
                    }
                    else
                    {
                        qb.WhereStr += (" year(PDate) = 2013");
                        firstWhereEntry = false;
                    }
                }
                /// 2014
                else if (purchaseDateComboBox_LI.Text.Contains("2014"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" year(PDate) = 2014");
                    }
                    else
                    {
                        qb.WhereStr += (" year(PDate) = 2014");
                        firstWhereEntry = false;
                    }
                }
                /// 2015
                else if (purchaseDateComboBox_LI.Text.Contains("2015"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" year(PDate) = 2015");
                    }
                    else
                    {
                        qb.WhereStr += (" year(PDate) = 2015");
                        firstWhereEntry = false;
                    }
                }
                else
                {

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

            /// Large Component radio button is selected
            if (lComponentRadioButton.Checked)
            {
                if (!protocolComboBox.Text.Contains("Select"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" Protocol='" + (protocolComboBox.Text + "'"));
                    }
                    else
                    {
                        qb.WhereStr += (" Protocol='" + (protocolComboBox.Text + "'"));
                        firstWhereEntry = false;
                    }
                }

                if (!lengthComboBox.Text.Contains("Select"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" Length=" + (lengthComboBox.Text));
                    }
                    else
                    {
                        qb.WhereStr += (" Length=" + (lengthComboBox.Text));
                        firstWhereEntry = false;
                    }
                }

                if (!gaugeComboBox.Text.Contains("Select"))
                {
                    if (!firstWhereEntry)
                    {
                        qb.WhereStr += " and";
                        qb.WhereStr += (" Gauge=" + (gaugeComboBox.Text));
                    }
                    else
                    {
                        qb.WhereStr += (" Gauge=" + (gaugeComboBox.Text));
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
            else
            {
                qb.JoinOpsStr = "";
            }

            /// Locate an Item
            if (locateItemRadioButton.Checked)
            {
                /// Item is a component
                if(componentRadioButton.Checked)
                {
                    qb.SelectStr = "select OLabel as Organizer, DNo, Cmpt";
                    qb.JoinOpsStr += " join STORED_IN on STORED_IN.INum=INo join DRAWER on SISNum=DSNum join STORAGE_AREA on StoNo=SISNum";
                    qb.AggregateOpsStr = "";
                }
                /// Item is a tool
                else if (toolRadioButton.Checked)
                {
                    qb.SelectStr = "select PLabel as Pegboard, HNo";
                    qb.JoinOpsStr += " join STORED_IN on STORED_IN.INum=INo join HOOK on SISNum=HSNum join STORAGE_AREA on StoNo=SISNum";
                    qb.AggregateOpsStr = "";
                }
                /// Item is a large component
                else if (lComponentRadioButton.Checked)
                {
                    qb.SelectStr = "select BLabel as Bin";
                    qb.JoinOpsStr += " join STORED_IN on STORED_IN.INum=INo join STORAGE_AREA on BLabel=SISNum";
                    qb.AggregateOpsStr = "";
                }
                else
                {
                    /// Should never get here
                }
            }

            /// Send query to database
            var inv = Inventory.Instance();
            List<string> output = new List<string>();
            string query = qb.BuildViewItemQuery();

            try
            {
                output = inv.RetrieveRecords(dbCon, query);

                /// Populate and show results form
                ViewItemResults irForm = new ViewItemResults();

                for (int i = 0; i < output.Count; i++)
                {
                    if (includePaymentInfoCheckBox.Checked && viewItemRadioButton.Checked)
                    {
                        if ((i % 21) == 0 && i != 0)
                        {
                            irForm.viewItemResultsRichTextBox.AppendText("\n");
                        }
                    }
                    else if (!includePaymentInfoCheckBox.Checked && viewItemRadioButton.Checked)
                    {
                        if ((i % 17) == 0 && i != 0)
                        {
                            irForm.viewItemResultsRichTextBox.AppendText("\n");
                        }
                    }
                    else if (locateItemRadioButton.Checked && componentRadioButton.Checked)
                    {
                        if ((i % 3) == 0 && i != 0)
                        {
                            irForm.viewItemResultsRichTextBox.AppendText("\n");
                        }
                    }
                    else if (locateItemRadioButton.Checked && toolRadioButton.Checked)
                    {
                        if ((i % 2) == 0 && i != 0)
                        {
                            irForm.viewItemResultsRichTextBox.AppendText("\n");
                        }
                    }
                    else if (locateItemRadioButton.Checked && lComponentRadioButton.Checked)
                    {
                        if ((i % 1) == 0 && i != 0)
                        {
                            irForm.viewItemResultsRichTextBox.AppendText("\n");
                        }
                    }
                    
                    /// Handle null results from database
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

        private void locateItemRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void viewItemRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calculateTotalPriceButton_Click(object sender, EventArgs e)
        {
            /// Submit total price query and show result in textbox

            /// Save current values
            string oldSelectStr = qb.SelectStr;
            string oldAggStr = qb.AggregateOpsStr;

            /// Make necessary changes for valid response
            qb.SelectStr = "select sum(Price)";
            qb.AggregateOpsStr = "";

            var inv = Inventory.Instance();
            List<string> output = new List<string>();
            string query = qb.BuildViewItemQuery();

            try
            {
                output = inv.RetrieveRecords(dbCon, query);

                /// Populate and show results form
                ViewItemResults irForm = new ViewItemResults();

                for (int i = 0; i < output.Count; i++)
                {
                    /// Handle null results from database
                    if (output[i] == "")
                    {
                        irForm.viewItemResultsRichTextBox.AppendText("N/A" + ",");
                    }
                    else
                    {
                        irForm.viewItemResultsRichTextBox.AppendText(output[i] + ",");
                    }
                }

                /// Show total price of items returned
                try
                {
                    totalPriceTextBox.ForeColor = Color.Black;
                    totalPriceTextBox.Text = output[1];
                }
                catch (Exception ex)
                {
                    totalPriceTextBox.Text = "Error";
                    totalPriceTextBox.ForeColor = Color.Red;
                }
            }
            catch (NullReferenceException ex)
            {
                outputPane.AppendText("\nERROR: A problem occurred reading the database");
                outputPane.AppendText("\nAre you connected?");
            }

            /// Reinstate original query
            qb.SelectStr = oldSelectStr;
            qb.AggregateOpsStr = oldAggStr;
        }

        private void calculateTotalQuantityButton_Click(object sender, EventArgs e)
        {
            /// Submit total quantity query and show result in textbox

            /// Save current values
            string oldSelectStr = qb.SelectStr;
            string oldAggStr = qb.AggregateOpsStr;

            /// Make necessary changes for valid response
            qb.SelectStr = "select sum(Amount)";
            qb.AggregateOpsStr = "";

            var inv = Inventory.Instance();
            List<string> output = new List<string>();
            string query = qb.BuildViewItemQuery();

            try
            {
                output = inv.RetrieveRecords(dbCon, query);

                /// Populate and show results form
                ViewItemResults irForm = new ViewItemResults();

                for (int i = 0; i < output.Count; i++)
                {
                    /// Handle null results from database
                    if (output[i] == "")
                    {
                        irForm.viewItemResultsRichTextBox.AppendText("N/A" + ",");
                    }
                    else
                    {
                        irForm.viewItemResultsRichTextBox.AppendText(output[i] + ",");
                    }
                }

                /// Show total quantity of items returned
                try
                {
                    totalQuantityTextBox.ForeColor = Color.Black;
                    totalQuantityTextBox.Text = output[1];
                }
                catch (Exception ex)
                {
                    totalQuantityTextBox.Text = "Error";
                    totalQuantityTextBox.ForeColor = Color.Red;
                }
            }
            catch (NullReferenceException ex)
            {
                outputPane.AppendText("\nERROR: A problem occurred reading the database");
                outputPane.AppendText("\nAre you connected?");
            }

            /// Reinstate original query
            qb.SelectStr = oldSelectStr;
            qb.AggregateOpsStr = oldAggStr;

        }
    }
}
