using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierActivate : MonoBehaviour
{
    public GameObject soldier;
    public bool activate;


    // Update is called once per frame
    void Update()
    {
        if (activate == true)
        {
            soldier.SetActive(true);
        }
        else
        {
            soldier.SetActive(false);
        }
    }

}
