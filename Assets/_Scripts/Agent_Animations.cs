using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class NewBehaviourScript : MonoBehaviour
{
    protected Animator Agent_Animator;


    private void Awake()
    {
        Agent_Animator= GetComponent<Animator>();
    }

    public void SetWalkAnimation(bool val)
    {
        Agent_Animator.SetBool("Walk", val);   
    }

    public void AnimatePlayer(float velocity)
    {
        if(velocity > 0 )
        {
            SetWalkAnimation(true);

        }
    }
}
