using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ILikeScriot : MonoBehaviour
{
    public int hp = 100;
    // Use this for initialization
    void Start ()
    {
       
    }

    // Update is called once per frame
    void Update ()
    {
        Rigidbody myRigid = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRigid.AddForce(new Vector3(0, 30.0f, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            myRigid.AddForce(new Vector3(0, -30.0f, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigid.AddForce(new Vector3(30.0f, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigid.AddForce(new Vector3(-30.0f, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hp = hp - 20;
            Debug.Log("動物かわいい:" + hp);
        }
        if (hp == 0)
        {
            Debug.Log("はい！ひょっこりはん！");
        }
    }
}
