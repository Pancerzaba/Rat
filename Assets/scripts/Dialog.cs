using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class Dialog : MonoBehaviour
{
    public Button dalej;
    private GameObject DialogScore;
    private string textDialog ="Cześć, Uważaj zbierz jak najwięcej sera ";

    private Canvas dialog;
    // Start is called before the first frame update
    void Start()
    {
        DialogScore = GameObject.Find("DialogScore");
        dialog = GetComponent<Canvas>();//Pobranie menu głównego.
      

        dialog.enabled = false;


        Time.timeScale = 0;//Zatrzymanie czasu.
        Cursor.visible = dialog.enabled;//Ukrycie pokazanie kursora myszy.
        Cursor.lockState = CursorLockMode.Confined;//Odblokowanie kursora myszy.
    }

    // Update is called once per frame
  void Update()
    {

        if (Input.GetKeyUp(KeyCode.E))
        {
            dialog.enabled = !dialog.enabled;//Ukrycie/pokazanie menu.

            Cursor.visible = dialog.enabled;//Ukrycie pokazanie kursora myszy.
            if (dialog.enabled)
            {
                Cursor.lockState = CursorLockMode.Confined;//Odblokowanie kursora myszy.
                Cursor.visible = true;//Pokazanie kursora.
                Time.timeScale = 0;//Zatrzymanie czasu.

                dalej.enabled = true; //Aktywacja przycsiku 'Start'.

            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked; //Zablokowanie kursora myszy.
                Cursor.visible = false;//Ukrycie kursora.
                Time.timeScale = 1;//Włączenie czasu.

            }
        }
    }

    public void PrzyciskDalej()
    {

        dialog.enabled = false; //Ukrycie głównego menu.

        Time.timeScale = 1;//Właczenie czasu.

        Cursor.visible = false;//Ukrycie kursora.
        Cursor.lockState = CursorLockMode.Locked; //Zablokowanie kursora myszy.
    }
}
