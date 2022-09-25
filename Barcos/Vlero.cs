public class Velero
{

	private int numeroMastiles;

	public Velero(int numeroMastiles, string matricula, int eslora, int añoFabricacion) : base(matricula, eslora, añoFabricacion)
	{
		this.numeroMastiles = numeroMastiles;
	}

	public virtual int NumeroMastiles
	{
		get
		{
			return numeroMastiles;
		}
		set
		{
			this.numeroMastiles = value;
		}
	}


	public virtual double calculaPrecioAmarre()
	{
		return base.calculaPrecioAmarre() + numeroMastiles * 5;
	}

	public override string ToString()
	{
	return "****** Velero ******\n" + "Matrícula: " + base.getMatricula() + " | Metros de eslora: " + base.getEslora() + "\nAño de fabricación: " + getAñoFabricacion() + " | Mastiles: " + numeroMastiles;
	}
}
