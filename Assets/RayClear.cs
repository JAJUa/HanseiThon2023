using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayClear : MonoBehaviour
{
    RaycastHit HitBlock;
    public LayerMask DBlue;
    public GameObject clear;
    private void Update()
    {
        if (Physics.Raycast(transform.position, transform.up*-1, 5, DBlue))
        {
            if (Physics.Raycast(transform.position + new Vector3(1, 0, 0), transform.up * -1, 5, DBlue))
            {
                if (Physics.Raycast(transform.position + new Vector3(2, 0, 0), transform.up * -1, 5, DBlue))
                {
                    if (Physics.Raycast(transform.position + new Vector3(0, 0, 1), transform.up * -1, 5, DBlue))
                    {
                        if (Physics.Raycast(transform.position + new Vector3(0, 0, 2) , transform.up * -1, 5, DBlue))
                        {
                            if (Physics.Raycast(transform.position + new Vector3(1, 0, 1), transform.up * -1, 5, DBlue))
                            {
                                if (Physics.Raycast(transform.position + new Vector3(2, 0, 1), transform.up * -1, 5, DBlue))
                                {
                                    if (Physics.Raycast(transform.position + new Vector3(1, 0, 2), transform.up * -1, 5, DBlue))
                                    {
                                        if (Physics.Raycast(transform.position + new Vector3(2, 0, 2), transform.up * -1, 5, DBlue))
                                        {
                                            clear.SetActive(true);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.up * -1f);
    }
}
