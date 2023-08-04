using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SphereView : BaseObjectView
{
    public static UnityEvent<int> OnDestroy { get; private set; } = new();

    [SerializeField] int _scoreCounts = 1;

    private void OnCollisionEnter(Collision collision)
    {
        OnDestroy?.Invoke(_scoreCounts);
        Destroy(gameObject);
    }
}
