using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kareninposizyonu : MonoBehaviour
{
    Vector3 konum;
    

    void Start()
    {
        konum = transform.localPosition;
        
    }

    
    void Update()
    {
        
    }
    public void konumagerikoy()
    {
        transform.localPosition = konum;
    }
   
}
