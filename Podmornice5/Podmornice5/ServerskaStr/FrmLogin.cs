using Domen;

namespace ServerskaStr
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin ulogovaniAdmin = new Admin()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
            };
            if (Kontroler.Instance.Login(ulogovaniAdmin))
            {
                MessageBox.Show("Dobrodosli!");
                this.Visible = false;
                (new FrmServer(ulogovaniAdmin)).Show();

            }
            else
            {
                MessageBox.Show("Nepostojeci korisnik!");
                return;
            }
        }
    }
}
