// See https://aka.ms/new-console-template for more information

internal class VertBar
{
    private int dim;

    public VertBar(int dim)
    {
        this.dim = dim;
        for (int i = 0; i < dim; i++)
        {
            Console.WriteLine('|');
        }
    }
}