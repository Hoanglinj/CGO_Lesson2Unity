using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    public Rigidbody2D rb;
    public int tocDo = 4;
    public float traiPhai;
    public bool isFacingRight = true;

    public Animator anim;
    private void Start()
    {

    }

    private void Update()
    {
        traiPhai = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(traiPhai * tocDo, rb.velocity.y);

        if (isFacingRight == true && traiPhai == -1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            isFacingRight = false;
        }

        if (isFacingRight == false && traiPhai == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
            isFacingRight = true;
        }

        //Animation
        anim.SetFloat("dichuyen", Mathf.Abs(traiPhai));
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("tancong");
        }

    }
}
