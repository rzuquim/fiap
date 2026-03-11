public partial class Player
{
    public string Name { get; }
    public Color Color { get; }

    public Player(string name, Color color)
    {
        Name = name;
        Color = color;
    }
}
