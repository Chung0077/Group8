using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFire : MonoBehaviour
{
    public GameObject firePrefab;
    public Vector3 pos;
    public Transform target;


    public void Fire()
    {
        pos = this.transform.position;
        GameObject fire = Instantiate(firePrefab, pos, Quaternion.identity);
        fire.GetComponent<FireMagic>().target = target;
    }
}
