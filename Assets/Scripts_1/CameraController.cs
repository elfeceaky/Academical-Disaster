using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /*Player ve Camera'n�n transform �zelliklerini ayr� ayr� kontrol etmek ve kameray� karakterden ba��ms�z olarak istedi�imiz
    gibi hareket ettirebilmek i�in bu Controller'� yazd�k.
    */
    [SerializeField] private Transform player;

    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
