using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsApi
{
    public class ClientApi
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int? IdPassport { get; set; }

        public PassportApi Passport { get; set; }
    }

    public class PassportApi
    {
        public int Id { get; set; }
        public string Seria { get; set; }
        public string Nomer { get; set; }
        public DateTime? GainDate { get; set; }
    }
}
