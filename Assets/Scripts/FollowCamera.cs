using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] GameObject thingToFollow;
    // Camera position should be the same as the driver.

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -10);
    }
}
