using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    public float fuerzadesalto;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("estaSaltando",true);
            rigidbody2D.AddForce(new Vector2(0,fuerzadesalto));
            
        }
    }
}
