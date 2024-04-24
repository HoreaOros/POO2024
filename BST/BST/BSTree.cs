using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
//1    BST-Insert(T, z)
//2      y := NIL
//3      x := T.root
//4      while x ≠ NIL do
//5        y := x
//6        if z.key<x.key then
//7          x := x.left
//8        else
//9          x := x.right
//10       end if
//11     repeat
//12     z.parent := y
//13     if y = NIL then
//14       T.root := z
//15     else if z.key<y.key then
//16       y.left := z
//17     else
//18       y.right := z
//19     end if
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
            throw new NotImplementedException();
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
