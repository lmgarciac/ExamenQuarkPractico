using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenQuarkPractico.model
{
    public class Seller
    {
        private string _name;
        private string _surname;
        private string _id;
        private List<Pricing> _pricings = new List<Pricing>();

        public Seller(string name, string surname, string id)
        {
            _name = name;
            _surname = surname;
            _id = id;
        }

        public string Name { get => _name;}
        public string Surname { get => _surname;}
        public string Id { get => _id;}
        public List<Pricing> Pricings { get => _pricings;}
    }
}
