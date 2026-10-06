using UnityEngine;

public class ControladorLupa : MonoBehaviour
{
    public Animator animator;

    public void ActivarAnimacion()
    {
        animator.SetTrigger("mover");
    }
}