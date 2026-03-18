using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   public rigidbody2D rb;

  
    void Update()
    {
        rb.linearvelocity = new Vector2 (Input.getaxis *Horizontal*), rb.linearvelocity;
    }
}
