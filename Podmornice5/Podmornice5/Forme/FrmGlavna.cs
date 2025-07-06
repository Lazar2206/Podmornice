using Komunikacija;

namespace Forme
{
    public partial class FrmGlavna : Form
    {
        private Klijent klijent;
        private int brPokusaja = 0;
        private int brPogodjenih = 0;
        private List<int> brZaSortiranje = new List<int>();

        public FrmGlavna()
        {
            InitializeComponent();
            OnemoguciDugmad();
        }
        private void OnemoguciDugmad()
        {
            foreach (Control element in this.Controls)
            {
                // Ako je element dugme i nije dugme za povezivanje
                if (element is Button dugme && dugme.Name != "btnPoveziSe")
                {
                    // Isključi dugme
                    dugme.Enabled = false;
                }
            }
        }
        private void OmoguciDugmad()
        {
         
            foreach (Control element in this.Controls)
            {
                // Ako je element dugme i nije dugme za povezivanje
                if (element is Button dugme && dugme.Name != "btnPoveziSe")
                {
                    // Uključi dugme
                    dugme.Enabled = true;
                }
            }
        }
        private void btnPoveziSe_Click(object sender, EventArgs e)
        {
            try
            {
                klijent = new Klijent();
                klijent.PoveziSe();
                btnPoveziSe.Enabled = false;
                OmoguciDugmad();
            }
            catch (Exception )
            {

                MessageBox.Show("Pokrenite server!!!");
            }
        }
        private int ProveriVrednostZaOvoDugme(int rbDugmeta)
        {
            //1.kreiranje zahteva
            Poruka zahtev = new Poruka()
            {
                Object = rbDugmeta,
            };
            //2.slanje zahteva
            klijent.PosaljiPoruku(zahtev);
            //3.provera odgovora
            Poruka odgovor = klijent.PrimiPoruku();
            brPokusaja++;
            if (odgovor.Object != -1)
            {
                brPogodjenih++;
                brZaSortiranje.Add(odgovor.Object);
            }
            return odgovor.Object;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vrednost = ProveriVrednostZaOvoDugme(1);
            button1.Text = vrednost.ToString();
            button1.Enabled = false;

            if (brPogodjenih == 3)
            {
                int sifra = IzracunajSifru();
                MessageBox.Show("Cestitam!Pobedili ste!\nSifra:" + sifra);
                Application.Exit();
            }
            else if (brPokusaja == 5)
            {
                MessageBox.Show("Nemate vise pokusaja!");
                Application.Exit();
            }
        }

        private int IzracunajSifru()
        {
            brZaSortiranje.Sort();
            return 100 * brZaSortiranje[1] + 10 * brZaSortiranje[2] + brZaSortiranje[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vrednost = ProveriVrednostZaOvoDugme(2);
            button2.Text = vrednost.ToString();
            button2.Enabled = false;

            if (brPogodjenih == 3)
            {
                int sifra = IzracunajSifru();
                MessageBox.Show("Cestitam! Pobedili ste!\nSifra: " + sifra);
                Application.Exit();
            }
            else if (brPokusaja == 5)
            {
                MessageBox.Show("Nemate vise pokusaja!");
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int vrednost = ProveriVrednostZaOvoDugme(3);
            button3.Text = vrednost.ToString();
            button3.Enabled = false;

            if (brPogodjenih == 3)
            {
                int sifra = IzracunajSifru();
                MessageBox.Show("Cestitam! Pobedili ste!\nSifra: " + sifra);
                Application.Exit();
            }
            else if (brPokusaja == 5)
            {
                MessageBox.Show("Nemate vise pokusaja!");
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int vrednost = ProveriVrednostZaOvoDugme(4);
            button4.Text = vrednost.ToString();
            button4.Enabled = false;

            if (brPogodjenih == 3)
            {
                int sifra = IzracunajSifru();
                MessageBox.Show("Cestitam! Pobedili ste!\nSifra: " + sifra);
                Application.Exit();
            }
            else if (brPokusaja == 5)
            {
                MessageBox.Show("Nemate vise pokusaja!");
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int vrednost = ProveriVrednostZaOvoDugme(5);
            button5.Text = vrednost.ToString();
            button5.Enabled = false;

            if (brPogodjenih == 3)
            {
                int sifra = IzracunajSifru();
                MessageBox.Show("Cestitam! Pobedili ste!\nSifra: " + sifra);
                Application.Exit();
            }
            else if (brPokusaja == 5)
            {
                MessageBox.Show("Nemate vise pokusaja!");
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int vrednost = ProveriVrednostZaOvoDugme(6);
            button6.Text = vrednost.ToString();
            button6.Enabled = false;

            if (brPogodjenih == 3)
            {
                int sifra = IzracunajSifru();
                MessageBox.Show("Cestitam! Pobedili ste!\nSifra: " + sifra);
                Application.Exit();
            }
            else if (brPokusaja == 5)
            {
                MessageBox.Show("Nemate vise pokusaja!");
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int vrednost = ProveriVrednostZaOvoDugme(7);
            button7.Text = vrednost.ToString();
            button7.Enabled = false;

            if (brPogodjenih == 3)
            {
                int sifra = IzracunajSifru();
                MessageBox.Show("Cestitam! Pobedili ste!\nSifra: " + sifra);
                Application.Exit();
            }
            else if (brPokusaja == 5)
            {
                MessageBox.Show("Nemate vise pokusaja!");
                Application.Exit();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int vrednost = ProveriVrednostZaOvoDugme(8);
            button8.Text = vrednost.ToString();
            button8.Enabled = false;

            if (brPogodjenih == 3)
            {
                int sifra = IzracunajSifru();
                MessageBox.Show("Cestitam! Pobedili ste!\nSifra: " + sifra);
                Application.Exit();
            }
            else if (brPokusaja == 5)
            {
                MessageBox.Show("Nemate vise pokusaja!");
                Application.Exit();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int vrednost = ProveriVrednostZaOvoDugme(9);
            button9.Text = vrednost.ToString();
            button9.Enabled = false;

            if (brPogodjenih == 3)
            {
                int sifra = IzracunajSifru();
                MessageBox.Show("Cestitam! Pobedili ste!\nSifra: " + sifra);
                Application.Exit();
            }
            else if (brPokusaja == 5)
            {
                MessageBox.Show("Nemate vise pokusaja!");
                Application.Exit();
            }
        }
    }
}
