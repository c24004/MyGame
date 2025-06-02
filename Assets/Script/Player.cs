using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool pw;
    private void Start()
    {
        
        
        bool pa = Input.GetKeyDown(KeyCode.A);
        bool pd = Input.GetKeyDown(KeyCode.D);
    }
    private void Update()
    {
        pw = Input.GetKeyDown(KeyCode.W);
        if (pw)
        {
            transform.Translate(0, 1, 0);
        }
        bool ps = Input.GetKeyDown(KeyCode.S);
        if (ps)
        {
            transform.Translate(0, -1, 0);
        }
    }
}
