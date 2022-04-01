using TMPro;
using UnityEngine;

public class ScoreUpdate : MonoBehaviour
{
    private TMP_Text score;

    private void OnEnable()
    {
        score = transform.GetComponent<TMP_Text>();
        if (PlayerPrefs.HasKey("Score"))
        {
            score.text += " " + PlayerPrefs.GetInt("Score").ToString();
        }
    }
}
