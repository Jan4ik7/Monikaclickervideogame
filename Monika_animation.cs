using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monika_animation : MonoBehaviour { 
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }
    private void Update()
    {
        
            anim.Play("monika");
        
       
    }
}

