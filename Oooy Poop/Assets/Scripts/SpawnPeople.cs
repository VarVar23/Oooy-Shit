using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPeople : MonoBehaviour
{
    [SerializeField] private GameObject _people;

    [SerializeField] private int _maxCountPeople;
    public int CountPeople;
    private void Start()
    {
        Invoke(nameof(Spawn1), Random.Range(1, 5));
    }

    private void Spawn1()
    {
        if(CountPeople < _maxCountPeople)
        {
            Instantiate(_people, transform.position, transform.rotation);
            CountPeople++;
        }
        Invoke(nameof(Spawn2), Random.Range(2, 5));
    }

    private void Spawn2()
    {
        if (CountPeople < _maxCountPeople)
        {
            Instantiate(_people, transform.position, transform.rotation);
            CountPeople++;
        }
        Invoke(nameof(Spawn1), Random.Range(2, 5));
    }
}
