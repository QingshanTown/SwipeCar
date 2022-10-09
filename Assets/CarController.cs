using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {
    float carspeed = 0;
    Vector2 startPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
            //this.carspeed = 0.1f;
        }else if(Input.GetMouseButtonUp(0)){
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;
            this.carspeed = swipeLength / 500f;
            this.GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.carspeed, 0, 0);
        this.carspeed *= 0.98f;
	}
}
