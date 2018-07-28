using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDino : MonoBehaviour
{
    public int MoveForwardFactor = 3;
    public int ChangeDirectionMaxAmblitude = 90;
    public Transform MoveTowardsPoint;

    int changeDirectionAmblitude = 0;
    float oldYRotationValue = 0;
    bool changeDirection = false;

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * MoveForwardFactor);
        transform.position = Vector3.MoveTowards(transform.position, MoveTowardsPoint.position, 0.1f);

        if (changeDirection)
        {
            changeDirectionAmblitude--;
            //transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + 1, transform.rotation.z);
            transform.rotation = Quaternion.Euler(0, +oldYRotationValue + ChangeDirectionMaxAmblitude - changeDirectionAmblitude, 0);
            if (changeDirectionAmblitude < 0)
                changeDirection = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.name.Contains("Terrain") && !collision.gameObject.name.Contains("velociraptor"))
        {
            changeDirectionAmblitude = ChangeDirectionMaxAmblitude;
            oldYRotationValue = transform.eulerAngles.y;
            changeDirection = true;
        }
    }
}
