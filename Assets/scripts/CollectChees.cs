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
    private GameObject healthScore;


    //zadeklarowanie zmiennej licznika marchewek
    private int boxCollected = 0;
    private int cheesCollected=0;
    private int health=5;

    private int chees = 0;

    //zrodlo dzwieku
    public AudioSource zrodloDzwieku;

    //odglos strzallu
    public AudioClip odglosZebrania;
    public AudioClip odglosAtaku;

    //funkcja wywoływana podczas uruchomienia programu
    private void Start()
    {
        //przypisanie do zmiennej wyszukanego obiektu CarrotsScore
        boxScore = GameObject.Find("boxScore");
        cheeseScore = GameObject.Find("cheeseScore");
        healthScore = GameObject.Find("healthScore");
    }
   private void Update()
    {
        if (cheesCollected >= 100)
        {
            cheesCollected -= 100;
            health += 1;
            healthScore.GetComponent<Text>().text = "Boxy: " + health;
        }
        }

    private void OnTriggerStay(Collider box)
    {
        chees = cheesCollected;
        if (box.tag.Equals("box") && Input.GetKey(KeyCode.Q))
        {

            // if (chees  == cheesCollected) {
            boxCollected += 1;
            cheesCollected += 3;

            //healthScore.GetComponent<Text>().text = "Ser: " + health;

            //}
            //zwiększenie licznika o 1

            //Destroy(this.gameObject);
            //zmiana tekstu obiektu

            Console.WriteLine(boxCollected);

            boxScore.GetComponent<Text>().text = "Boxy: " + boxCollected;
            cheeseScore.GetComponent<Text>().text = "Ser: " + cheesCollected;
            

            if (zrodloDzwieku != null)
            {
                zrodloDzwieku.PlayOneShot(odglosAtaku);
            }

        }
        if (box.tag.Equals("Item"))
        {
            //zwiększenie licznika o 1
            cheesCollected += 1;
            // Destroy(this.gameObject);
            //zmiana tekstu obiektu
            if (cheesCollected >= 100)
            {
                cheesCollected -= 100;
                health += 1;
                healthScore.GetComponent<Text>().text = "Ser: " + health;
            }

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