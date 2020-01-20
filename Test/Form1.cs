using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Choice_group : Form
    {

        public string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Temp.txt";
       
        public string Group_comboBoxValue;


        //реализация функции для записи в файл Temp название выбираемой темы и открытия следующей формы
        private void OpenForm(string tagname, string tagnamefull, string title, string name)
        {
            // запись в файл Temp название темы по нажатию кнопки
            using (StreamWriter sw = new StreamWriter(currentPath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(tagname);
                sw.WriteLine(tagnamefull);
            }
            string TitlePdfFile = title;
            string TestName = name; 
            this.Hide();
            TestForm f = new TestForm(TitlePdfFile, TestName);
            f.Show();
        }

        private void Chek()
        {
            if (Fam_textBox.Text != "" && Name_textBox.Text != "" && Part_textBox.Text != "" )
            {
                string date = DateTime.Now.ToString(" dd MMMM yyyy HH.mm.ss");
                string s = Fam_textBox.Text + " " + Name_textBox.Text + " " + Part_textBox.Text + " " + Group_comboBox.Text;
                string TestName = TestName_comboBox.Text;
                string Path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Report" + "/" + s + " " + date + ".txt";

                string tagnamefull = TestName_comboBox.Text + Group_comboBox.Text;
                string tagname = TestName_comboBox.Text;
                OpenForm(tagname, tagnamefull, s +" " + date, TestName);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                   "Заполните все поля!",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        public Choice_group()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Choice_group_Load(object sender, EventArgs e)
        {
            Group_comboBox.Items.AddRange (new string[] { "ЛТ1-31Б", "ЛТ2-31Б", "ЛТ2-32Б", "ЛТ3-31Б", "ЛТ6-31Б", "ЛТ6-32Б", "ЛТ6-33Б" }); // ИЗМЕНИ ОБРАТНО НА лт6!!!!!


        }

        private void Group_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestName_comboBox.Items.Clear();
            Group_comboBoxValue = Group_comboBox.Text;

            if (Group_comboBoxValue == "ЛТ6-31Б" || Group_comboBoxValue == "ЛТ6-32Б" || Group_comboBoxValue == "ЛТ6-33Б")
            {
                TestName_comboBox.Items.AddRange(new string[] { "Контрольная работа 1. Факторы и сущность почвообразования. Физические свойства почвы" });
            }
            else
            {
                TestName_comboBox.Items.AddRange(new string[] { "Контрольная работа 1. Факторы и сущность почвообразования" });
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            //функция для записи в файл Temp название выбираемой темы 


            Chek();

            
        }
    }
}
