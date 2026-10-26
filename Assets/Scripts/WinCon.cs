using System;
using UnityEngine;

public class WinCon : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            var controller = FindAnyObjectByType<LevelUIController>();
            controller.Win();
        }
    }
        
}