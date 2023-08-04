using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseObjectView : MonoBehaviour
{
    [SerializeField] Vector3 _scale;
    private void Start()
    {
        //Set custom scale
        transform.localScale = _scale;
    }
}
