using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_migrations.Dominio
{
    public class Artist
    {
        public Guid Id { get; set; }
        public string Artistic_name { get; set; }
        public string Real_name { get; set; }

        public Country Country { get; set; }
        private Guid Country_id;

        public float Average_salary { get; set; }
        public string Ocuppation { get; set; }

    }
}
