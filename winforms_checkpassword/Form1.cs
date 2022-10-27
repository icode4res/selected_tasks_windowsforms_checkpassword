using System.Runtime.CompilerServices;

namespace winforms_checkpassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmdCheckPassword_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Check Passwort: " + cboPassword.Text);
            listBox1.Items.Add("Länge: " + cboPassword.Text.Length);
            //Variablen und Array Deklarationen
            string strSonderzeichen = "! ? @ ( ) . { } , _ § [ ] / = ~ % \\ & # * - +";
            string strPass = cboPassword.Text;
            char[] chars = strPass.ToCharArray();
            int nZiffern = 0;
            int nKleinbuchstaben = 0;
            int nGrossbuchstaben = 0;
            int nSonderzeichen = 0;
            //Charüberprüfung der Eingabe: Passwort auf verschiedene Zeichen. 
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsNumber(chars[i]))
                {
                    nZiffern++;
                }
                if (char.IsLower(chars[i]))
                {
                    nKleinbuchstaben++;
                }
                if (char.IsUpper(chars[i]))
                {
                    nGrossbuchstaben++;
                }
                if (strSonderzeichen.Contains(chars[i]))
                {
                    nSonderzeichen++;
                }
            }
            //Ausgabe der Anzahl verschiedener Zeichengruppen
            listBox1.Items.Add("Ziffern: " + nZiffern);
            listBox1.Items.Add("Kleinbuchstaben: " + nKleinbuchstaben);
            listBox1.Items.Add("Grossbuchstaben: " + nGrossbuchstaben);
            listBox1.Items.Add("Sonderzeichen: " + nSonderzeichen);
            //Prüfung der Eingabe: Passwort auf Vollständige Eingabe; entsprechende Ausgabe
            if (cboPassword.Text.Length > 7 && nZiffern > 0 && nKleinbuchstaben > 0 && nGrossbuchstaben > 0 && nSonderzeichen > 0)
            {
                LblAusgabe.ForeColor = Color.Green;
                LblAusgabe.Text = "available";
                LblSonderzeichen.Text = "";
                listBox1.Items.Add("Das Passwort entspricht den Vorgaben ...");
            }
            else
            {
                LblAusgabe.ForeColor = Color.Red;
                LblAusgabe.Text = "not available";
                LblSonderzeichen.Text = "Erlaubte Sonderzeichen: " + strSonderzeichen;
                listBox1.Items.Add("Das Passwort entspricht nicht den Vorgaben ...");
            }
            listBox1.Items.Add("\n");
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static bool CheckPassword(string strPwd)
        {
            bool bCheck = false;

            //Mögliche Methode hier. Noch keine Lösung!

            return bCheck;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}