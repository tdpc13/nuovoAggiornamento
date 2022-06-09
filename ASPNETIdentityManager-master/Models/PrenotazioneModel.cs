using ASPNETIdentityManager.Entities;
using System.Collections.Generic;

namespace ASPNETIdentityManager.Models
{
    public class PrenotazioneModel
    {
        public List<Prenotazione> Prenotazione { get; set; } = new List<Prenotazione>();
        public string ID { get; set; }
        public string UserName { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }
        public int Persone { get; set; }
        public string Pacchetto { get; set; }
    }
}
