using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField]private Button playButton;
    void Start()
    {
        playButton = GetComponent<Button>();
        playButton.onClick.AddListener(() => {
            StartCoroutine(SceneController._SingleInstance.LoadingDetails());
            SceneController._SingleInstance.LoadLevel("GamePlayScene");
            SoundFXManager._SingleInstance.BGMusicMainMenuStop();
            SoundFXManager._SingleInstance.BGMusicGamePlay();
        });
    }
}
