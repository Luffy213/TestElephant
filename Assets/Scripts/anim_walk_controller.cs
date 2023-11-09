using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_walk_controller : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    bool change = false;
    private void OnMouseDown()
    {
        if (change == false)
        {
            _anim.SetBool("walking", change = true);
        }
        else
        {
            _anim.SetBool("walking", change = false);
        }
    }
}
