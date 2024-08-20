using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ringcollision : MonoBehaviour
{
    public AudioSource rimhit;

    public void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player"){
            rimhit.Play();
        }
    }

}
