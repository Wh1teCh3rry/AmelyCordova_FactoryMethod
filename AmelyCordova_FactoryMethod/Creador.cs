namespace AmelyCordova_FactoryMethod
{
    //Clase que crea objetos
    public class Creador
    {
        public const int SERENDIPITY = 1;
        public const int SPIRIT = 2;
        public const int DIARIO = 3;
        public const int BOB_ESPONJA = 4;
        public const int AVATAR2 = 5;

        public static Peliculas CreadorPeliculas(int Opcion)
        {
            switch (Opcion)
            {
                case SERENDIPITY:
                    return new Serendipity();
                case SPIRIT:
                    return new Spirit();
                case DIARIO:
                    return new DiarioDeUnaPasion();
                case BOB_ESPONJA:
                    return new BobEsponja();
                case AVATAR2:
                    return new Avatar2();
                default: 
                    return null;
            }
        }
    }
}
