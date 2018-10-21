﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D other){

        if (other.gameObject.CompareTag("Player")){

            Player.isDead = true;
            //Debug.Break();
        }
    }
    
}
