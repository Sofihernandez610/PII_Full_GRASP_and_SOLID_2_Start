using System;
using System.Collections;
using System.Linq;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID.Library
{
    // Para respetar el principio de responsabilidad única, las clases solo deben tener una sola razón para
    // cambiar. La clase Recipe puede recibir modificaciones tales como agregar nuevos datos de como realizar
    // la receta, por ejemplo "consejos extras". Recipe también poseía la responsabilidad de imprimir la receta,
    // pero si en un futuro se desea imprimir la receta en otra forma que no sea la consola, debe volver 
    // a cambiarse. Para evitar que Recipe tenga más de una responsabilidad y cumplir con el principio SRP, 
    // se crea una nueva clase, "ConsolePrinter" la cual recibe una receta como parametro y tiene la
    // responsabilidad de imprimir la misma en consola.
    // Cabe destacar que ConsolePrinter se convierte en el nuevo experto en imprimir recetas, ya que conoce la
    // información necesaria al recibirlas como parametro.
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            ArrayList steps = recipe.getSteps();
            foreach (Step step in steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            
        }
    }
}