using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KontakTelpon.Models
{
    public class Kontak
    {
        private static int _counter = 0;

        public Kontak()
        {
            Id = ++_counter;
        }
        public int Id { get; }
        public string NamaDepan { get; set; }
        public string NamaBelakang { get; set; }
        public string Email { get; set; }
        public string NoTelp { get; set; }

        [DataType(DataType.Date)]
        public DateTime TanggalLahir { get; set; }
    }
}
