﻿using System;
using System.Collections.Generic;

#nullable disable

namespace _1135AirportApi.db
{
    public partial class Client
    {
        public Client()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int? IdPassport { get; set; }

        public virtual Passport IdPassportNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
