using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SaveData : MonoBehaviour
{
    public float ThreeStarTime;
    public float TwoStarTime;
    public float OneStarTime;
    public TextMeshProUGUI StarsWonText = null;
    public TextMeshProUGUI StarsWonText2 = null;

    public int SaveStars (float time)
    {
        int stars = 0;
        int lastStars = PlayerPrefs.GetInt("Score_Level_" + SceneManager.GetActiveScene().buildIndex, 0);

        if (time <= ThreeStarTime)
        {
            stars = 3;
        }
        else if (time <= TwoStarTime)
        {
            stars = 2;
        }
        else if (time <= OneStarTime)
        {
            stars = 1;
        }

        SetTextStarsWon(StarsWonText, stars, "You Won: ", " stars!");
        SetTextStarsWon(StarsWonText2, stars, "You Won: ", " stars! Still, " +
            "you do not reach the minimum stars to go to the next level. Try again or change level!");

        PlayerPrefs.SetInt("Score_Level_" + SceneManager.GetActiveScene().buildIndex, Mathf.Max(stars, lastStars));

        //Debug.Log(PlayerPrefs.GetInt("Score_Level_" + SceneManager.GetActiveScene().buildIndex, Mathf.Max(stars, lastStars)));

        return stars;
    }

    public int GetLevelStars(int levelBuildIndex)
    {
        return PlayerPrefs.GetInt("Score_Level_" + levelBuildIndex, 0);
    }

    public void SetTextStarsWon(TextMeshProUGUI text, int stars, string description = "", string description2 = "")
    {
        text.text = description + stars + description2;
    }
}