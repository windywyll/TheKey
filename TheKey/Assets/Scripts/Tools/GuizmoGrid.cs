using UnityEngine;
using System.Collections;

public class GuizmoGrid : MonoBehaviour {

    public float height = 0.0f;
    public float zWidth = 10.0f;
    public float xWidth = 10.0f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDrawGizmos()
    {
        Vector3 pos = Camera.current.transform.position;

        Gizmos.color = Color.black;

        for (float z = pos.z - 800.0f; z < pos.z + 800.0f; z += zWidth)
        {
            Gizmos.DrawLine(new Vector3(-1000000.0f, height, Mathf.Floor(z / zWidth) * zWidth), new Vector3(1000000.0f, height, Mathf.Floor(z / zWidth) * zWidth));
        }

        for (float x = pos.x - 1200.0f; x < pos.x + 1200.0f; x += xWidth)
        {
            Gizmos.DrawLine(new Vector3(Mathf.Floor(x / xWidth) * xWidth, height, -1000000.0f),
                            new Vector3(Mathf.Floor(x / xWidth) * xWidth, height, 1000000.0f));
        }
    }
}

//http://code.tutsplus.com/tutorials/how-to-add-your-own-tools-to-unitys-editor--active-10047