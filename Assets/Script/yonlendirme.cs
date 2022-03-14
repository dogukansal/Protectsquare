using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yonlendirme : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject ucgen;

    public bool yonusttrue=false;
    

    public bool yonalttrue = false;
    

    public bool yonsoltrue = false;
    

    public bool yonsagtrue = false;

    //karenin etrafýndaki yuvarlaklarý yönüne göre açýp kapýyor
    public GameObject ucgenustyuvarlak;
    public GameObject ucgenaltyuvarlak;
    public GameObject ucgensolyuvarlak;
    public GameObject ucgensagyuvarlak;
     bool ustte = false;
     bool altta = false;
     bool solda = false;
     bool sagda = false;
    //mermi fýrlatma butonu
    public Button mermibutonu;
    //namlular
    public Transform namlumermiust;
    public Transform namlumermisol;
    public Transform namlumermisag;
    public Transform namlumermialt;
    //mermi
    public Transform ozelmermi;

    public Joystick joystick;
    void Start()
    {
        rb = ucgen.GetComponent<Rigidbody2D>();
        ucgenustyuvarlak.SetActive(true);
        mermibutonu.interactable = false;
    }
    
    
    void Update()
    {
        movesol();
        moveust();
        //movealt();
        //movesag();
    }

    public void ateset()
    {
        if (ustte)
        {
            Transform mermicik;
            mermicik = Instantiate(ozelmermi, namlumermiust.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namlumermiust.forward * 200);
            mermibutonu.interactable = false;
        }
        else if (altta)
        {
            Transform mermicik;
            mermicik = Instantiate(ozelmermi, namlumermialt.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namlumermialt.forward * 200);
            mermibutonu.interactable = false;
        }
        else if (solda)
        {
            Transform mermicik;
            mermicik = Instantiate(ozelmermi, namlumermisol.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namlumermisol.forward * 200);
            mermibutonu.interactable = false;
        }
        else if (sagda)
        {
            Transform mermicik;
            mermicik = Instantiate(ozelmermi, namlumermisag.position, Quaternion.identity);
            mermicik.GetComponent<Rigidbody2D>().AddForce(namlumermisag.forward * 200);
            mermibutonu.interactable = false;
        }



    }


    
    public void movesol()
    {
        if (joystick.Horizontal <= -.5f) //yonsoltrue
        {

            rb.velocity = new Vector2(-3, rb.velocity.y);
            ucgensolyuvarlak.SetActive(true);
            ucgenaltyuvarlak.SetActive(false);
            ucgensagyuvarlak.SetActive(false);
            ucgenustyuvarlak.SetActive(false);
             ustte = false;
             altta = false;
             solda = true;
             sagda = false;

        }
        else if (joystick.Horizontal >= .5f) //yonsagtrue
        {
            rb.velocity = new Vector2(3, rb.velocity.y);
            ucgensolyuvarlak.SetActive(false);
            ucgenaltyuvarlak.SetActive(false);
            ucgensagyuvarlak.SetActive(true);
            ucgenustyuvarlak.SetActive(false);
            ustte = false;
            altta = false;
            solda = false;
            sagda = true;
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        


    }
    public void movesag()
    {
        if (joystick.Horizontal >= .2f) //yonsagtrue
        {
            rb.velocity = new Vector2(4, rb.velocity.y);
            ucgensolyuvarlak.SetActive(false);
            ucgenaltyuvarlak.SetActive(false);
            ucgensagyuvarlak.SetActive(true);
            ucgenustyuvarlak.SetActive(false);
             ustte = false;
             altta = false;
             solda = false;
             sagda = true;
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

    }
    public void moveust()
    {
        if (joystick.Vertical >= .5f) //yonustture
        {
            rb.velocity = new Vector2(rb.velocity.x, 3);
            ucgensolyuvarlak.SetActive(false);
            ucgenaltyuvarlak.SetActive(false);
            ucgensagyuvarlak.SetActive(false);
            ucgenustyuvarlak.SetActive(true);
             ustte = true;
             altta = false;
             solda = false;
             sagda = false;
        }
        else if (joystick.Vertical <= -.5f) //yonaltrue
        {
            rb.velocity = new Vector2(rb.velocity.x, -3);
            ucgensolyuvarlak.SetActive(false);
            ucgenaltyuvarlak.SetActive(true);
            ucgensagyuvarlak.SetActive(false);
            ucgenustyuvarlak.SetActive(false);
            ustte = false;
            altta = true;
            solda = false;
            sagda = false;
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }

    }
    public void movealt()
    {
        if (joystick.Vertical <= -.2f) //yonaltrue
        {
            rb.velocity = new Vector2(rb.velocity.x, -5);
            ucgensolyuvarlak.SetActive(false);
            ucgenaltyuvarlak.SetActive(true);
            ucgensagyuvarlak.SetActive(false);
            ucgenustyuvarlak.SetActive(false);
             ustte = false;
             altta = true;
             solda = false;
             sagda = false;
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
        
    }

    public void trueust()
    {
        yonusttrue = true;
    }
    public void falseust()
    {
        yonusttrue = false;
        rb.velocity = new Vector2(rb.velocity.x, 0 );
    }
    public void truesag()
    {
        yonsagtrue = true;
    }
    public void falsesag()
    {
        yonsagtrue = false;
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
    public void truealt()
    {
        yonalttrue = true;
    }
    public void falsealt()
    {
        yonalttrue = false;
        rb.velocity = new Vector2(rb.velocity.x, 0);
    }
    public void truesol()
    {
        yonsoltrue = true;
        
    }
    public void falsesol()
    {
        yonsoltrue = false;
        rb.velocity = new Vector2(0, rb.velocity.y);
    }

    public void oyunuresetle()
    {
        ucgen.SetActive(false);
        mermibutonu.interactable = false;
    }
}
