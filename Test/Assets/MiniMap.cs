using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{

    public Transform playerPferd;


    void LateUpdate()
    {
        Vector3 newPosition = playerPferd.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f , playerPferd.eulerAngles.y , 0f);
    }


}
