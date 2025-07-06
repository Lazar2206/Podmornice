using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaStr
{
    public class Server
    {
        private Socket socket;

        public void Start()
        {
            socket=new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
            socket.Bind(ipEndPoint);
            socket.Listen(10);
        }

        public void Accept(List<int>vrednosti)
        {
            while (true)
            {
                Debug.WriteLine(">>>>>Cekam klijenta da se poveze.");
                Socket klijent = socket.Accept();
                Debug.WriteLine(">>>>>Klijent se uspesno povezao."); 

                ClientHandler ch=new ClientHandler(klijent,vrednosti);
                Thread nit=new Thread(ch.HandleClient);
                nit.Start();
            }



        }


    }
}
