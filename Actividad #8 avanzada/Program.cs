using Actividad__8_avanzada;

bool right = true;
List<Recetas> recetasList = new List<Recetas>();
int idPosition = 0;
int quantity = 0;
do
{
	try
	{

	}
	catch (Exception)
	{

		throw;
	}
} while (right);

static int Menu()
{
    Console.WriteLine("Escoja una opción");
    Console.WriteLine("1.Agregar");
    Console.WriteLine("2.Buscar");
    Console.WriteLine("3.Mostrar");
    Console.WriteLine("4.Salir");
    int option = int.Parse(Console.ReadLine());
	return option;
}
static void ShowSiwtch()
{
	switch(Menu())
	{
		case 1:
			break;
			case 2:
			break;
			case 3:
			break;
			case 4:
			break;
	}
}
