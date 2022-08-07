using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndBoxScript : MonoBehaviour
{
    Rigidbody endboxRB;
    private bool isActivated = false;
    [SerializeField] private Vector3 endPosition;
    [SerializeField] private float speed;

    private void Start()
    {
        endboxRB = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(isActivated)
            Move();
    }
    public void Move()
    {
        endboxRB.MovePosition(transform.position + (endPosition - transform.position).normalized * speed * Time.fixedDeltaTime);
        if (Vector3.Distance(transform.position,endPosition) < 0.1f)
            isActivated = false;
    }

    public void Activate()
    {
        isActivated = true;
    }
}
