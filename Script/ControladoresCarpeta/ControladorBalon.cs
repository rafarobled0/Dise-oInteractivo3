using UnityEngine;

public class ControladorBalon : MonoBehaviour
{
    public Animator animator;
    public AudioSource sonido;

    public void ActivarAnimacion()
    {
        animator.SetTrigger("rebotar");
        sonido.Play();
    }
}