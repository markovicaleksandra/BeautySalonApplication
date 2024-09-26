using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Common.Communication;
using Common.Domen;

namespace Server
{
    public class ClientHandler
    {
        private readonly Socket socket;
        private Sender sender;
        private Receiver receiver;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }
        public async Task HandleRequestsAsync()
        {
            try
            {
                while (true)
                {
                    Request request = await receiver.ReceiveAsync<Request>();
                    Response response = await CreateResponseAsync(request);
                    await sender.SendAsync(response);
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }

        private async Task<Response> CreateResponseAsync(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.Login:
                        response.Result = Controller.Instance.Login(JsonSerializer.Deserialize<Zaposleni>(request.Argument.ToString()));
              
                        break;
                    case Operation.UcitajListuTipovaUsluga:
                        response.Result = Controller.Instance.UcitajListuTipovaUsluga();
                        break;
                    case Operation.DodajUslugu:
                        Controller.Instance.DodajUslugu(JsonSerializer.Deserialize<Usluga>(request.Argument.ToString()));
                        break;
                    case Operation.DodajKlijenta:
                        Controller.Instance.DodajKlijenta(JsonSerializer.Deserialize<Klijent>(request.Argument.ToString()));
                        break;
                    case Operation.UcitajListuKlijenata:
                        response.Result = Controller.Instance.UcitajListuKlijenata();
                        break;
                    case Operation.IzmeniKlijenta:
                        Controller.Instance.IzmeniKlijenta(JsonSerializer.Deserialize<Klijent
                            >(request.Argument.ToString()));
                        break;
                    case Operation.PretraziKlijente:
                        response.Result = Controller.Instance.PretraziKlijente(request.Argument.ToString());
                        break;
                    case Operation.UcitajListuUsluga:
                        response.Result = Controller.Instance.UcitajListuUsluga();
                        break;
                    case Operation.IzbrisiUslugu:
                        Controller.Instance.IzbrisiUslugu(JsonSerializer.Deserialize<Usluga>(request.Argument.ToString()));
                        break;
                    case Operation.IzmeniUslugu:
                        Controller.Instance.IzmeniUslugu(JsonSerializer.Deserialize<Usluga>(request.Argument.ToString()));
                        break;
                    case Operation.UcitajListuUslugaPoTipu:
                        response.Result = Controller.Instance.UcitajListuUslugaPoTipu(JsonSerializer.Deserialize<TipUsluge>(request.Argument.ToString()));
                        break;
                    case Operation.UcitajListuZaposlenihPoTipuUsluge:
                        response.Result = Controller.Instance.UcitajListuZaposlenihPoTipuUsluge(JsonSerializer.Deserialize<TipUsluge>(request.Argument.ToString()));
                        break;
                    case Operation.UcitajListuRezervacija:
                        response.Result = Controller.Instance.UcitajListuRezervacija();
                        break;
                    case Operation.UcitajKlijenta:
                        response.Result = Controller.Instance.UcitajKlijenta(JsonSerializer.Deserialize<Klijent>(request.Argument.ToString()));
                        break;
                    case Operation.UcitajUslugu:
                        response.Result = Controller.Instance.UcitajUslugu(JsonSerializer.Deserialize<Usluga>(request.Argument.ToString()));
                        break;
                    case Operation.SacuvajRezervacije:
                        Controller.Instance.SacuvajRezervacije(JsonSerializer.Deserialize<List<Rezervacija>>(request.Argument.ToString()));
                        break;
                    case Operation.ProveriDostupnostTermina:
                        response.Result = Controller.Instance.ProveriDostupnostTermina(JsonSerializer.Deserialize<Rezervacija>(request.Argument.ToString()));
                        break;
                    case Operation.IzbrisiRezervaciju:
                        Controller.Instance.IzbrisiRezervaciju(JsonSerializer.Deserialize<Rezervacija>(request.Argument.ToString()));
                        break;
                    case Operation.UcitajListuZaposlenih:
                        response.Result = Controller.Instance.UcitajListuZaposlenih();
                        break;
                    case Operation.UcitajListuTipovaUslugaPoZaposlenom:
                        response.Result = Controller.Instance.UcitajListuTipovaUslugaPoZaposlenom(JsonSerializer.Deserialize<Zaposleni>(request.Argument.ToString()));
                        break;
                    case Operation.IzmeniZaposlenog:
                        Controller.Instance.IzmeniZaposlenog(JsonSerializer.Deserialize<Zaposleni>(request.Argument.ToString()));
                        break;
                    case Operation.UcitajZaposlenog:
                        response.Result = Controller.Instance.UcitajZaposlenog(JsonSerializer.Deserialize<Zaposleni>(request.Argument.ToString()));
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                response.Exception = ex;
            }
            return response;
        }
    }
}