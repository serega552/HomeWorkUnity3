using UnityEngine;

public class MoneyPickUp : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Player> (out Player player))
        _spriteRenderer.color = Color.cyan;
    }
}
