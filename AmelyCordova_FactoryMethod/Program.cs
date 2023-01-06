namespace AmelyCordova_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Peliculas p = Creador.CreadorPeliculas(Creador.SERENDIPITY);
            Peliculas p2 = Creador.CreadorPeliculas(Creador.SPIRIT);
            Peliculas p3 = Creador.CreadorPeliculas(Creador.DIARIO);
            Peliculas p4 = Creador.CreadorPeliculas(Creador.BOB_ESPONJA);
            Peliculas p5 = Creador.CreadorPeliculas(Creador.AVATAR2);
            //Impresión de la duración de cada película en consola
            Console.WriteLine(p.Duracion());
            Console.WriteLine(p2.Duracion());
            Console.WriteLine(p3.Duracion());
            Console.WriteLine(p4.Duracion());
            Console.WriteLine(p5.Duracion());
        }
    }
}