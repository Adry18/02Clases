using System;
{ }
namespace Libros
{
	static void Main(string[] args)
	{
		Scanner sc = new Scanner(System.in);
		string titulo, autor;
		int ejemplares;


		Libro libro1 = new Libro("Harry Potter", "J.K Rowling", 1, 0);

		Libro libro2 = new Libro();

		Console.Write("Introduce titulo: ");
		titulo = sc.nextLine();
		Console.Write("Introduce autor: ");
		autor = sc.nextLine();
		Console.Write("Numero de ejemplares: ");
		ejemplares = sc.nextInt();
		libro2.setTitulo(titulo);
		libro2.setAutor(autor);
		libro2.setEjemplares(ejemplares);



		Console.WriteLine("Libro 1:");
		Console.WriteLine("Titulo: " + libro1.getTitulo());
		Console.WriteLine("Autor: " + libro1.getAutor());
		Console.WriteLine("Ejemplares: " + libro1.getEjemplares());
		Console.WriteLine("Prestados: " + libro1.getPrestados());
		Console.WriteLine();



		if (libro1.prestamo())
		{
			Console.WriteLine("Se ha prestado el libro " + libro1.getTitulo());
		}
		else
		{
			Console.WriteLine("No quedan ejemplares del libro " + libro1.getTitulo() + " para prestar");
		}


		if (libro1.devolucion())
		{
			Console.WriteLine("Se ha devuelto el libro " + libro1.getTitulo());
		}
		else
		{
			Console.WriteLine("No hay ejemplares del libro " + libro1.getTitulo() + " prestados");
		}


		if (libro1.prestamo())
		{
			Console.WriteLine("Se ha prestado el libro " + libro1.getTitulo());
		}
		else
		{
			Console.WriteLine("No quedan ejemplares del libro " + libro1.getTitulo() + " para prestar");
		}


		if (libro1.prestamo())
		{
			Console.WriteLine("Se ha prestado el libro " + libro1.getTitulo());
		}
		else
		{
			Console.WriteLine("No quedan ejemplares del libro " + libro1.getTitulo() + " para prestar");
		}

		Console.WriteLine("Libro 1:");
		Console.WriteLine("Titulo: " + libro1.getTitulo());
		Console.WriteLine("Autor: " + libro1.getAutor());
		Console.WriteLine("Ejemplares: " + libro1.getEjemplares());
		Console.WriteLine("Prestados: " + libro1.getPrestados());
		Console.WriteLine();


		Console.WriteLine("Libro 2:");
		Console.WriteLine("Titulo: " + libro2.getTitulo());
		Console.WriteLine("Autor: " + libro2.getAutor());
		Console.WriteLine("Ejemplares: " + libro2.getEjemplares());
		Console.WriteLine("Prestados: " + libro2.getPrestados());
		Console.WriteLine();
	}

	internal class Libro
	{
		public Libro()
		{
		}

		public Libro(string v1, string v2, int v3, int v4)
		{
		}

		internal bool devolucion()
		{
			throw new NotImplementedException();
		}

		internal string getAutor()
		{
			throw new NotImplementedException();
		}

		internal string getEjemplares()
		{
			throw new NotImplementedException();
		}

		internal string getPrestados()
		{
			throw new NotImplementedException();
		}

		internal string getTitulo()
		{
			throw new NotImplementedException();
		}

		internal bool prestamo()
		{
			throw new NotImplementedException();
		}

		internal void setAutor(string autor)
		{
			throw new NotImplementedException();
		}

		internal void setEjemplares(int ejemplares)
		{
			throw new NotImplementedException();
		}

		internal void setTitulo(string titulo)
		{
			throw new NotImplementedException();
		}
	}

	internal class Scanner
	{
		private object 1;
	private object 2;

	public Scanner(object 1, in object 2)
		{
			this.1 = 1;
			this.2 = 2;
		}

		internal int nextInt()
		{
			throw new NotImplementedException();
		}

		internal string nextLine()
		{
			throw new NotImplementedException();
		}
	}
}