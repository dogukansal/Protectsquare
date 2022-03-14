using System.Collections;
using System.Collections.Generic;
using TigerForge;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class arayuz : MonoBehaviour
{
    
    public GameObject bestskorsayaci;
    public GameObject duvarlar;
    public GameObject squarelar;
    public GameObject movelar;
    public GameObject pausetusu;
    public GameObject arayuzukapat;
    public GameObject htpyifoto;
    public GameObject htpyifoto2;
    public GameObject htpyitext;
    public GameObject pauseekrani;
    public GameObject joystk;
    bool fotodurumu=true;
    float zamandurumu=1f;
    //oyunu hizlandirmanin altýndaki ýþýklar
    public GameObject oyunuhizlandir1;
    public GameObject oyunuhizlandir2;
    public GameObject oyunuhizlandir3;
    public GameObject oyunuhizlandir4;
    public GameObject oyunuhizlandir5;
    public GameObject oyunuhizlandir6;
    public GameObject oyunuhizlandir7;
    
    
    public Sprite muzikresim;
    public Sprite sesresim;
    public Sprite muzikresimkes;
    public Sprite sesresimkes;
    public Button muzikbutonu;
    public Button sesbutonu;

    public GameObject bestskor;

    public GameObject oyunbitincegelenbuton;

    GameObject circlebool2;
    GameObject circlebool3;
    GameObject circlebool7;
    GameObject circlebool11;
    GameObject circlebool13;
    AdmobManager admobManager;
     void Awake()
    {
        admobManager = Object.FindObjectOfType<AdmobManager>(); 
    }
    void Start()
    {
        Time.timeScale = 0f;
        DataManager.Instance.SaveData();


        if (DataManager.Instance.sarkicalsinmi)
        {
            
            muzikbutonu.image.sprite = muzikresim;
            DataManager.Instance.muzikk();
        }
        else if (!DataManager.Instance.sarkicalsinmi)
        {
           
            muzikbutonu.image.sprite = muzikresimkes;
            DataManager.Instance.muzikk();
        }

        if (DataManager.Instance.sescalsinmi)
        {
            sesbutonu.image.sprite = sesresim;
        }
        else if (!DataManager.Instance.sescalsinmi)
        {
            sesbutonu.image.sprite = sesresimkes;
        }
        sayi = DataManager.Instance.enyuksekskor;
        bestskor.GetComponent<Text>().text = sayi.ToString();
        circlebool2 = GameObject.Find("Circle1");
        circlebool3 = GameObject.Find("Circle2");
        circlebool7 = GameObject.Find("Circle3");
        circlebool11 = GameObject.Find("Circle4");
        circlebool13 = GameObject.Find("Circle5");
        
    }

    
    
    public void oyunabasla()
    {
        
        pausetusu.SetActive(true);
        bestskorsayaci.SetActive(false);
        duvarlar.SetActive(true);
        squarelar.SetActive(true);
        movelar.SetActive(true);
        arayuzukapat.SetActive(false);
        joystk.SetActive(true);
        circlebool2.SetActive(true);
        circlebool3.SetActive(false);
        circlebool7.SetActive(false);
        circlebool11.SetActive(false);
        circlebool13.SetActive(false);
        Time.timeScale = 1f;
        UcgenManager.oyunuresetlevebasla();
        hizlandirmaresimlerinikapat();
        admobManager.HideBanner();
    }
    public void oyunudurdur()
    {
        Time.timeScale = 0f;
        pauseekrani.SetActive(true);
        admobManager.ShowBanner();
    }
    public void oyunudevamet()
    {
        Time.timeScale = zamandurumu;
        pauseekrani.SetActive(false);
        admobManager.HideBanner();
    }
    public void nasiloynaniriac()
    {
        if (fotodurumu)
        {
            htpyifoto.SetActive(true); 
            htpyifoto2.SetActive(true);
            htpyitext.SetActive(true);
            fotodurumu = false;
        }
        else
        {
            htpyifoto.SetActive(false);
            htpyifoto2.SetActive(false);
            htpyitext.SetActive(false);
            fotodurumu = true;
        }
    }
    
    public void musicstop()
    {
        
        if (DataManager.Instance.sarkicalsinmi)
        {
            
            DataManager.Instance.sarkicalsinmi = false;
            DataManager.Instance.SaveData();
            DataManager.Instance.muzikk();
            muzikbutonu.image.sprite = muzikresimkes;
            
            


        }
        else if (!DataManager.Instance.sarkicalsinmi)
        
        {
            
            DataManager.Instance.sarkicalsinmi = true;
            DataManager.Instance.SaveData();
            DataManager.Instance.muzikk();
            muzikbutonu.image.sprite = muzikresim;
        }
    }
    public void sesstop()
    {
        
        if (DataManager.Instance.sescalsinmi)
        {
            DataManager.Instance.sescalsinmi = false;
            DataManager.Instance.SaveData();
            sesbutonu.image.sprite = sesresimkes;
        }
        else if(!DataManager.Instance.sescalsinmi)
        {
            DataManager.Instance.sescalsinmi = true;
            DataManager.Instance.SaveData();
            sesbutonu.image.sprite = sesresim;
        }
    }
    public void anamenuyedon()
    {
        pausetusu.SetActive(false);
        bestskorsayaci.SetActive(true);
        duvarlar.SetActive(false);
        squarelar.SetActive(false);
        movelar.SetActive(false);
        pauseekrani.SetActive(false);
        arayuzukapat.SetActive(true);
        joystk.SetActive(false);
        oyunbitincegelenbuton.SetActive(false);
        if (DataManager.Instance.sarkicalsinmi)
        {

            muzikbutonu.image.sprite = muzikresim;
            
        }
        else if (!DataManager.Instance.sarkicalsinmi)
        {

            muzikbutonu.image.sprite = muzikresimkes;
            
        }

        if (DataManager.Instance.sescalsinmi)
        {
            sesbutonu.image.sprite = sesresim;
        }
        else if (!DataManager.Instance.sescalsinmi)
        {
            sesbutonu.image.sprite = sesresimkes;
        }
        sayi = DataManager.Instance.enyuksekskor;
        bestskor.GetComponent<Text>().text = sayi.ToString();
        circlebool2.SetActive(false);
        circlebool3.SetActive(false);
        circlebool7.SetActive(false);
        circlebool11.SetActive(false);
        circlebool13.SetActive(false);
        admobManager.ShowBanner();

    }
    int sayi = 0;
    int sayi2 = 0;
    public void oyunuhizlandir()
    {
        if (sayi2 == 0)
        {
            zamandurumu = 1.10f;

            sayi2++;
            oyunuhizlandir1.SetActive(true);
}
        else if (sayi2 == 1)
        {
            oyunuhizlandir2.SetActive(true);
            zamandurumu = 1.20f;
            sayi2++;

        }
        else if (sayi2 == 2)
        {
            oyunuhizlandir3.SetActive(true);
            zamandurumu = 1.30f;
            sayi2++;
        }
        else if (sayi2 == 3)
        {
            oyunuhizlandir4.SetActive(true);
            zamandurumu = 1.40f;
            sayi2++;
        }
        else if (sayi2 == 4)
        {
            oyunuhizlandir5.SetActive(true);
            zamandurumu = 1.50f;
            sayi2++;
        }
        else if (sayi2 == 5)
        {
            oyunuhizlandir6.SetActive(true);
            zamandurumu = 1.60f;
            sayi2++;
        }
        else if (sayi2 == 6)
        {
            oyunuhizlandir7.SetActive(true);
            zamandurumu = 1.70f;
            sayi2++;
        }
        else if (sayi2 == 7)
        {
            hizlandirmaresimlerinikapat();
            zamandurumu = 1f;
            sayi2 = 0;
        }

    }
    void hizlandirmaresimlerinikapat()
    {
        oyunuhizlandir1.SetActive(false);
        oyunuhizlandir2.SetActive(false);
        oyunuhizlandir3.SetActive(false);
        oyunuhizlandir4.SetActive(false);
        oyunuhizlandir5.SetActive(false);
        oyunuhizlandir6.SetActive(false);
        oyunuhizlandir7.SetActive(false);
    }
}
