using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Missions1Dialog2 : MonoBehaviour
{
    public GameObject _DialogBox;

    public GameObject _Option1;
    public GameObject _Option2;
    public GameObject _Option3;

    public GameObject _btn1;
    public GameObject _btn2;
    public GameObject _btn3;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (_Option1.activeSelf)
        {
            _DialogBox.SetActive(false);
            if (!_btn1.activeSelf)
            {
                _Option2.SetActive(true);
                if (_Option2.activeSelf)
                {
                    if (!_btn2.activeSelf)
                    {
                        _Option3.SetActive(true);
                        if (_Option3.activeSelf)
                        {
                            if (!_btn3.activeSelf)
                            {
                                _Option1.SetActive(false);
                                _Option2.SetActive(false);
                                _Option3.SetActive(false);
                            }
                        }
                    }
                }
            }
        }
    }
}