
using System.Drawing;

namespace ConnectFour.Model;
public class Player(string name, Color color)
{
    public string Name { get; set; } = name;
    public Color Color { get; set; } = color;
    public int Score { get; set; } = 0;

    public void ResetScore()
    {
        Score = 0;
    }
}