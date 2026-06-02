using System.Windows.Forms;
namespace ProyectoLavanderia
{
    public class Servicio
    {
		private int numeroOrden;

		public int NumeroOrden
		{
			get { return numeroOrden; }
			set
			{
				if (value > 0)
				{
					numeroOrden = value;
				}
				else
				{
					MessageBox.Show("El número de orden debe ser un número entero positivo.");
				}
			}
		}
		private int cantidad;

		public int Cantidad
		{
			get { return cantidad; }
			set
			{
				if (value > 0)
				{
					cantidad = value;
				}
				else
				{
					MessageBox.Show("La cantidad debe ser un número entero positivo.");
				}
			}
		}
		private string tipoRopa;

		public string TipoRopa
		{
			get { return tipoRopa; }
			set
			{
				if (value == "Ropa Blanca" || value == "Ropa de Color" || value == "Ropa Delicada")
				{
					tipoRopa = value;
				}
				else
				{
					MessageBox.Show("Tipo de ropa no válido, debe ser (Ropa Blanca/Ropa de Color/Ropa Delicada)");
				}
			}
		}
		private bool planchado;

		public bool Planchado
		{
			get { return planchado; }
			set { planchado = value; }
		}
		private bool detergentePremium;

		public bool DetergentePremium
		{
			get { return detergentePremium; }
			set { detergentePremium = value; }
		}
		public Servicio(int numeroOrden, int cantidad, string tipoRopa, bool planchado, bool detergentePremium)
		{
			this.NumeroOrden = numeroOrden;
			this.Cantidad = cantidad;
			this.TipoRopa = tipoRopa;
			this.Planchado = planchado;
			this.DetergentePremium = detergentePremium;
        }
		public double TotalEstudianteDescuento(bool esEstudiante)
		{
			double totalDescuento = 15;
			if (Cantidad > 10)
			{
				totalDescuento = totalDescuento + ((Cantidad - 10) * 1.50);
			}
			if (Planchado == true)
			{
                totalDescuento += 5;
			}
			if(DetergentePremium == true)
			{
                totalDescuento += 3;
            }
			if (esEstudiante)
			{
                totalDescuento *= 0.85;
			}
			return totalDescuento;
        }
		public double CalcularTotal()
		{
			double total = 15;
			if (Cantidad > 10)
			{
				total += (Cantidad - 10) * 1.50;
            }
			if(Planchado == true)
			{
				total += 5;
			}
			if(DetergentePremium == true)
			{
				total += 3;
			}
			return total;
        }
    }
}