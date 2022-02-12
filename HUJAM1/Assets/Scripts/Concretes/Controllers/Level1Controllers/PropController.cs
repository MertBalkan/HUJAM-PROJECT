using System.Collections;
using System.Collections.Generic;
using HUJAM1.Abstracts.Components;
using HUJAM1.Abstracts.Movements;
using HUJAM1.Concretes.Movements;
using UnityEngine;

public class PropController : RotateComponent
{
    [Range(0, 0.9f)]
    [SerializeField] private float _horMinRanValue;
    [Range(0, 0.9f)]
    [SerializeField] private float _horMaxRanValue;
    [Range(0, 0.9f)]
    [SerializeField] private float _verMinRanValue;
    [Range(0, 0.9f)]
    [SerializeField] private float _verMaxRanValue;
    private IMove2D _move;
    private float _horDir;
    private float _verDir;

    private void Awake()
    {
        _move = new PropMovement(this);
    }

    private void OnEnable()
    {
        _horDir = Random.Range(_horMinRanValue, _horMaxRanValue);
        _verDir = Random.Range(_verMinRanValue, _verMaxRanValue);
    }

    protected override void Update()
    {
        base.Update();
        _move.Move(_horDir, _verDir);
    }
}
