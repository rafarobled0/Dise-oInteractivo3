using UnityEngine;

public class ControladorCamisetas : MonoBehaviour
{
    public Animator animator;

    public void ActivarAnimacion()
    {
        animator.SetTrigger("crecer");
    }
}