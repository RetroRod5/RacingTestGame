using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripping : MonoBehaviour
{
    private TimeFunction timeFunction;
    public AudioSource Src;
    public Animator WipeTransition;
    bool ready = false;

    public void StartClick()
    {
        Src.Play();
        ready = true;
        WipeTransition.SetTrigger("Phase2");
        timeFunction = new TimeFunction(PlayGame, 2f);
    }

    private void Update()
    {
        if (ready == true)
        timeFunction.Update();
    }

    private void PlayGame()
    {
        Debug.Log("I am loaded!");
        SceneManager.LoadScene("Game");
    }

    public void LeaveGame()
    {
        Application.Quit();
    }
}
