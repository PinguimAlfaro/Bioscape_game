using System.Collections.Generic;
using UnityEngine;

public class StartDialog2 : MonoBehaviour
{
    public static StartDialog2 startdialog2;
    // Referências dos 6 botões
    public GameObject Op1;
    public GameObject Op2;
    public GameObject Op3;
    public GameObject Op4;
    public GameObject Op5;
    public GameObject Op6;

    //public GameObject TextBox;
    public GameObject Dialog1;
    public GameObject Dialog2;
    public GameObject Dialog3;
    public GameObject Dialog4;
    public GameObject Dialog5;
    public GameObject Dialog6;

    private List<GameObject> _dialogs;
    private List<GameObject> _buttons;

    public bool _Pressed;


    void Start()
    {
        startdialog2 = this;
        // Adiciona os botões à lista para facilitar o gerenciamento
        _buttons = new List<GameObject> { Op1, Op2, Op3, Op4, Op5, Op6 };
        _dialogs = new List<GameObject> { Dialog1, Dialog2, Dialog3, Dialog4, Dialog5, Dialog6 };

    }
    private void Update()
    {

    }
    // Este método deve ser chamado ao clicar em um botão, com ele como parâmetro
    public void PressButton(GameObject clickedButton)
    {
        foreach (var btn in _buttons)
        {
            if (btn != null)
            {

                if (btn != clickedButton)
                {
                    btn.SetActive(false);
                    _Pressed = true;
                }
            }
        }

    }
    public void ActiveButton()
    {
        foreach (var btn in _buttons)
        {
            if (btn != null)
            {
                btn.SetActive(true);
                _Pressed = false;
            }

        }

    }
    public void DesactiveButton()
    {
        foreach (var btn in _buttons)
        {
            if (btn != null)
            {
                btn.SetActive(false);
            }

        }

    }
    private void OnDisable()
    {

    }
}