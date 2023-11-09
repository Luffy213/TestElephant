using UnityEngine;

public class Anim_swordsman_controller : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    bool change = false;
    private void OnMouseDown()
    {
        if(change == false)
        { 
            _anim.SetBool("attack", change = true);
        }
        else
        {
            _anim.SetBool("attack", change = false);
        }
    }

}
