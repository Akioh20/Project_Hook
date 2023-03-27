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
    #endregion

    #region Private Variables
    private MenuManager menuManager;
    private SetStars setStars;
    #endregion

    #region Cheats
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            for (int i = 1; i <= 31; i++)
            {
                PlayerPrefs.SetInt("Score_Level_" + i, 3);
            }
        }
    }
    #endregion

    void Start()
    {
        menuManager = FindObjectOfType<MenuManager>();
        setStars = FindObjectOfType<SetStars>();

        //dataScript.SetTextStarsWon(StarsLvl[1], dataScript.GetLevelStars(1), "Current Stars: ");

        if (PlayerPrefs.GetInt("Lock2") == 1)
        {
            Locks[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock3") == 1)
        {
            Locks[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock4") == 1)
        {
            Locks[4].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock5") == 1)
        {
            Locks[5].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock6") == 1)
        {
            Locks[6].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock7") == 1)
        {
            Locks[7].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock8") == 1)
        {
            Locks[8].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock9") == 1)
        {
            Locks[9].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock10") == 1)
        {
            Locks[10].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock11") == 1)
        {
            Locks[11].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock12") == 1)
        {
            Locks[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock13") == 1)
        {
            Locks[13].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock14") == 1)
        {
            Locks[14].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock15") == 1)
        {
            Locks[15].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock16") == 1)
        {
            Locks[16].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock17") == 1)
        {
            Locks[17].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock18") == 1)
        {
            Locks[18].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock19") == 1)
        {
            Locks[19].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock20") == 1)
        {
            Locks[20].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock21") == 1)
        {
            Locks[21].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock22") == 1)
        {
            Locks[22].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock23") == 1)
        {
            Locks[23].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock24") == 1)
        {
            Locks[24].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock25") == 1)
        {
            Locks[25].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock26") == 1)
        {
            Locks[26].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock27") == 1)
        {
            Locks[27].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock28") == 1)
        {
            Locks[28].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock29") == 1)
        {
            Locks[29].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock30") == 1)
        {
            Locks[30].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lock31") == 1)
        {
            Locks[31].SetActive(false);
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
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
                        Start();
                        setStars.SetStarsFunc();
                    }
                }
                break;
            case 31:
                if (menuManager.totalStars >= 90)
                {
                    if (PlayerPrefs.GetInt("Lock31") == 0)
                    {
                        Locks[31].SetActive(false);
                        PlayerPrefs.SetInt("Lock31", 1);
                        Start();
                        setStars.SetStarsFunc();
                    }
                }
                break;
            default:
                break;
        }
    }
}