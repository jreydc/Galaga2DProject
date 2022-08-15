using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField]private Button playButton;
    // Start is called before the first frame update
    void Start()
    {
        playButton = GetComponent<Button>();
        playButton.onClick.AddListener(delegate {LoadLevel("GamePlayScene");
        });
    }

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Single);
    }
}
