using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGameObject : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float range;
    [SerializeField] float speed;
    private Vector3 offset = new Vector3(1, 1, 1);
    Rigidbody followerRB;

    void Start()
    {
        followerRB = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float distanceBetweenObjects = Vector3.Distance(transform.position, target.transform.position);

        if (distanceBetweenObjects <= range)
        {
            followerRB.MovePosition(Vector3.Slerp(transform.position, target.transform.position, followerRB.mass * Time.fixedDeltaTime));
        }
    }
}
