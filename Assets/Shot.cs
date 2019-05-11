using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

		   // 弾のスピード
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        // 自分のlocalPositionに、
        // z方向のベクトルをspeed分だけ伸ばしたベクトルを足す
        // つまり、z方向にspeedずつ毎フレーム移動する
        //transform.localPosition += new Vector3(0, 0, 1.0f) * speed;

        // 自分のlocalPositionに、
        // 自分の前ベクトルをspeed分だけ伸ばしたベクトルを足す
        // つまり、前方向にspeedずつ毎フレーム移動する
        transform.localPosition += transform.forward * speed;
    }

    // 当たり判定に何かオブジェクトが入ったときに呼ばれる
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name + "に当たったよ！");
        // もし当たったものが敵なら敵を消す
        // 敵のゲームオブジェクトのタグがEnemyなら
        if (other.gameObject.tag == "Enemy")
        {
            // 敵のコンポーネントをとってくる
            Enemy enemy = other.gameObject.GetComponent<Enemy>();

            // 敵の体力を減らす.
            enemy.HP = enemy.HP - 1;

            // 敵の体力がゼロ以下になったら消す
            if (enemy.HP <= 0)
            {
                Destroy(other.gameObject);
            }
        }
        // 当たったものが何であろうと自分（ショット）は消す
        Destroy(gameObject);
    }
}

