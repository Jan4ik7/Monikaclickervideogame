using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AnimationContorller : MonoBehaviour
{
   
    private void Awake()
    {

        GetComponent<Animation>().Play("First");
    }
}
