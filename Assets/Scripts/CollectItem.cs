using System;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public static event Action OnItemCollected;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag.Equals("Item"))
        {
            OnItemCollected?.Invoke();
            Debug.Log("ITEM RECOGIDO");
            Destroy(hit.gameObject);
        }
    }
}
