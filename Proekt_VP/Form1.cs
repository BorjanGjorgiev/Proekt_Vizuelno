using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Media;
using NAudio.Wave;
using System;


namespace Proekt_VP
{
    // private Timer timer1;
    public partial class Form1 : Form
    {
        int TocenOdgovor;
        int BrojPrasanje = 1;
        int score;
        int percentage;
        int totalQuestions;
        private int timeLeft { get; set; } = 7;

        // public int timeLeft { get; set; } =7;

         SoundPlayer Muzika = new SoundPlayer(@"C:\\Users\\user\\Desktop\\Proekt_VP\\Proekt_VP\\Resources\Who Wants To Be A Millionaire Full Theme.wav");

        SoundPlayer Muzika2 = new SoundPlayer(@"C:\Users\user\Desktop\Proekt_VP\Proekt_VP\\Resources\Pokratko.wav");


        public Form1()
        {
            InitializeComponent();
            askQuestion(BrojPrasanje);

            totalQuestions = 15;


            panel17.Hide();
            panelPhone.Hide();

          
            Muzika.Play();

        }

        private int Score(int num)
        {

            return num;
        }

        private void ProveriOdgovor(object sender, EventArgs e)
        {
            List<Panel> panels = new List<Panel> { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12, panel13, panel15, panel16 };
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);


