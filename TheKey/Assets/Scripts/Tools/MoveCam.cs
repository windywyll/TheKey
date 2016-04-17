using UnityEngine;
using System.Collections;

public class MoveCam : MonoBehaviour {

    Vector3 movement;

	// Use this for initialization
	void Start () {
        movement = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
            movement.x = -1;

        if (Input.GetKeyUp(KeyCode.LeftArrow))
            movement.x = 0;

        if (Input.GetKey(KeyCode.RightArrow))
            movement.x = 1;

        if (Input.GetKeyUp(KeyCode.RightArrow))
            movement.x = 0;

        if (Input.GetKey(KeyCode.UpArrow))
            movement.y = 1;

        if (Input.GetKeyUp(KeyCode.UpArrow))
            movement.y = 0;

        if (Input.GetKey(KeyCode.DownArrow))
            movement.y = -1;

        if (Input.GetKeyUp(KeyCode.DownArrow))
            movement.y = 0;

        this.transform.Translate(movement);
    }
}
