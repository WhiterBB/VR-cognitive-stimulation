using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    // public FadeScreen fadeScreen;
    public void LoadGame(int id)
    {
        StateNameController._difficulty = id;
        // StartCoroutine(GoToSceneRoutine());
        SceneManager.LoadScene("MarketScene");
    }

    // IEnumerator GoToSceneRoutine()
    // {
    //     fadeScreen.FadeOut();
    //     yield return new WaitForSeconds(fadeScreen.fadeDuration);
    // }

}
