using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroNets : MonoBehaviour
{
	public GameObject netbook;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

	void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.name == "FPSController")
		{
			//if (Input.GetKeyDown(KeyCode.N))
			//{
				Instantiate(netbook).transform.position = new Vector3(-3, 1, 4);

			//}
		}
	}
}

