﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossLoadManager : MonoBehaviour
{
    public CameraFollow cameraMovement;
    public GameObject player;
    public GameObject teleportPoint;
    public BossFightManager fight;
    public GameObject proTipPanel;

    void OnTriggerStay()
    {
        if (Input.GetButtonDown("E"))
        {
            if (NPC_Dialogue.levelchange == true)
            {
                // Teleport the player to the boss zone
                Animator animator = proTipPanel.GetComponent<Animator>();
                if (animator != null)
                {
                    animator.Play("ProTip");
                }
                player.transform.position = teleportPoint.transform.position;
                cameraMovement = GameObject.FindGameObjectWithTag("CameraFolder").GetComponent<CameraFollow>();
                cameraMovement.enabled = false;
                cameraMovement.enabled = true;
                //fight.StartBossFight();
                // Change the lighting and enable the boss
            }
        }
    }
    
}