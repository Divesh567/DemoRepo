using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController 
{
    private SquareView _view;
    private SquareModel _data;

    public void Init(SquareView view)
    { 
        _view = view;
        _data = new SquareModel();
    }

    public void SendColorToModel(Color color)
    {
        _data.SetColor(color);
    }

    public void SendShapeToModel(string shape)
    {
        _data.SetGameObject(shape);
    }

    public void SendSquareToView()
    {
        _view.color = _data.Color;
    }

}
