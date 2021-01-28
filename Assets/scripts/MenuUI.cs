using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class MenuUI : MonoBehaviour
{

	public Button btnStart;
	public Button btnExit;

	private Canvas manuUI;

	void Start()
	{
		manuUI = (Canvas)GetComponent<Canvas>();//Pobranie menu głównego.

		

		btnStart = btnStart.GetComponent<Button>();//Ustawienie przycisku uruchomienia gry.
		btnExit = btnExit.GetComponent<Button>();//Ustawienie przycisku wyjścia z gry.

	

		Time.timeScale = 0;//Zatrzymanie czasu.
		Cursor.visible = manuUI.enabled;//Ukrycie pokazanie kursora myszy.
		Cursor.lockState = CursorLockMode.Confined;//Odblokowanie kursora myszy.
	}

	void Update()
	{
		if (Input.GetKeyUp(KeyCode.Escape))
		{ //Jeżeli naciśnięto klawisz "Escape"
			manuUI.enabled = !manuUI.enabled;//Ukrycie/pokazanie menu.

			Cursor.visible = manuUI.enabled;//Ukrycie pokazanie kursora myszy.

			if (manuUI.enabled)
			{
				Cursor.lockState = CursorLockMode.Confined;//Odblokowanie kursora myszy.
				Cursor.visible = true;//Pokazanie kursora.
				Time.timeScale = 0;//Zatrzymanie czasu.
				
				btnStart.enabled = true; //Aktywacja przycsiku 'Start'.
				btnExit.enabled = true; //Aktywacja przycsiku 'Wyjście'.
			}
			else
			{
				Cursor.lockState = CursorLockMode.Locked; //Zablokowanie kursora myszy.
				Cursor.visible = false;//Ukrycie kursora.
				Time.timeScale = 1;//Włączenie czasu.
				
			}

		}
	}

	//Metoda wywoływana po naciśnięciu przycisku "Exit"
	public void PrzyciskWyjscie()
	{
		Application.Quit(); 
	}

	
	public void PrzyciskStart()
	{
		
		manuUI.enabled = false; //Ukrycie głównego menu.

		Time.timeScale = 1;//Właczenie czasu.

		Cursor.visible = false;//Ukrycie kursora.
		Cursor.lockState = CursorLockMode.Locked; //Zablokowanie kursora myszy.
	}


	public void PrzyciskTakWyjdz()
	{
		Application.Quit(); //Powoduje wyjście z gry.

	}
}

