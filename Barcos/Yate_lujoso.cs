namespace Barcos
{
    public class Yate
    {

        private int camarotes;

        public Yate(int camarotes, int potencia, string matricula, int eslora, int añoFabricacion) : base(potencia, matricula, eslora, añoFabricacion)
        {
            this.camarotes = camarotes;
        }

        public virtual int Camarotes
        {
            get
            {
                return camarotes;
            }
            set
            {
                camarotes = value;
            }
        }


        public virtual double calculaPrecioAmarre()
        {
            return base.calculaPrecioAmarre() + camarotes * 20;
        }

        public override string ToString()
        {
            return "***** Yate de lujo *****\n" + "Matrícula: " + base.getMatricula() + " | Metros de eslora: " + base.getEslora() + "\nAño de fabricación: " + getAñoFabricacion() + " | Potencia: " + base.getPotencia() + "CV" + " | Camarotes: " + camarotes;
        }
    }
}