using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    [SerializeField] private AudioSource scoreSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreSoundEffect.Play();
        Score.score++;
    }
}
