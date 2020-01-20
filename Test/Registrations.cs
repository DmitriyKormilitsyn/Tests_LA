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
    public partial class Registrations : Form
    {
        public Registrations()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            //Запись в файл ФИО студента
            string s = DateTime.Now.ToString(" dd MMMM yyyy HH.mm.ss");
            string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Report" + "/" + StudentRichBox.Text + " " + s + ".txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(currentPath, true, System.Text.Encoding.Default))
                {

                    sw.WriteLine(StudentRichBox.Text + s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                if (StudentRichBox.Text == "")
                {
                    DialogResult result = MessageBox.Show(
                       "Заполните поле!",
                       "Ошибка!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    this.Close();
                    Choice_theme f = new Choice_theme();
                    f.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }
    }
}
