using System.Data;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String expresie = "";
      
        private void afisare_TextChanged(object sender, EventArgs e)
        {
            afisare.Text = expresie;
        }

        private void numar0_Click(object sender, EventArgs e)
        {
            expresie = expresie + "0";
            afisare.Text = expresie;
        }

        private void numar1_Click(object sender, EventArgs e)
        {
            expresie = expresie + "1";
            afisare.Text = expresie;
        }

        private void numar2_Click(object sender, EventArgs e)
        {
            expresie = expresie + "2";
            afisare.Text = expresie;
        }

        private void numar3_Click(object sender, EventArgs e)
        {
            expresie = expresie + "3";
            afisare.Text = expresie;
        }

        private void numar4_Click(object sender, EventArgs e)
        {
            expresie = expresie + "4";
            afisare.Text = expresie;
        }

        private void numar5_Click(object sender, EventArgs e)
        {
            expresie = expresie + "5";
            afisare.Text = expresie;
        }

        private void numar6_Click(object sender, EventArgs e)
        {
            expresie = expresie + "6";
            afisare.Text = expresie;
        }

        private void numar7_Click(object sender, EventArgs e)
        {
            expresie = expresie + "7";
            afisare.Text = expresie;
        }

        private void numar8_Click(object sender, EventArgs e)
        {
            expresie = expresie + "8";
            afisare.Text = expresie;
        }

        private void numar9_Click(object sender, EventArgs e)
        {
            expresie = expresie + "9";
            afisare.Text = expresie;
        }

        private void adunare_Click(object sender, EventArgs e)
        {
            expresie = expresie + "+";
            afisare.Text = expresie;
        }

        private void inmultire_Click(object sender, EventArgs e)
        {
            expresie = expresie + "x";
            afisare.Text = expresie;
        }

        private void impartire_Click(object sender, EventArgs e)
        {
            expresie = expresie + "/";
            afisare.Text = expresie;
        }

        private void egal_Click(object sender, EventArgs e)
        {
            try
            {
                expresie = expresie.Replace('x', '*').ToString();
                expresie = new DataTable().Compute(expresie, null).ToString();
                expresie = expresie.Replace(',', '.').ToString();
                afisare.Text = expresie.ToString();
            }
            catch
            {
                MessageBox.Show("Eroare la introducere ","Expresie invalida",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                expresie = "";
                afisare.Text = expresie;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            expresie = "";
            afisare.Text = expresie;
        }

        private void undo_Click(object sender, EventArgs e)
        {
            expresie = expresie.Remove(expresie.Length - 1);
            afisare.Text = expresie;
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            expresie = expresie + ".";
            afisare.Text = expresie;
        }

        private void scadere_Click_1(object sender, EventArgs e)
        {
            expresie = expresie + "-";
            afisare.Text = expresie;
        }
    }
}