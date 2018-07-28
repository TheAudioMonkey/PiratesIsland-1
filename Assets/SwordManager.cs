using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordManager : MonoBehaviour
{

    void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            if (Input.GetMouseButtonDown(0))
            {

                Debug.Log("button pressed");
                GetComponent<Animator>().SetTrigger("Hit");

            }
        }
    }
}
