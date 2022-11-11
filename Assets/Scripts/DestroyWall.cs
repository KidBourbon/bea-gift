using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    // Deactivates the parent of this gameobject if it triggers with a bound
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bound"))
        {
            transform.parent.gameObject.SetActive(false);
        }
    }
}
