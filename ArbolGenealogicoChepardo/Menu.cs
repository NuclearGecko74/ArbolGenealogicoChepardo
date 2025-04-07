using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArbolGenealogicoChepardo
{
    internal class Menu
    {
        private int option;
        private string name;

        public Menu() { }

        // Metodo que muestra el menu en la consola
        public void Show()
        {
            Console.WriteLine("Arbol Genealogico");
            Console.WriteLine("=========================");

            Console.WriteLine("Introduzca el primer miembro: ");
            name = Console.ReadLine();

            Console.Write("Introduzca el padre del miembro: ");
            string fatherName = Console.ReadLine();

            Console.Write("Introduzca la madre del miembro: ");
            string motherName = Console.ReadLine();

            Console.WriteLine("Introduzca su genero");
            Console.WriteLine("1. Masculino, 2.Femenino");
            int gender = Convert.ToInt32(Console.ReadLine());
            if (gender == 1)
            {
                FamilyTree tree = new FamilyTree(name, fatherName, motherName, true);
                while (true)
                {
                    Operations(tree, ref option);
                    if (option == 5) return;
                }
            }

            else if (gender == 2)
            {
                FamilyTree tree = new FamilyTree(name, fatherName, motherName, true);
                while (true)
                {
                    Operations(tree, ref option);
                    if (option == 5) return;
                }
            }

            else
            {
                Console.WriteLine("Introduzca una opcion valida");
                return;
            }
        }

        // Metodo que muestra al usuario las operacines disponibles
        public void Operations(FamilyTree tree, ref int option)
        {
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("1. Agregar un miembro al arbol");
            Console.WriteLine("2. Agregar padres a un miembro");
            Console.WriteLine("3. Mostrar Familia");
            Console.WriteLine("4. Encuentra a los padres de un miembro");
            Console.WriteLine("5. Salir Del Programa");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Introduzca el nombre del miembro que desea insertar al arbol: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Introduzca su genero");
                    Console.WriteLine("1. Masculino, 2.Femenino");
                    int gender = Convert.ToInt32(Console.ReadLine());
                    if (gender == 1)
                    {
                        tree.InsertMember(name, true);
                    }
                    else if (gender == 2)
                    {
                        tree.InsertMember(name, false);
                    }
                    else
                    {
                        Console.WriteLine("Introduzca una opcion valida");
                        return;
                    }
                    break;
                case 2:
                    Console.WriteLine("Introduzca el miembro al que le quiere agregar padres");
                    name = Console.ReadLine();
                    Console.Write("Introduzca el padre del miembro que desea agregar al arbol: ");
                    string fatherName = Console.ReadLine();
                    Console.Write("Introduzca la madre del miembro que desea agregar al arbol: ");
                    string motherName = Console.ReadLine();
                    tree.InsertParents(name, fatherName, motherName);
                    break;
                case 3:
                    tree.GetFamily();
                    break;
                case 4:
                    Console.WriteLine("Introduzca el miembro al que desea conocer sus padres");
                    name = Console.ReadLine();
                    tree.GetParents(name);
                    break;
                case 5:
                    Console.WriteLine("Gracias por usar el programa!");
                    return;
                default:
                    Console.WriteLine("Introduzca una opcion valida");
                    break;
            }
        }
    }
}
