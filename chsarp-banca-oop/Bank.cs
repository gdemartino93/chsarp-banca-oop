using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chsarp_banca_oop
{
    internal class Bank
    {
        private string name;
        private List<Cliente> customer;
        private List<Prestito> loan;
        public string Name { get; set; }
    }
}
