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
    public class Sender
    {
        private readonly Socket socket;
        private readonly NetworkStream stream;
        public Sender(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
        }
        public async Task SendAsync<T>(T obj) where T : class
        {
            string json = JsonSerializer.Serialize(obj);
            byte[] buffer = Encoding.UTF8.GetBytes(json);
            await stream.WriteAsync(buffer, 0, buffer.Length);
            await stream.FlushAsync();
        }
    }
}
