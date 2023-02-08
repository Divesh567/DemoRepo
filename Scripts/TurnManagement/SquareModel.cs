using Unity;
using UnityEngine;
public class SquareModel 
{
    public string PlayerName { get; private set; }
    public Color Color { get; private set; }
    public string Shape { get; private set; }
    public void SetPlayerName(string name)
    {
        PlayerName = name;
    }

    public void SetColor(Color color)
    {
        Color = color / 100;
        
    }

    public void SetGameObject(string shape)
    {
        Shape = shape;
    }
}
