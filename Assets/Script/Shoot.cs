using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float sakana;
    private void Update()
    {
        transform.Translate(Vector3.forward);
        if (gameObject)
        {
            Destroy(gameObject, sakana);
        }
    }
}
