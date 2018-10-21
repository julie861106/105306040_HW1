//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Player : MonoBehaviour
//{
//    public float speed = 1;

//    public static bool isDead;

//    private Rigidbody2D rbody2D;


//    private Animator anim;
//    void Start()
//    {
//        rbody2D = gameObject.GetComponent<Rigidbody2D>();
//        anim = gameObject.GetComponent<Animator>();

//    }


//    void Update()
//    {
//        float dirx = Input.GetAxisRaw("Horizontal");
//        rbody2D.velocity = new Vector2(dirx * speed, rbody2D.velocity.y);


//        if (dirx != 0){
//            anim.SetInteger("state", 0);
//        }else{
//            anim.SetInteger("state", 1);
//        }

//        if (dirx * this.transform.localScale.x < 0)
//        {
//            this.transform.localScale = new Vector3(this.transform.localScale.x * -1, this.transform.localScale.y, 0);
//        }

//        Vector2 newDirection = new Vector2(dirx, 0);
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float forceX;//水平推力
    public static bool isDead;
    Rigidbody2D playerRigidBody2D;
    readonly float toLeft = -1;
    readonly float toRight = 1;
    readonly float stop = 0;
    float directionX;
    int state;

    private Animator anim;

    void Start()
    {
        isDead = false;
        playerRigidBody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        state = 0;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            directionX = toLeft;
            state = 1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            directionX = toRight;
            state = 1;
        }
        else
        {
            directionX = stop;
            state = 0;
        }
        Vector2 newDirection = new Vector2(directionX, 0);
        playerRigidBody2D.AddForce(newDirection * forceX);



        if (directionX * this.transform.localScale.x < 0)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x * -1, this.transform.localScale.y, 0);
        }

        anim.SetInteger("state", state);

    }
}
