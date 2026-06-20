using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{

    bool lifted = false;

    float tSalto = 1;

    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

        

        if(collision.gameObject.tag != "Player")
        {
            return;
        }
        if (!lifted)
        {
            Levantar();
        }
    }

    void OnCollisionExit(Collision collision)
    {

        

        if(collision.gameObject.tag != "Player")
        {
            return;
        }
        if (lifted)
        {
            Reset();
        }
    }

    void Levantar()
    {
        lifted = true;

        

        animator.SetBool("levantar", true);
        animator.SetBool("resetear", false);
        
    }

    void Reset()
    {
        lifted = false;

        animator.SetBool("levantar", false);
        animator.SetBool("resetear", true);
    }
   
}
