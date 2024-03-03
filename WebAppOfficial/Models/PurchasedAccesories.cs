using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppOfficial.Models
{
    public class PurchasedAccesories
    {
        public Accesories accesories { get; set; }

       public List<Client> clients { get; set; }
       
        public PurchasedAccesories()
        {
            clients = new List<Client>();
        }
    }
}