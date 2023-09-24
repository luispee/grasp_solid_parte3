using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        //PrintRecipe es un metodo polimorfico. Su funcionamiento cambia según desde donde lo invoque.
        //En este caso defino que si lo llama un file printer lo guarde como un archivo Recipe.txt
        public void PrintRecipe(Recipe recipe)
        {
            if (sale != null)
            {
                File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
            }
        }
    }
}