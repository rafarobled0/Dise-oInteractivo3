using UnityEngine;

public class ControladorBajo : MonoBehaviour
{
    public Animator animator;

    public void ActivarAnimacion()
    {
        animator.SetTrigger("encogerse");
    }
}