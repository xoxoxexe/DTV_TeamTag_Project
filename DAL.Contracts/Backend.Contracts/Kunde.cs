using System;
namespace Backend.Contracts
{
    public class Kunde
    {
        public Guid  Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Strasse { get; set; }

        public string Plz { get; set; }

        public string Ort { get; set; }

        public string Telefon { get; set; }
    }
}
