using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ozelmermi : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody2D>();
        if (DataManager.Instance.sescalsinmi)
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
        else
        {
            gameObject.GetComponent<AudioSource>().Stop();
        }
        Destroy(gameObject, 10f);
    }

    
    
    
}
