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
    public partial class Choice_theme : Form
    {
        public Choice_theme()
        {
            InitializeComponent();
        }
        public string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Temp.txt";
        public string Group;

        //реализация функции для записи в файл Temp название выбираемой темы и открытия следующей формы
        private void OpenForm (string tagname,string tagnamefull)
        {
            // запись в файл Temp название темы по нажатию кнопки
            using (StreamWriter sw = new StreamWriter(currentPath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(tagname);
                sw.WriteLine(tagnamefull);
            }

            this.Close();
            //TestForm f = new TestForm();
            //f.Show();
        }

        private void Choice_theme_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            try
            {
                using (StreamReader sr = new StreamReader(currentPath, System.Text.Encoding.Default))
                {
                    //читаем из файла Temp, в зависимости от того, что там показываем нужную панель
                    string line;
                    line = sr.ReadLine();
                    if (line == "LT1")
                    {
                        Group = "LT1-3";
                        panel1.Visible = true;
                    }
                    else
                    {
                        Group = "LT6";
                        panel2.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        void Button_Click(object sender, EventArgs e) 
        {
            try
            {
                string name = (sender as Button).Name;
                string tagnamefull = ((sender as Button).Tag + Group).ToString();
                string tagname = (sender as Button).Tag.ToString();
                //функция для записи в файл Temp название выбираемой темы и открытия следующей формы
                OpenForm(tagname,tagnamefull);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
    }
}
