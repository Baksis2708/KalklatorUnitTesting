using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorWO
{

    public partial class Form1 : Form
    {
        CurrentValue currentValue = new CurrentValue();
        public Form1()
        {

            InitializeComponent();

            rBtnDec.Checked = true;
            rBtnQword.Checked = true;
            btnRev.Enabled = false;
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            currentValue.textBox1Expression = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //rBtnDec
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnDec.Checked == true)
            {
                btn0.Enabled = true;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
            }
        }
        //btnOct
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnOct.Checked == true)
            {
                btn0.Enabled = true;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            klikniecieCyfry("0", btn0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            klikniecieCyfry("1", btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            klikniecieCyfry("2", btn2);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            klikniecieCyfry("3", btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            klikniecieCyfry("4", btn4);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            klikniecieCyfry("5", btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            klikniecieCyfry("6", btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            klikniecieCyfry("7", btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            klikniecieCyfry("8", btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            klikniecieCyfry("9", btn9);
        }

        private void rBtnHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnHex.Checked == true)
            {
                btn0.Enabled = true;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
            }
        }

        private void rBtnBin_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnBin.Checked == true)
            {
                btn0.Enabled = true;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {

        }

        private void btnB_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {

        }

        private void btnD_Click(object sender, EventArgs e)
        {

        }

        private void btnE_Click(object sender, EventArgs e)
        {

        }

        private void btnF_Click(object sender, EventArgs e)
        {

        }

        private void rBtnQword_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnQword.Checked == true)
            {
                currentValue.words = CurrentValue.Words.QWord;
                lbl15.Visible = true;
                lbl14.Visible = true;
                lbl13.Visible = true;
                lbl12.Visible = true;
                lbl11.Visible = true;
                lbl10.Visible = true;
                lbl9.Visible = true;
                lbl8.Visible = true;
                lbl7.Visible = true;
                lbl6.Visible = true;
                lbl5.Visible = true;
                lbl4.Visible = true;
                lbl3.Visible = true;
                lbl2.Visible = true;
                lbl1.Visible = true;

                label22.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label19.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
            }
        }

        private void rBtnDword_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnQword.Checked == true)
            {
                currentValue.words = CurrentValue.Words.DWord;
                lbl15.Visible = false;
                lbl14.Visible = false;
                lbl13.Visible = false;
                lbl12.Visible = false;
                lbl11.Visible = false;
                lbl10.Visible = false;
                lbl9.Visible = false;
                lbl8.Visible = false;
                lbl7.Visible = true;
                lbl6.Visible = true;
                lbl5.Visible = true;
                lbl4.Visible = true;
                lbl3.Visible = true;
                lbl2.Visible = true;
                lbl1.Visible = true;

                label22.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label19.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
            }
        }

        private void rBtnWord_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnQword.Checked == true)
            {
                currentValue.words = CurrentValue.Words.Word;
                lbl15.Visible = false;
                lbl14.Visible = false;
                lbl13.Visible = false;
                lbl12.Visible = false;
                lbl11.Visible = false;
                lbl10.Visible = false;
                lbl9.Visible = false;
                lbl8.Visible = false;
                lbl7.Visible = false;
                lbl6.Visible = false;
                lbl5.Visible = false;
                lbl4.Visible = true;
                lbl3.Visible = true;
                lbl2.Visible = true;
                lbl1.Visible = true;

                label22.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label19.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
            }
        }

        private void rBtnBajt_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnQword.Checked == true)
            {
                currentValue.words = CurrentValue.Words.Bajt;
                lbl15.Visible = false;
                lbl14.Visible = false;
                lbl13.Visible = false;
                lbl12.Visible = false;
                lbl11.Visible = false;
                lbl10.Visible = false;
                lbl9.Visible = false;
                lbl8.Visible = false;
                lbl7.Visible = false;
                lbl6.Visible = false;
                lbl5.Visible = false;
                lbl4.Visible = false;
                lbl3.Visible = false;
                lbl2.Visible = true;
                lbl1.Visible = true;

                label22.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label19.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
            }
        }

        private void btnRev_Click(object sender, EventArgs e)
        {

        }

        //Cyfra to string, bo moze tez byc A, B, C, D, E, F
        private void klikniecieCyfry(string cyfra, Button przycisk)
        {
            if (textBox1.Text.Substring(textBox1.Text.Length - 2) == " 0")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1) + cyfra;

            }
            else
            {

                textBox1.Text = textBox1.Text + cyfra;
            }
        }

        private void lbl15_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
