using Actividad__8_avanzada;
using System.Security.AccessControl;

bool right = true;
List<Recetas> recetasList = new List<Recetas>();

do
{
	try
	{
		ShowSiwtch(ref recetasList, right);
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
static bool Salir(ref bool right)
{

    right = false;
    return right;
}
static void ShowSiwtch(ref List<Recetas> recetasList, bool right)
{
	switch (Menu())
	{
		case 1:
			Recetas.AddRecipe(ref recetasList);

			break;
		case 2:
			Recetas.FindRecipe(ref recetasList);
			break;
			case 3:
			Recetas.ShowRecipes(ref recetasList);
			break;
			case 4:
			Salir(ref right);
			break;
	}
}
