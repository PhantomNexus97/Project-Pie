using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour, IDataPersistence
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _turnSpeed = 360f;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Transform _model;

    private Vector3 _input;



    private void Update()
    {
        GatherInput();
        Look();
    }

     void FixedUpdate()
     {
        Move();
     }

    void GatherInput()
    {
        _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

    }
    private void Look()
    {
        if (_input == Vector3.zero) return;

        Quaternion rot = Quaternion.LookRotation(_input.ToIso(), Vector3.up);
        _model.rotation = Quaternion.RotateTowards(_model.rotation, rot, _turnSpeed * Time.deltaTime);
    }

    void Move()
    {
    _rb.MovePosition(transform.position + _input.ToIso() * _input.normalized.magnitude * _speed * Time.deltaTime);
    }

    public void LoadData(GameData data)
    {
        //this.transform.position = data._PlayerPosition;

    }

    public void SaveData(GameData data)
    {
        //data._PlayerPosition = this.transform.position;

    }



}


    



