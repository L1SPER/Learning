using UnityEngine;

public class Sign : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("Interacted with sign");
    }
}
