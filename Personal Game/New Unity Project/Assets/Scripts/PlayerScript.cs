using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float walkspeed, runspeed, turnspeed, jumpforce;
    float walkspeed2;
    public KeyCode forward, back, left, right, run, jump, interact;
    Rigidbody rb;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GameObject.Find(transform.name + "/furry").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(forward))
        {
            transform.Translate(Vector3.forward * walkspeed2);
            anim.SetBool("Walking",true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }

        if (Input.GetKey(back))
        {
            transform.Translate(Vector3.forward * -1 * walkspeed2);
            anim.SetBool("Back Walk", true);
        }
        else
        {
            anim.SetBool("Back Walk", false);
        }

        if (Input.GetKey(left))
        {
            transform.Rotate(new Vector3(0, turnspeed * -1, 0));
            anim.SetBool("Turn Left", true);
        }
        else
        {
            anim.SetBool("Turn Left", false);
        }

        if (Input.GetKey(right))
        {
            transform.Rotate(new Vector3(0, turnspeed, 0));
            anim.SetBool("Turn Right", true);
        }
        else
        {
            anim.SetBool("Turn Right", false);
        }
    

        if (Input.GetKeyDown(jump))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            anim.SetTrigger("Jump");
        }

        if (Input.GetKey(run))
        {
            walkspeed2 = runspeed;
            anim.SetBool("Running", true);
        }
        else
        {
            walkspeed2 = walkspeed;
            anim.SetBool("Running", false);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        anim.SetTrigger("Jump End");
    }
}
