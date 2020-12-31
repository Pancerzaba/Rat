using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCrystal : MonoBehaviour
{
    //zadeklarowanie zmiennej pola tekstowego
    private GameObject crystalScore;


    //zadeklarowanie zmiennej licznika marchewek
    private int crystalCollected = 0;

    //funkcja wywoływana podczas uruchomienia programu
    private void Start()
    {
        //przypisanie do zmiennej wyszukanego obiektu CarrotsScore
        crystalScore = GameObject.Find("cheeseScore");
    }

    //funkcja wykonywana podczas kolizji królika i marchewkicheeseScore
    private void OnTriggerEnter(Collider chees)
    {
        if (chees.tag.Equals("crystal"))
        {
            //zwiększenie licznika o 1
            crystalCollected += 1;
            // Destroy(this.gameObject);
            //zmiana tekstu obiektu
            //zmiana tekstu obiektu
            Console.WriteLine(crystalCollected);
            crystalScore.GetComponent<Text>().text = "Kryształ " + crystalCollected;

        }


    }

}