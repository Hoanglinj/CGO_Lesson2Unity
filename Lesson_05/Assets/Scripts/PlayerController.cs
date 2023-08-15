using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum TargetEnum
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
    }

    public float speed;
    
    public Transform topLeftTarget;
    public Transform topRightTarget;
    public Transform bottomLeftTarget;
    public Transform bottomRightTarget;

    private Transform currentTarget;
    private TargetEnum nextTarget = TargetEnum.TopLeft; 

    private void PlayMode()
    {
        if (Input.GetKey(KeyCode.M))
        {
            mode = DriveMode.Manual;
        }
        if (Input.GetKey(KeyCode.N))
        {
            mode = DriveMode.Automatic;
        }
    }
    public enum DriveMode { Manual, Automatic }
    public DriveMode mode = DriveMode.Manual;

    
    void Start()
    {
        currentTarget = topLeftTarget;
    }


    private void Update()
    {
        if (mode == DriveMode.Automatic)
        {
            
            AutoDrive();
        }
        else if (mode == DriveMode.Manual)
        {
            
            ManualDrive();
        }
    }

    private void AutoDrive()
    {
        

        Vector3 targetPosition = currentTarget.position;
        Vector3 moveDirection = targetPosition - transform.position;

        float distance = moveDirection.magnitude;

        if (distance > 0.1f)
        {
            
            transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);
        }
        else
        {
            
            SetNextTarget(nextTarget);
        }

        
        Vector3 direction = currentTarget.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = targetRotation;

    }

    private void ManualDrive()
    {
        
        float horizontalMove = Input.GetAxis("Horizontal"); 
        float verticalMove = Input.GetAxis("Vertical"); 
        Vector3 movement = new Vector3(horizontalMove, 0f, verticalMove) * speed * Time.deltaTime;

        
        transform.Translate(movement);
    }



    private void SetNextTarget(TargetEnum target)
    {
        switch (target)
        {
            case TargetEnum.TopLeft:
                currentTarget = topLeftTarget;
                nextTarget = TargetEnum.TopRight;
                break;
            case TargetEnum.TopRight:
                currentTarget = topRightTarget;
                nextTarget = TargetEnum.BottomLeft;
                break;
            case TargetEnum.BottomLeft:
                currentTarget = bottomLeftTarget;
                nextTarget = TargetEnum.BottomRight;
                break;
            case TargetEnum.BottomRight:
                currentTarget = bottomRightTarget;
                nextTarget = TargetEnum.TopLeft;
                break;
        }
    }
}
