using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject playerVehicle;
    [SerializeField] private Vector3 offset;

    private void Update()
    {
        transform.position = playerVehicle.transform.position + offset;
    }
}
