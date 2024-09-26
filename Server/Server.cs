using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class Server
    {
        private Socket serverSocket;
        private CancellationTokenSource cancellationTokenSource;

        public Server()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            cancellationTokenSource = new CancellationTokenSource();
        }
        public async Task StartAsync()
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));
                serverSocket.Bind(endPoint);
                serverSocket.Listen(100);
                //Povezivanje klijenata u pozadini 
                _ = PoveziKlijenteAsync(cancellationTokenSource.Token);
            }catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }
        public async Task PoveziKlijenteAsync(CancellationToken cancellationToken)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    Socket clientSocket = await serverSocket.AcceptAsync();
                    ClientHandler handler = new ClientHandler(clientSocket);
                    _ = Task.Run(() => handler.HandleRequestsAsync());
                }
            }catch (SocketException ex)
            {
                if (!cancellationToken.IsCancellationRequested)
                {
                    Debug.WriteLine(">>>" + ex.Message);
                }
            }catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }
        public void Stop()
        {
            cancellationTokenSource.Cancel();
            serverSocket.Close();
        }
    }
}
