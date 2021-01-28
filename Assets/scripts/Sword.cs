using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class Sword : MonoBehaviour
{ 
         //zadeklarowanie zmiennej pola tekstowego
    private GameObject boxScore;
    private GameObject cheeseScore;


    //zadeklarowanie zmiennej licznika marchewek
    private int boxCollected=0;
    private int cheesCollected;



    //funkcja wywoływana podczas uruchomienia programu
    private void Start()
    {
        //przypisanie do zmiennej wyszukanego obiektu CarrotsScore
        boxScore = GameObject.Find("boxScore");
        cheeseScore = GameObject.Find("cheeseScore");
    }

    //funkcja wykonywana podczas kolizji królika i marchewkicheeseScore
    private void OnTriggerEnter(Collider box)
    {
        if (box.tag.Equals("box")&& Input.GetKeyDown(KeyCode.Q))
        {
            //zwiększenie licznika o 1
            boxCollected += 1;
            cheesCollected += 5;
            //Destroy(this.gameObject);
            //zmiana tekstu obiektu

            Console.WriteLine(boxCollected);

            boxScore.GetComponent<Text>().text = "Boxy: " + boxCollected;
            cheeseScore.GetComponent<Text>().text = "Ser: " + cheesCollected;


        }


    }
}