using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform tf;
    private Vector3 standardCam = new Vector3(3.38f, 0.978f, 2.861f);
    private Vector3 standardRot = new Vector3(0,60,0);

    private Vector3 a1 = new Vector3(0,0,0);
    private Vector3 a2 = new Vector3(20, 0, 0);
    private Vector3 a3 = new Vector3(40, 0, 0);
    private Vector3 a4 = new Vector3(60, 0, 0);
    private Vector3 a5 = new Vector3(80, 0, 0);

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = tf.localEulerAngles;
        if (Input.GetKey(KeyCode.Alpha1))
        {
            tf.localPosition = a1 + standardCam;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            tf.localPosition = a2 + standardCam;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            tf.localPosition = a3 + standardCam;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            tf.localPosition = a4 + standardCam;
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            tf.localPosition = a5 + standardCam;
        }

    }
}
