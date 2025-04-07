using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolGenealogicoChepardo
{
    internal class FamilyTree
    {
        private Node root, newMember;

        // Constructor de la clase FamilyTree
        public FamilyTree(string member, string father, string mother, bool gender)
        {
            if (gender)
            {
                root = new Node(member, gender);
            }
            else
            {
                root = new Node(member, gender);
            }

            root.Left = new Node(father, true);
            root.Right = new Node(mother, false);
        }

        // Metodo que inserta un nuevo miembro al arbol
        public void InsertMember(string member, bool gender)
        {
            if (gender)
            {
                newMember = new Node(member, gender);
            }
            else
            {
                newMember = new Node(member, gender);
            }

            ChooseGender(newMember, gender, member);

            if (root.Gender)
            {
                Console.WriteLine("Introduzca el nombre de la madre");
                newMember.Left = root;
                string mother = Console.ReadLine();
                InsertMother(newMember, mother);
            }

            else
            {
                Console.WriteLine("Introduzca el nombre del padre");
                newMember.Right = root;
                string father = Console.ReadLine();
                InsertFather(newMember, father);
            }

            root = newMember;
        }

        // Metodo que inserta el padre al miembro mas reciente
        public void InsertFather(Node member, string father)
        {
            member.Left = new Node(father, true);
            member.Left.Gender = true;
        }

        // Metodo que inserta la madre al miembro mas reciente
        public void InsertMother(Node member, string mother)
        {
            member.Right = new Node(mother, false);
            member.Right.Gender = false;
        }

        // Metodo que inserta los padres al miembro mas reciente
        public void InsertParents(string name, string father, string mother)
        {
            Node member = FindMember(name);
            if (member == null) return;

            member.Left = new Node(father, true);
            member.Right = new Node(mother, false);
        }

        // Metodo que retorna los padres de un miembro
        public void GetParents(string name)
        {
            Node member = FindMember(name);
            if (member == null) return;

            Console.WriteLine("El padre de " + member.Data + " es " + member.Left.Data + " y la madre es " + member.Right.Data);
        }

        // Metodo que retorna un miembro en base a su nombre
        private Node FindMember(Node node, string name)
        {
            if (node == null) return null;

            if (node.Data == name) return node;

            Node member = FindMember(node.Left, name);
            if (member != null) return member;

            return FindMember(node.Right, name);
        }

        private Node FindMember(string name) { return FindMember(root, name); }

        // Metodo que imprime todo el arbol genealogico
        private void GetFamily(Node node)
        {
            if (node == null) return;

            Console.WriteLine("|-- " + node.Data);

            GetFamily(node.Left);
            GetFamily(node.Right);
        }

        public void GetFamily() { GetFamily(root); }

        // Metodo que determina el genero de un miembro del arbol
        private void ChooseGender(Node member, bool gender, string name)
        {
            if (gender)
            {
                member = new Node(name, gender);
            }
            else
            {
                member = new Node(name, gender);
            }
        }
    }
}
