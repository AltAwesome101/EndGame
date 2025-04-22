using UnityEngine;

public class Consumable : MonoBehaviour
{
    public Item item;
    public GameObject labelText; // Assign this in the Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Add to inventory if needed
            RMInventory playerInventory = collision.GetComponent<RMInventory>();
            if (playerInventory != null)
            {
                playerInventory.AddItem(item);
            }

            // Hide or destroy the label
            if (labelText != null)
            {
                labelText.SetActive(false); // Or use Destroy(labelText);
            }

            // Destroy the item object
            Destroy(gameObject);
        }
    }
}

