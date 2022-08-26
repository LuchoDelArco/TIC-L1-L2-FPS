using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroNets : MonoBehaviour
{
	public GameObject netbook;
	public Transform spawn;

	bool spawnable;
    // Start is called before the first frame update
    void Start()
    {
		spawnable = false;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.N) && spawnable == true)
		{
			Instantiate(netbook);
			netbook.transform.position = spawn.transform.position;
			
		}
		
    }

	void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.tag == "Player")
		{
			spawnable = true;
		}
	}
}

