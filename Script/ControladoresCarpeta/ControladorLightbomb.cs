using UnityEngine;

public class ControladorLightbomb : MonoBehaviour
{
    public Animator animator;

    public void ActivarAnimacion()
    {
        animator.SetTrigger("enfrente");
    }
}