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

            output = inv.RetrieveRecords(dbCon, queryOption);

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
    }
}
