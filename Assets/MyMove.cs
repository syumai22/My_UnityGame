using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        // RigidBodyのコンポーネントを入れるハコを準備する
        Rigidbody myRigid = GetComponent<Rigidbody>();

        // 上矢印を押している間、RigidBodyに力をいれ続ける
		if(Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("スクリプトうごいてるよ！");

            //myRigidさん.力を加えてください
            //（新しく作ったx=0,y=30,z=0のベクトルで）
            myRigid.AddForce(new Vector3(0, 30.0f, 0));
        }
    }
}
