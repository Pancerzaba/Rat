using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //przypisać tagi tak by pkt byly tylko za chees

public class CollectChees : MonoBehaviour
{
    //zadeklarowanie zmiennej pola tekstowego
    private GameObject cheeseScore;
    //zadeklarowanie zmiennej licznika marchewek
    private int cheesCollected=-3;

    //funkcja wywoływana podczas uruchomienia programu
    private void Start()
    {
        //przypisanie do zmiennej wyszukanego obiektu CarrotsScore
        cheeseScore = GameObject.Find("cheeseScore");
    }

    //funkcja wykonywana podczas kolizji królika i marchewkicheeseScore
    private void OnTriggerEnter(Collider chees)
    {
        //zwiększenie licznika o 1
        cheesCollected += 1;
        //zmiana tekstu obiektu
        cheeseScore.GetComponent<Text>().text = "Cheese: " + cheesCollected;
        //Destroy(gameObject);
    }

}