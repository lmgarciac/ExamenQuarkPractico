using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenQuarkPractico.model
{
    public class Seller
    {
        private string _name;
        private string _surname;
        private int _id;
        private List<Pricing> _pricings = new List<Pricing>();

        public Seller(string nombre, string apellido, int codigo)
        {
            Name = nombre;
            Surname = apellido;
            Id = codigo;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public int Id { get => _id; set => _id = value; }
        public List<Pricing> Pricings { get => _pricings; set => _pricings = value; }
    }
}
