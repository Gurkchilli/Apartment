using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public GameObject[] goArr;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            HideGos();
            SetActiveGo(0);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            HideGos();
            SetActiveGo(1);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            HideGos();
            SetActiveGo(2);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            HideGos();
            SetActiveGo(3);
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            HideGos();
            SetActiveGo(4);
        }

    }

    private void HideGos()
    {
        foreach(GameObject go in goArr)
        {
            go.SetActive(false);
        }
    }

    private void SetActiveGo(int index)
    {
        goArr[index].SetActive(true);
    }
}
