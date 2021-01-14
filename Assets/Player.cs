using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject respawnPoint;
    Vector3 respawnPos;
    public GameObject message;

    private void Start()
    {
        respawnPos = respawnPoint.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("KillBox"))
        {
            gameObject.transform.position = respawnPos;
            Debug.Log("Triggered");
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            message.SetActive(false);
        }
    }
}
