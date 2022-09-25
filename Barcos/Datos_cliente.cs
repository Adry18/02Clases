public class Cliente
{

    private string nombre, dni;
    private long telefono;

    public Cliente(string nombre, string dni, long telefono)
    {
        this.nombre = nombre;
        this.dni = dni;
        this.telefono = telefono;
    }

    public virtual string Nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            this.nombre = value;
        }
    }

    public virtual string Dni
    {
        get
        {
            return dni;
        }
        set
        {
            this.dni = value;
        }
    }

    public virtual long Telefono
    {
        get
        {
            return telefono;
        }
        set
        {
            this.telefono = value;
        }
    }



}
