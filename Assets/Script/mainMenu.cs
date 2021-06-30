using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void problem1_3 ()
    {
        SceneManager.LoadScene(1);

    }
    public void problem4()
    {
        SceneManager.LoadScene(2);

    }
    public void problem5()
    {
        SceneManager.LoadScene(3);

    }
    public void problem6_10()
    {
        SceneManager.LoadScene(4);

    }
    public void home()
    {
        SceneManager.LoadScene(0);

    }
}
