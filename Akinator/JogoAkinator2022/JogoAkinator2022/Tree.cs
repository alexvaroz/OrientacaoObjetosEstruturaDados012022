using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAkinator2022
{
    class Tree
    {
        Node root;

        public Tree(Node root)
        {
            this.root = root;
        }

        internal Node Root { get => root; set => root = value; }
    }
}
