using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShit : MonoBehaviour
{
    [SerializeField] private GameObject _shit;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(_shit, transform.position, transform.rotation);
        }
    }
}
