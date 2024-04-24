using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BSTree T = new BSTree();
            List<Node> lst = new List<Node>
            {
                new Node{ Key = 5  },
                new Node{ Key = 3  },
                new Node{ Key = 10  },
                new Node{ Key = 4  },
                new Node{ Key = 1  },
                new Node{ Key = 15  },
                new Node{ Key = 7  }
            };
            foreach (Node node in lst)
            {
                T.Insert(node);
            }
            T.PostorderTreeWalk();
        }
    }
}
