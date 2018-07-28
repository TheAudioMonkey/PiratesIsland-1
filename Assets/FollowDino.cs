using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDino : MonoBehaviour
{

    public Transform MasterDino;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, MasterDino.position, 0.1f);
        transform.LookAt(MasterDino);
    }
}
