using System.Collections.Generic;
using System.Linq;
    public class Presupuestos{
        private int IdPresupuesto { get; set; }
        private string NombreDestinatario { get; set; }
        private List<PresupuestosDetalle> Detalle { get; set; }
        public Presupuestos(int idPresupuesto, string nombreDestinatario){
            IdPresupuesto=idPresupuesto;
            NombreDestinatario=nombreDestinatario;
            Detalle=new List<PresupuestosDetalle>();
        }
        public int GetIdPresupuesto(){
            return IdPresupuesto;
        }
        public string? GetNombreDestinatario(){
            return NombreDestinatario;
        }
        public List<PresupuestosDetalle>? GetDetalle(){
            return Detalle;
        }
        public int MontoPresupuesto(){
            int total=0;
            foreach(PresupuestosDetalle d in Detalle){
                total+=d.GetCantidad()*d.GetProducto().GetPrecioProducto();
            }
            return total;
        }
        public double MontoPresupuestoConIva(){
            return MontoPresupuesto()*1.21;
        }
        public int CantidadProductos(){
            int total=0;
            foreach(PresupuestosDetalle d in Detalle){
                total+=d.GetCantidad();
            }
            return total;
        }
    }

