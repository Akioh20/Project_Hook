using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UnlockLevels : MonoBehaviour
{
    #region Public Variables
    [Header("Locks Assigned")]
    public GameObject[] Locks;
    [Header ("Stars Text Assigned")]
    public TextMeshProUGUI[] StarsLvl;
    #endregion

    #region Private Variables
    private MenuManager menuManager;
    private SaveData dataScript;
    #endregion

    #region Cheats
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            for (int i = 1; i <= 26; i++)
            {
                PlayerPrefs.SetInt("Score_Level_" + i, 3);
            }
        }
    }
    #endregion

    void Start()
    {
        menuManager = FindObjectOfType<MenuManager>();
        dataScript = FindObjectOfType<SaveData>();

        dataScript.SetTextStarsWon(StarsLvl[1], dataScript.GetLevelStars(1), "Current Stars: ");


        if (PlayerPrefs.GetInt("Lock2") == 1)
        {
            Locks[2].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[2], dataScript.GetLevelStars(2), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock3") == 1)
        {
            Locks[3].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[3], dataScript.GetLevelStars(3), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock4") == 1)
        {
            Locks[4].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[4], dataScript.GetLevelStars(4), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock5") == 1)
        {
            Locks[5].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[5], dataScript.GetLevelStars(5), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock6") == 1)
        {
            Locks[6].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[6], dataScript.GetLevelStars(6), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock7") == 1)
        {
            Locks[7].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[7], dataScript.GetLevelStars(7), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock8") == 1)
        {
            Locks[8].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[8], dataScript.GetLevelStars(8), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock9") == 1)
        {
            Locks[9].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[9], dataScript.GetLevelStars(9), "Current Stars: ");

        }
        if (PlayerPrefs.GetInt("Lock10") == 1)
        {
            Locks[10].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[10], dataScript.GetLevelStars(10), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock11") == 1)
        {
            Locks[11].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[11], dataScript.GetLevelStars(11), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock12") == 1)
        {
            Locks[12].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[12], dataScript.GetLevelStars(12), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock13") == 1)
        {
            Locks[13].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[13], dataScript.GetLevelStars(13), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock14") == 1)
        {
            Locks[14].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[14], dataScript.GetLevelStars(14), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock15") == 1)
        {
            Locks[15].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[15], dataScript.GetLevelStars(15), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock16") == 1)
        {
            Locks[16].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[16], dataScript.GetLevelStars(16), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock17") == 1)
        {
            Locks[17].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[17], dataScript.GetLevelStars(17), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock18") == 1)
        {
            Locks[18].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[18], dataScript.GetLevelStars(18), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock19") == 1)
        {
            Locks[19].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[19], dataScript.GetLevelStars(19), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock20") == 1)
        {
            Locks[20].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[20], dataScript.GetLevelStars(20), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock21") == 1)
        {
            Locks[21].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[21], dataScript.GetLevelStars(21), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock22") == 1)
        {
            Locks[22].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[22], dataScript.GetLevelStars(22), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock23") == 1)
        {
            Locks[23].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[23], dataScript.GetLevelStars(23), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock24") == 1)
        {
            Locks[24].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[24], dataScript.GetLevelStars(24), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock25") == 1)
        {
            Locks[25].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[25], dataScript.GetLevelStars(25), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock26") == 1)
        {
            Locks[26].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[26], dataScript.GetLevelStars(26), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock27") == 1)
        {
            Locks[27].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[27], dataScript.GetLevelStars(27), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock28") == 1)
        {
            Locks[28].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[28], dataScript.GetLevelStars(28), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock29") == 1)
        {
            Locks[29].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[29], dataScript.GetLevelStars(29), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock30") == 1)
        {
            Locks[30].SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl[30], dataScript.GetLevelStars(30), "Current Stars: ");
        }
    }

    public void Unlock(int levelLock)
    {
        switch (levelLock)
        {
            case 2:
                if (menuManager.totalStars >= 2)
                {
                    if (PlayerPrefs.GetInt("Lock2") == 0)
                    {
                        Locks[2].SetActive(false);
                        PlayerPrefs.SetInt("Lock2", 1);
                    }
                }
                break;
            case 3:
                if (menuManager.totalStars >= 4)
                {
                    if (PlayerPrefs.GetInt("Lock3") == 0)
                    {
                        Locks[3].SetActive(false);
                        PlayerPrefs.SetInt("Lock3", 1);
                    }
                }
                break;
            case 4:
                if (menuManager.totalStars >= 6)
                {
                    if (PlayerPrefs.GetInt("Lock4") == 0)
                    {
                        Locks[4].SetActive(false);
                        PlayerPrefs.SetInt("Lock4", 1);
                    }
                }
                break;
            case 5:
                if (menuManager.totalStars >= 8)
                {
                    if (PlayerPrefs.GetInt("Lock5") == 0)
                    {
                        Locks[5].SetActive(false);
                        PlayerPrefs.SetInt("Lock5", 1);
                    }
                }
                break;
            case 6:
                if (menuManager.totalStars >= 10)
                {
                    if (PlayerPrefs.GetInt("Lock6") == 0)
                    {
                        Locks[6].SetActive(false);
                        PlayerPrefs.SetInt("Lock6", 1);
                    }
                }
                break;
            case 7:
                if (menuManager.totalStars >= 12)
                {
                    if (PlayerPrefs.GetInt("Lock7") == 0)
                    {
                        Locks[7].SetActive(false);
                        PlayerPrefs.SetInt("Lock7", 1);
                    }
                }
                break;
            case 8:
                if (menuManager.totalStars >= 14)
                {
                    if (PlayerPrefs.GetInt("Lock8") == 0)
                    {
                        Locks[8].SetActive(false);
                        PlayerPrefs.SetInt("Lock8", 1);
                    }
                }
                break;
            case 9:
                if (menuManager.totalStars >= 16)
                {
                    if (PlayerPrefs.GetInt("Lock9") == 0)
                    {
                        Locks[9].SetActive(false);
                        PlayerPrefs.SetInt("Lock9", 1);
                    }
                }
                break;
            case 10:
                if (menuManager.totalStars >= 18)
                {
                    if (PlayerPrefs.GetInt("Lock10") == 0)
                    {
                        Locks[10].SetActive(false);
                        PlayerPrefs.SetInt("Lock10", 1);
                    }
                }
                break;
            case 11:
                if (menuManager.totalStars >= 20)
                {
                    if (PlayerPrefs.GetInt("Lock11") == 0)
                    {
                        Locks[11].SetActive(false);
                        PlayerPrefs.SetInt("Lock11", 1);
                    }
                }
                break;
            case 12:
                if (menuManager.totalStars >= 22)
                {
                    if (PlayerPrefs.GetInt("Lock12") == 0)
                    {
                        Locks[12].SetActive(false);
                        PlayerPrefs.SetInt("Lock12", 1);
                    }
                }
                break;
            case 13:
                if (menuManager.totalStars >= 24)
                {
                    if (PlayerPrefs.GetInt("Lock13") == 0)
                    {
                        Locks[13].SetActive(false);
                        PlayerPrefs.SetInt("Lock13", 1);
                    }
                }
                break;
            case 14:
                if (menuManager.totalStars >= 26)
                {
                    if (PlayerPrefs.GetInt("Lock14") == 0)
                    {
                        Locks[14].SetActive(false);
                        PlayerPrefs.SetInt("Lock14", 1);
                    }
                }
                break;
            case 15:
                if (menuManager.totalStars >= 28)
                {
                    if (PlayerPrefs.GetInt("Lock15") == 0)
                    {
                        Locks[15].SetActive(false);
                        PlayerPrefs.SetInt("Lock15", 1);
                    }
                }
                break;
            case 16:
                if (menuManager.totalStars >= 30)
                {
                    if (PlayerPrefs.GetInt("Lock16") == 0)
                    {
                        Locks[16].SetActive(false);
                        PlayerPrefs.SetInt("Lock16", 1);
                    }
                }
                break;
            case 17:
                if (menuManager.totalStars >= 32)
                {
                    if (PlayerPrefs.GetInt("Lock17") == 0)
                    {
                        Locks[17].SetActive(false);
                        PlayerPrefs.SetInt("Lock17", 1);
                    }
                }
                break;
            case 18:
                if (menuManager.totalStars >= 34)
                {
                    if (PlayerPrefs.GetInt("Lock18") == 0)
                    {
                        Locks[18].SetActive(false);
                        PlayerPrefs.SetInt("Lock18", 1);
                    }
                }
                break;
            case 19:
                if (menuManager.totalStars >= 36)
                {
                    if (PlayerPrefs.GetInt("Lock19") == 0)
                    {
                        Locks[19].SetActive(false);
                        PlayerPrefs.SetInt("Lock19", 1);
                    }
                }
                break;
            case 20:
                if (menuManager.totalStars >= 38)
                {
                    if (PlayerPrefs.GetInt("Lock20") == 0)
                    {
                        Locks[20].SetActive(false);
                        PlayerPrefs.SetInt("Lock20", 1);
                    }
                }
                break;
            case 21:
                if (menuManager.totalStars >= 40)
                {
                    if (PlayerPrefs.GetInt("Lock21") == 0)
                    {
                        Locks[21].SetActive(false);
                        PlayerPrefs.SetInt("Lock21", 1);
                    }
                }
                break;
            case 22:
                if (menuManager.totalStars >= 42)
                {
                    if (PlayerPrefs.GetInt("Lock22") == 0)
                    {
                        Locks[22].SetActive(false);
                        PlayerPrefs.SetInt("Lock22", 1);
                    }
                }
                break;
            case 23:
                if (menuManager.totalStars >= 44)
                {
                    if (PlayerPrefs.GetInt("Lock23") == 0)
                    {
                        Locks[23].SetActive(false);
                        PlayerPrefs.SetInt("Lock23", 1);
                    }
                }
                break;
            case 24:
                if (menuManager.totalStars >= 46)
                {
                    if (PlayerPrefs.GetInt("Lock24") == 0)
                    {
                        Locks[24].SetActive(false);
                        PlayerPrefs.SetInt("Lock24", 1);
                    }
                }
                break;
            case 25:
                if (menuManager.totalStars >= 48)
                {
                    if (PlayerPrefs.GetInt("Lock25") == 0)
                    {
                        Locks[25].SetActive(false);
                        PlayerPrefs.SetInt("Lock25", 1);
                    }
                }
                break;
            case 26:
                if (menuManager.totalStars >= 50)
                {
                    if (PlayerPrefs.GetInt("Lock26") == 0)
                    {
                        Locks[26].SetActive(false);
                        PlayerPrefs.SetInt("Lock26", 1);
                    }
                }
                break;
            case 27:
                if (menuManager.totalStars >= 78)
                {
                    if (PlayerPrefs.GetInt("Lock27") == 0)
                    {
                        Locks[27].SetActive(false);
                        PlayerPrefs.SetInt("Lock27", 1);
                    }
                }
                break;
            case 28:
                if (menuManager.totalStars >= 81)
                {
                    if (PlayerPrefs.GetInt("Lock28") == 0)
                    {
                        Locks[28].SetActive(false);
                        PlayerPrefs.SetInt("Lock28", 1);
                    }
                }
                break;
            case 29:
                if (menuManager.totalStars >= 84)
                {
                    if (PlayerPrefs.GetInt("Lock29") == 0)
                    {
                        Locks[29].SetActive(false);
                        PlayerPrefs.SetInt("Lock29", 1);
                    }
                }
                break;
            case 30:
                if (menuManager.totalStars >= 87)
                {
                    if (PlayerPrefs.GetInt("Lock30") == 0)
                    {
                        Locks[30].SetActive(false);
                        PlayerPrefs.SetInt("Lock30", 1);
                    }
                }
                break;
            default:
                break;
        }
    }
}