using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget1 : MonoBehaviour
{
    public Transform target;
    [SerializeField] float speed = 10;
    [SerializeField] float stopDistance = 2;


    void Update()
    {
        Vector3 a, b;
        a = target.transform.position;
        b = transform.position;

        if (Vector3.Distance(a, b) > stopDistance)
        {
            Vector3 direction = a - b;
            direction = direction.normalized;
            transform.position += direction * Time.deltaTime * speed;
            transform.rotation = Quaternion.LookRotation(direction);
        }



    }
    public float Map(float x, float in_min, float in_max, float out_min, float out_max)
    {
        return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
    }
}
