using UnityEngine;

public class ControladorDisco : MonoBehaviour
{
    public Animator animator;

    public void ActivarAnimacion()
    {
        animator.SetTrigger("girar");
    }
}