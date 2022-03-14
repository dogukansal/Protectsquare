using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UcgenManager : MonoBehaviour
{
    public Transform namluust1;
    public Transform namluust2;
    public Transform namluust3;
    public Transform namluust4;
    public Transform namluust5;
    public Transform namluust6;

    public Transform namlusol1;
    public Transform namlusol2;
    public Transform namlusol3;
    public Transform namlusol4;

    public Transform namlusag1;
    public Transform namlusag2;

    public Transform namlualt1;
    public Transform namlualt2;
    public Transform namlualt3;
    public Transform namlualt4;

    public Transform mermiust;
    public Transform mermisol;
    public Transform mermisag;
    public Transform mermialt;

    public Transform specialbullet;

    float zamanaeklespecial;
    float zamanspecial;

   

    float zamanaekle2;
    float zaman2;

    float zamanaekle3;
    float zaman3;

    float zamanaekle4;
    float zaman4;

    float zamanaekle5;
    float zaman5;

  

    float zamanaekle7;
    float zaman7;

    float zamanaekle8;
    float zaman8;

  

    float zamanaekle10;
    float zaman10;

    float zamanaekle11;
    float zaman11;

 

    float zamanaekle13;
    float zaman13;




    float zamanaekle16;
    float zaman16;

    float mermihizi = 400;
    float mermihizi2 = 70;
    void Start()
    {
        
   
        zamanaekle2 = 1.3f;
        zaman2 = Time.time;

        zamanaekle3 = 1.3f;
        zaman3 = Time.time;

        zamanaekle4 = 1.3f;
        zaman4 = Time.time;

        zamanaekle5 = 1.3f;
        zaman5 = Time.time;


        zamanaekle7 = 1.3f;
        zaman7 = Time.time;

        zamanaekle8 = 1.3f;
        zaman8 = Time.time;



        zamanaekle10 = 1.3f;
        zaman10 = Time.time;

        zamanaekle11 = 1.3f;
        zaman11 = Time.time;


        zamanaekle13 = 1.3f;
        zaman13 = Time.time;


        zamanaekle16 = 1.3f;
        zaman16 = Time.time;

        zamanspecial = Time.time;
        zamanaeklespecial = 5f;
        oyunuresetledim = false;

    }


    void Update()
    {
        

        if (!oyunuresetledim)
        {
            Invoke("shoot2", 1.5f);
            Invoke("shoot3", 1.1f);
            Invoke("shoot4", 1.4f);
            Invoke("shoot5", 1.7f);
            Invoke("shoot7", 1.1f);
            Invoke("shoot8", 1.4f);
            Invoke("shoot10", 1.2f);
            Invoke("shoot11", 1.1f);
            Invoke("shoot13", 1.7f);
            Invoke("shoot16", 1.5f);
        }
        
    }
    
    void shoot2()
    {
        Transform mermicik;
        Transform mermicik2;
        if (Time.time > zaman2)
        {
            mermicik = Instantiate(mermiust, namluust2.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namluust2.forward * mermihizi);
            zaman2 = Time.time + zamanaekle2;
        }
        if (Time.time > zamanspecial)
        {
            rastgelesayi();
            if (sayi == 2)
            {
                mermicik2 = Instantiate(specialbullet, namluust2.position, Quaternion.identity);
                mermicik2.GetComponent<Rigidbody2D>().AddForce(namluust2.forward * mermihizi2);
                zamanspecial = Time.time + zamanaeklespecial;
            }
        }
    }

    void shoot3()
    {
        Transform mermicik;
        Transform mermicik2;
        if (Time.time > zaman3)
        {
            mermicik = Instantiate(mermiust, namluust3.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namluust3.forward * mermihizi);
            zaman3 = Time.time + zamanaekle3;
        }
        if (Time.time > zamanspecial)
        {
            rastgelesayi();
            if (sayi == 3)
            {
                mermicik2 = Instantiate(specialbullet, namluust3.position, Quaternion.identity);
                mermicik2.GetComponent<Rigidbody2D>().AddForce(namluust3.forward * mermihizi2);
                zamanspecial = Time.time + zamanaeklespecial;
            }
        }
    }

    void shoot4()
    {
        Transform mermicik;
        Transform mermicik2;
        if (Time.time > zaman4)
        {
            mermicik = Instantiate(mermiust, namluust4.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namluust4.forward * mermihizi);
            zaman4 = Time.time + zamanaekle4;
        }
        if (Time.time > zamanspecial)
        {
            rastgelesayi();
            if (sayi == 4)
            {
                mermicik2 = Instantiate(specialbullet, namluust4.position, Quaternion.identity);
                mermicik2.GetComponent<Rigidbody2D>().AddForce(namluust4.forward * mermihizi2);
                zamanspecial = Time.time + zamanaeklespecial;
            }
        }
    }

    void shoot5()
    {
        Transform mermicik;
        Transform mermicik2;
        if (Time.time > zaman5)
        {
            mermicik = Instantiate(mermiust, namluust5.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namluust5.forward * mermihizi);
            zaman5 = Time.time + zamanaekle5;
        }
        if (Time.time > zamanspecial)
        {
            rastgelesayi();
            if (sayi == 5)
            {
                mermicik2 = Instantiate(specialbullet, namluust5.position, Quaternion.identity);
                mermicik2.GetComponent<Rigidbody2D>().AddForce(namluust5.forward * mermihizi2);
                zamanspecial = Time.time + zamanaeklespecial;
            }
        }
    }

   

    void shoot7()
    {
        Transform mermicik;
        Transform mermicik2;
        if (Time.time > zaman7)
        {
            mermicik = Instantiate(mermisag, namlusag1.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namlusag1.forward * mermihizi);
            zaman7 = Time.time + zamanaekle7;
        }
        if (Time.time > zamanspecial)
        {
            rastgelesayi();
            if (sayi == 6)
            {
                mermicik2 = Instantiate(specialbullet, namlusag1.position, Quaternion.identity);
                mermicik2.GetComponent<Rigidbody2D>().AddForce(namlusag1.forward * mermihizi2);
                zamanspecial = Time.time + zamanaeklespecial;
            }
        }
    }

    void shoot8()
    {
        Transform mermicik;
        Transform mermicik2;
        if (Time.time > zaman8)
        {
            mermicik = Instantiate(mermisag, namlusag2.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namlusag2.forward * mermihizi);
            zaman8 = Time.time + zamanaekle8;
        }
        if (Time.time > zamanspecial)
        {
            rastgelesayi();
            if (sayi == 7)
            {
                mermicik2 = Instantiate(specialbullet, namlusag2.position, Quaternion.identity);
                mermicik2.GetComponent<Rigidbody2D>().AddForce(namlusag2.forward * mermihizi2);
                zamanspecial = Time.time + zamanaeklespecial;
            }
        }
    }


    void shoot10()
    {
        Transform mermicik;
        Transform mermicik2;
        if (Time.time > zaman10)
        {
            mermicik = Instantiate(mermialt, namlualt2.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namlualt2.forward * mermihizi);
            zaman10 = Time.time + zamanaekle10;
        }
        if (Time.time > zamanspecial)
        {
            rastgelesayi();
            if (sayi ==8)
            {
                mermicik2 = Instantiate(specialbullet, namlualt2.position, Quaternion.identity);
                mermicik2.GetComponent<Rigidbody2D>().AddForce(namlualt2.forward * mermihizi2);
                zamanspecial = Time.time + zamanaeklespecial;
            }
        }
    }

    void shoot11()
    {
        Transform mermicik;
        Transform mermicik2;
        if (Time.time > zaman11)
        {
            mermicik = Instantiate(mermialt, namlualt3.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namlualt3.forward * mermihizi);
            zaman11 = Time.time + zamanaekle11;
        }
        if (Time.time > zamanspecial)
        {
            rastgelesayi();
            if (sayi == 9)
            {
                mermicik2 = Instantiate(specialbullet, namlualt3.position, Quaternion.identity);
                mermicik2.GetComponent<Rigidbody2D>().AddForce(namlualt3.forward * mermihizi2);
                zamanspecial = Time.time + zamanaeklespecial;
            }
        }
    }

   
    void shoot13()
    {
        Transform mermicik;
        Transform mermicik2;
        if (Time.time > zaman13)
        {
            mermicik = Instantiate(mermisol, namlusol1.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namlusol1.forward * mermihizi);
            zaman13 = Time.time + zamanaekle13;
        }
        if (Time.time > zamanspecial)
        {
            rastgelesayi();
            if (sayi == 10)
            {
                mermicik2 = Instantiate(specialbullet, namlusol1.position, Quaternion.identity);
                mermicik2.GetComponent<Rigidbody2D>().AddForce(namlusol1.forward * mermihizi2);
                zamanspecial = Time.time + zamanaeklespecial;
            }
        }
    }

   

    void shoot16()
    {
        Transform mermicik;
        Transform mermicik2;
        if (Time.time > zaman16)
        {
            mermicik = Instantiate(mermisol, namlusol4.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namlusol4.forward * mermihizi);
            zaman16 = Time.time + zamanaekle16;
        }
        if (Time.time > zamanspecial)
        {
            rastgelesayi();
            if (sayi == 11)
            {
                mermicik2 = Instantiate(specialbullet, namlusol4.position, Quaternion.identity);
                mermicik2.GetComponent<Rigidbody2D>().AddForce(namlusol4.forward * mermihizi2);
                zamanspecial = Time.time + zamanaeklespecial;
            }
        }
    }
    int sayi=0;
    
    public void rastgelesayi()
    {
        sayi = Random.Range(1, 12);
    }
    public static bool oyunuresetledim;
    public static void oyunuresetle()
    {
        oyunuresetledim = true;
    }
    public static void oyunuresetlevebasla()
    {
        oyunuresetledim = false;
    }



}