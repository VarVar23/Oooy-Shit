using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);

        if(transform.position.y < -2f)
        {
            GameObject.Find("SpawnPeople").GetComponent<SpawnPeople>().CountPeople--;
            Destroy(gameObject);
        }
    }
}
