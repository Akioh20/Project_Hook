using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SaveData : MonoBehaviour
{
    #region Public Variables
    public float ThreeStarTime;
    public float TwoStarTime;
    public float OneStarTime;
    public TextMeshProUGUI StarsWonText = null;
    public TextMeshProUGUI StarsWonText2 = null;
    #endregion

    public int SaveStars (float time)
    {
        int stars = 0;
        int lastStars = PlayerPrefs.GetInt("Score_Level_" + SceneManager.GetActiveScene().buildIndex, 0);

        // We look at how many stars the player can get
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

        // Text for when the player has enough stars
        SetTextStarsWon(StarsWonText, stars, "You Won ", " stars!");
        // Text for when the player doesn't have enough stars
        SetTextStarsWon(StarsWonText2, stars, "You Won ", " stars! Still, " +
            "you do not reach the minimum stars to go to the next level. Try again or change level!");

        // We save the stars in the corresponding index
        PlayerPrefs.SetInt("Score_Level_" + SceneManager.GetActiveScene().buildIndex, Mathf.Max(stars, lastStars));

        // The function returns the stars obtained
        return stars;
    }

    // Gets the stars for the actual level
    public int GetLevelStars(int levelBuildIndex)
    {
        return PlayerPrefs.GetInt("Score_Level_" + levelBuildIndex, 0);
    }

    // Sets the text for the actual level
    public void SetTextStarsWon(TextMeshProUGUI text, int stars, string description = "", string description2 = "")
    {
        text.text = description + stars + description2;
    }
}