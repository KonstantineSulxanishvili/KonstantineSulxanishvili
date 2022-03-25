using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScriptN5 : MonoBehaviour
{
  public float speed;
  public float jumpSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
          transform.Translate(Vector2.right * 0.02f);
          print("Right");
        }
         if(Input.GetKey(KeyCode.W))
        {
          transform.Translate(Vector2.up * 0.02f);
          print("Up");
        }
        if(Input.GetKey(KeyCode.A))
        {
          transform.Translate(Vector2.left * 0.02f);
          print("Left");
        }
        if(Input.GetKey(KeyCode.S))
        {
          transform.Translate(Vector2.down * 0.02f);
          print("Down");
        }
    }
}
