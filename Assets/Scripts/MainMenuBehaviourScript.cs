using Assets.Constants;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehaviourScript : MonoBehaviour
{
    public void PlayGame()
    {
        int option = Convert.ToInt32(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        GameManager.Instance.CharIndex = option;

        SceneManager.LoadScene(Constants.GAMEPLAY_SCENE);
    }
}
