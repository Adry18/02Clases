public class Deportivo
{

    private int potencia;

    public Deportivo(int potencia, string matricula, int eslora, int añoFabricacion) : base(matricula, eslora, añoFabricacion)
    {
        this.potencia = potencia;
    }

    public virtual int Potencia
    {
        get
        {
            return potencia;
        }
        set
        {
            this.potencia = value;
        }
    }


    public virtual double calculaPrecioAmarre()
    {
        return base.calculaPrecioAmarre() + potencia * 1;
    }

    public override string ToString()
    {
        return "***** Deportivo a motor *****\n" + "Matrícula: " + base.getMatricula() + " | Metros de eslora: " + base.getEslora() + "\nAño de fabricación: " + getAñoFabricacion() + " | Potencia: " + potencia + "CV";
    }
}
