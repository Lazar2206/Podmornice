using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Komunikacija;

namespace Forme
{
    public class Klijent
    {
        private Socket socket;
        private JsnNetworkSerializer jsn;

        public void PoveziSe()
        {
            socket=new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9000);
            Debug.WriteLine(">>>>>Uspesno povezivanje sa serverom.");
            jsn=new JsnNetworkSerializer(socket);
        }

        public void PosaljiPoruku(Poruka poruka)
        {
            jsn.PosaljiPoruku(poruka);
        }

        public Poruka PrimiPoruku()
        {
            return jsn.PrimiPoruku<Poruka>();
        }

        public T ReadType<T>(Object podaci)
        {
            return jsn.ReadType<T>(podaci);
        }
    }
}
