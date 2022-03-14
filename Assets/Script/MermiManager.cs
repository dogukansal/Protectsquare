using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MermiManager : MonoBehaviour
{
    Rigidbody2D rb;
    public bool yonust = false;
    public bool yonalt = false;
    public bool yonsag = false;
    public bool yonsol = false;
    public bool specialbullet = false;
    public bool normalbullet;
    
    float lifetime=2.5f;

    GameObject skorsayacitext;
    
    string gecici;
    int skorsayaci = 0;
    AdmobFullscren AdmobFullscren ;


    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody2D>();
        yuzunudondur();
        if (specialbullet)
        {
            
            Destroy(gameObject, 10f);

        }
        else
        {
            Destroy(gameObject, lifetime);
        }

        skorsayacitext = GameObject.Find("skorsayacitexti");
        AdmobFullscren = Object.FindObjectOfType<AdmobFullscren>();
    }

    
    void yuzunudondur()
    {
        if (yonsol)
        {
            rb.transform.eulerAngles = new Vector3(
            rb.transform.eulerAngles.x,
            rb.transform.eulerAngles.y + 180,
            rb.transform.eulerAngles.z
            );
        }
        else if (yonsag)
        {
            rb.transform.eulerAngles = new Vector3(
          rb.transform.eulerAngles.x,
          rb.transform.eulerAngles.y,
          rb.transform.eulerAngles.z
          );
        }
        else if (yonust)
        {
            rb.transform.eulerAngles = new Vector3(
          rb.transform.eulerAngles.x,
          rb.transform.eulerAngles.y,
          rb.transform.eulerAngles.z+270
          );
        }
        else if (yonalt)
        {
            rb.transform.eulerAngles = new Vector3(
          rb.transform.eulerAngles.x,
          rb.transform.eulerAngles.y,
          rb.transform.eulerAngles.z+90
          );
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "karekalkan" && normalbullet)
        {
            Destroy(gameObject);
        }
        if (collision.tag == "kare" && normalbullet)
        {
            Time.timeScale = 0f;

            gecici = skorsayacitext.GetComponent<Text>().text;
            skorsayaci = System.Convert.ToInt32(gecici);
            if (skorsayaci > DataManager.Instance.enyuksekskor)
            {
                DataManager.Instance.enyuksekskor = skorsayaci;
            }

            DataManager.Instance.SaveData();
            if (DataManager.Instance.sescalsinmi)
            {
                gameovermusic.Instance.sess();
            }
            else
            {
                gameovermusic.Instance.sessdurdur();
            }

            DataManager.Instance.bitisekranibuton();
            DataManager.Instance.reklamsayisi++;
            DataManager.Instance.SaveData();
            if (DataManager.Instance.reklamsayisi > 9)//9
            {
                AdmobFullscren.reklamiyukle();


            }

            if (DataManager.Instance.reklamsayisi > 13)//13
            {
                AdmobFullscren.GameOver();
                DataManager.Instance.reklamsayisi = 0;
                Time.timeScale = 0f;

            }
            Time.timeScale = 0f;
        }
    }
    
}
