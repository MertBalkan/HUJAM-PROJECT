using System.Collections;
using System.Collections.Generic;
using HUJAM1.Abstracts.Movements;
using HUJAM1.Concretes.Movements;
using UnityEngine;

public class PropController : MonoBehaviour
{
    private IMove2D _move;
    private float _horDir;
    private float _verDir;

    private void Awake()
    {
        _move = new PropMovement(this);
    }

    private void OnEnable()
    {
        _horDir = Random.Range(0.1f, 0.2f);
        _verDir = Random.Range(0.1f, 0.2f);
    }

    private void Update()
    {
        _move.Move(_horDir, _verDir);
    }
}
