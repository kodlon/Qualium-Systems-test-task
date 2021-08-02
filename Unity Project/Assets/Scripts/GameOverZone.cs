﻿using UnityEngine;

public class GameOverZone : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] Canvas gameOverMenu;


    private void OnTriggerEnter(Collider other)
    {
        StartGame.GameActive = false;
        gameOverMenu.gameObject.SetActive(true);
        timer.StopTimer();

        Rigidbody ballBody = other.GetComponent<Rigidbody>();
        ballBody.useGravity = false;
        ballBody.velocity = Vector3.zero;
    }
}
