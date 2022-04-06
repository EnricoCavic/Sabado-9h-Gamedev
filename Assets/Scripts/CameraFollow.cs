using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform alvo;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 posAlvo = new Vector3(alvo.position.x, transform.position.y, alvo.position.z);
        transform.position = posAlvo;
    }
}
