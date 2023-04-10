using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    /*
     * Objenin herhangi noktas�na de�di�imiz zaman da �al���yordu, bunun olmamas� i�in...
     * 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player") //Hiyerar�ideki ismi player m� diye kontrol ediyoruz...
        {
            collision.gameObject.transform.SetParent(transform); //Player'�n, hareketli platformumuzun �ocu�u olarak at�yoruz...
        } 
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player") 
        {
            collision.gameObject.transform.SetParent(null); //Player�, hiyerar�ideki yerine geri koyuyoruz...
        }

    }
    */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player") //Hiyerar�ideki ismi player m� diye kontrol ediyoruz...
        {
            collision.gameObject.transform.SetParent(transform); //Player'�n, hareketli platformumuzun �ocu�u olarak at�yoruz...
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null); //Player�, hiyerar�ideki yerine geri koyuyoruz...
        }
    }
}
