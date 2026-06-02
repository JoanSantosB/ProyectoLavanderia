using System.Windows.Forms;
namespace ProyectoLavanderia
{
    public class Maquina
    {
		private string id;

		public string ID
		{
			get { return id; }
			set
			{
				if (value.Length == 5)
				{
					id = value;
				}
				else
				{
					MessageBox.Show("Error ID incorrecto, debe tener 5 caracteres.");
				}
			}
		}

		private string tipo;

		public string Tipo
		{
			get { return tipo; }
			set
			{
				if (value == "Lavadora" || value == "Secadora")
				{
					tipo = value;
				}
				else
				{
					MessageBox.Show("Error esta maquina no existe, debe ser lavadora o secadora.");
				}
			}
		}
		private string estado;

		public string Estado
		{
			get { return estado; }
			set {
				if (value == "Disponible" || value == "Ocupado" || value=="Mantenimiento") 
				{
					estado = value; 
				}
				else
				{
					MessageBox.Show("Error estado incorrecto, debe ser (Disponible, Ocupado o Mantenimiento)");
				}
			}
		}
		private int contadorCiclos;

		public int ContadorCiclos
		{
			get { return contadorCiclos; }
			set 
			{ 
				if(value>=0) 
				{
					contadorCiclos = value; 
				}
				else 
				{
					MessageBox.Show("Error contador de ciclos incorrecto, debe ser mayor o igual a 0.");
				}
			}
		}
		public Maquina(string id, string tipo, string estado, int contadorCiclos)
		{
			this.ID = id;
			this.Tipo = tipo;
			this.Estado = estado;
			this.ContadorCiclos = contadorCiclos;
        }
		public void InformacionMaquina()
		{
			if (Estado == "Disponible")
			{
				Estado="Ocupado";
				ContadorCiclos++;
				if (ContadorCiclos >= 10)
				{
					Estado= "Mantenimiento";
					MessageBox.Show("La máquina ha alcanzado el límite de ciclos y requiere mantenimiento.");
                }
            }
			else
			{
				MessageBox.Show("La máquina no esta disponible por el momento.");
            }
		}
    }
}