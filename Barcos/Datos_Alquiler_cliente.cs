using System.Globalization;

namespace Barcos
{
    public class Alquiler
    {

        private GregorianCalendar fInicio, fFin;
        private int posicionAmarre;
        private Barco barco;
        private double precioAlquiler;
        private Cliente cliente;

        public Alquiler(Cliente cliente, int diaInicio, int mesInicio, int añoInicio, int diaFin, int mesFin, int añoFin, int posicionAmarre, Barco barco)
        {
            this.cliente = cliente;
            fInicio = new GregorianCalendar(añoInicio, mesInicio, diaInicio);
            fFin = new GregorianCalendar(añoFin, mesFin, diaFin);
            this.posicionAmarre = posicionAmarre;
            this.barco = barco;
            precioAlquiler = 0.0;
        }


        public virtual Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                this.cliente = value;
            }
        }

        public virtual string getfInicio()
        { 
            return fInicio.get(Calendar.DATE) + "/" + fInicio.get(Calendar.MONTH) + "/" + fInicio.get(Calendar.YEAR);
        }

        public virtual string getfFin()
        { 
            return fFin.GetType(Calendar.DATE) + "/" + fFin.get(Calendar.MONTH) + "/" + fFin.get(Calendar.YEAR);
        }

        public virtual int PosicionAmarre
        {
            get
            {
                return posicionAmarre;
            }
            set
            {
                this.posicionAmarre = value;
            }
        }

        public virtual Barco Barco
        {
            get
            {
                return barco;
            }
            set
            {
                this.barco = value;
            }
        }

        public virtual double PrecioAlquiler
        {
            get
            {
                return precioAlquiler;
            }
        }




        public virtual void setfInicio(int diaInicio, int mesInicio, int añoInicio)
        {
            fInicio = new GregorianCalendar(añoInicio, mesInicio, diaInicio);
        }

        public virtual void setfFin(int diaFin, int mesFin, int añoFin)
        {
            fFin = new GregorianCalendar(añoFin, mesFin, diaFin);
        }



        
        private long diasOcupados()
        {
            long aux = fFin.getTimeInMillis() - fInicio.getTimeInMillis();
            long dias = aux / (1000 * 60 * 60 * 24);
            return dias;
        }

        
        public virtual void calculaPrecioAlquiler(Barco a)
        {

            precioAlquiler = diasOcupados() * a.calculaPrecioAmarre() + 2;
        }


        public override string ToString()
        {
            return "***** Alquiler ******" + "\nNombre: " + cliente.getNombre() + " | DNI: " + cliente.getDni() + " | Teléfono: " + cliente.getTelefono() + "\nFecha de inicio: " + getfInicio() + " | Fecha de fin: " + getfFin() + "\nPosicion de amarre: " + posicionAmarre + " | Barco: " + barco.getMatricula();
        }

    }
}
