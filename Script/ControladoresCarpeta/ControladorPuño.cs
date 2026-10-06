using UnityEngine;

public class ControladorPuño : MonoBehaviour
{
    public Animator animator;

    public void ActivarAnimacion()
    {
        animator.SetTrigger("enfrente");
    }
}