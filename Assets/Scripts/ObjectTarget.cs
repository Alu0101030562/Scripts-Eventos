using System;
using UnityEngine;

public class ObjectTarget : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] private float _movementSpeed = 3f;
    [SerializeField] private float _accuracy = .01f;

    private Vector3 _distance;
    private bool _enableMovement;
    void Start()
    {
        CollectItem.OnItemCollected += GoTarget;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_enableMovement)
            return;

        _distance = _target.position - transform.position;
        _distance.y = 0;
        
        if (!(_distance.magnitude > _accuracy))
            return;
         
        transform.Translate(_distance.normalized * (_movementSpeed * Time.deltaTime), Space.World);
    }
    
    private void GoTarget()
    {
        _enableMovement = true;
        Debug.Log($"{gameObject.name} activado");
    }

    private void OnDestroy()
    {
        CollectItem.OnItemCollected -= GoTarget;
    }
}