            if (buttonTag == TocenOdgovor)
            {
                BrojPrasanje++;
                askQuestion(BrojPrasanje);

            }
            else
            {

                string message = "Погрешен одговор!";
                string caption = "Се враќата на почеток!";

                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {

                    foreach (Panel panel in panels)
                    {
                        panel.BackColor = Color.Transparent;
                    }

                }
                BrojPrasanje = 1;
                askQuestion(BrojPrasanje);
                tbOsvoeniSredstva.Text = 0.ToString();
                pictureBox1.Show();
                pictureBox1.Enabled = true;
                pictureBox3.Show();
                pictureBox3.Enabled = true;
                panel17.Hide();
            }

        }
        private void askQuestion(int Qnum)
        {

            switch (Qnum)
            {
                case 1:
                    //Question
                    label33.Text = "На кој датум Република Македонија ја стекна својата независност?";
                    label13.Text = "1";
                    OptionA.Text = "A) 11-ти Октомври";
                    OptionB.Text = "B) 6-ти Септември ";
                    OptionC.Text = "C) 8-ми Септември";
                    OptionD.Text = "D) 8-ми Ноември";

                    TocenOdgovor = 3;
                    panel16.BackColor = Color.Orange;
                    Muzika.Stop();
                    Muzika2.Play();
                    tbOsvoeniSredstva.Text = Score(100).ToString();
                    break;

                case 2:
                    label33.Text = "Што означува соединението H20?";
                    label13.Text = "2";
                    OptionA.Text = "A) Сок";
                    OptionB.Text = "B) Вода";
                    OptionC.Text = "C) Кафе";
                    OptionD.Text = "D) Чај";

                    TocenOdgovor = 2;
                    Muzika2.Play();
                    panel1.BackColor = Color.Orange;
                    panel16.BackColor = Color.Transparent;
                    tbOsvoeniSredstva.Text = Score(200).ToString();
                    break;

                case 3:
                    label33.Text = "Колку континенти има на земјината топка?";
                    label13.Text = "3";
                    OptionA.Text = "A) 7";
                    OptionB.Text = "B) 9";
                    OptionC.Text = "C) 5";
                    OptionD.Text = "D) 8";

                    TocenOdgovor = 1;
                    Muzika2.Play();
                    panel2.BackColor = Color.DarkOrange;
                    panel1.BackColor = Color.Transparent;
                    tbOsvoeniSredstva.Text = Score(300).ToString();
                    break;

                case 4:

                    label33.Text = "Кое митолошко суштество одново се раѓа од пепел?";
                    label13.Text = "4";
                    OptionA.Text = "A) Минотаур";
                    OptionB.Text = "B) Змеј";
                    OptionC.Text = "C) Феникс";
                    OptionD.Text = "D) Кенгур";
                    TocenOdgovor = 3;
                    Muzika2.Play();
                    panel3.BackColor = Color.DarkOrange;
                    panel2.BackColor = Color.Transparent;
                    tbOsvoeniSredstva.Text = Score(500).ToString();
                    break;

                case 5:

                    label33.Text = "Колку острови има во Македонија?";
                    label13.Text = "5";
                    OptionA.Text = "A) 0";
                    OptionB.Text = "B) 2";
                    OptionC.Text = "C) 3";
                    OptionD.Text = "D) 1";
                    panel4.BackColor = Color.DarkOrange;
                    panel3.BackColor = Color.Transparent;
                    TocenOdgovor = 4;
                    Muzika2.Play();
                    tbOsvoeniSredstva.Text = Score(1000).ToString();
                    break;

                case 6:
                    label33.Text = "Хералдика е наука за?";
                    label13.Text = "6";
                    OptionA.Text = "A) Знамињата";
                    OptionB.Text = "B) Грбовите";
                    OptionC.Text = "C) Говорот";
                    OptionD.Text = "D) Потеклото";
                    panel5.BackColor = Color.DarkOrange;
                    panel4.BackColor = Color.Transparent;
                    TocenOdgovor = 2;
                    tbOsvoeniSredstva.Text = Score(1500).ToString();
                    Muzika2.Play();
                    break;


                case 7:
                    label33.Text = "Кои три бои се наоѓаат на семафорот?";
                    label13.Text = "7";
                    OptionA.Text = "A) црвена,жолта,зелена";
                    OptionB.Text = "B) бела,црна,сина";
                    OptionC.Text = "C) плава,зелена,сина";
                    OptionD.Text = "D) жолта,бела,црна";
                    panel6.BackColor = Color.DarkOrange;
                    panel5.BackColor = Color.Transparent;
                    tbOsvoeniSredstva.Text = Score(2500).ToString();
                    TocenOdgovor = 1;
                    Muzika2.Play();

                    break;


                case 8:
                    label33.Text = "Кој од овие зборови е палиндром?";
                    label13.Text = "8";
                    OptionA.Text = "A) Поп";
                    OptionB.Text = "B) Палец";
                    OptionC.Text = "C) Прст";
                    OptionD.Text = "D) Пиле";
                    TocenOdgovor = 1;
                    Muzika2.Play();
                    panel7.BackColor = Color.DarkOrange;
                    panel6.BackColor = Color.Transparent;
                    tbOsvoeniSredstva.Text = Score(4000).ToString();
                    break;

                case 9:
                    label33.Text = "Кое животно е карактеристично за македонската фудбалска репрезентација?";
                    label13.Text = "9";
                    OptionA.Text = "A) Пајак";
                    OptionB.Text = "B) Лав";
                    OptionC.Text = "C) Змија";
                    OptionD.Text = "D) Рис";
                    TocenOdgovor = 4;
                    Muzika2.Play();
                    panel8.BackColor = Color.DarkOrange;
                    panel7.BackColor = Color.Transparent;
                    tbOsvoeniSredstva.Text = Score(6000).ToString();
                    break;

                case 10:

                    label33.Text = "Ако од некоја работа сме завршиле 40%, ни остануваат уште?";
                    label13.Text = "10";
                    OptionA.Text = "A) 1/5";
                    OptionB.Text = "B) 3/5";
                    OptionC.Text = "C) 2/5";
                    OptionD.Text = "D) 4/5";
                    TocenOdgovor = 2;
                    Muzika2.Play();
                    panel9.BackColor = Color.DarkOrange;
                    panel8.BackColor = Color.Transparent;
                    tbOsvoeniSredstva.Text = Score(10000).ToString();
                    break;
                case 11:
                    label33.Text = "Која додавка ја имал градот Велес во СФРЈ?";
                    label13.Text = "11";
                    OptionA.Text = "A) Голем";
                    OptionB.Text = "B) Петков";
                    OptionC.Text = "C) Титов";
                    OptionD.Text = "D) Мал";
                    TocenOdgovor = 3;
                    Muzika2.Play();
                    panel10.BackColor = Color.DarkOrange;
                    panel9.BackColor = Color.Transparent;
                    tbOsvoeniSredstva.Text = Score(20000).ToString();
                    break;
                case 12:
                    label33.Text = "Најдолга река во Македонија е?";
                    label13.Text = "12";
                    OptionA.Text = "A) Вардар";
                    OptionB.Text = "B) Брегалница";
                    OptionC.Text = "C) Пчиња";
                    OptionD.Text = "D) Треска";
                    TocenOdgovor = 1;
                    Muzika2.Play();
                    panel11.BackColor = Color.DarkOrange;
                    panel10.BackColor = Color.Transparent;
                    tbOsvoeniSredstva.Text = Score(50000).ToString();
                    break;
                case 13:
                    label33.Text = "Градот Скопје е најблиску до која држава?";
                    label13.Text = "13";
                    OptionA.Text = "A) Србија";
                    OptionB.Text = "B) Грција";
                    OptionC.Text = "C) Албанија";
                    OptionD.Text = "D) Бугарија";
                    TocenOdgovor = 1;
                    Muzika2.Play();
                    panel12.BackColor = Color.DarkOrange;
                    panel11.BackColor = Color.Transparent;
                    tbOsvoeniSredstva.Text = Score(100000).ToString();
                    break;
                case 14:
                    label33.Text = "Која од овие направи е најстара?";
                    label13.Text = "14";
                    OptionA.Text = "A) Телефон";
                    OptionB.Text = "B) Телеграф";
                    OptionC.Text = "C) Телевизор";
                    OptionD.Text = "D) Радио";
                    TocenOdgovor = 2;
                    Muzika2.Play();
                    panel13.BackColor = Color.DarkOrange;
                    panel12.BackColor = Color.Transparent;
                    tbOsvoeniSredstva.Text = Score(250000).ToString();
                    break;
                case 15:
                    label33.Text = "Каде се произведува автомобилот Ферари?";
                    label13.Text = "15";
                    OptionA.Text = "A) Неапол";
                    OptionB.Text = "B) Фиренца";
                    OptionC.Text = "C) Маранело";
                    OptionD.Text = "D) Торино";
                    TocenOdgovor = 3;
                    Muzika2.Play();
                    panel15.BackColor = Color.DarkOrange;
                    panel13.BackColor = Color.Transparent;
                    tbOsvoeniSredstva.Text = Score(1000000).ToString();
                    break;

                default:
                    Muzika2.Stop();
                    Muzika.Play();
                    MessageBox.Show("ЧЕСТИТКИ ВИЕ СТЕ ПОБЕДНИКОТ! ОСВОИВТЕ 1.000.000 ДЕНАРИ");
                    Application.Exit();
                    break;


            }

        }



        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void btnOdgovori_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel17.Show();
            timer1.Start();





