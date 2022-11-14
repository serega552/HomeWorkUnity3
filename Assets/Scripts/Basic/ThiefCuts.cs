using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefCuts : MonoBehaviour
{
    [SerializeField] private GameObject _spriteGameOver;

    private bool _isEnd = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Player> (out Player player) && _isEnd)
        {
            var gameOver = Instantiate (_spriteGameOver,new Vector3(0,0,0), Quaternion.identity);
            _isEnd = false;
        }
    }
}
