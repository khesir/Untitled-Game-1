using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    [SerializeField] private string transitionName;

    private void Start()
    {
        if (transitionName == SceneManagement.Instance.SceneTransitionName)
        {
            PlayerController.Instance.transform.position = this.transform.position;
            CameraController.Instance.SetupPlayerCameraFollow();
            UIFade.Instance.FadeToClear();
        }
    }
}
