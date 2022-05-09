using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UnlockLevels : MonoBehaviour
{
    private MenuManager menuManager;
    private SaveData dataScript;

    #region Public Variables
    [Header("Locks")]
    public GameObject Lock2;
    public GameObject Lock3;
    public GameObject Lock4;
    public GameObject Lock5;
    public GameObject Lock6;
    public GameObject Lock7;
    public GameObject Lock8;
    public GameObject Lock9;
    public GameObject Lock10;
    public GameObject Lock11;
    public GameObject Lock12;
    public GameObject Lock13;
    public GameObject Lock14;
    public GameObject Lock15;
    public GameObject Lock16;
    public GameObject Lock17;
    public GameObject Lock18;
    public GameObject Lock19;
    public GameObject Lock20;
    public GameObject Lock21;
    public GameObject Lock22;
    public GameObject Lock23;
    public GameObject Lock24;
    public GameObject Lock25;
    public GameObject Lock26;
    [Header ("Stars Text")]
    public TextMeshProUGUI StarsLvl1 = null;
    public TextMeshProUGUI StarsLvl2 = null;
    public TextMeshProUGUI StarsLvl3 = null;
    public TextMeshProUGUI StarsLvl4 = null;
    public TextMeshProUGUI StarsLvl5 = null;
    public TextMeshProUGUI StarsLvl6 = null;
    public TextMeshProUGUI StarsLvl7 = null;
    public TextMeshProUGUI StarsLvl8 = null;
    public TextMeshProUGUI StarsLvl9 = null;
    public TextMeshProUGUI StarsLvl10 = null;
    public TextMeshProUGUI StarsLvl11 = null;
    public TextMeshProUGUI StarsLvl12 = null;
    public TextMeshProUGUI StarsLvl13 = null;
    public TextMeshProUGUI StarsLvl14 = null;
    public TextMeshProUGUI StarsLvl15 = null;
    public TextMeshProUGUI StarsLvl16 = null;
    public TextMeshProUGUI StarsLvl17 = null;
    public TextMeshProUGUI StarsLvl18 = null;
    public TextMeshProUGUI StarsLvl19 = null;
    public TextMeshProUGUI StarsLvl20 = null;
    public TextMeshProUGUI StarsLvl21 = null;
    public TextMeshProUGUI StarsLvl22 = null;
    public TextMeshProUGUI StarsLvl23 = null;
    public TextMeshProUGUI StarsLvl24 = null;
    public TextMeshProUGUI StarsLvl25 = null;
    public TextMeshProUGUI StarsLvl26 = null;
    #endregion

    void Start()
    {
        menuManager = FindObjectOfType<MenuManager>();
        dataScript = FindObjectOfType<SaveData>();

        dataScript.SetTextStarsWon(StarsLvl1, dataScript.GetLevelStars(1), "Current Stars: ");


        if (PlayerPrefs.GetInt("Lock2") == 1)
        {
            Lock2.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl2, dataScript.GetLevelStars(2), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock3") == 1)
        {
            Lock3.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl3, dataScript.GetLevelStars(3), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock4") == 1)
        {
            Lock4.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl4, dataScript.GetLevelStars(4), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock5") == 1)
        {
            Lock5.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl5, dataScript.GetLevelStars(5), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock6") == 1)
        {
            Lock6.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl6, dataScript.GetLevelStars(6), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock7") == 1)
        {
            Lock7.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl7, dataScript.GetLevelStars(7), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock8") == 1)
        {
            Lock8.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl8, dataScript.GetLevelStars(8), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock9") == 1)
        {
            Lock9.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl9, dataScript.GetLevelStars(9), "Current Stars: ");

        }
        if (PlayerPrefs.GetInt("Lock10") == 1)
        {
            Lock10.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl10, dataScript.GetLevelStars(10), "Current Stars: ", " 10");
        }
        if (PlayerPrefs.GetInt("Lock11") == 1)
        {
            Lock11.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl11, dataScript.GetLevelStars(11), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock12") == 1)
        {
            Lock12.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl12, dataScript.GetLevelStars(12), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock13") == 1)
        {
            Lock13.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl13, dataScript.GetLevelStars(13), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock14") == 1)
        {
            Lock14.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl14, dataScript.GetLevelStars(14), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock15") == 1)
        {
            Lock15.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl15, dataScript.GetLevelStars(15), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock16") == 1)
        {
            Lock16.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl16, dataScript.GetLevelStars(16), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock17") == 1)
        {
            Lock17.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl17, dataScript.GetLevelStars(17), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock18") == 1)
        {
            Lock18.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl18, dataScript.GetLevelStars(18), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock19") == 1)
        {
            Lock19.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl19, dataScript.GetLevelStars(19), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock20") == 1)
        {
            Lock20.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl20, dataScript.GetLevelStars(20), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock21") == 1)
        {
            Lock21.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl21, dataScript.GetLevelStars(21), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock22") == 1)
        {
            Lock22.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl22, dataScript.GetLevelStars(22), "Current Stars: ", " 22");
        }
        if (PlayerPrefs.GetInt("Lock23") == 1)
        {
            Lock23.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl23, dataScript.GetLevelStars(23), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock24") == 1)
        {
            Lock24.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl24, dataScript.GetLevelStars(24), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock25") == 1)
        {
            Lock25.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl25, dataScript.GetLevelStars(25), "Current Stars: ");
        }
        if (PlayerPrefs.GetInt("Lock26") == 1)
        {
            Lock26.SetActive(false);
            dataScript.SetTextStarsWon(StarsLvl26, dataScript.GetLevelStars(26), "Current Stars: ");
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
                        Lock2.SetActive(false);
                        PlayerPrefs.SetInt("Lock2", 1);
                    }
                }
                break;
            case 3:
                if (menuManager.totalStars >= 4)
                {
                    if (PlayerPrefs.GetInt("Lock3") == 0)
                    {
                        Lock3.SetActive(false);
                        PlayerPrefs.SetInt("Lock3", 1);
                    }
                }
                break;
            case 4:
                if (menuManager.totalStars >= 6)
                {
                    if (PlayerPrefs.GetInt("Lock4") == 0)
                    {
                        Lock4.SetActive(false);
                        PlayerPrefs.SetInt("Lock4", 1);
                    }
                }
                break;
            case 5:
                if (menuManager.totalStars >= 8)
                {
                    if (PlayerPrefs.GetInt("Lock5") == 0)
                    {
                        Lock5.SetActive(false);
                        PlayerPrefs.SetInt("Lock5", 1);
                    }
                }
                break;
            case 6:
                if (menuManager.totalStars >= 10)
                {
                    if (PlayerPrefs.GetInt("Lock6") == 0)
                    {
                        Lock6.SetActive(false);
                        PlayerPrefs.SetInt("Lock6", 1);
                    }
                }
                break;
            case 7:
                if (menuManager.totalStars >= 12)
                {
                    if (PlayerPrefs.GetInt("Lock7") == 0)
                    {
                        Lock7.SetActive(false);
                        PlayerPrefs.SetInt("Lock7", 1);
                    }
                }
                break;
            case 8:
                if (menuManager.totalStars >= 14)
                {
                    if (PlayerPrefs.GetInt("Lock8") == 0)
                    {
                        Lock8.SetActive(false);
                        PlayerPrefs.SetInt("Lock8", 1);
                    }
                }
                break;
            case 9:
                if (menuManager.totalStars >= 16)
                {
                    if (PlayerPrefs.GetInt("Lock9") == 0)
                    {
                        Lock9.SetActive(false);
                        PlayerPrefs.SetInt("Lock9", 1);
                    }
                }
                break;
            case 10:
                if (menuManager.totalStars >= 18)
                {
                    if (PlayerPrefs.GetInt("Lock10") == 0)
                    {
                        Lock10.SetActive(false);
                        PlayerPrefs.SetInt("Lock10", 1);
                    }
                }
                break;
            case 11:
                if (menuManager.totalStars >= 20)
                {
                    if (PlayerPrefs.GetInt("Lock11") == 0)
                    {
                        Lock11.SetActive(false);
                        PlayerPrefs.SetInt("Lock11", 1);
                    }
                }
                break;
            case 12:
                if (menuManager.totalStars >= 22)
                {
                    if (PlayerPrefs.GetInt("Lock12") == 0)
                    {
                        Lock12.SetActive(false);
                        PlayerPrefs.SetInt("Lock12", 1);
                    }
                }
                break;
            case 13:
                if (menuManager.totalStars >= 24)
                {
                    if (PlayerPrefs.GetInt("Lock13") == 0)
                    {
                        Lock13.SetActive(false);
                        PlayerPrefs.SetInt("Lock13", 1);
                    }
                }
                break;
            case 14:
                if (menuManager.totalStars >= 26)
                {
                    if (PlayerPrefs.GetInt("Lock14") == 0)
                    {
                        Lock14.SetActive(false);
                        PlayerPrefs.SetInt("Lock14", 1);
                    }
                }
                break;
            case 15:
                if (menuManager.totalStars >= 28)
                {
                    if (PlayerPrefs.GetInt("Lock15") == 0)
                    {
                        Lock15.SetActive(false);
                        PlayerPrefs.SetInt("Lock15", 1);
                    }
                }
                break;
            case 16:
                if (menuManager.totalStars >= 30)
                {
                    if (PlayerPrefs.GetInt("Lock16") == 0)
                    {
                        Lock16.SetActive(false);
                        PlayerPrefs.SetInt("Lock16", 1);
                    }
                }
                break;
            case 17:
                if (menuManager.totalStars >= 32)
                {
                    if (PlayerPrefs.GetInt("Lock17") == 0)
                    {
                        Lock17.SetActive(false);
                        PlayerPrefs.SetInt("Lock17", 1);
                    }
                }
                break;
            case 18:
                if (menuManager.totalStars >= 34)
                {
                    if (PlayerPrefs.GetInt("Lock18") == 0)
                    {
                        Lock18.SetActive(false);
                        PlayerPrefs.SetInt("Lock18", 1);
                    }
                }
                break;
            case 19:
                if (menuManager.totalStars >= 36)
                {
                    if (PlayerPrefs.GetInt("Lock19") == 0)
                    {
                        Lock19.SetActive(false);
                        PlayerPrefs.SetInt("Lock19", 1);
                    }
                }
                break;
            case 20:
                if (menuManager.totalStars >= 38)
                {
                    if (PlayerPrefs.GetInt("Lock20") == 0)
                    {
                        Lock20.SetActive(false);
                        PlayerPrefs.SetInt("Lock20", 1);
                    }
                }
                break;
            case 21:
                if (menuManager.totalStars >= 40)
                {
                    if (PlayerPrefs.GetInt("Lock21") == 0)
                    {
                        Lock21.SetActive(false);
                        PlayerPrefs.SetInt("Lock21", 1);
                    }
                }
                break;
            case 22:
                if (menuManager.totalStars >= 42)
                {
                    if (PlayerPrefs.GetInt("Lock22") == 0)
                    {
                        Lock22.SetActive(false);
                        PlayerPrefs.SetInt("Lock22", 1);
                    }
                }
                break;
            case 23:
                if (menuManager.totalStars >= 44)
                {
                    if (PlayerPrefs.GetInt("Lock23") == 0)
                    {
                        Lock23.SetActive(false);
                        PlayerPrefs.SetInt("Lock23", 1);
                    }
                }
                break;
            case 24:
                if (menuManager.totalStars >= 46)
                {
                    if (PlayerPrefs.GetInt("Lock24") == 0)
                    {
                        Lock24.SetActive(false);
                        PlayerPrefs.SetInt("Lock24", 1);
                    }
                }
                break;
            case 25:
                if (menuManager.totalStars >= 48)
                {
                    if (PlayerPrefs.GetInt("Lock25") == 0)
                    {
                        Lock25.SetActive(false);
                        PlayerPrefs.SetInt("Lock25", 1);
                    }
                }
                break;
            case 26:
                if (menuManager.totalStars >= 50)
                {
                    if (PlayerPrefs.GetInt("Lock26") == 0)
                    {
                        Lock26.SetActive(false);
                        PlayerPrefs.SetInt("Lock26", 1);
                    }
                }
                break;

            default:
                break;
        }
    }
}
