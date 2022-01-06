using System.Collections;
using UnityEngine;

class ObjectSpawnerWithTimer : ObjectSpawner
{
    [SerializeField] private float _timeToSpawn;

    protected void Start()
    {
        StartCoroutine(SpawnWithTime());
    }
    private IEnumerator SpawnWithTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(_timeToSpawn);
            base.Spawn();
        }
    }
}