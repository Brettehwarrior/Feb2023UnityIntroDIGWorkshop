using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class FollowHeight : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void Update()
    {
        if (target == null)
            return;
        
        if (transform.position.y < target.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);
        }
    }
}
