namespace Project1010doga
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        private int[] correctResults = new int[5];
        private TextBox[] inputBoxes;
        private Label[] labels;
        public Form1()
        {
            InitializeComponent();
            btnnew.Click += Btnnew_Click;
            btncheck.Click += Btncheck_Click;
            btnclose.Click += Btnclose_Click;

            
            inputBoxes = new TextBox[] { txtInput1, txtInput2, txtInput3, txtInput4, txtInput5 };
            labels = new Label[] { lbl1, lbl2, lbl3, lbl4, lbl5 };

            btncheck.Enabled = false;
            foreach (var box in inputBoxes)
            {
                box.Enabled = false;
            }
        }

        private void Btnclose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnnew_Click(object? sender, EventArgs e)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                correctResults[i] = UpdateLabel(labels[i]);
                labels[i].BackColor = SystemColors.Control;
            }
            btncheck.Enabled = true;
            foreach (var box in inputBoxes)
            {
                box.Enabled = true;
                box.Clear(); 
            }
        }

        private int UpdateLabel(Label lbl)
        {
            int firstNumber = rnd.Next(10, 100);
            int secondNumber = rnd.Next(10, 100);
            int result;

            if (rnd.Next(0, 2) == 0)
            {
                lbl.Text = $"{firstNumber} + {secondNumber}";
                result = firstNumber + secondNumber;
            }
            else
            {
                lbl.Text = $"{firstNumber} - {secondNumber}";
                result = firstNumber - secondNumber;
            }

            return result; 
        }

        private void Btncheck_Click(object? sender, EventArgs e)
        {
            int correctCount = 0;

            for (int i = 0; i < inputBoxes.Length; i++)
            {
                if (int.TryParse(inputBoxes[i].Text, out int userInput))
                {
                    if (userInput == correctResults[i])
                    {
                        correctCount++; 
                        labels[i].ForeColor = Color.Green; 
                    }
                    else
                    {
                        labels[i].ForeColor = Color.Red; 
                    }
                }
                else
                {
                    richTextBox1.Text = $"A(z) {i + 1}. feladatnál nem megfelelõ formátumú számot adott meg!";
                    return;
                }
            }

            richTextBox1.Text = $"{correctCount} helyes megoldásod van!";

            btncheck.Enabled = false;
            foreach (var box in inputBoxes)
            {
                box.Enabled = false; 
            }
        }
    }
}
