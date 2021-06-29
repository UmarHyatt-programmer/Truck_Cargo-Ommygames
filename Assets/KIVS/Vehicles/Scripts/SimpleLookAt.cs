using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SimpleLookAt : MonoBehaviour 
{
    Transform _transf;
    public Transform lookAtTarget;

    public void OnEnable()
    {
        _transf = transform;
    }

    void Start()
    {
        _transf = transform;
    }

    void LateUpdate()
    {
        _transf.LookAt(lookAtTarget);
    }
}
