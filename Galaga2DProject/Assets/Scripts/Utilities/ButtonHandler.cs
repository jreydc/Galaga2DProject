using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField]private Button playButton;
    void Start()
    {
        playButton = GetComponent<Button>();
        playButton.onClick.AddListener(delegate {
            SceneController._SingleInstance.LoadLevel("GamePlayScene");
        });
    }
}
