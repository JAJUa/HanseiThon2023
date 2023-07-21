using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
   public void goFirstScene()
    {
        SceneManager.LoadScene("Main");
    }
    public void goMapSelect()
    {
        SceneManager.LoadScene("RealMapSelec");
    }
}
