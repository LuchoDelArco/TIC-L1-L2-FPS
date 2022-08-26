using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncontrarElementoEnArray : MonoBehaviour
{
	public GameObject[] arrayDeMesas;  //declaracion array público

	

    // Start is called before the first frame update
    void Start()
    {
		arrayDeMesas = GameObject.FindGameObjectsWithTag("Mesa"); //Meter en el array todos los gameobjects con tag
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))	//Si se toca el 0...
		{
			//DeactivateObjectsInArray();			//Se invoca a la funcion

			DestroyDestructible();
		}

		if (Input.GetKeyDown(KeyCode.Alpha4))   //Si se toca el 4...
		{
			AsignarScriptAElementosArray();         //Se invoca a la funcion
		}
	}

	void DeactivateObjectsInArray()		//Declarar funcion
	{
		for (int i = 0; i < arrayDeMesas.Length; i++)	//for para recorrer el largo del array
		{
			arrayDeMesas[i].SetActive(false);		//Desactivar cada posicion del array
		}
	}
	
	// 5. Crear una funcion que asigne a todos los elementos del array el script mesa. Establecer el valor de la variable "destructible" aleatoriamente.

	void AsignarScriptAElementosArray()
	{
		foreach ( GameObject go in arrayDeMesas)		//Declaracion foreach
		{
			go.AddComponent<Mesa>();		//Añadir componente a los GameObjects dentro del array
			go.GetComponent<Mesa>().destructible = Random.Range(0, 2) == 0;		//



		}
	}

	
	// 6. Crear una funcion que destruya el elemento del array que contenga un script "Mesa" cuya variable booleana "destructible" sea true.

	void DestroyDestructible()
	{
		foreach (GameObject go in arrayDeMesas)
		{
			if (go.GetComponent<Mesa>().destructible)		//Si la variable destructible es true...
			{
				Destroy(go);		//Detroy GameObject
			}
		}
	}


	

}
