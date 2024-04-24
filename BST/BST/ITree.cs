namespace BST
{
    internal interface ITree
    {
        Node Search(int key);
        void Insert(Node node);
        void Delete(Node node);
        void InorderTreeWalk();
        void PreorderTreeWalk();
        void PostorderTreeWalk();
    }
}