            Random random = new Random();


            int TocenOdgovor = random.Next(50, 101);
            Dictionary<int, int> tabela = new Dictionary<int, int>
            {
    { 1, 3 },
    { 2, 2 },
    { 3, 1 },
    { 4, 3 },
    { 5, 4 },
    { 6, 2 },
    { 7, 1 },
    { 8, 1 },
     { 9, 4 },
    { 10, 2 },
    { 11, 3 },
    { 12, 1 },
    { 13, 1 },
    { 14, 2 },
    { 15, 3 }
            };

            int searchKey = (int)Convert.ToUInt32(label13.Text);

            if (tabela.ContainsKey(searchKey))
            {
                int correctOption = tabela[searchKey];
                if (correctOption == 1)
                {
                    int opcija3 = random.Next(0, 50);
                    int opcija2 = random.Next(0, 50);
                    int opcija4 = random.Next(0, 50);
                    progressBar1.Value = TocenOdgovor;
                    NumA.Text = TocenOdgovor.ToString();
                    NumB.Text = opcija2.ToString();
                    NumC.Text = opcija3.ToString();
                    NumD.Text = opcija4.ToString();
                    progressBar2.Value = opcija2;
                    progressBar3.Value = opcija3;
                    progressBar4.Value = opcija4;

                }
                if (correctOption == 2)
                {
                    int opcija3 = random.Next(0, 50);
                    int opcija1 = random.Next(0, 50);
                    int opcija4 = random.Next(0, 50);

                    progressBar2.Value = TocenOdgovor;
                    NumA.Text = opcija1.ToString();
                    NumB.Text = TocenOdgovor.ToString();
                    NumC.Text = opcija3.ToString();
                    NumD.Text = opcija4.ToString();

                    progressBar1.Value = opcija1;
                    progressBar3.Value = opcija3;
                    progressBar4.Value = opcija4;
                }
                if (correctOption == 3)
                {
                    int opcija2 = random.Next(0, 50);
                    int opcija1 = random.Next(0, 50);
                    int opcija4 = random.Next(0, 50);

                    progressBar3.Value = TocenOdgovor;

                    NumA.Text = opcija1.ToString();
                    NumB.Text = opcija2.ToString();
                    NumC.Text = TocenOdgovor.ToString();
                    NumD.Text = opcija4.ToString();

                    progressBar1.Value = opcija1;
                    progressBar2.Value = opcija2;
                    progressBar4.Value = opcija4;

                }
                if (correctOption == 4)
                {
                    int opcija1 = random.Next(0, 50);
                    int opcija2 = random.Next(0, 50);
                    int opcija3 = random.Next(0, 50);

                    progressBar4.Value = TocenOdgovor;

                    NumA.Text = opcija1.ToString();
                    NumB.Text = opcija2.ToString();
                    NumC.Text = opcija3.ToString();
                    NumD.Text = TocenOdgovor.ToString();

                    progressBar1.Value = opcija1;
                    progressBar3.Value = opcija3;
                    progressBar2.Value = opcija2;

                }
                // UpdateProgressBar(correctOption);
            }

            pictureBox3.Hide();
            pictureBox3.Enabled = false;





