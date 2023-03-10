using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestorySelf : MonoBehaviour
{
    [SerializeField] float destoryTime = 5f;

    private void Start()
    {
        Destroy(this.gameObject, destoryTime);
    }
}
