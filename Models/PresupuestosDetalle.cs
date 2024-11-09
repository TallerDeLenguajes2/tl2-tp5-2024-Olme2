public class PresupuestosDetalle{
        private Productos Producto { get; set; }
        private int Cantidad { get; set; }
        public PresupuestosDetalle(Productos producto, int cantidad){
            Producto = producto;
            Cantidad = cantidad;
        }
        public Productos GetProducto(){
            return Producto;
        }
        public int GetCantidad(){
            return Cantidad;
        }
    }
