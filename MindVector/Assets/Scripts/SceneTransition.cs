using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    private static SceneTransition instance;
    private Animator componentAnimator;
    private AsyncOperation loadingSceneOperation;
    private static bool shouldPlayOpeningAnimation = false;

    public Image LoadingProgressBar;


    public static void SwitchToScene(string sceneName)
    {
        instance.componentAnimator.SetTrigger("SceneEnd");
        instance.loadingSceneOperation = SceneManager.LoadSceneAsync(sceneName);
        instance.loadingSceneOperation.allowSceneActivation = false;
        
    }
    void Start()
    {
        instance = this;
        componentAnimator = GetComponent<Animator>();
        if (shouldPlayOpeningAnimation)
        {
            componentAnimator.SetTrigger("SceneStart");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (loadingSceneOperation != null)
        {
            LoadingProgressBar.fillAmount = loadingSceneOperation.progress;
        }
        
    }

    private void OnAnimationOver()
    {
        shouldPlayOpeningAnimation = true;
        loadingSceneOperation.allowSceneActivation = true;
    }
}
