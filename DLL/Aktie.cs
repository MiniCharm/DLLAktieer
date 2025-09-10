namespace DLL
{
    public class Aktie
    {
        /// <summary>
        /// Dettte er en aktie klasse
        /// Build i relaease mode for at tilføje "Release" folder i bin
        /// Build i relaease mode for at tilføje "Release" folder i bin
        /// </summary>
        /// 
        public string AktieNavn { get; set; }

        public int Antal { get; set; }

        public int KøbsPris { get; set; }

        public int SalgsKurs { get; set; }

        public Aktie()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aktieNavn"></param>
        /// <param name="antal"></param>
        /// <param name="købsPris"></param>
        public Aktie(string aktieNavn, int antal, int købsPris, int salgsKurs)
        {
            AktieNavn = aktieNavn;
            Antal = antal;
            KøbsPris = købsPris;
            SalgsKurs = salgsKurs;
        }

        /// <summary>
        /// Den totale pris på aktier
        /// </summary>
        /// <returns>Der tages ikke højde for skatteberegning i prisen </returns>
        public int TotalPris() 
        {
            return Antal*KøbsPris;
        }

        /// <summary>
        /// Udregner hvormanget man vil tabe/vinde, ved at sælge sine aktier nu
        /// </summary>
        /// <returns> returnere diferancen mellem købspris og salgs pris</returns>
        public int Afkast() 
        {
            return (SalgsKurs- KøbsPris) * Antal;
        }
    }
}
