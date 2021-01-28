using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using Random = UnityEngine.Random;




public class Box : MonoBehaviour
{

    void Start()
    {

    }

    //wbudowana funkcja OnTriggerEnter wywoływana w momencie zetknięcia się obiektu z graczem
    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            //wywołanie funkcji ReplaceCarrot
            RemoveBox();
        }
    }

    //zdefiniowanie funkcji ReplaceCarrot 
    private void RemoveBox()
    {
        if(Input.GetKey(KeyCode.Q))
            Destroy(gameObject);  //usuniecie obiektu


    }

}