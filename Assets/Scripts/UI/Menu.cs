using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    public void Open()
    {
        Time.timeScale = 0;
        _panel.SetActive(true);
    }

    public void Close()
    {
        Time.timeScale = 1;
        _panel.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
