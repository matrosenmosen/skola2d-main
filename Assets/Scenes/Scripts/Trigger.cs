using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject activeObject;
    public GameObject triggerObject;
    public bool setactive;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        activeObject.SetActive(setactive);
        Destroy(triggerObject);

    }
}
