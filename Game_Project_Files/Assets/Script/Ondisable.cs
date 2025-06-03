using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ondisable : MonoBehaviour
{
    public int _Order;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnDisable()
    {
        SetOrder.setorder.SetOrdercs(_Order);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