            //   progressBar1.Value = option1 ;
            //  progressBar2.Value = option2 ;
            //    progressBar3.Value = option3;
            //    progressBar4.Value = option4 ;

        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int optionToHide1 = random.Next(1, 5); // Generate the first random number between 1 and 4
            int optionToHide2 = random.Next(1, 5); // Generate the second random number between 1 and 4

            Dictionary<int, int> tabela = new Dictionary<int, int>
            {
    { 1, 3 },
    { 2, 2 },
    { 3, 1 },
    { 4, 3 },
    { 5, 4 },
    { 6, 2 },
    { 7, 1 },
    { 8, 1 },
     { 9, 4 },
    { 10, 2 },
    { 11, 3 },
    { 12, 1 },
    { 13, 1 },
    { 14, 2 },
    { 15, 3 }
            };
            int searchKey = (int)Convert.ToUInt32(label13.Text);

            if (tabela.ContainsKey(searchKey))
            {
                int correctOption = tabela[searchKey];
                if (correctOption == 1)
                {
                    //1//4
                    OptionC.Text = "";
                    OptionB.Text = "";

                }
                if (correctOption == 2)
                {
                    //2//4
                    OptionA.Text = "";
                    OptionC.Text = "";
                }
                if (correctOption == 3)
                {//3//1
                    OptionD.Text = "";
                    OptionB.Text = "";

                }
                if (correctOption == 4)
                {
                    //4//2
                    OptionA.Text = "";
                    OptionC.Text = "";
                }
                // UpdateProgressBar(correctOption);
            }

            /*
            // Ensure that the two random numbers are distinct
            while (optionToHide2 == optionToHide1)
            {
                optionToHide2 = random.Next(1, 5);
            }

            if (optionToHide1 == 1 || optionToHide2 == 1)
            {
                OptionA.Text = "";
            }
            if (optionToHide1 == 2 || optionToHide2 == 2)
            {
                OptionB.Text = "";
            }
            if (optionToHide1 == 3 || optionToHide2 == 3)
            {
                OptionC.Text = "";
            }
            if (optionToHide1 == 4 || optionToHide2 == 4)
            {
                OptionD.Text = "";
            }
            */

            pictureBox1.Hide();
        }

        private void label36_Click(object sender, EventArgs e)
        {
            panel17.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            if (timeLeft <= 0)
            {
                panel17.Hide();
                timer1.Stop();
                timeLeft = 7;
                //this.Close();   
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelPhone.Show();
            pictureBox2.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> tabela = new Dictionary<int, int>
            {
    { 1, 3 },
    { 2, 2 },
    { 3, 1 },
    { 4, 3 },
    { 5, 4 },
    { 6, 2 },
    { 7, 1 },
    { 8, 1 },
     { 9, 4 },
    { 10, 2 },
    { 11, 3 },
    { 12, 1 },
    { 13, 1 },
    { 14, 2 },
    { 15, 3 }
            };
            int searchKey = (int)Convert.ToUInt32(label13.Text);

            if (tabela.ContainsKey(searchKey))
            {
                int correctOption = tabela[searchKey];
                if (correctOption == 1)
                {
                    //1//4
                    label35.Text = "Мислам дека точниот одговор е под А";

                }
                if (correctOption == 2)
                {
                    label35.Text = "Не сум сигурен но ,мислам дека точниот одговор е под B";
                }
                if (correctOption == 3)
                {//3//1

                    label35.Text = " Точниот одгвор е под А";
                }
                if (correctOption == 4)
                {
                    //4//2
                    label35.Text = " Точниот одговор е под D";
                }
            }
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
            Dictionary<int, int> tabela = new Dictionary<int, int>
            {
    { 1, 3 },
    { 2, 2 },
    { 3, 1 },
    { 4, 3 },
    { 5, 4 },
    { 6, 2 },
    { 7, 1 },
    { 8, 1 },
     { 9, 4 },
    { 10, 2 },
    { 11, 3 },
    { 12, 1 },
    { 13, 1 },
    { 14, 2 },
    { 15, 3 }
            };
            int searchKey = (int)Convert.ToUInt32(label13.Text);

            if (tabela.ContainsKey(searchKey))
            {
                int correctOption = tabela[searchKey];
                if (correctOption == 1)
                {
                    //1//4
                    label35.Text = "Мислам дека точниот одговор е под А";

                }
                if (correctOption == 2)
                {
                    label35.Text = "Не сум сигурна но ,мислам дека точниот одговор е под C";
                }
                if (correctOption == 3)
                {//3//1

                    label35.Text = " Точниот одгвор е под C";
                }
                if (correctOption == 4)
                {
                    //4//2
                    label35.Text = " Точниот одговор е под D";
                }
            }
           
            
        }

        private void label34_Click(object sender, EventArgs e)
        {
            panelPhone.Hide();
        }
    }
}



