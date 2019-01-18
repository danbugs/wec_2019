using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if(gameObject.tag == "Tile")
        {
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("You clicked on a number");
        }
            
    }
}
