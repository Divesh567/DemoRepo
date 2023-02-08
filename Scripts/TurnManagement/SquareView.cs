using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;

public class SquareView : MonoBehaviour
{
    private static SquareView _instance;

    public static SquareView Instance { get { return _instance; } }
    
    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    private SquareController _controller;
    [SerializeField]
    private GameObject _square;
    public Color color { get; set; }

    private void Start()
    {
        _controller = new SquareController();
        _controller.Init(this);
        _controller.SendShapeToModel("Cube");
    }

    public void ShowPlayerTurn(string _turn)
    {
        GameMenu.Instance.ShowPlayerTurn(_turn);
    }

    public void OnRedButtonPressed()
    {
        _controller.SendColorToModel(new Color(217,56,56,255));
    }

    public void OnBlueButtonPressed()
    {
        _controller.SendColorToModel(new Color(56, 56, 217, 255));
    }

    public void OnGreenButtonPressed()
    {
        _controller.SendColorToModel(new Color(56, 217, 56, 255));
    }

    public void CreatePlayer()
    {
        _controller.SendSquareToView();
    }
}
