using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f))
        {
            Debug.Log("Hit name: " + hit.collider.gameObject.name);
            Debug.Log("Hit point: " + hit.point);
            Debug.Log("Distance : " + hit.distance);
           
        }

        Debug.DrawRay(ray.origin, ray.direction * 1000f, Color.red);


        RaycastHit[] hits = Physics.RaycastAll(ray);

        foreach(RaycastHit h in hits)
        {
            Debug.Log("Hit name: " + hit.collider.gameObject.name);
        }
    }
}
