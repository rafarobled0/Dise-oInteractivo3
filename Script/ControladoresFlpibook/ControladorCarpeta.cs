using UnityEngine;

public class CaminataEscarabajo : MonoBehaviour
{
    public Animator animator;

    public void Caminata()
    {
        animator.SetTrigger("CaminataEscarabajo");
    }
}