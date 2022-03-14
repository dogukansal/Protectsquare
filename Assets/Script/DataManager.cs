using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public GameObject oyunbitisbutonu;
    public GameObject pausetusunugizle;
    public bool sarkicalsinmi=true;
    public bool sescalsinmi=true;
    public int enyuksekskor=0;
    public int reklamsayisi=0;
    
    EasyFileSave myFile;
    void Awake()
    {
        if (Instance ==null)
        {
            Instance = this;
            StartProcess();
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    
    void StartProcess()
    {
        myFile = new EasyFileSave();
        LoadData();

    }
    public void SaveData()
    {
        myFile.Add("sarkidurum", sarkicalsinmi);
        myFile.Add("sesdurum", sescalsinmi);
        myFile.Add("yuksekskor", enyuksekskor);
        myFile.Add("reklamdurum", reklamsayisi);
        myFile.Save();
    }

    public void LoadData()
    {
        if (myFile.Load())
        {
            sarkicalsinmi = myFile.GetBool("sarkidurum");
            sescalsinmi = myFile.GetBool("sesdurum");
            enyuksekskor = myFile.GetInt("yuksekskor");
            reklamsayisi = myFile.GetInt("reklamdurum");
        }
        
    }
    public void muzikk()
    {
        if (sarkicalsinmi)
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
        else
        {
            gameObject.GetComponent<AudioSource>().Stop();
        }
    }
    public void bitisekranibuton()
    {
        oyunbitisbutonu.SetActive(true);
        pausetusunugizle.SetActive(false);
    }
    
}
