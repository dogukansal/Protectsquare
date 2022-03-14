using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameovermusic : MonoBehaviour
{
    public static gameovermusic Instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sess()
    {
       gameObject.GetComponent<AudioSource>().Play();
      
        
    }
    public void sessdurdur()
    {
        gameObject.GetComponent<AudioSource>().Stop();
    }

    }
