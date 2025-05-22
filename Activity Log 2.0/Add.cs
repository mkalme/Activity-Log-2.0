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

namespace Activity_Log_2._0
{
    public partial class Add : Form
    {
        private int SelectedIndex = -1;

        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            loadLanguage();

            SelectedIndex = -1;

            addRemoveCombo.Items.Add(Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["XML"], 0]);
            addRemoveCombo.Items.Add(Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["XML"], 1]);

            cashBankCombo.Items.Add(Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 11]);
            cashBankCombo.Items.Add(Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 12]);

            timer1.Start();
        }

        private void loadLanguage() {
            Text =              Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 0];
            groupBox1.Text =    Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 1];
            label1.Text =       Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 2];
            label2.Text =       Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 3];
            label3.Text =       Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 4];
            addButton1.Text =   Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 5];
            label4.Text =       Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 6];
            label5.Text =       Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 7];
            label6.Text =       Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 8];
            cancelButton.Text = Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 9];
            addButton.Text =    Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["ADD"], 10];
        }

        private void addRemoveCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = addRemoveCombo.SelectedIndex;

            loadActivityType();
        }

        private void loadActivityType() {
            typeCombo.Items.Clear();

            for (int i = 0; i < Base.OptionNodes[SelectedIndex].Count; i++) {
                typeCombo.Items.Add(Base.OptionNodes[SelectedIndex][i][0]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //add1 button
            if (SelectedIndex > -1)
            {
                if (!string.IsNullOrEmpty(addText.Text) && checkForEqualNames(addText.Text))
                {
                    addButton1.Enabled = true;
                }else {
                    addButton1.Enabled = false;
                }
            }else {
                addButton1.Enabled = false;
            }

            //done button
            if (SelectedIndex > -1 && typeCombo.SelectedIndex > -1 && cashBankCombo.SelectedIndex > -1)
            {
                if (!string.IsNullOrEmpty(amountText.Text))
                {
                    addButton.Enabled = true;                    
                }else {
                    addButton.Enabled = false;
                }
            }else {
                addButton.Enabled = false;
            }
        }

        private bool checkForEqualNames(string name)
        {
            bool noDoubles = true;

            for (int i = 0; i < Base.OptionNodes[SelectedIndex].Count; i++)
            {
                if (Base.OptionNodes[SelectedIndex][i][0] == name)
                {
                    noDoubles = false;
                    goto after_loop;
                }
            }

            after_loop:

            return noDoubles;
        }

        private string getNewID()
        {
            int maxID = 0;

            for (int i = 0; i < Base.OptionNodes[SelectedIndex].Count; i++){
                if (Int32.Parse(Base.OptionNodes[SelectedIndex][i][1]) > maxID){
                    maxID = Int32.Parse(Base.OptionNodes[SelectedIndex][i][1]);
                }
            }

            maxID++;

            return maxID.ToString();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            Base.OptionNodes[SelectedIndex].Add(new List<string> {addText.Text, getNewID(), "false"});
            addText.Text = "";

            Base.updateOptionsXML();
            loadActivityType();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
