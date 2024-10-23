using UnityEngine;
public class KnifeHit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!KnifeThrow._isActive)
            return;

        KnifeThrow._isActive = false;

        if(other.collider.tag == "Log")
        {
            KnifeThrow._knifeRb.velocity = new Vector2(0, 0);
            KnifeThrow._knifeRb.bodyType = RigidbodyType2D.Kinematic;
            transform.SetParent(other.collider.transform);

            KnifeThrow._knifeCollider.offset = new Vector2(KnifeThrow._knifeCollider.offset.x, -0.4f);
            KnifeThrow._knifeCollider.size = new Vector2(KnifeThrow._knifeCollider.size.x, 1.2f);
            //TODO: Спавн следующего ножика.
        }
        else if(other.collider.tag == "Knife")
        {
            KnifeThrow._knifeRb.velocity = new Vector2(KnifeThrow._knifeRb.velocity.x, -2); 
        }
    }
}
