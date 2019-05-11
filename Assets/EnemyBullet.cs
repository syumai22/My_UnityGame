using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    public Transform target;//追いかける対象-オブジェクトをインスペクタから登録できるように
    public float speed = 0.1f;//移動スピード
    private Vector3 vec;
    [SerializeField]
   

    Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        // 自分の位置を、自分の位置 ＋
        // 自分の向いている前方向ベクトル ✕ speedに変更する.
        //rigidBody.MovePosition(transform.position +
        //    transform.forward * speed);
        //targetの方に少しずつ向きが変わる
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 0.3f);

        //targetに向かって進む
        transform.position += transform.forward * speed;

    }

    // ものに当たったとき.
    private void OnTriggerEnter(Collider other)
	{
		// Goolに当たった時.
		if(other.gameObject.tag == "Gool")
		{
			// プレイヤーコンポーネントを変数に代入.
			Player player = other.gameObject.GetComponent<Player>();

			// ダメージの関数を呼ぶ.
			player.OnDamage(1);	// HPを「1」減らす
			
        }

		//// 自分自身を消す
		//Destroy(gameObject);
    }
}
