using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad__8_avanzada
{
    internal class Recetas
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string  Ingridients { get; set; }
        public string  Process { get; set; }

        public Recetas(string iD, string name, string ingridients, string process)
        {
            ID = iD;
            Name = name;
            Ingridients = ingridients;
            Process = process;
        }
        public static void AddRecipe( ref List<Recetas> recetasList)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el ID de la receta");
            string idRecipe = Console.ReadLine();   
            Console.WriteLine("Ingrese el nombre de la receta");
            string nameRecipe = Console.ReadLine();
            Console.WriteLine("Ingrese los ingredientes de la lista");
            string ingridientRecipe = Console.ReadLine();
            Console.WriteLine("Ingrese el procedimiento de la receta");
            string processRecipe = Console.ReadLine();
            Recetas newRecipe = new Recetas(idRecipe,nameRecipe,ingridientRecipe,processRecipe);
            recetasList.Add(newRecipe);
            Console.WriteLine("La receta se ha agregado exitosamente");
            Console.ReadKey();
        }
        public static void FindRecipe(ref List<Recetas> recetasList)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el ID de la receta que desea buscar");
            string idRecipe = Console.ReadLine();
            Recetas findRecipe = recetasList.Find(p => p.ID == idRecipe);
            if (findRecipe != null) 
            {
                Console.WriteLine("La receta ya existe");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La receta aun no existe");
                Console.ReadKey(); 
            }

        }
        public static void ShowRecipes(ref List<Recetas> recetasList)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a las recetas de doña Juana");
            foreach (Recetas allRecipes in recetasList)
            {
                if (allRecipes != null)
                {
                    Console.WriteLine($"\n ID: {allRecipes.ID}| Name: {allRecipes.Name}| Ingredientes: {allRecipes.Ingridients}| proceso:{allRecipes.Process} ");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("No hay recetas agreagadas aun favor ingresar recetas");
                    Console.ReadKey ();
                }
            }
            }
        }
    }

