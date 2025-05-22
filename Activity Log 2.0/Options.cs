using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;

namespace Activity_Log_2._0
{
    public partial class Options : Form
    {
        private static int SelectedRow = 0;
        private static int SelectedIndex = -1;

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            SelectedRow = 0;
            SelectedIndex = -1;

            comboBox1.Items.Add("");
            comboBox1.Items.Add("");

            loadLanguage();

            timer1.Start();
        }

        private void loadLanguage() {
            Text =              Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Options"], 0];

            addButton.Text =    Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Options"], 1];
            renameButton.Text = Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Options"], 2];
            removeButton.Text = Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Options"], 3];
            upButton.Text =     Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Options"], 4];
            downButton.Text =   Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Options"], 5];
            saveButton.Text =   Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Options"], 6];

            comboBox1.Items[0] = Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["XML"], 0];
            comboBox1.Items[1] = Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["XML"], 1];
        }

        private void loadDataGridView() {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < Base.OptionNodes[SelectedIndex].Count; i++) {
                dataGridView1.Rows.Add(Base.OptionNodes[SelectedIndex][i][0], Base.OptionNodes[SelectedIndex][i][1]);
            }

            if (dataGridView1.RowCount > 0) {
                dataGridView1.Rows[SelectedRow].Selected = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = comboBox1.SelectedIndex;
            SelectedRow = 0;
            loadDataGridView();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            swapNodes(dataGridView1.SelectedRows[0].Index, dataGridView1.SelectedRows[0].Index - 1);

            Base.updateOptionsXML();

            SelectedRow--;
            loadDataGridView();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            swapNodes(dataGridView1.SelectedRows[0].Index, dataGridView1.SelectedRows[0].Index + 1);

            Base.updateOptionsXML();

            SelectedRow++;
            loadDataGridView();
        }

        private void swapNodes(int index1, int index2) {
            int currentNode = index1;
            int nodeToSwap = index2;

            List<string> tempNode = new List<string>(Base.OptionNodes[SelectedIndex][nodeToSwap]);

            //swap
            Base.OptionNodes[SelectedIndex][nodeToSwap] = Base.OptionNodes[SelectedIndex][currentNode];
            Base.OptionNodes[SelectedIndex][currentNode] = tempNode;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //select row
            if (dataGridView1.RowCount > 0){
                SelectedRow = dataGridView1.SelectedRows[0].Index;
            }
            else {
                SelectedRow = 0;
            }

            //add button
            if (SelectedIndex > -1){
                if (!string.IsNullOrEmpty(addTextBox.Text) && checkForEqualNames(addTextBox.Text)){
                    addButton.Enabled = true;
                }
                else{
                    addButton.Enabled = false;
                }
            }
            else {
                addButton.Enabled = false;
            }

            //rename button
            if (SelectedIndex > -1){
                if (!string.IsNullOrEmpty(renameTextBox.Text) && checkForEqualNames(renameTextBox.Text) &&
                    Base.OptionNodes[SelectedIndex][SelectedRow][2] == "false")
                {
                    renameButton.Enabled = true;
                }else {
                    renameButton.Enabled = false;
                }
            }
            else{
                renameButton.Enabled = false;
            }

            //remove button
            if (SelectedIndex > -1){

                if (Base.OptionNodes[SelectedIndex][SelectedRow][2] == "false"){
                    removeButton.Enabled = true;
                }
                else {
                    removeButton.Enabled = false;
                }
            }
            else{
                removeButton.Enabled = false;
            }

            //up button
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Index > 0)
                {
                    upButton.Enabled = true;
                }
                else{
                    upButton.Enabled = false;
                }
            }else {
                upButton.Enabled = false;
            }

            //down button
            if (dataGridView1.Rows.Count > 0){
                if (dataGridView1.SelectedRows[0].Index + 1 < dataGridView1.RowCount)
                {
                    downButton.Enabled = true;
                }else{
                    downButton.Enabled = false;
                }
            }
            else {
                downButton.Enabled = false;
            }
        }

        private bool checkForEqualNames(string name) {
            bool noDoubles = true;

            for (int i = 0; i < dataGridView1.RowCount; i++) {
                if ((string)dataGridView1.Rows[i].Cells[0].Value == name) {
                    noDoubles = false;
                    goto after_loop;
                }
            }
            after_loop:

            return noDoubles;
        }

        private string getNewID() {
            int maxID = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++) {
                if (Int32.Parse((string)dataGridView1.Rows[i].Cells[1].Value) > maxID) {
                    maxID = Int32.Parse((string)dataGridView1.Rows[i].Cells[1].Value);
                }
            }

            maxID++;

            return maxID.ToString();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Base.OptionNodes[SelectedIndex].RemoveAt(SelectedRow);
            Base.updateOptionsXML();

            if (SelectedRow + 1 == dataGridView1.RowCount) {
                SelectedRow--;
            }

            loadDataGridView();
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            Base.OptionNodes[SelectedIndex][SelectedRow][0] = renameTextBox.Text;
            renameTextBox.Text = "";

            Base.updateOptionsXML();
            loadDataGridView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            List<string> tempNode = new List<string> { addTextBox.Text , getNewID(), "false"};

            addTextBox.Text = "";
            Base.OptionNodes[SelectedIndex].Insert(SelectedRow + 1, tempNode);
            SelectedRow++;

            Base.updateOptionsXML();
            loadDataGridView();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
