using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelMediator : MonoBehaviour
{
    [SerializeField] CounterView _counter;

    private void Start()
    {
        SphereView.OnDestroy.AddListener((time) => _counter.Score += time);
    }

    private void OnDestroy() => SphereView.OnDestroy.RemoveAllListeners();
}
