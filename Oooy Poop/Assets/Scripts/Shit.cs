using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shit : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _timeLife;

    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * _force, ForceMode.Impulse);
        Invoke(nameof(Destroy), _timeLife);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
