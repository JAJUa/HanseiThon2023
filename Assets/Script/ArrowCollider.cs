using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCollider : MonoBehaviour
{
    public int AroPos;
    public GameObject[] Arrow;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(AroPos == 1 && Player.TurnCube >= 1)
            {
                Arrow[0].SetActive(true);
                Arrow[1].SetActive(true);
                Arrow[10].SetActive(true);
                Arrow[11].SetActive(true);
                Debug.Log("°³¾ö");
            }

            if (AroPos == 2 && Player.TurnCube >= 1)
            {
                Arrow[0].SetActive(true);
                Arrow[1].SetActive(true);
                Arrow[8].SetActive(true);
                Arrow[9].SetActive(true);
            }

            if (AroPos == 3 && Player.TurnCube >= 1)
            {
                Arrow[0].SetActive(true);
                Arrow[1].SetActive(true);
                Arrow[6].SetActive(true);
                Arrow[7].SetActive(true);
            }

            if (AroPos == 4 && Player.TurnCube >= 1)
            {
                Arrow[2].SetActive(true);
                Arrow[3].SetActive(true);
                Arrow[10].SetActive(true);
                Arrow[11].SetActive(true);
            }

            if (AroPos == 5 && Player.TurnCube >= 1)
            {
                Arrow[2].SetActive(true);
                Arrow[3].SetActive(true);
                Arrow[8].SetActive(true);
                Arrow[9].SetActive(true);
            }

            if (AroPos == 6 && Player.TurnCube >= 1)
            {
                Arrow[2].SetActive(true);
                Arrow[3].SetActive(true);
                Arrow[6].SetActive(true);
                Arrow[7].SetActive(true);
            }

            if (AroPos == 7 && Player.TurnCube >= 1)
            {
                Arrow[4].SetActive(true);
                Arrow[5].SetActive(true);
                Arrow[10].SetActive(true);
                Arrow[11].SetActive(true);
            }

            if (AroPos == 8 && Player.TurnCube >= 1)
            {
                Arrow[4].SetActive(true);
                Arrow[5].SetActive(true);
                Arrow[8].SetActive(true);
                Arrow[9].SetActive(true);
            }

            if (AroPos == 9 && Player.TurnCube >= 1)
            {
                Arrow[4].SetActive(true);
                Arrow[5].SetActive(true);
                Arrow[6].SetActive(true);
                Arrow[7].SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        for(int i = 0; i < Arrow.Length;i++)
        {
            Arrow[i].SetActive(false);
        }
    }
}
