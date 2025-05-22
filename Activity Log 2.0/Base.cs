using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace Activity_Log_2._0
{
    public partial class Base : Form
    {
        public static String BasePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Activity Log 2.0";
        public static List<List<List<string>>> OptionNodes = new List<List<List<string>>> { new List<List<string>>(), new List<List<string>>()};

        public Base()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setLanguage();

            if (!File.Exists(BasePath + @"\Options.xml")) {
                OptionNodes[0].Add(new List<string> { Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["XML"], 2], "0", "true" });
                OptionNodes[1].Add(new List<string> { Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["XML"], 3], "0", "true" });

                updateOptionsXML();
            }

            loadNodes();

            loadLanguage();
        }

        private void loadNodes() {
            XmlDocument document = new XmlDocument();
            document.Load(BasePath + @"\Options.xml");

            //income
            XmlNodeList incomeList = document.SelectNodes("/options/income/activity");
            OptionNodes[0].Clear();
            for (int i = 0; i < incomeList.Count; i++) {
                if (incomeList[i].Attributes["default"].Value == "false"){
                    OptionNodes[0].Add(new List<string> { incomeList[i].Attributes["name"].Value,
                                                                incomeList[i].Attributes["id"].Value,
                                                                incomeList[i].Attributes["default"].Value
                    });
                }
                else {
                    OptionNodes[0].Add(new List<string> { Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["XML"], 2],
                                                                incomeList[i].Attributes["id"].Value,
                                                                incomeList[i].Attributes["default"].Value
                    });
                }
            }

            //expenses
            XmlNodeList expensesList = document.SelectNodes("/options/expenses/activity");
            OptionNodes[1].Clear();
            for (int i = 0; i < expensesList.Count; i++){
                if (expensesList[i].Attributes["default"].Value == "false") {
                    OptionNodes[1].Add(new List<string> { expensesList[i].Attributes["name"].Value,
                                                                expensesList[i].Attributes["id"].Value,
                                                                expensesList[i].Attributes["default"].Value
                    });
                }else {
                    OptionNodes[1].Add(new List<string> { Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["XML"], 3],
                                                                expensesList[i].Attributes["id"].Value,
                                                                expensesList[i].Attributes["default"].Value
                    });
                }
            }
        }

        private void setLanguage() {
            XmlDocument document = new XmlDocument();
            document.Load(BasePath + @"\Options.xml");

            //language
            XmlNode languageNode = document.SelectSingleNode("/options/language"); ;
            Languages.SelectedLanguage = Int32.Parse(languageNode.Attributes["index"].Value.ToString());
        }

        private void loadLanguage() {
            Text =                                  Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Base"], 0];

            dataGridView1.Columns[0].HeaderText =   Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Base"], 1];
            dataGridView1.Columns[1].HeaderText =   Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Base"], 2];
            dataGridView1.Columns[2].HeaderText =   Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Base"], 3];
            dataGridView1.Columns[3].HeaderText =   Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Base"], 4];

            optionsButton.Text =                    Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Base"], 5];
            addButton.Text =                        Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Base"], 6];
            viewStatsButton.Text =                  Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Base"], 7];
            calendarButton.Text =                   Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Base"], 8];
            removeButton.Text =                     Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Base"], 9];
            closeButton.Text =                      Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Base"], 10];

            linkLabel1.Text =                       Languages.AllLanguages[Languages.SelectedLanguage, Languages.FormIndexes["Base"], 11];
        }

        public static void updateOptionsXML() {
            XmlDocument document = new XmlDocument();
            XmlElement root = document.DocumentElement;

            XmlElement optionsElement = document.CreateElement(string.Empty, "options", string.Empty);
            document.AppendChild(optionsElement);

            //language element
            XmlNode languageNode = document.CreateNode(XmlNodeType.Element, "language", null);
            XmlAttribute indexAttribute = document.CreateAttribute("index");
            indexAttribute.Value = Languages.SelectedLanguage.ToString();
            languageNode.Attributes.Append(indexAttribute);
            optionsElement.AppendChild(languageNode);

            //income element
            XmlElement incomeElement = document.CreateElement(string.Empty, "income", string.Empty);
            optionsElement.AppendChild(incomeElement);

            //expenses element
            XmlElement expensesElement = document.CreateElement(string.Empty, "expenses", string.Empty);
            optionsElement.AppendChild(expensesElement);

            XmlElement[] elementTempArray = {incomeElement, expensesElement};

            for (int i = 0; i < 2; i++) {
                for (int b = 0; b < OptionNodes[i].Count; b++) {
                    XmlNode node = document.CreateNode(XmlNodeType.Element, "activity", null);

                    XmlAttribute xa = document.CreateAttribute("name");
                    if (OptionNodes[i][b][2] == "true"){
                        xa.Value = Languages.AllLanguages[0, Languages.FormIndexes["XML"], i + 2];
                    }
                    else {
                        xa.Value = OptionNodes[i][b][0];
                    }

                    XmlAttribute xb = document.CreateAttribute("id");
                    xb.Value = OptionNodes[i][b][1];

                    XmlAttribute xc = document.CreateAttribute("default");
                    xc.Value = OptionNodes[i][b][2];

                    node.Attributes.Append(xa);
                    node.Attributes.Append(xb);
                    node.Attributes.Append(xc);

                    elementTempArray[i].AppendChild(node);
                }
            }

            document.Save(BasePath + @"\Options.xml");
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(BasePath);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }
    }
}
