using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

internal class ExamplePlayer :MonoBehaviour, IHasHealthBar,IHasPointBar
{
    public event UnityAction<int, int> HealthChange;
    public event UnityAction<int, int> PointChange;

    private void Start()
    {
        print("I am here");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.gameObject.SetActive(false);
        }
        
    }

}