using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using UnityEngine;

public class ObjectPool : MonoBehaviour,IObjectPool
{
    [SerializeField] private GameObject _gameObjectToPool;
    [SerializeField] private int _capacity;
    
    private List<GameObject> _pool;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _pool = new List<GameObject>(_capacity);
        for (int i = 0; i < _capacity; i++)
        {
            GameObject gO = Instantiate(_gameObjectToPool, this.transform); 
            gO.SetActive(false);
            _pool.Add(gO);
        }
    }

    bool IObjectPool.TryGetObject(out GameObject gameObject)
    {
        gameObject = _pool.First((gO) => gO.activeSelf == false); //кидає ексепшин при пустому пулі
        return gameObject != null;
    }

    void IObjectPool.ResetPool()
    {
        foreach (var gO in _pool)
        {
            gO.SetActive(false);
        }
    }
}