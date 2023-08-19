using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    public float moveSpeed = 0.125f;
    private Transform rigTransform;
    public Vector3 offset;
    // Start is called before the first frame update
    private void LateUpdate() //Sử lí liên quan đến camera
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, moveSpeed * Time.deltaTime);
        //Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(10, 10, 10), 0.5f);

        transform.position = smoothedPosition;

        transform.LookAt(target);
    }

    
  
}
