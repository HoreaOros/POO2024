// See https://aka.ms/new-console-template for more information

/// <summary>
/// +---+
/// |
/// |
/// +---+
/// |
/// |
/// +---+
/// |
/// |
/// +---+
/// </summary>
internal class Ladder
{
    Frame f1, f2;
    VertBar v;

    public Ladder(int width, int height)
    {
        this.f1 = new Frame(height, width);
        this.v = new VertBar(height);
        this.f2 = new Frame(height, width);
    }
}