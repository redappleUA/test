using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] float _speed;

    private Control _control;

    private void OnEnable() => _control.Map.Enable();
    private void OnDisable() => _control.Map.Disable();
    private void Awake() => _control = new();

    private void Update()
    {
        Move();
    }

    void Move()
    {
        var direction = _control.Map.Move.ReadValue<Vector3>() * _speed * Time.deltaTime;

        transform.DOBlendableMoveBy(direction, Time.deltaTime);
    }
}
