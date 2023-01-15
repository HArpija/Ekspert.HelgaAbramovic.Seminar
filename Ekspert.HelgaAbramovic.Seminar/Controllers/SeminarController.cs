using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ekspert.HelgaAbramovic.Seminar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeminarController : ControllerBase
    {

        [HttpGet("ime/prezime")]                                                                     // 4.//
        public ActionResult<string> Unesi(string ime, string prezime)
        {
            var seminar = $"Seminar napravila: {ime} {prezime}";
            return seminar;
        }

        [HttpGet("zbroji/{prviBroj}/{drugiBroj}")]                                                    // 5. //
        public ActionResult<int> Zbroji(int prviBroj, int drugiBroj)
        {
            var zbroj = prviBroj + drugiBroj;
            return zbroj;
        }

        [HttpGet("zbroji2/{prviBroj}/{drugiBroj}")]                                                 // 6. //
        public ActionResult<string> Zbroji2(int prviBroj, int drugiBroj)
        {
            var zbroj2 = prviBroj + drugiBroj;
            {
                return $"Rezultat dva proslijeđena broja je: {zbroj2}";
            }

        }
        [HttpGet("usporedi_brojeve/{prviBroj}/{drugiBroj}")]                                         // 7. //
        public ActionResult<int> Usporedi(int prviBroj, int drugiBroj)
        {
            if (prviBroj > drugiBroj)
            {
                return prviBroj;
            }
            else
                return drugiBroj;
        }

        [HttpGet("provjeri_brojeve/{prviBroj}/{drugiBroj}")]                                         // 8. //
        public ActionResult<int> Provjeri(string prviBroj, string drugiBroj)
        {
            int prbroj = System.Convert.ToInt32(prviBroj);
            int drbroj = System.Convert.ToInt32(drugiBroj);

            if (prbroj < drbroj)
            {
                return prbroj + drbroj;
            }
            else if (prbroj == drbroj)
            {
                return prbroj * drbroj;
            }
            else
            {
                return drbroj - prbroj;
            }
        }

        [HttpGet("unesi_broj/{odabraniBroj}")]                                                                // 9. //
        public ActionResult<List<string>> Pomnozi(int odabraniBroj)
        {
            List<string> vratiListu = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                var rezultatMnozenja = i * odabraniBroj;
                var vraceniString = $"Rezultat {i} iteracije je {rezultatMnozenja}.";
                vratiListu.Add(vraceniString);
            }

            return vratiListu;
        }




        /* 4. Napravi get Metodu koja prihvaća imePrezime parametar tipa string, i vraća rezultat tipa string i u kojem će pisati
         * "Seminar napravio: {imePrezime}"
        5. Napravi Get metodu koja će prihvaćati 2 parametra tipa int, te vratiti zbroj bilo koja 2 broja koji će se proslijediti kroz ta
                dva parametra
        6. Napravi Get metodu koja će primiti dva parametra tipa int , zbrojiti ta dva broja i vratiti rezultat tipa string u kojem će 
                pisati "Rezultat dva proslijeđena broja je: {rezultat}"}"
        7. Napravi get Metodu koja će primiti 2 parametra tipa int , te sa IF uvjetom provjeriti da li je prvi broj veći od drugoga.
            -Ako je prvi dobijeni broj veći od drugog vrati kao rezultat prvi broj, u suprotnom vrati drugi broj kao rezultat.
        8. Napravi get metodu koja će primiti 2 broja tipa string. Konvertiraj ih u integer i napravi sljedeće provjere:
            -ako je prvi broj manji od drugoga - zbroji ta ta dva broja i vrati rezultat
            - ako je prvi broj jednak drugom -pomnoži ta dva broja i vrati rezultat
            -u suprotnom oduzmi drugi broj od prvog i vrati rezultat
        9. Napravi Get metodu koja prima  parametar {odabraniBroj} tipa int.
            -u svakoj iteraciji petlje pomnozi {i} vrijednost petlje sa prosliijeđenom vrijednosti odabraniBroj (i*odabraniBroj)
            -vrati listu stringova sa 10 rezultata na način da String izgleda ovako "rezultat {i}. iteracije je {rezultatMnozenja}"
        */


    }
}

    

