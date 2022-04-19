using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kółko_i_krzyżyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        bool gracz1 = true;
        int ruch = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Restartuj();//wywołujemy funkcję restartuj, aby zacząć od nowa grę
            wynikO.Text = "0";
            wynikX.Text = "0";
            kto.Text = "O";

        }
        private void Sprawdz()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text==btn3.Text)
            {
                Wygrana();
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text)
            {
                Wygrana();
            }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text)
            {
                Wygrana();
            }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text)
            {
                Wygrana();
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text)
            {
                Wygrana();
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text)
            {
                Wygrana();
            }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text)
            {
                Wygrana();
            }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text)
            {
                Wygrana();
            }
            else if (ruch == 9)
            {
                MessageBox.Show("Remis", "koniec gry!", MessageBoxButtons.OK , MessageBoxIcon.Information);
                Restartuj();
            }
        }

        private void Wygrana()
        {
            MessageBox.Show("Wygrywa gracz " + (gracz1 ? "O!" : "X!"), "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Restartuj();
            if (gracz1)
                wynikO.Text = (Convert.ToInt32(wynikO.Text) + 1).ToString();
            else
                wynikX.Text = (Convert.ToInt32(wynikX.Text) + 1).ToString();
        }

        private void Restartuj()
        {
            ruch = 0;
            Button [] all= new Button[9];//robimy tablicę odpowiadającą za przyciski
            all[0] = btn1;
            all[1] = btn2;
            all[2] = btn3;
            all[3] = btn4;
            all[4] = btn5;
            all[5] = btn6;
            all[6] = btn7;
            all[7] = btn8;
            all[8] = btn9;
            foreach (Button b in all)
            {
                b.Enabled=true;
                b.Text = "";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ruch++;//zwiększamy nasz ruch
            ((Button)sender).Text = gracz1 ? "O" : "X";//korzystamy z obiektu sender, który przechowuje informację o tym, kto wysłał to zdarzenie
            //zamiast używać if sprawdzamy czy kółko ma swoją kolej
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();//wywolujemy funkcję która sprawdzi kto wygrał
            }
            gracz1 = !gracz1;// kolejkę ma gracz przeciwny do pierwszego (drugi)
            kto.Text = gracz1 ? "O" : "X";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ruch++;//zwiększamy nasz ruch
            ((Button)sender).Text = gracz1 ? "O" : "X";//korzystamy z obiektu sender, który przechowuje informację o tym, kto wysłał to zdarzenie
            //zamiast używać if sprawdzamy czy kółko ma swoją kolej
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();//wywolujemy funkcję która sprawdzi kto wygrał
            }
            gracz1 = !gracz1;// kolejkę ma gracz przeciwny do pierwszego (drugi)
            kto.Text = gracz1 ? "O" : "X";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ruch++;//zwiększamy nasz ruch
            ((Button)sender).Text = gracz1 ? "O" : "X";//korzystamy z obiektu sender, który przechowuje informację o tym, kto wysłał to zdarzenie
            //zamiast używać if sprawdzamy czy kółko ma swoją kolej
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();//wywolujemy funkcję która sprawdzi kto wygrał
            }
            gracz1 = !gracz1;// kolejkę ma gracz przeciwny do pierwszego (drugi)
            kto.Text = gracz1 ? "O" : "X";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ruch++;//zwiększamy nasz ruch
            ((Button)sender).Text = gracz1 ? "O" : "X";//korzystamy z obiektu sender, który przechowuje informację o tym, kto wysłał to zdarzenie
            //zamiast używać if sprawdzamy czy kółko ma swoją kolej
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();//wywolujemy funkcję która sprawdzi kto wygrał
            }
            gracz1 = !gracz1;// kolejkę ma gracz przeciwny do pierwszego (drugi)
            kto.Text = gracz1 ? "O" : "X";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ruch++;//zwiększamy nasz ruch
            ((Button)sender).Text = gracz1 ? "O" : "X";//korzystamy z obiektu sender, który przechowuje informację o tym, kto wysłał to zdarzenie
            //zamiast używać if sprawdzamy czy kółko ma swoją kolej
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();//wywolujemy funkcję która sprawdzi kto wygrał
            }
            gracz1 = !gracz1;// kolejkę ma gracz przeciwny do pierwszego (drugi)
            kto.Text = gracz1 ? "O" : "X";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ruch++;//zwiększamy nasz ruch
            ((Button)sender).Text = gracz1 ? "O" : "X";//korzystamy z obiektu sender, który przechowuje informację o tym, kto wysłał to zdarzenie
            //zamiast używać if sprawdzamy czy kółko ma swoją kolej
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();//wywolujemy funkcję która sprawdzi kto wygrał
            }
            gracz1 = !gracz1;// kolejkę ma gracz przeciwny do pierwszego (drugi)
            kto.Text = gracz1 ? "O" : "X";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ruch++;//zwiększamy nasz ruch
            ((Button)sender).Text = gracz1 ? "O" : "X";//korzystamy z obiektu sender, który przechowuje informację o tym, kto wysłał to zdarzenie
            //zamiast używać if sprawdzamy czy kółko ma swoją kolej
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();//wywolujemy funkcję która sprawdzi kto wygrał
            }
            gracz1 = !gracz1;// kolejkę ma gracz przeciwny do pierwszego (drugi)
            kto.Text = gracz1 ? "O" : "X";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ruch++;//zwiększamy nasz ruch
            ((Button)sender).Text = gracz1 ? "O" : "X";//korzystamy z obiektu sender, który przechowuje informację o tym, kto wysłał to zdarzenie
            //zamiast używać if sprawdzamy czy kółko ma swoją kolej
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();//wywolujemy funkcję która sprawdzi kto wygrał
            }
            gracz1 = !gracz1;// kolejkę ma gracz przeciwny do pierwszego (drugi)
            kto.Text = gracz1 ? "O" : "X";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ruch++;//zwiększamy nasz ruch
            ((Button)sender).Text = gracz1 ? "O" : "X";//korzystamy z obiektu sender, który przechowuje informację o tym, kto wysłał to zdarzenie
            //zamiast używać if sprawdzamy czy kółko ma swoją kolej
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();//wywolujemy funkcję która sprawdzi kto wygrał
            }
            gracz1 = !gracz1;// kolejkę ma gracz przeciwny do pierwszego (drugi)
            kto.Text = gracz1 ? "O" : "X";
        }
    }
}
