using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Komunikacija;

namespace ServerskaStr
{
    public class ClientHandler
    {
        private Socket socket;
        private JsnNetworkSerializer jsn;
        private List<int> vrednosti;
        public ClientHandler(Socket socket, List<int> vrednosti)
        {
            this.socket = socket;
            jsn=new JsnNetworkSerializer(socket);
            this.vrednosti = vrednosti;
        }

        public void HandleClient()
        {
            int brPokusaja = 0;
            int brPogodjenih = 0;
            bool kraj = false;
            while (!kraj)
            {
                //1.primanje zahteva
                Poruka zahtev = jsn.PrimiPoruku<Poruka>();
                Poruka odgovor = new Poruka()
                {
                    Object = -1
                };
                brPokusaja++;
                //2.obrada
                int redniBroj=zahtev.Object -1;
                if (vrednosti[redniBroj] != -1)
                {
                    odgovor.Object = vrednosti[redniBroj];
                    brPogodjenih++;
                }
                //3.slanje odgovora
                jsn.PosaljiPoruku(odgovor);
                if(brPogodjenih==3 || brPokusaja == 5)
                {
                    kraj = true;
                }

            }
        }
    }
}
