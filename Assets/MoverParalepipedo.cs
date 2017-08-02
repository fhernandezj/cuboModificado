using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverParalepipedo : MonoBehaviour {

    public float movementSpeed = 5f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0f, 1, 0f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(0f, -1, 0f));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0f, 0f, 1) * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0f, 0f, -1) * Time.deltaTime * movementSpeed);
        }
    }
}
