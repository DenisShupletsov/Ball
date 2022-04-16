using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SphereControl : MonoBehaviour
{
    [SerializeField] Rigidbody sphereRigidbody;
    [SerializeField] float force = 100;

    public static UnityEvent OnFall = new UnityEvent();

    void FixedUpdate()
    {
        MoveSphere(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if(gameObject.transform.position.y <= -1f)
        {
            OnFall?.Invoke();
        }
    }

    void MoveSphere(float horizontalInput, float verticalInput)
    {
        sphereRigidbody.AddForce(new Vector3(horizontalInput, 0, verticalInput) * force * Time.deltaTime);
    }
}
