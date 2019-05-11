using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour {

    // 弾のスピード
    public float speed = 0.1f;

	// Update is called once per frame
	void Update () {
        // 自分のlocalPositionに、
        // z方向のベクトルをspeed分だけ伸ばしたベクトルを足す
        // つまり、z方向にspeedずつ毎フレーム移動する
        //transform.localPosition += new Vector3(0, 0, 1.0f) * speed;

        // 自分のlocalPositionに、
        // 自分の前ベクトルをspeed分だけ伸ばしたベクトルを足す
        // つまり、前方向にspeedずつ毎フレーム移動する
        transform.localPosition += transform.forward * speed;
    }

    //当たり判定に何かしらのおジェクトが入ったときに呼ばれる
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name+"何か当たったよ");

        if (other.gameObject.tag == "Enemy")
        {
            Enemy enemy = other.gameObject.GetComponent<Enemy>();

            enemy.HP = enemy.HP - 1;
            //体力がゼロになったら消す
            if (enemy.HP<=0)
            {
                Destroy(other.gameObject);
            }
        }
        Destroy(gameObject);
    }
}
