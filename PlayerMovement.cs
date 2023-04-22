using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Playerchar;

    public float mousex;
    public float mousey;

    public float playerLocationx;
    public float playerLocationy;

    //Vector3 Destination;

    void Start()
    {
        playerLocationx = Playerchar.transform.position.x;
        playerLocationy = Playerchar.transform.position.y;
    }


    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousex = (mousePos.x);
        mousey = (mousePos.y);

        playerLocationx = Playerchar.transform.position.x;
        playerLocationy = Playerchar.transform.position.y;

}
}
