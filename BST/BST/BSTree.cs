using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class BSTree : ITree
    {
        public Node Root { get; set; } = null;

        public void Delete(Node node)
        {
            throw new NotImplementedException();
        }

        public void InorderTreeWalk()
        {
            InorderTreeWalkHelper(Root);
        }

        private void InorderTreeWalkHelper(Node p)
        {
            if(p != null)
            {
                InorderTreeWalkHelper(p.Left);
                Console.WriteLine($"{p.Key} -> ");
                InorderTreeWalkHelper(p.Right);
            }
        }

        public void Insert(Node node)
        {
            Node y = null;
            Node x = Root;
            while(x != null)
            {
                y = x;
                if (node.Key < x.Key)
                    x = x.Left;
                else if (node.Key > x.Key)
                    x = x.Right;
                else
                {
                    x.Frequency += 1;
                    return;
                }
            }
            node.Parent = y;
            node.Frequency = 1;
            if (y == null)
                Root = node;
            else if (node.Key < y.Key)
                y.Left = node;
            else
                y.Right = node;
        }

        public void PostorderTreeWalk()
        {
            PostorderTreeWalkHelper(Root);
        }

        private void PostorderTreeWalkHelper(Node p)
        {
            if (p != null)
            {
                PostorderTreeWalkHelper(p.Left);
                PostorderTreeWalkHelper(p.Right);
                Console.WriteLine($"{p.Key} -> ");
            }
        }

        public void PreorderTreeWalk()
        {
            throw new NotImplementedException();
        }

        public Node Search(int key)
        {
            Node x = Root;
            while(x != null && x.Key != key)
            {
                if (key < x.Key)
                    x = x.Left;
                else
                    x = x.Right;
            }
            return x;
        }
    }
}
