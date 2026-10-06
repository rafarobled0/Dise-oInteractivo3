using UnityEngine;

public class ControladorInsecto : MonoBehaviour
{
    public Animator animator;
    public string nombreTrigger;

    public void ActivarAnimacion()
    {
        animator.SetTrigger("Mover");
    }
}