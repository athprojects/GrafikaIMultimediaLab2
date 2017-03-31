using UnityEngine;
using UnityEngine.UI;

public class ReplayButton : MonoBehaviour {
    void Start ()
    {
        var btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    private static void TaskOnClick()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
