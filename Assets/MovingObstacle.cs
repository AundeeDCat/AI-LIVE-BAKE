using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField] private float speed;

    private bool isSwitchDir = false;

    void Update()
    {
        if(!isSwitchDir)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if(isSwitchDir)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if(transform.position.z >= 20)
        {
            isSwitchDir = true;
        }
        if (transform.position.z <= -20)
        {
            isSwitchDir = false;
        }
    }
}
