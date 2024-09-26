using Common.Communication;
using Common.Domen;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.ServerCommunication
{
    public class Communication
    {
        //singlton
        private static Communication instance;
        public static Communication Instance
        {
            get
            {
                if(instance == null)
                    instance = new Communication();
                return instance;
            }
        }
        private Communication() { }

        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        //konekcija sa serverom
        public async Task Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            await socket.ConnectAsync("127.0.0.1", 9999);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        public async Task<Zaposleni> Login(Zaposleni zaposleni)
        {
            Request request = new Request()
            {
                Operation = Operation.Login,
                Argument = zaposleni
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            Zaposleni result = JsonSerializer.Deserialize<Zaposleni>(response.Result.ToString());
            return result;
        }

        public async Task<List<TipUsluge>> UcitajListuTipovaUsluga()
        { 
            Request request = new Request()
            {
                Operation = Operation.UcitajListuTipovaUsluga
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            List<TipUsluge> result = JsonSerializer.Deserialize<List<TipUsluge>>(response.Result.ToString());
            return result;

        }

        public async Task DodajUslugu(Usluga usluga)
        {
            Request request = new Request()
            {
                Operation = Operation.DodajUslugu,
                Argument = usluga
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        public async Task DodajKlijenta(Klijent klijent)
        {
            Request request = new Request()
            {
                Operation = Operation.DodajKlijenta,
                Argument = klijent
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        public async Task<List<Klijent>> UcitajListuKlijenata()
        {
            Request request = new Request()
            {
                Operation = Operation.UcitajListuKlijenata
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            List<Klijent> result = JsonSerializer.Deserialize<List<Klijent>>(response.Result.ToString());
            return result;

        }

        public async Task IzmeniKlijenta(Klijent klijent)
        {
            Request request = new Request()
            {
                Operation = Operation.IzmeniKlijenta,
                Argument = klijent
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        public async Task<List<Klijent>> PretraziKlijente(string filter)
        {
            Request request = new Request()
            {
                Operation = Operation.PretraziKlijente,
                Argument = filter
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            List<Klijent> result = JsonSerializer.Deserialize<List<Klijent>>(response.Result.ToString());
            return result;

        }

        public async Task<List<Usluga>> UcitajListuUsluga()
        {
            Request request = new Request()
            {
                Operation = Operation.UcitajListuUsluga
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            List<Usluga> result = JsonSerializer.Deserialize<List<Usluga>>(response.Result.ToString());
            return result;

        }

        public async Task IzbrisiUslugu(Usluga usluga)
        {
            Request request = new Request()
            {
                Operation = Operation.IzbrisiUslugu,
                Argument = usluga
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        public async Task IzmeniUslugu(Usluga usluga)
        {
            Request request = new Request()
            {
                Operation = Operation.IzmeniUslugu,
                Argument = usluga
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        public async Task<List<Usluga>> UcitajListuUslugaPoTipu(TipUsluge tipUsluge)
        {
            Request request = new Request()
            {
                Operation = Operation.UcitajListuUslugaPoTipu,
                Argument = tipUsluge
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            List<Usluga> result = JsonSerializer.Deserialize<List<Usluga>>(response.Result.ToString());
            return result;

        }

        public async Task<List<Zaposleni>> UcitajListuZaposlenihPoTipuUsluge(TipUsluge tipUsluge)
        {
            Request request = new Request()
            {
                Operation = Operation.UcitajListuZaposlenihPoTipuUsluge,
                Argument = tipUsluge
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            List<Zaposleni> result = JsonSerializer.Deserialize<List<Zaposleni>>(response.Result.ToString());
            return result;

        }



        public async Task<List<Rezervacija>> UcitajListuRezervacija()
        {
            Request request = new Request()
            {
                Operation = Operation.UcitajListuRezervacija
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            List<Rezervacija> result = JsonSerializer.Deserialize<List<Rezervacija>>(response.Result.ToString());
            return result;

        }

        public async Task<Klijent> UcitajKlijenta(Klijent klijent)
        {
            Request request = new Request()
            {
                Operation = Operation.UcitajKlijenta,
                Argument = klijent
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }

            Klijent result = JsonSerializer.Deserialize<Klijent>(response.Result.ToString());
            return result;

        }

        public async Task<Usluga> UcitajUslugu(Usluga usluga)
        {
            Request request = new Request()
            {
                Operation = Operation.UcitajUslugu,
                Argument = usluga
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }

            Usluga result = JsonSerializer.Deserialize<Usluga>(response.Result.ToString());
            return result;

        }

        public async Task SacuvajRezervacije(List<Rezervacija> rezervacije)
        {
            Request request = new Request()
            {
                Operation = Operation.SacuvajRezervacije,
                Argument = rezervacije
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        public async Task<bool> ProveriDostupnostTermina(Rezervacija rezervacija)
        {
            Request request = new Request()
            {
                Operation = Operation.ProveriDostupnostTermina,
                Argument = rezervacija
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }


            if (response.Result is JsonElement jsonElement)
            {
                bool result = jsonElement.GetBoolean();
                return result;
            }

            throw new InvalidCastException("Response.Result cannot be cast to bool.");

        }

        public async Task IzbrisiRezervaciju(Rezervacija rezervacija)
        {
            Request request = new Request()
            {
                Operation = Operation.IzbrisiRezervaciju,
                Argument = rezervacija
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        public async Task<List<Zaposleni>> UcitajListuZaposlenih()
        {
            Request request = new Request()
            {
                Operation = Operation.UcitajListuZaposlenih,
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            List<Zaposleni> result = JsonSerializer.Deserialize<List<Zaposleni>>(response.Result.ToString());
            return result;

        }

        public async Task<List<TipUsluge>> UcitajListuTipovaUslugaPoZaposlenom(Zaposleni zaposleni)
        {
            Request request = new Request()
            {
                Operation = Operation.UcitajListuTipovaUslugaPoZaposlenom,
                Argument = zaposleni
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            List<TipUsluge> result = JsonSerializer.Deserialize<List<TipUsluge>>(response.Result.ToString());
            return result;

        }

        public async Task IzmeniZaposlenog(Zaposleni zaposleni)
        {
            Request request = new Request()
            {
                Operation = Operation.IzmeniZaposlenog,
                Argument = zaposleni
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        public async Task<Zaposleni> UcitajZaposlenog(Zaposleni zaposleni)
        {
            Request request = new Request()
            {
                Operation = Operation.UcitajZaposlenog,
                Argument = zaposleni
            };
            await sender.SendAsync(request);
            Response response = await receiver.ReceiveAsync<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }

            Zaposleni result = JsonSerializer.Deserialize<Zaposleni>(response.Result.ToString());
            return result;
        }
    }
}
