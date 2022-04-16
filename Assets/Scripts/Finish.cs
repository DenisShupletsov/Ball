using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Finish : MonoBehaviour
{
    public static UnityEvent OnFinish = new UnityEvent();
    bool isUserFinish;

    private void OnTriggerEnter(Collider other)
    {
        if(!isUserFinish && other.tag == "Sphere")
        {
            isUserFinish = true;
            OnFinish?.Invoke();
        }
    }
}
