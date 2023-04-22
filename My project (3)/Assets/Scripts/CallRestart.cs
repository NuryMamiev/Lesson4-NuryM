using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CallRestart : MonoBehaviour
{
    [SerializeField] private Button restartCallButton;
    [SerializeField] private float targetCount = 3;




    public void RestartScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            targetCount--;
            if (targetCount == 0)
            {
                restartCallButton.gameObject.SetActive(true);

            }
        }
    }
}
