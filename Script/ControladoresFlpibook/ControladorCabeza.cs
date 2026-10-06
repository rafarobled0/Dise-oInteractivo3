using UnityEngine;

public class ControladorCabeza : MonoBehaviour
{
    public Animator animator;

    public void Derecha()
    {
        animator.SetTrigger("CambiarDerecha");
    }

    public void Izquierda()
    {
        animator.SetTrigger("CambiarIzquierda");
    }
}

