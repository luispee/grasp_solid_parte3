using System;

namespace Full_GRASP_And_SOLID.Library
{

    //Para implementar el patrón de polimorfismo creo una interfaz que será utilizada por ambas impresoras y que eventualmente puede utilizar otra distinta
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}