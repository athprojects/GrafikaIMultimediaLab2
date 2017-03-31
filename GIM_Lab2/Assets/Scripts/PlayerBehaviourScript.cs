using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviourScript : MonoBehaviour {
    private int _count;
    private Rigidbody2D _playerObj;

    public Text PointCountText;
    public GameObject WinPanel;

    void Start()
    {
        _count = 0;
        _playerObj = GetComponent<Rigidbody2D>();
        UpdatePointCountUI();
    }

    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUpType1"))
            IncreaseScore(1);      
        else if (other.gameObject.CompareTag("PickUpType2"))
            IncreaseScore(3);
    }

    private void ShowWinPanelIfNeeded()
    {
        if (_count >= 20)
            WinPanel.gameObject.SetActive(true);
    }

    private void IncreaseScore(int scoreIncrease)
    {
        _count += scoreIncrease;
        UpdatePointCountUI();
        ShowWinPanelIfNeeded();
    }

    private void UpdatePointCountUI()
    {
        PointCountText.text = "Score: " + _count;
    }
}
