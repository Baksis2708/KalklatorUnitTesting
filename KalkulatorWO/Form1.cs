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
            btnSqrt.Enabled = false;
            btnModMath.Enabled = false;
            btnComma.Enabled = false;
            btnOpenP.Enabled = false;
            btnCloseP.Enabled = false;
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 1)
            {
                textBox1.Text = " " + textBox1.Text;
            }
            currentValue.textBox1Expression = textBox1.Text;

            if (currentValue.lastOperacja == "")
                UpdateBitLabels(textBox1.Text);
            /*
            switch(currentValue.words)
            {
                case CurrentValue.Words.QWord:
                    
                    break;
                case CurrentValue.Words.DWord:

                    break;
                case CurrentValue.Words.Word:

                    break;
                case CurrentValue.Words.Bajt:

                    break;
                default:
                    break;
            }
            */

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

                currentValue.digitSystem = CurrentValue.DigitSystem.Dec;
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

                currentValue.digitSystem = CurrentValue.DigitSystem.Oct;
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
            dzialanieArytmetyczne("+");
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

                currentValue.digitSystem = CurrentValue.DigitSystem.Hex;
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

                currentValue.digitSystem = CurrentValue.DigitSystem.Bin;
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
            if (rBtnDword.Checked == true)
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

                label22.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label19.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
            }
        }

        private void rBtnWord_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnWord.Checked == true)
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
                lbl4.Visible = false;
                lbl3.Visible = true;
                lbl2.Visible = true;
                lbl1.Visible = true;

                label22.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label19.Visible = false;
                label18.Visible = true;
                label17.Visible = true;
            }
        }

        private void rBtnBajt_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnBajt.Checked == true)
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
                lbl2.Visible = false;
                lbl1.Visible = true;

                label22.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label19.Visible = false;
                label18.Visible = false;
                label17.Visible = true;
            }
        }

        private void btnRev_Click(object sender, EventArgs e)
        {

        }

        //Cyfra to string, bo moze tez byc A, B, C, D, E, F
        /*
        private void klikniecieCyfry(string cyfra, Button przycisk)
        {
            bool flag = false;
            if (currentValue.lastOperacja != "")
            {
                textBox1.Text = cyfra;
                flag = true;
                currentValue.currentDzialanie = currentValue.currentDzialanie + cyfra;

                return;
            }
            if (textBox1.Text.Substring(textBox1.Text.Length - 2) == " 0")
            {
                
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1) + cyfra;

            }
            else
            {

                textBox1.Text = textBox1.Text + cyfra;
                if(flag == false)
                {
                    currentValue.currentDzialanie = currentValue.currentDzialanie + cyfra;
                }
                    
            }

            currentValue.lastOperacja = "";

        }
        */
        private void klikniecieCyfry(string cyfra, Button przycisk)
        {
            // Jeśli ostatnia operacja była operatorem, zacznij nową liczbę
            if (!string.IsNullOrEmpty(currentValue.lastOperacja))
            {
                textBox1.Text = "";
                currentValue.lastOperacja = "";
            }

            // Zapobiegaj wielokrotnym zerom na początku
            if (textBox1.Text == "0" && cyfra == "0")
                return;

            // Aktualizuj interfejs i wyrażenie
            textBox1.Text += cyfra;
            currentValue.currentDzialanie += cyfra;
        }

        private void lbl15_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            dzialanieArytmetyczne("-");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            dzialanieArytmetyczne("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            dzialanieArytmetyczne("/");
        }

        //dzialanie : +, -, *, /, MOD, RSH, LSH, AND, OR, XOR
        /*
        private void dzialanieArytmetyczne(string dzialanie)
        {
            string dzialaniaString = "/+-*MODRSHLSHANDORXOR";
            if (currentValue.lastOperacja != "")
            {
                currentValue.currentDzialanie = currentValue.currentDzialanie + currentValue.currentDzialanie.Substring(0, currentValue.currentDzialanie.Length - dzialanie.Length - 2);
                
            }
            currentValue.lastOperacja = dzialanie;
            currentValue.currentDzialanie = currentValue.currentDzialanie + " " + dzialanie + " ";
        }
        */
        private void dzialanieArytmetyczne(string dzialanie)
        {
            // Jeśli wyrażenie jest puste, nie dodawaj operatora
            if (string.IsNullOrEmpty(currentValue.currentDzialanie))
                return;

            // Sprawdź ostatni znak w wyrażeniu
            char ostatniZnak = currentValue.currentDzialanie[^1];

            // Jeśli ostatni znak to operator, zastąp go
            if ("+-*/%".Contains(ostatniZnak))
            {
                currentValue.currentDzialanie = currentValue.currentDzialanie[..^1] + dzialanie;
            }
            else
            {
                currentValue.currentDzialanie += $" {dzialanie} ";
            }

            currentValue.lastOperacja = dzialanie;
            textBox1.Text = dzialanie; // Opcjonalnie: pokaż operator na ekranie
        }

        // =
        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = initEval();

        }

        public string initEval()
        {
            if (currentValue.textBox1Expression == " 0" || currentValue.textBox1Expression == "")
            {
                return "0";
            }
            string[] tokens = currentValue.currentDzialanie.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 0)
            {
                return currentValue.textBox1Expression; // Brak działania do modyfikacji
            }

            // 3. Sprawdź, czy ostatni token to liczba (nie operator)
            string lastToken = tokens.Last();
            bool isOperator = lastToken == "+" || lastToken == "-" || lastToken == "*" || lastToken == "/" || lastToken == "%";
            if (isOperator)
            {
                return currentValue.textBox1Expression;
            }

            //textBox1.Text = currentValue.currentDzialanie;
            string temp = CurrentValue.EvaluateAsLong(currentValue.currentDzialanie).ToString();
            currentValue.currentDzialanie = temp;
            return temp;
        }

        // %
        private void btnModMath_Click(object sender, EventArgs e)
        {
            dzialanieArytmetyczne("%");
        }

        private void btnComma_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentValue.lastOperacja != "")
            {
                return;
            }

            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            currentValue.currentDzialanie = currentValue.currentDzialanie.Substring(0, currentValue.currentDzialanie.Length - 1);
        }

        /*
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (currentValue.lastOperacja != "")
            {
                return;
            }

            textBox1.Text = "-" + textBox1.Text;
            currentValue.currentDzialanie = currentValue.currentDzialanie.Substring(0, currentValue.currentDzialanie.Length - 1);
        }
        */

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (currentValue.lastOperacja != "")
            {
                return;
            }

            string[] tokens = currentValue.currentDzialanie.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 0)
            {
                return; // Brak działania
            }

            // Znajdź ostatnią liczbę w działaniu (ostatni token)
            string lastNumber = tokens.Last();

            // Zmień znak ostatniej liczby
            string newLastNumber = InvertNumberSign(lastNumber);

            // Zaktualizuj tablicę tokenów
            tokens[tokens.Length - 1] = newLastNumber;

            // Zbuduj nowe działanie
            currentValue.currentDzialanie = string.Join(" ", tokens);

            // Zaktualizuj textBox (pokazuje ostatnią liczbę)
            textBox1.Text = newLastNumber;
        }

        // Pomocnicza funkcja do zmiany znaku
        public string InvertNumberSign(string number)
        {
            return number.StartsWith("-") ? number.Substring(1) : "-" + number;
        }

        private void btnCReset_Click(object sender, EventArgs e)
        {
            // 1. Zresetuj interfejs
            textBox1.Text = "0";  // Domyślna wartość w textBox

            // 2. Wyczyść historię działań i stany
            currentValue.currentDzialanie = "";    // Resetuj bieżące działanie
            currentValue.lastOperacja = "";        // Resetuj ostatnią operację

            // 3. Dodatkowe resetowanie dla kalkulatora programisty (np. system liczbowy)
            // Jeśli masz flagę systemu (np. hex, bin, dec), zresetuj ją tutaj:
            // currentValue.currentSystem = NumberSystem.DEC;

            // 4. Opcjonalnie: zresetuj inne zmienne stanu
            // currentValue.memoryValue = 0;
            // currentValue.isNewNumber = true;
        }

        /*
        private void btnCE_Click(object sender, EventArgs e)
        {

        }
        */
        private void btnCE_Click(object sender, EventArgs e)
        {
            // 1. Zresetuj aktualnie wprowadzaną liczbę (textBox)
            textBox1.Text = "0";

            // 2. Pobierz tokeny z bieżącego działania (np. "FF + AB" → ["FF", "+", "AB"])
            string[] tokens = currentValue.currentDzialanie
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 0)
            {
                return; // Brak działania do modyfikacji
            }

            // 3. Sprawdź, czy ostatni token to liczba (nie operator)
            string lastToken = tokens.Last();
            bool isOperator = lastToken == "+" || lastToken == "-" || lastToken == "*" || lastToken == "/" || lastToken == "Ror" | lastToken == "Rol" | lastToken == ">>" | lastToken == "<<";

            if (!isOperator)
            {
                // Usuń ostatnią liczbę z działania (np. "FF + AB" -> "FF +")
                currentValue.currentDzialanie = string.Join(" ", tokens.Take(tokens.Length - 1));
            }

            // 4. Opcjonalnie: zaktualizuj stan systemu liczbowego (np. HEX -> DEC)
            // if (currentValue.currentSystem != NumberSystem.DEC)
            // {
            //     currentValue.currentSystem = NumberSystem.DEC;
            // }
        }

        /*
        private void btnMC_Click(object sender, EventArgs e)
        {
            currentValue.memoryLiczba = "0";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            textBox1.Text = currentValue.memoryLiczba;
            currentValue.currentDzialanie += currentValue.memoryLiczba;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            currentValue.memoryLiczba = textBox1.Text;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            currentValue.memoryLiczba += " + " + textBox1.Text;
            currentValue.memoryLiczba = initEvalForMPlusAndMinus();
        }

        private string initEvalForMPlusAndMinus()
        {
            if (currentValue.textBox1Expression == " 0" || currentValue.textBox1Expression == "")
            {
                return "0";
            }
            string[] tokens = currentValue.currentDzialanie.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 0)
            {
                return currentValue.textBox1Expression; // Brak działania do modyfikacji
            }

            // 3. Sprawdź, czy ostatni token to liczba (nie operator)
            string lastToken = tokens.Last();
            bool isOperator = lastToken == "+" || lastToken == "-" || lastToken == "*" || lastToken == "/";
            if (isOperator)
            {
                return currentValue.textBox1Expression;
            }

            //textBox1.Text = currentValue.currentDzialanie;
            string temp = CurrentValue.EvaluateAsLong(currentValue.currentDzialanie).ToString();
            //currentValue.memoryLiczba = temp;
            return temp;
        }
        */
        private void btnMC_Click(object sender, EventArgs e)
        {
            currentValue.memoryLiczba = "0";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            textBox1.Text = currentValue.memoryLiczba;
            currentValue.currentDzialanie += currentValue.memoryLiczba;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            currentValue.memoryLiczba = textBox1.Text;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            try
            {
                // Konwertuj pamięć i aktualną wartość na typ `long`
                long memoryNumber = Convert.ToInt64(currentValue.memoryLiczba);
                long currentNumber = Convert.ToInt64(textBox1.Text);

                // Wykonaj dodawanie i zaktualizuj pamięć
                long result = memoryNumber + currentNumber;
                currentValue.memoryLiczba = result.ToString();
            }
            catch (FormatException)
            {
                textBox1.Text = "Błąd: niepoprawna liczba";
            }
            catch (OverflowException)
            {
                textBox1.Text = "Błąd: liczba poza zakresem";
            }
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            try
            {
                // Konwertuj pamięć i aktualną wartość na typ `long`
                long memoryNumber = Convert.ToInt64(currentValue.memoryLiczba);
                long currentNumber = Convert.ToInt64(textBox1.Text);

                // Wykonaj odejmowanie i zaktualizuj pamięć
                long result = memoryNumber - currentNumber;
                currentValue.memoryLiczba = result.ToString();
            }
            catch (FormatException)
            {
                textBox1.Text = "Błąd: niepoprawna liczba";
            }
            catch (OverflowException)
            {
                textBox1.Text = "Błąd: liczba poza zakresem";
            }
        }


        private void btnOpenP_Click(object sender, EventArgs e)
        {


        }

        private void btnCloseP_Click(object sender, EventArgs e)
        {

        }

        private void btnModProg_Click(object sender, EventArgs e)
        {
            dzialanieArytmetyczne("%");
        }

        /*
        private void btnRol_Click(object sender, EventArgs e)
        {

        }

        private void btnRoR_Click(object sender, EventArgs e)
        {

        }
        */

        private void btnRol_Click(object sender, EventArgs e)
        {
            if (currentValue.lastOperacja != "")
            {
                return; // Blokuj, jeśli trwa inna operacja
            }

            string[] tokens = currentValue.currentDzialanie.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 0)
            {
                return;
            }

            string lastToken = tokens.Last();

            if (IsNumericToken(lastToken))
            {
                // Zastąp ostatni token funkcją Rol (np. "123" -> "Rol(123, ")
                currentValue.currentDzialanie = string.Join(" ", tokens.Take(tokens.Length - 1)) + " Rol(" + lastToken + ")";
                //textBox1.Text = ""; // Przygotuj na wprowadzenie wartości przesunięcia
                currentValue.lastOperacja = "Rol"; // Zablokuj inne operacje
            }

            if (IsNumericToken(lastToken))
            {
                string newExpression = string.Join(" ", tokens.Take(tokens.Length - 1))
                                     + " BitOperations.Rol(" + lastToken + ")"; // Dodaj nazwę klasy
                currentValue.currentDzialanie = newExpression;
                textBox1.Text = "BitOperations.Rol(" + lastToken + ")";
            }

        }

        private void btnRoR_Click(object sender, EventArgs e)
        {
            if (currentValue.lastOperacja != "")
            {
                return; // Blokuj, jeśli trwa inna operacja
            }

            string[] tokens = currentValue.currentDzialanie.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 0)
            {
                return;
            }

            string lastToken = tokens.Last();

            if (IsNumericToken(lastToken))
            {
                // Zastąp ostatni token funkcją Ror (np. "123" → "Ror(123, ")
                currentValue.currentDzialanie = string.Join(" ", tokens.Take(tokens.Length - 1)) + " Ror(" + lastToken + ")";
                textBox1.Text = ""; // Przygotuj na wprowadzenie wartości przesunięcia
                currentValue.lastOperacja = "Ror"; // Zablokuj inne operacje
            }

            if (IsNumericToken(lastToken))
            {
                string newExpression = string.Join(" ", tokens.Take(tokens.Length - 1))
                                     + " BitOperations.Ror(" + lastToken + ")"; // Dodaj nazwę klasy
                currentValue.currentDzialanie = newExpression;
                textBox1.Text = "BitOperations.Ror(" + lastToken + ")";
            }

        }


        private void btnOr_Click(object sender, EventArgs e)
        {
            dzialanieArytmetyczne("|");
        }

        private void btnXor_Click(object sender, EventArgs e)
        {
            dzialanieArytmetyczne("^");
        }

        /*
        private void btnLsh_Click(object sender, EventArgs e)
        {

        }

        private void btnRsh_Click(object sender, EventArgs e)
        {

        }
        */

        /// //////////////////////////
        private void btnLsh_Click(object sender, EventArgs e)
        {
            if (currentValue.lastOperacja != "")
            {
                return; // Blokuj, jeśli trwa inna operacja
            }

            string[] tokens = currentValue.currentDzialanie.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 0)
            {
                return; // Brak tokenów
            }

            string lastToken = tokens.Last();

            // Sprawdź, czy ostatni token to liczba
            if (IsNumericToken1(lastToken))
            {
                // Dodaj operator << do działania
                currentValue.currentDzialanie += " << ";
                textBox1.Text = ""; // Wyczyść textBox dla nowej liczby (wartość przesunięcia)
                currentValue.lastOperacja = "<<"; // Zablokuj inne operacje
            }
        }

        private void btnRsh_Click(object sender, EventArgs e)
        {
            if (currentValue.lastOperacja != "")
            {
                return; // Blokuj, jeśli trwa inna operacja
            }

            string[] tokens = currentValue.currentDzialanie.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 0)
            {
                return; // Brak tokenów
            }

            string lastToken = tokens.Last();

            // Sprawdź, czy ostatni token to liczba
            if (IsNumericToken1(lastToken))
            {
                // Dodaj operator >> do działania
                currentValue.currentDzialanie += " >> ";
                textBox1.Text = ""; // Wyczyść textBox dla nowej liczby (wartość przesunięcia)
                currentValue.lastOperacja = ">>"; // Zablokuj inne operacje
            }
        }

        // Funkcja pomocnicza sprawdzająca, czy token jest liczbą
        public bool IsNumericToken1(string token)
        {
            return long.TryParse(token, out _);
        }



        /*
        private void btnNot_Click(object sender, EventArgs e)
        {
            
        }
        */
        private void btnNot_Click(object sender, EventArgs e)
        {
            if (currentValue.lastOperacja != "")
            {
                return; // Blokuj, jeśli trwa operacja
            }

            string[] tokens = currentValue.currentDzialanie.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 0)
            {
                return; // Brak tokenów
            }

            string lastToken = tokens.Last();

            // Sprawdź, czy ostatni token to liczba (np. "123", "-45")
            if (IsNumericToken(lastToken))
            {
                // Dodaj ~ przed liczbą (np. "123" → "~123")
                string newLastToken = "~" + lastToken;
                tokens[tokens.Length - 1] = newLastToken;

                currentValue.currentDzialanie = string.Join(" ", tokens);
                textBox1.Text = newLastToken;
            }
        }

        // Sprawdza, czy token jest liczbą (całkowitą)
        public bool IsNumericToken(string token)
        {
            return long.TryParse(token, out _);
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            dzialanieArytmetyczne("&");
        }

        private void lbl14_Click(object sender, EventArgs e)
        {

        }

        private void lbl0_Click(object sender, EventArgs e)
        {

        }

        public void UpdateBitLabels(string input)
        {
            // Sprawdź, czy input jest poprawną liczbą typu long
            if (!long.TryParse(input, out long number))
            {
                MessageBox.Show("Nieprawidłowa liczba! Podaj wartość z zakresu od -9,223,372,036,854,775,808 do 9,223,372,036,854,775,807.");
                return;
            }

            // Konwersja na 64-bitowy ciąg binarny (z wiodącymi zerami)
            string binaryString = Convert.ToString(number, 2).PadLeft(64, '0');

            // Podział na 4-bitowe grupy od końca (LSB -> MSB)
            List<string> nibbles = new List<string>();
            for (int i = 60; i >= 0; i -= 4) // Start od indeksu 60 (ostatnie 4 bity)
            {
                string nibble = binaryString.Substring(i, 4);
                nibbles.Add(nibble);
            }

            // Przypisanie do Labeli (lbl0 to LSB, lbl15 to MSB)
            Label[] labels = { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7,
                       lbl8, lbl9, lbl10, lbl11, lbl12, lbl13, lbl14, lbl15 };

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = nibbles[i];
            }
        }

    }
}
