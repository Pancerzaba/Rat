﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using Random = UnityEngine.Random;




public class Chees : MonoBehaviour
{

    void Start()
    {
       
    }

    //wbudowana funkcja OnTriggerEnter wywoływana w momencie zetknięcia się obiektu z królikiem
    private void OnTriggerEnter(Collider other)
    {
        //wywołanie funkcji ReplaceCarrot
        RemoveChees();
    }

    //zdefiniowanie funkcji ReplaceCarrot 
    private void RemoveChees()
    {

        //usuniecie obiektu
        Destroy(gameObject);
    }

}