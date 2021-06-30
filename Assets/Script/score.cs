using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreText.scoreAmount += 1;
        Destroy(gameObject);
    }
}
