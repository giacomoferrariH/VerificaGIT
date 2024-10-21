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
    public class Biblioteca
    {
        public string Nome { get; }
        public string Indirizzo { get; }
        public string Orari { get; }
        private List<Libro> libri;

        public Biblioteca(string nome, string indirizzo, string orari)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            Orari = orari;
            libri = new List<Libro>();
        }

        #region Metodi della classe Biblioteca
        // "L’applicazione deve consentire le seguenti operazioni:"

        /// <summary>
        /// aggiunta di un nuovo libro alla biblioteca
        /// </summary>
        /// <param name="libro"></param>
        public void AggiungiLibro(Libro libro)
        {
            libri.Add(libro);
        }

        /// <summary>
        /// ricerca di un libro a partire dal titolo
        /// </summary>
        /// <param name="titolo"></param>
        /// <returns></returns>
        public Libro CercaLibro(string titolo)
        {
            return libri.FirstOrDefault(l => l.Titolo.Equals(titolo, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// ricerca di tutti i libri di uno specifico autore
        /// </summary>
        /// <param name="autore"></param>
        /// <returns></returns>
        public List<Libro> CercaLibriPerAutore(string autore)
        {
            return libri.Where(l => l.Autore.Equals(autore, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        /// <summary>
        /// determinazione del numero dei libri presenti
        /// </summary>
        /// <returns></returns>
        public int ContaLibri()
        {
            return libri.Count;
        }

        #endregion
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Libro berlino = new Libro("Christiane F.", "Noi, i ragazzi dello zoo di Berlino", 1982, "Rizzoli", 470);
        }
    }
}
