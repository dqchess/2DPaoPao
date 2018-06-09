using UnityEngine;
using System.Collections;

public class New : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = new Vector3(0f, speed , 0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
