using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadingController : MonoBehaviour

{
    private void Start()

    {

        UserDataManager.Load();

        SceneManager.LoadScene(1);

    }

}