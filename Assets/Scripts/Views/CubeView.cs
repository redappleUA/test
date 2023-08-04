using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeView : BaseObjectView
{
    [SerializeField] Renderer _renderer;
    [SerializeField] Animator _animator;

    private void OnCollisionEnter(Collision collision)
    {
        ColorService.SetRandomColor(_renderer);
        _animator.SetTrigger("Hit");
    }
}
