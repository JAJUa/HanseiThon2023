using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Firstpuzzle;
    public static float TurnCube;
    public bool dontMove;
    public AudioSource audioSource;
    public RaycastHit BuckDul;
    public LayerMask BuckLayer;
    void Start()
    {
        TurnCube = 0;
    }

    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) && dontMove == false)
        {
            transform.position += transform.forward * 1;
            audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(0f, -90f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.Rotate(0f, 90f, 0f);
        }

        if (TurnCube >= 1)
        {
            dontMove = true;
        }
        if (Physics.Raycast(transform.position, transform.forward, out BuckDul, 4.7f, BuckLayer))
        {
            dontMove = true;
        }
        else if (TurnCube <= 0)
        {
            dontMove = false;
        }
    }

    public void FirstPuzzleEnter()
    {
        Firstpuzzle.SetActive(true);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * 4.7f);
        
    }
}
