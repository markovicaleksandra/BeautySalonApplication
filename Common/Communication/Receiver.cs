using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Common.Communication
{
    public class Receiver
    {
        private readonly Socket socket;
        private readonly NetworkStream stream;
        public Receiver(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
        }
        public async Task<T> ReceiveAsync<T>() where T : class
        {
            byte[] buffer = new byte[32768];  
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            if (bytesRead == 0)
            {
                throw new Exception("Connection closed by the remote host.");
            }
            string json = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
