using KontakTelpon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontakTelpon.Repository
{
    public interface IKontakRepo
    {
        public IEnumerable<Kontak> GetAllKontak();
        public Kontak GetKontakById(int id);
        public void AddNewKontak(Kontak kontak);
        public void DeleteKontakById(int id);
        public void UpdateKontak(Kontak updatedKontak);
    }
}
