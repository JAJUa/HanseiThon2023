using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPuzzle : MonoBehaviour
{
    public GameObject[] soundbutton;
    public GameObject[] Randonsoundbutton;
    public AudioSource[] audio;
    private int i;
    public int temp;
    public int random;
    public int listecount = 0;

    private void Start()
    {
        listecount = 0;
        audio = GameObject.Find("SoundSystem").GetComponents<AudioSource>();
   
    }

    private void OnEnable()
    {
        listecount = 0;
    }

    private void Update()
    {
        
       
    }

    public void listen()
    {
        if (listecount < 1)
        {
            random = Random.Range(0, audio.Length );
            Debug.Log(random);
            temp = random;
            listecount += 1;
        }
        
        
        
        audio[temp].Play();
        Debug.Log(temp);
        soundbutton[temp].GetComponent<button1>().Correct = true;
    }

    public void sequence()
    {
        StartCoroutine(audioSequence());
    }

    IEnumerator audioSequence()
    {
        audio[0].Play();
        yield return new WaitForSeconds(1f);
        audio[1].Play();
        yield return new WaitForSeconds(1f);
        audio[2].Play();
        yield return new WaitForSeconds(1f);
        audio[3].Play();
    }
}
