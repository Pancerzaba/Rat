using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class CollectChees : MonoBehaviour
{
    //zadeklarowanie zmiennej pola tekstowego
    private GameObject cheeseScore;
    private GameObject boxScore;


    //zadeklarowanie zmiennej licznika marchewek
    private int boxCollected = 0;
    private int cheesCollected=0;

    private int chees = 0;

    //zrodlo dzwieku
    public AudioSource zrodloDzwieku;

    //odglos strzallu
    public AudioClip odglosZebrania;

    //funkcja wywoływana podczas uruchomienia programu
    private void Start()
    {
        //przypisanie do zmiennej wyszukanego obiektu CarrotsScore
        boxScore = GameObject.Find("boxScore");
        cheeseScore = GameObject.Find("cheeseScore");
    }


    private void OnTriggerStay(Collider box)
    {
        chees = cheesCollected;
        if (box.tag.Equals("box") && Input.GetKey(KeyCode.Q))
        {

            if (chees  == cheesCollected) {
                boxCollected += 1;
                cheesCollected += 5;
            }
            //zwiększenie licznika o 1
            
            //Destroy(this.gameObject);
            //zmiana tekstu obiektu

            Console.WriteLine(boxCollected);

            boxScore.GetComponent<Text>().text = "Boxy: " + boxCollected;
            cheeseScore.GetComponent<Text>().text = "Ser: " + cheesCollected;


        }

        if (box.tag.Equals("Item"))
        {
            //zwiększenie licznika o 1
            cheesCollected += 1;
            // Destroy(this.gameObject);
            //zmiana tekstu obiektu

            Console.WriteLine(cheesCollected);
            cheeseScore.GetComponent<Text>().text = "Ser: " + cheesCollected;


            if (zrodloDzwieku != null)
            {
                zrodloDzwieku.PlayOneShot(odglosZebrania);
            }

        }


    }
    //funkcja wykonywana podczas kolizji królika i marchewkicheeseScore



}