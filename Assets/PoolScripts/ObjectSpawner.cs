using System;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _objectPool; 
        
    protected IObjectPool Pool;

    protected void Awake()
    {
        Pool = _objectPool.GetComponent<IObjectPool>();
        if(Pool==null) Debug.LogError($"{_objectPool.name} dosen't implement {typeof(IObjectPool).Name}");
    }

    protected virtual void Spawn()
    {
        Pool.TryGetObject(out GameObject gO);
        gO.SetActive(true);
    }
    //there is one mor methods: ResetPool();
}