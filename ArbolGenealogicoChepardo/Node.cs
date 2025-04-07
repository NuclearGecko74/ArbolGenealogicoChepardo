using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolGenealogicoChepardo
{
    internal class Node
    {
        private string data; // Dato que guarda el nodo
        private Node left; // Nodo siguiente a la izquierda
        private Node right; // Nodo siguiente a la derecha
        private bool gender;

        // Constructores de la clase Node
        public Node(string data, Node left, Node right, bool gender)
        {
            this.data = data;
            this.left = left;
            this.right = right;
            this.gender = gender;
        }

        public Node(string data, bool gender)
        {
            this.data = data;
            this.gender = gender;
            left = null;
            right = null;
        }

        public Node()
        {
            data = null;
            left = null;
            right = null;
            gender = false;
        }

        // Getters y setters de la clase Node
        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }
    }
}
