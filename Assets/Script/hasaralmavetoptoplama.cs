using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hasaralmavetoptoplama : MonoBehaviour
{   //kýrmýzý top gelince ateþ etme tuþunu aktifleþtiriyorum
    public Button button;
    

    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ucgendengelen")
        {
            button.interactable = true;
            Destroy(collision.gameObject);
        }
    }
     
    
    
}
