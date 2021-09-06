using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlMenu : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    void Start()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    
    public void showPanel1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    public void showPanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    
}
