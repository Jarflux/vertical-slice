using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float _speed = 500f;
    public Animator animator;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(_speed * Time.deltaTime * transform.right);
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift)) {
                Sprint();
            } else {
                Walk();
            }
        }
        else {
            Idle();
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(_speed * Time.deltaTime * -transform.right);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(_speed * Time.deltaTime * -transform.forward);
        }
    }


    void Walk() {
        animator.SetBool("Running", false);
        animator.SetBool("Walking", true);
    }
    void Sprint() {
        animator.SetBool("Walking", false);
        animator.SetBool("Running", true);
    }

    void Idle() {
        animator.SetBool("Walking", false);
        animator.SetBool("Running", false);
    }


}
