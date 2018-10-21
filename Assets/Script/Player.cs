using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1;

    public static bool isDead;

    private Rigidbody2D rbody2D;


    private Animator anim;
    void Start()
    {
        rbody2D = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();

    }


    void Update()
    {
        float dirx = Input.GetAxisRaw("Horizontal");
        rbody2D.velocity = new Vector2(dirx * speed, rbody2D.velocity.y);


        if (dirx != 0){
            anim.SetInteger("state", 0);
        }else{
            anim.SetInteger("state", 1);
        }

        if (dirx * this.transform.localScale.x < 0)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x * -1, this.transform.localScale.y, 0);
        }
    }
}

