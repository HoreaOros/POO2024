// See https://aka.ms/new-console-template for more information


/// <summary>
/// +-----+
/// |
/// |
/// |
/// +-----+
/// </summary>
internal class Frame
{
    HorzBar h1, h2;
    VertBar vert;

    public Frame(int height, int width)
    {
        h1 = new HorzBar(width);
        vert = new VertBar(height);
        h2= new HorzBar(width);
    }
}