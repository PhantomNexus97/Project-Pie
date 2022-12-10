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
    [SerializeField] private VirtualJoystick inputSource;
    public RangedWeaponData weaponData;

    private Animator animator;

    private Vector3 _input;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }



    private void Update()
    {
        GatherInput();
        Look();

    }

     void FixedUpdate()
     {
        Move();
        if ( _rb.velocity.magnitude > 0) 
        {
            animator.SetBool("isMoving", true);
        }
        else if (_rb.velocity.magnitude < 1) 
        {
            animator.SetBool("isMoving", false);
        }

    }

    void GatherInput()
    {
        //_input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        _rb.velocity = inputSource.Direction;
    }
    private void Look()
    {
        if (inputSource.Direction == Vector3.zero) return;

      Quaternion rot = Quaternion.LookRotation(inputSource.Direction.ToIso(), Vector3.up);
      _model.rotation = Quaternion.RotateTowards(_model.rotation, rot, _turnSpeed * Time.deltaTime);
        

    }

    void Move()
    {
    _rb.MovePosition(transform.position + inputSource.Direction.ToIso() * inputSource.Direction.normalized.magnitude * _speed * Time.deltaTime);
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


    



