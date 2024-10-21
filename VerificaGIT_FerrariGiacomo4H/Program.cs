namespace Biblioteca
{
    public class Libro
    {
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public int AnnoPubblicazione { get; set; }
        public string Editore { get; set; }
        public int NumeroPagine { get; set; }

        public Libro(string autore, string titolo, int annoPubblicazione, string editore, int numeroPagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            Editore = editore;
            NumeroPagine = numeroPagine;
        }

        #region Metodi della classe Libro

        /// <summary>
        /// restituisce una stringa con tutti i dati dell'oggetto su cui è invocato
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Titolo} di {Autore}, {AnnoPubblicazione}, {Editore}, {NumeroPagine} pagine.";
        }

        /// <summary>
        /// ════════════════════════════════════════════════════════════════════════════════════════════════╗
        /// restituisce un tempo di lettura pari a 1h se le pagine sono inferiori a 100, un valore pari  a  ║
        /// 2h se le pagine sono comprese tra 100 e 200 e un tempo superiore alle 2h se le pagine sono in   ║
        /// quantitativo superiore a 200                                                                    ║
        /// ════════════════════════════════════════════════════════════════════════════════════════════════╝
        /// </summary>
        /// <returns></returns>
        public string ReadingTime()
        {
            if (NumeroPagine < 100) return "Tempo di lettura: 1h";
            if (NumeroPagine <= 200) return "Tempo di lettura: 2h";
            return "Tempo di lettura: >2h";
        }

        #endregion
    }
}
