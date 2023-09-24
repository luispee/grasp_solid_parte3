using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    //PrintRecipe es un metodo polimorfico. Su funcionamiento cambia según desde donde lo invoque.
    //En este caso si lo llama una console printer el mensaje será imrpeso en consola
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            if (sale != null)
            {
                Console.WriteLine(recipe.GetTextToPrint());
            }
        }
    }
}