using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMagic : MonoBehaviour
{
    public GameObject explosion;
    Vector3 pos;
    public Transform target;
    private FollowTarget1 followTarget;

    private void Start()
    {
        followTarget = this.GetComponent<FollowTarget1>();
        followTarget.target = target.GetComponent<Dragon>().target;
    }

    public void Explosion()
    {
        pos = this.transform.position;
        Instantiate(explosion, pos, Quaternion.identity);
        Destroy(this.gameObject);
        target.GetComponent<Animator>().SetTrigger("Attacked");
    }
}
