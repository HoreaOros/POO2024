// See https://aka.ms/new-console-template for more information

internal class HorzBar
{
    private int dim;

    public HorzBar(int dim)
    {
        this.dim = dim;
        Console.Write('+');
        for (int i = 0; i < dim; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine('+');
    }
}