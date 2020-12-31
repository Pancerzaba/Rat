﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class CollectChees : MonoBehaviour
{
    //zadeklarowanie zmiennej pola tekstowego
    private GameObject cheeseScore;


    //zadeklarowanie zmiennej licznika marchewek
    private int cheesCollected=0;

    //funkcja wywoływana podczas uruchomienia programu
    private void Start()
    {
        //przypisanie do zmiennej wyszukanego obiektu CarrotsScore
        cheeseScore = GameObject.Find("cheeseScore");
    }

    //funkcja wykonywana podczas kolizji królika i marchewkicheeseScore
    private void OnTriggerEnter(Collider chees)
    {
        if (chees.tag.Equals("Item")) { 
            //zwiększenie licznika o 1
            cheesCollected += 1;
            // Destroy(this.gameObject);
            //zmiana tekstu obiektu
            //zmiana tekstu obiektu
            Console.WriteLine(cheesCollected);
        cheeseScore.GetComponent<Text>().text = "Ser2: " + cheesCollected;
           
        }

      
    }

}