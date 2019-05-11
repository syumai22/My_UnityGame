using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    //敵の体力
    public int HP = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// トリガーじゃない当たり判定に当たった時
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Gool")
        {
            Destroy(gameObject);
        }
    }
}
