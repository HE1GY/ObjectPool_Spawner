using UnityEngine;
public interface IObjectPool
{
    bool TryGetObject(out GameObject gO);
    void ResetPool();
}