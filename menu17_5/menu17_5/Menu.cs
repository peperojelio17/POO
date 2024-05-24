namespace menu17_5
{
    internal class Menu
    {
        public string[] items;
        public string nombreMenu;
        public int posItem;
        public int columna;
        public int fila;

        public Menu(int posItem, string nombreMenu, string[] opciones, int fila, int col)
        {
            this.items = opciones;
            this.nombreMenu = nombreMenu;
            this.posItem = posItem;
            this.fila = fila;
            this.columna = col;
        }
    }
}
