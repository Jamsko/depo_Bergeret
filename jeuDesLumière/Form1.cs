namespace jeuDesLumière
{
    public partial class Form1 : Form
    {
        List<Button> lstBtn = new List<Button>();
        List<Button> lstBtnSup = new List<Button>();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lstBtn.Clear();

            lstBtn.Add(btnC1);
            lstBtn.Add(btnC2);
            lstBtn.Add(btnC3);
            lstBtn.Add(btnC4);
            lstBtn.Add(btnC5);
            lstBtn.Add(btnC6);
            lstBtn.Add(btnC7);
            lstBtn.Add(btnC8);
            lstBtn.Add(btnC9);

            foreach (var btn in lstBtn)
            {
                btn.BackColor = Color.FromArgb(224, 224, 224);
            }

            if (rbSimple.Checked)
            {
                tmrJeu.Interval = 1000;
            }
            else if (rbRapide.Checked)
            {
                tmrJeu.Interval = 500;
            }
            else if (rbTresRapide.Checked)
            {
                tmrJeu.Interval = 250;
            }

            tmrJeu.Enabled = true;
        }

        private void tmrJeu_Tick(object sender, EventArgs e)
        {
            if (lstBtnSup.Count != 0)
            {
                lstBtnSup[lstBtnSup.Count - 1].BackColor = Color.FromArgb(224, 224, 224);
            }

            if (lstBtn.Count != 0)
            {
                int rndIndex = rnd.Next(lstBtn.Count);

                lstBtn[rndIndex].BackColor = Color.Red;

                lstBtnSup.Add(lstBtn[rndIndex]);
                lstBtn.RemoveAt(rndIndex);
            }
            else
            {
                tmrJeu.Stop();
            }
        }

        public int rndColor()
        {
            Random rnd = new Random();
            return rnd.Next(256);
        }

        public void Jouer(Button btn)
        {
            btn.BackColor = Color.FromArgb(rndColor(), rndColor(), rndColor());

            if (lstBtnSup.Count != 0)
            {
                if (lstBtnSup[0] == btn)
                {
                    btn.BackColor = Color.FromArgb(224, 224, 224);
                    lstBtnSup.Remove(btn);
                }
                else
                {
                    MessageBox.Show("Perdu");
                }
            }
            else
            {
                MessageBox.Show("Gagné");
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            Jouer(btnC1);
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            Jouer(btnC2);
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            Jouer(btnC3);
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            Jouer(btnC4);
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            Jouer(btnC5);
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            Jouer(btnC6);
        }

        private void btnC7_Click(object sender, EventArgs e)
        {
            Jouer(btnC7);
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            Jouer(btnC8);
        }

        private void btnC9_Click(object sender, EventArgs e)
        {
            Jouer(btnC8);
        }
    }
}