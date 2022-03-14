
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yuvarlaklarveskor : MonoBehaviour
{
    GameObject skorsayacitext;
    int skorsayaci=0;
    string gecici;
    public bool carpmadurumu = false;
     GameObject circlebool2;
     GameObject circlebool3;
     GameObject circlebool7;
     GameObject circlebool11;
     GameObject circlebool13;
    int sayi = 0;
    public AudioSource daireyemermigeldimusic;

    void Start()
    {
        skorsayacitext = GameObject.Find("skorsayacitexti");
        circlebool2 = GameObject.Find("Circle1"); 
        circlebool3 = GameObject.Find("Circle2"); 
        circlebool7 = GameObject.Find("Circle3"); 
        circlebool11 = GameObject.Find("Circle4"); 
        circlebool13 = GameObject.Find("Circle5");
        
    }



    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "kareskormermisi")
        {
            if (DataManager.Instance.sescalsinmi)
            {
                daireyemermigeldimusic.Play();
            }
            else
            {
                daireyemermigeldimusic.Stop();
            }
            gecici = skorsayacitext.GetComponent<Text>().text;
            skorsayaci = System.Convert.ToInt32(gecici);
            skorsayaci++;
            skorsayacitext.GetComponent<Text>().text = skorsayaci.ToString();
            yuvarlakgorunur();


            Destroy(collision.gameObject);
        }
    }
    void yuvarlakgorunur()
    {
        
            
            rastgelesayi();
            if (sayi == 2)
            {
                circlebool2.SetActive(true);
                circlebool3.SetActive(false);


                circlebool7.SetActive(false);

                circlebool11.SetActive(false);

                circlebool13.SetActive(false);
                

            }
            else if (sayi == 3)
            {
                circlebool2.SetActive(false);
                circlebool3.SetActive(true);


                circlebool7.SetActive(false);

                circlebool11.SetActive(false);

                circlebool13.SetActive(false);
                
            }
            else if (sayi == 4)
            {
                circlebool2.SetActive(false);
                circlebool3.SetActive(false);


                circlebool7.SetActive(true);

                circlebool11.SetActive(false);

                circlebool13.SetActive(false);
               
            }
            else if (sayi == 5)
            {
                circlebool2.SetActive(false);
                circlebool3.SetActive(false);


                circlebool7.SetActive(false);

                circlebool11.SetActive(true);

                circlebool13.SetActive(false);
                
            }
            else if (sayi == 6)
            {
                circlebool2.SetActive(false);
                circlebool3.SetActive(false);


                circlebool7.SetActive(false);

                circlebool11.SetActive(false);

                circlebool13.SetActive(true);
                
            }
        }

    public void rastgelesayi()
    {
        sayi = Random.Range(1, 7);
    }
    public void yuvarlaklarigorunuryapreset()
    {
        
        gecici = skorsayacitext.GetComponent<Text>().text;
        skorsayaci = System.Convert.ToInt32(gecici);
        skorsayaci=0;
        skorsayacitext.GetComponent<Text>().text = skorsayaci.ToString();
        Time.timeScale = 1f;
    }
}
    
    




