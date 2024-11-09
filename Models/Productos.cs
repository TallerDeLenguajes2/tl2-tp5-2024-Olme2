public class Productos{
        private int IdProducto { get; set; }
        private string Descripcion { get; set; }
        private int Precio { get; set; }
        public Productos(int idProducto, string descripcion, int precio){
            IdProducto = idProducto;
            Descripcion=descripcion;
            Precio=precio;
        }
        public int GetIdProducto(){
            return IdProducto;
        }
        public string? GetDescripcionProducto(){
            return Descripcion;
        }
        public int GetPrecioProducto(){
            return Precio;
        }
    }