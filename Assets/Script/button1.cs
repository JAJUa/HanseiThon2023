using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    public GameObject Firstpuzzle;
    public bool Correct;
    // Start is called before the first frame update
    void Start()
    {
        Correct = false;
    }
    private void OnEnable()
    {
        Correct = false;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    public void isclick()
    {
        if (Correct)
        {
            Firstpuzzle.SetActive(false);
            Player.TurnCube += 1;
        }
        if (!Correct)
        {
            Firstpuzzle.SetActive(false);
        }
    }
}
