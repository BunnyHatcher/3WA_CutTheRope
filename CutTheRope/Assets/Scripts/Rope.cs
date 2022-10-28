using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public Rigidbody2D _hook;
    public GameObject _linkPrefab;

    public int _linkAmount = 7;

    private void Start()
    {
        GenerateRope();
    }

    private void GenerateRope()
    {
        Rigidbody2D previousRB = _hook;
        for(int i = 0; i < _linkAmount; i++)
        {
            GameObject link = Instantiate(_linkPrefab, transform);
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = _hook;

            previousRB = link.GetComponent<Rigidbody2D>();
        }
    }
}
