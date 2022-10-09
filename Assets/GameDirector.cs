using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {
    GameObject car;
    GameObject flag;
    GameObject distance;
	// Use this for initialization
	void Start () {
        this.car = GameObject.Find("car");//按 name 查找 GameObject，然后返回它。
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }
	
	// Update is called once per frame
	void Update () {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length > 0)
        {
            this.distance.GetComponent<Text>().text = "距离目标" + length.ToString("F2") + "m";
        }
        else
        {
            this.car.transform.position = this.flag.transform.position;
            this.distance.GetComponent<Text>().text = "游戏结束";
        }

    }
}
