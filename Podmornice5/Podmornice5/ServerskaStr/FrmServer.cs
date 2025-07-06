using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace ServerskaStr
{
    public partial class FrmServer : Form
    {
        private Admin ulogovaniAdmin;

        public FrmServer(Admin admin)
        {
            InitializeComponent();
            ulogovaniAdmin = admin;
            lblIme.Text= ulogovaniAdmin.Ime;
            lblPrezime.Text=ulogovaniAdmin.Prezime;
        }

        private void btnPokreniIgru_Click(object sender, EventArgs e)
        {
            Server server=new Server();
            //1.definisanje pozicija
            List<int> vrednosti = new List<int>()
            {
                -1,-1,-1,
                -1,-1,-1,
                -1,-1,-1
            };
            if (textBox1.Text != "")
            {
                vrednosti[0]=int.Parse(textBox1.Text);
            }
            if (textBox2.Text != "")
            {
                vrednosti[1] = int.Parse(textBox2.Text);
            }
            if (textBox3.Text != "")
            {
                vrednosti[2] = int.Parse(textBox3.Text);
            }
            if (textBox4.Text != "")
            {
                vrednosti[3] = int.Parse(textBox4.Text);
            }
            if (textBox5.Text != "")
            {
                vrednosti[4] = int.Parse(textBox5.Text);
            }
            if (textBox6.Text != "")
            {
                vrednosti[5] = int.Parse(textBox6.Text);
            }
            if (textBox7.Text != "")
            {
                vrednosti[6] = int.Parse(textBox7.Text);
            }
            if (textBox8.Text != "")
            {
                vrednosti[7] = int.Parse(textBox8.Text);
            }
            if (textBox9.Text != "")
            {
                vrednosti[8] = int.Parse(textBox9.Text);
            }


            //2.pokretanje igre
            server.Start();
            Thread nit=new Thread(() => { server.Accept(vrednosti); });
            nit.Start();
            btnPokreniIgru.Enabled = false;
        }
    }
}
