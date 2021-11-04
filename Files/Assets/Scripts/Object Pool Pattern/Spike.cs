using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.name.Equals("Death Layer"))
        {
            Destroy(this.gameObject);
        }
    }
}
