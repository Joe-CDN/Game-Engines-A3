using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.name.Equals("Death Layer"))
        {
            Destroy(this.gameObject);
        }
    }
}
