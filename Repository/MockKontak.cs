using KontakTelpon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontakTelpon.Repository
{
    public class MockKontak : IKontakRepo
    {
        public List<Kontak> Kontaks { get; set; } = new List<Kontak>()
        {
            new Kontak(){NamaDepan = "Ana", NamaBelakang="Benia", Email="anabenia@gmail.com", NoTelp="081987654321", TanggalLahir= new DateTime(1997, 9, 24)},
            new Kontak(){NamaDepan = "Ciaki", NamaBelakang = "Dindema", Email="ciakidindema@gmail.com", NoTelp="085123456789", TanggalLahir = new DateTime(2000, 2, 7)},
            new Kontak(){NamaDepan = "Ema", NamaBelakang="Fanandi", Email = "emafanadi@gmanil.com", NoTelp ="082456789123", TanggalLahir=new DateTime(1993, 4, 27)}
        };

        public IEnumerable<Kontak> GetAllKontak()
        {
            return Kontaks;
        }

        public Kontak GetKontakById(int id)
        {
            return Kontaks.FirstOrDefault(x => x.Id == id);
        }

        public void AddNewKontak(Kontak kontak)
        { 
            Kontaks.Add(kontak);
        }

        public void DeleteKontakById(int id)
        {
            var target = Kontaks.FirstOrDefault(x => x.Id == id);
            Kontaks.Remove(target);
        }

        public void UpdateKontak(Kontak updatedKontak)
        {
            int index = Kontaks.FindIndex(x => x.Id == updatedKontak.Id);
            Kontaks[index].NamaDepan = updatedKontak.NamaDepan;
            Kontaks[index].NamaBelakang = updatedKontak.NamaBelakang;
            Kontaks[index].Email = updatedKontak.Email;
            Kontaks[index].TanggalLahir = updatedKontak.TanggalLahir;
            Kontaks[index].NoTelp = updatedKontak.NoTelp;
        }
    }
}
