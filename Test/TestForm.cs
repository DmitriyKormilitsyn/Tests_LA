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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Test
{
    public partial class TestForm : Form
    {
        public string TitlePdfFile, TestName;
        public TestForm(string s, string name)
        {
            //переопределение параметров для заголовка пдф отчета
            TestName = name;
            TitlePdfFile = s;
            InitializeComponent();
        }

        public string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Temp.txt";
        public string TestNamePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Test";
        public int[] RandomNum = new int[200];
        public int[] RandomNumA = new int[200];
        public int[] RandomNumAnswers = new int[200];
        public int[] RandomNumQuestions = new int[200];
        //количество вопросов на вывод
        public int QuantityQuestions;
        public int CountQuestions = 1;
        Random rand = new Random();
        double Point = 0;
        public int timer = 63;
        public int CountQuestionsForOutput;
        public int RandAll = 143;
        string testname;
        public int QuantityQuestionsAllTest = 30;

        public List<string> MassivOfQuestions = new List<string>();
        public List<string> MassivOfAnswer = new List<string>();
        public List<string> MassivOfAnswers = new List<string>();
        public List<string> MassivOfAnswersForPdf = new List<string>();


        //функция создания пдф отчета
        private void PdfCreator (string resultstr)
        {

            string Path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Report" + "/";
            string FontPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Font" + "/ofont.ru_Arial.ttf";

            //подключение руссккого языка
            BaseFont baseFont = BaseFont.CreateFont(@FontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(Path + TitlePdfFile + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph Title = new Paragraph(TitlePdfFile, font);
            Title.Alignment = Element.ALIGN_CENTER;
            doc.Add(Title);

            Paragraph TitleTestName = new Paragraph(TestName + "\n", font);
            TitleTestName.Alignment = Element.ALIGN_CENTER;
            doc.Add(TitleTestName);

            int count = 1;
            for (int i = 0; i < 30; i++)
            {
                
                Paragraph Ques = new Paragraph("Вопрос №" + (count) + ": " + MassivOfQuestions[RandomNumQuestions[i]], font);
                Paragraph Answ = new Paragraph("Ответ: " + MassivOfAnswersForPdf[i], font);

                doc.Add(Ques);
                doc.Add(Answ);
                count++;
            }

            Paragraph Res = new Paragraph("\nИтоговый балл: " + Math.Round(Point).ToString() + " " + resultstr, font);
            doc.Add(Res);

            doc.Close();
        }

        private void ClearField()
        {
            Question_label.Text = "";
            Answer1_label.Text = "";
            Answer2_label.Text = "";
            Answer3_label.Text = "";
            Answer4_label.Text = "";
            Answer_label.Text = "";
        }

        private int[] Sdvig (int [] Mass, int temp, int RandAll, int i)
        {
            int k = temp;
            RandomNum[i] = Mass[k];
            for (k = temp+1; k < RandAll; k++)
            {
                
                Mass[k-1] = Mass[k];
            }
            //x++;
            return Mass;
        }

        private int[] RandNum(int RandAll)
        {
            int i = 0;
            int x = 0;
            int[] Mas1 = new int[RandAll];

            for (int j = 0; j < RandAll; j++)
            {
                Mas1[j] = j;
            }
           
            while (i < RandAll)
            {
                int temp = rand.Next(0, RandAll - i);
                Mas1 = Sdvig(Mas1, temp, RandAll - i, i);
                i++;
            }
            return RandomNum;
        }

        private void Change (string bufer)
        {
            string buf = "";
            int k = 0;
            string strr = MassivOfAnswer[RandomNumQuestions[0]];
            for (int j = 0; j < bufer.Length; j++)
            {
                if (bufer[j] != '*')
                    buf = buf + bufer[j];
                else
                {

                    MassivOfAnswers.Add(buf);
                    //MassivOfAnswers.Remove("*");
                    buf = "";
                }
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

            MaxBall_textBox.Text = "23";
            MinBall_textBox.Text = "14";
            CountQuestionsForOutput = CountQuestions;

            LeftTime_textBox.Text = timer.ToString();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();

            Next_button.Visible = false;

            CuurQuest_textBox.Text = (CountQuestionsForOutput).ToString();
            LeftQuest_textBox.Text = (30 - CountQuestionsForOutput).ToString();

            CurBall_textBox.Text = Point.ToString();

            //Вывод названия темы на экран из файла Temp
            using (StreamReader sr = new StreamReader(currentPath, System.Text.Encoding.Default))
            {
                string line;

                line = sr.ReadLine();
                testname = sr.ReadLine();
            }
            TestNamePath = TestNamePath + "/" + testname + ".txt";
            int count = 0, k = 0;
            string bufer = "";

            int i = 0;
            RandNum(RandAll);

            while (i < QuantityQuestionsAllTest)
            {
                RandomNumQuestions[i] = RandomNum[i];
                i++;
            }


            RandNum(4);
            i = 0;
            while (i <= 3)
            {
                RandomNumAnswers[i] = RandomNum[i];
                i++;
            }

            //запись в массивы вопросов и ответов 
            try
            {
                using (StreamReader sr = new StreamReader(TestNamePath, System.Text.Encoding.Default))
                {
                    while (true)
                    { 
                        string temp = sr.ReadLine();
                        if (count % 5 == 0)
                        {
                            bufer = "";
                            MassivOfQuestions.Add(temp);
                            Answer1_label.Text = Answer1_label.Text + MassivOfQuestions[k];
                            k++;
                        }
                        else
                        {
                            bufer = bufer + temp + "*";
                            //костыль для ввода в массив всех вариантов ответа к вопросу
                            if ((count + 1) % 5 == 0)
                            {
                                MassivOfAnswer.Add(bufer);
                               
                            }
                        }
                        
                        count++;
                        if (temp == null) break;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //функция для очистки полей
            ClearField();


            // Change(RandomNum, RandomNumAnswers, 3);


            Change(MassivOfAnswer[RandomNumQuestions[0]]);

            //делаем массив ответов



            Question_label.Text = MassivOfQuestions[RandomNumQuestions[0]].ToString();
            Answer1_label.Text = MassivOfAnswers[RandomNumAnswers[0]].ToString();
            Answer2_label.Text = MassivOfAnswers[RandomNumAnswers[1]].ToString();
            Answer3_label.Text = MassivOfAnswers[RandomNumAnswers[2]].ToString();
            Answer4_label.Text = MassivOfAnswers[RandomNumAnswers[3]].ToString();


        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            timer = 60;
            timer1.Enabled = true;
            timer1.Start();

            CountQuestionsForOutput++;

            CurBall_textBox.Text = Point.ToString();

            CuurQuest_textBox.Text = (CountQuestionsForOutput).ToString();
            LeftQuest_textBox.Text = (30 - CountQuestionsForOutput).ToString();

            MassivOfAnswers.Clear();
            ClearField();
            AnswerButton.Visible = true;
            Next_button.Visible = false;
            Answer_label.Visible = false;

            int i = 0;

            RandNum(4);
            i = 0;
            while (i <= 3)
            {
                RandomNumAnswers[i] = RandomNum[i];
                i++;
            }


                Change(MassivOfAnswer[RandomNumQuestions[CountQuestions]]);

                Question_label.Text = MassivOfQuestions[RandomNumQuestions[CountQuestions]].ToString();

                Answer1_label.Text = MassivOfAnswers[RandomNumAnswers[0]].ToString();
                Answer2_label.Text = MassivOfAnswers[RandomNumAnswers[1]].ToString();
                Answer3_label.Text = MassivOfAnswers[RandomNumAnswers[2]].ToString();
                Answer4_label.Text = MassivOfAnswers[RandomNumAnswers[3]].ToString();
            CountQuestions++;

            
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            string resultstr;
            timer1.Stop();
            AnswerButton.Visible = false;
            Next_button.Visible = true;
            Answer_label.Visible = true;

            if (Answer1_radioButton.Checked)
            {
                if (MassivOfAnswers[RandomNumAnswers[0]] == MassivOfAnswers[0])
                {
                    Answer_label.Text = "Правильный ответ!";
                    Point = Point + 0.8;
                    CurBall_textBox.Text = Point.ToString();

                    MassivOfAnswersForPdf.Add(MassivOfAnswers[RandomNumAnswers[0]]);
                }
                else
                {
                    Answer_label.Text = "Неправильный ответ! ";
                    MassivOfAnswersForPdf.Add(MassivOfAnswers[RandomNumAnswers[0]]);

                }
            }

            if (Answer2_radioButton.Checked)
            {
                if (MassivOfAnswers[RandomNumAnswers[1]] == MassivOfAnswers[0])
                {
                    Answer_label.Text = "Правильный ответ!";
                    Point = Point + 0.8;
                    CurBall_textBox.Text = Point.ToString();
                    MassivOfAnswersForPdf.Add(MassivOfAnswers[RandomNumAnswers[1]]);

                }
                else
                {
                    Answer_label.Text = "Неправильный ответ! ";
                    MassivOfAnswersForPdf.Add(MassivOfAnswers[RandomNumAnswers[1]]);

                }
            }

            if (Answer3_radioButton.Checked)
            {
                if (MassivOfAnswers[RandomNumAnswers[2]] == MassivOfAnswers[0])
                {
                    Answer_label.Text = "Правильный ответ!";
                    Point = Point + 0.8;
                    CurBall_textBox.Text = Point.ToString();
                    MassivOfAnswersForPdf.Add(MassivOfAnswers[RandomNumAnswers[2]]);

                }
                else
                {
                    Answer_label.Text = "Неправильный ответ! ";
                    MassivOfAnswersForPdf.Add(MassivOfAnswers[RandomNumAnswers[2]]);

                }
            }

            if (Answer4_radioButton.Checked)
            {
                if (MassivOfAnswers[RandomNumAnswers[3]] == MassivOfAnswers[0])
                {
                    Answer_label.Text = "Правильный ответ!";
                    Point = Point + 0.8;
                    CurBall_textBox.Text = Point.ToString();
                    MassivOfAnswersForPdf.Add(MassivOfAnswers[RandomNumAnswers[3]]);

                }
                else
                {
                    Answer_label.Text = "Неправильный ответ! ";
                    MassivOfAnswersForPdf.Add(MassivOfAnswers[RandomNumAnswers[3]]);

                }
            }


            if (CountQuestions == QuantityQuestionsAllTest)
            {
                if (Point == 24)
                {
                    Point = 23;
                }

                if (Point >= 14)
                {
                    resultstr = "Вы прошли тест!";
                }
                else
                {
                    resultstr = "Вы не прошли тест!";
                }

                DialogResult result = MessageBox.Show(
                   resultstr + "\n" + "Ваш балл: " + Math.Round(Point),
                   "Результат теста",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.OK)
                {

                    this.Close();
                    Choice_group f = new Choice_group();
                    f.Show();
                }
                PdfCreator(resultstr);
            }
            //ClearField();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LeftTime_textBox.Text = (--timer).ToString();
            //Timer_label.Text = (--timer).ToString();
            if (timer == 0)
            {
                timer1.Stop();
                AnswerButton.Visible = false;
                Next_button.Visible = true;
                Answer_label.Visible = true;
                Answer_label.Text = "Время истекло! ";

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
