using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolManager : MonoBehaviour
{

    private bool needsReload = true;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            if (Input.GetMouseButtonDown(0) && !needsReload)
            {
                needsReload = true;
                Debug.Log("button pressed");
                GetComponent<Animation>().Play("shot", PlayMode.StopSameLayer);

            }
            if (Input.GetKeyDown(KeyCode.R) && needsReload)
            {
                Debug.Log("reload ");
                GetComponent<Animation>().Play("charging", PlayMode.StopSameLayer);
                needsReload = false;
            }
            //Vector3 mousePosition = Input.mousePosition;
            //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            //transform.rotation = Quaternion.FromToRotation(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z), mousePosition);
            //transform.rotation = Quaternion.Slerp(transform.rotation, to.rotation, Time.deltaTime * speed);
        }

        //Vector3 mousePosition = Input.mousePosition;
        //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        ////Quaternion.loo
        //transform.LookAt(mousePosition);
        //transform.rotation = Quaternion.LookRotation(mousePosition);
    }
}
