using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStars : MonoBehaviour
{
    public GameObject[] stars1;
    public GameObject[] stars2;
    public GameObject[] stars3;
    public GameObject[] stars4;
    public GameObject[] stars5;
    public GameObject[] stars6;
    public GameObject[] stars7;
    public GameObject[] stars8;
    public GameObject[] stars9;
    public GameObject[] stars10;
    public GameObject[] stars11;
    public GameObject[] stars12;
    public GameObject[] stars13;
    public GameObject[] stars14;
    public GameObject[] stars15;
    public GameObject[] stars16;
    public GameObject[] stars17;
    public GameObject[] stars18;
    public GameObject[] stars19;
    public GameObject[] stars20;
    public GameObject[] stars21;
    public GameObject[] stars22;
    public GameObject[] stars23;
    public GameObject[] stars24;
    public GameObject[] stars25;
    public GameObject[] stars26;
    public GameObject[] stars27;
    public GameObject[] stars28;
    public GameObject[] stars29;
    public GameObject[] stars30;
    public GameObject[] stars31;

    private SaveData dataScript;

    // Start is called before the first frame update
    void Start()
    {
        SetStarsFunc();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStarsFunc()
    {
        dataScript = FindObjectOfType<SaveData>();

        switch (dataScript.GetLevelStars(1))
        {
            case 0:
                stars1[3].SetActive(true);
                stars1[4].SetActive(true);
                stars1[5].SetActive(true);
                break;
            case 1:
                stars1[0].SetActive(true);
                stars1[4].SetActive(true);
                stars1[5].SetActive(true);
                break;
            case 2:
                stars1[0].SetActive(true);
                stars1[1].SetActive(true);
                stars1[5].SetActive(true);
                break;
            case 3:
                stars1[0].SetActive(true);
                stars1[1].SetActive(true);
                stars1[2].SetActive(true);
                break;
            default:
                break;
        }


        if (PlayerPrefs.GetInt("Lock2") == 1)
        {
            switch (dataScript.GetLevelStars(2))
            {
                case 0:
                    stars2[3].SetActive(true);
                    stars2[4].SetActive(true);
                    stars2[5].SetActive(true);
                    break;
                case 1:
                    stars2[0].SetActive(true);
                    stars2[4].SetActive(true);
                    stars2[5].SetActive(true);
                    break;
                case 2:
                    stars2[0].SetActive(true);
                    stars2[1].SetActive(true);
                    stars2[5].SetActive(true);
                    break;
                case 3:
                    stars2[0].SetActive(true);
                    stars2[1].SetActive(true);
                    stars2[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock3") == 1)
        {
            switch (dataScript.GetLevelStars(3))
            {
                case 0:
                    stars3[3].SetActive(true);
                    stars3[4].SetActive(true);
                    stars3[5].SetActive(true);
                    break;
                case 1:
                    stars3[0].SetActive(true);
                    stars3[4].SetActive(true);
                    stars3[5].SetActive(true);
                    break;
                case 2:
                    stars3[0].SetActive(true);
                    stars3[1].SetActive(true);
                    stars3[5].SetActive(true);
                    break;
                case 3:
                    stars3[0].SetActive(true);
                    stars3[1].SetActive(true);
                    stars3[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock4") == 1)
        {
            switch (dataScript.GetLevelStars(4))
            {
                case 0:
                    stars4[3].SetActive(true);
                    stars4[4].SetActive(true);
                    stars4[5].SetActive(true);
                    break;
                case 1:
                    stars4[0].SetActive(true);
                    stars4[4].SetActive(true);
                    stars4[5].SetActive(true);
                    break;
                case 2:
                    stars4[0].SetActive(true);
                    stars4[1].SetActive(true);
                    stars4[5].SetActive(true);
                    break;
                case 3:
                    stars4[0].SetActive(true);
                    stars4[1].SetActive(true);
                    stars4[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock5") == 1)
        {
            switch (dataScript.GetLevelStars(5))
            {
                case 0:
                    stars5[3].SetActive(true);
                    stars5[4].SetActive(true);
                    stars5[5].SetActive(true);
                    break;
                case 1:
                    stars5[0].SetActive(true);
                    stars5[4].SetActive(true);
                    stars5[5].SetActive(true);
                    break;
                case 2:
                    stars5[0].SetActive(true);
                    stars5[1].SetActive(true);
                    stars5[5].SetActive(true);
                    break;
                case 3:
                    stars5[0].SetActive(true);
                    stars5[1].SetActive(true);
                    stars5[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock6") == 1)
        {
            switch (dataScript.GetLevelStars(6))
            {
                case 0:
                    stars6[3].SetActive(true);
                    stars6[4].SetActive(true);
                    stars6[5].SetActive(true);
                    break;
                case 1:
                    stars6[0].SetActive(true);
                    stars6[4].SetActive(true);
                    stars6[5].SetActive(true);
                    break;
                case 2:
                    stars6[0].SetActive(true);
                    stars6[1].SetActive(true);
                    stars6[5].SetActive(true);
                    break;
                case 3:
                    stars6[0].SetActive(true);
                    stars6[1].SetActive(true);
                    stars6[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock7") == 1)
        {
            switch (dataScript.GetLevelStars(7))
            {
                case 0:
                    stars7[3].SetActive(true);
                    stars7[4].SetActive(true);
                    stars7[5].SetActive(true);
                    break;
                case 1:
                    stars7[0].SetActive(true);
                    stars7[4].SetActive(true);
                    stars7[5].SetActive(true);
                    break;
                case 2:
                    stars7[0].SetActive(true);
                    stars7[1].SetActive(true);
                    stars7[5].SetActive(true);
                    break;
                case 3:
                    stars7[0].SetActive(true);
                    stars7[1].SetActive(true);
                    stars7[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock8") == 1)
        {
            switch (dataScript.GetLevelStars(8))
            {
                case 0:
                    stars8[3].SetActive(true);
                    stars8[4].SetActive(true);
                    stars8[5].SetActive(true);
                    break;
                case 1:
                    stars8[0].SetActive(true);
                    stars8[4].SetActive(true);
                    stars8[5].SetActive(true);
                    break;
                case 2:
                    stars8[0].SetActive(true);
                    stars8[1].SetActive(true);
                    stars8[5].SetActive(true);
                    break;
                case 3:
                    stars8[0].SetActive(true);
                    stars8[1].SetActive(true);
                    stars8[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock9") == 1)
        {
            switch (dataScript.GetLevelStars(9))
            {
                case 0:
                    stars9[3].SetActive(true);
                    stars9[4].SetActive(true);
                    stars9[5].SetActive(true);
                    break;
                case 1:
                    stars9[0].SetActive(true);
                    stars9[4].SetActive(true);
                    stars9[5].SetActive(true);
                    break;
                case 2:
                    stars9[0].SetActive(true);
                    stars9[1].SetActive(true);
                    stars9[5].SetActive(true);
                    break;
                case 3:
                    stars9[0].SetActive(true);
                    stars9[1].SetActive(true);
                    stars9[2].SetActive(true);
                    break;
                default:
                    break;
            }

        }
        if (PlayerPrefs.GetInt("Lock10") == 1)
        {
            switch (dataScript.GetLevelStars(10))
            {
                case 0:
                    stars10[3].SetActive(true);
                    stars10[4].SetActive(true);
                    stars10[5].SetActive(true);
                    break;
                case 1:
                    stars10[0].SetActive(true);
                    stars10[4].SetActive(true);
                    stars10[5].SetActive(true);
                    break;
                case 2:
                    stars10[0].SetActive(true);
                    stars10[1].SetActive(true);
                    stars10[5].SetActive(true);
                    break;
                case 3:
                    stars10[0].SetActive(true);
                    stars10[1].SetActive(true);
                    stars10[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock11") == 1)
        {
            switch (dataScript.GetLevelStars(11))
            {
                case 0:
                    stars11[3].SetActive(true);
                    stars11[4].SetActive(true);
                    stars11[5].SetActive(true);
                    break;
                case 1:
                    stars11[0].SetActive(true);
                    stars11[4].SetActive(true);
                    stars11[5].SetActive(true);
                    break;
                case 2:
                    stars11[0].SetActive(true);
                    stars11[1].SetActive(true);
                    stars11[5].SetActive(true);
                    break;
                case 3:
                    stars11[0].SetActive(true);
                    stars11[1].SetActive(true);
                    stars11[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock12") == 1)
        {
            switch (dataScript.GetLevelStars(12))
            {
                case 0:
                    stars12[3].SetActive(true);
                    stars12[4].SetActive(true);
                    stars12[5].SetActive(true);
                    break;
                case 1:
                    stars12[0].SetActive(true);
                    stars12[4].SetActive(true);
                    stars12[5].SetActive(true);
                    break;
                case 2:
                    stars12[0].SetActive(true);
                    stars12[1].SetActive(true);
                    stars12[5].SetActive(true);
                    break;
                case 3:
                    stars12[0].SetActive(true);
                    stars12[1].SetActive(true);
                    stars12[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock13") == 1)
        {
            switch (dataScript.GetLevelStars(13))
            {
                case 0:
                    stars13[3].SetActive(true);
                    stars13[4].SetActive(true);
                    stars13[5].SetActive(true);
                    break;
                case 1:
                    stars13[0].SetActive(true);
                    stars13[4].SetActive(true);
                    stars13[5].SetActive(true);
                    break;
                case 2:
                    stars13[0].SetActive(true);
                    stars13[1].SetActive(true);
                    stars13[5].SetActive(true);
                    break;
                case 3:
                    stars13[0].SetActive(true);
                    stars13[1].SetActive(true);
                    stars13[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock14") == 1)
        {
            switch (dataScript.GetLevelStars(14))
            {
                case 0:
                    stars14[3].SetActive(true);
                    stars14[4].SetActive(true);
                    stars14[5].SetActive(true);
                    break;
                case 1:
                    stars14[0].SetActive(true);
                    stars14[4].SetActive(true);
                    stars14[5].SetActive(true);
                    break;
                case 2:
                    stars14[0].SetActive(true);
                    stars14[1].SetActive(true);
                    stars14[5].SetActive(true);
                    break;
                case 3:
                    stars14[0].SetActive(true);
                    stars14[1].SetActive(true);
                    stars14[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock15") == 1)
        {
            switch (dataScript.GetLevelStars(15))
            {
                case 0:
                    stars15[3].SetActive(true);
                    stars15[4].SetActive(true);
                    stars15[5].SetActive(true);
                    break;
                case 1:
                    stars15[0].SetActive(true);
                    stars15[4].SetActive(true);
                    stars15[5].SetActive(true);
                    break;
                case 2:
                    stars15[0].SetActive(true);
                    stars15[1].SetActive(true);
                    stars15[5].SetActive(true);
                    break;
                case 3:
                    stars15[0].SetActive(true);
                    stars15[1].SetActive(true);
                    stars15[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock16") == 1)
        {
            switch (dataScript.GetLevelStars(16))
            {
                case 0:
                    stars16[3].SetActive(true);
                    stars16[4].SetActive(true);
                    stars16[5].SetActive(true);
                    break;
                case 1:
                    stars16[0].SetActive(true);
                    stars16[4].SetActive(true);
                    stars16[5].SetActive(true);
                    break;
                case 2:
                    stars16[0].SetActive(true);
                    stars16[1].SetActive(true);
                    stars16[5].SetActive(true);
                    break;
                case 3:
                    stars16[0].SetActive(true);
                    stars16[1].SetActive(true);
                    stars16[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock17") == 1)
        {
            switch (dataScript.GetLevelStars(17))
            {
                case 0:
                    stars17[3].SetActive(true);
                    stars17[4].SetActive(true);
                    stars17[5].SetActive(true);
                    break;
                case 1:
                    stars17[0].SetActive(true);
                    stars17[4].SetActive(true);
                    stars17[5].SetActive(true);
                    break;
                case 2:
                    stars17[0].SetActive(true);
                    stars17[1].SetActive(true);
                    stars17[5].SetActive(true);
                    break;
                case 3:
                    stars17[0].SetActive(true);
                    stars17[1].SetActive(true);
                    stars17[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock18") == 1)
        {
            switch (dataScript.GetLevelStars(18))
            {
                case 0:
                    stars18[3].SetActive(true);
                    stars18[4].SetActive(true);
                    stars18[5].SetActive(true);
                    break;
                case 1:
                    stars18[0].SetActive(true);
                    stars18[4].SetActive(true);
                    stars18[5].SetActive(true);
                    break;
                case 2:
                    stars18[0].SetActive(true);
                    stars18[1].SetActive(true);
                    stars18[5].SetActive(true);
                    break;
                case 3:
                    stars18[0].SetActive(true);
                    stars18[1].SetActive(true);
                    stars18[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock19") == 1)
        {
            switch (dataScript.GetLevelStars(19))
            {
                case 0:
                    stars19[3].SetActive(true);
                    stars19[4].SetActive(true);
                    stars19[5].SetActive(true);
                    break;
                case 1:
                    stars19[0].SetActive(true);
                    stars19[4].SetActive(true);
                    stars19[5].SetActive(true);
                    break;
                case 2:
                    stars19[0].SetActive(true);
                    stars19[1].SetActive(true);
                    stars19[5].SetActive(true);
                    break;
                case 3:
                    stars19[0].SetActive(true);
                    stars19[1].SetActive(true);
                    stars19[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock20") == 1)
        {
            switch (dataScript.GetLevelStars(20))
            {
                case 0:
                    stars20[3].SetActive(true);
                    stars20[4].SetActive(true);
                    stars20[5].SetActive(true);
                    break;
                case 1:
                    stars20[0].SetActive(true);
                    stars20[4].SetActive(true);
                    stars20[5].SetActive(true);
                    break;
                case 2:
                    stars20[0].SetActive(true);
                    stars20[1].SetActive(true);
                    stars20[5].SetActive(true);
                    break;
                case 3:
                    stars20[0].SetActive(true);
                    stars20[1].SetActive(true);
                    stars20[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock21") == 1)
        {
            switch (dataScript.GetLevelStars(21))
            {
                case 0:
                    stars21[3].SetActive(true);
                    stars21[4].SetActive(true);
                    stars21[5].SetActive(true);
                    break;
                case 1:
                    stars21[0].SetActive(true);
                    stars21[4].SetActive(true);
                    stars21[5].SetActive(true);
                    break;
                case 2:
                    stars21[0].SetActive(true);
                    stars21[1].SetActive(true);
                    stars21[5].SetActive(true);
                    break;
                case 3:
                    stars21[0].SetActive(true);
                    stars21[1].SetActive(true);
                    stars21[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock22") == 1)
        {
            switch (dataScript.GetLevelStars(22))
            {
                case 0:
                    stars22[3].SetActive(true);
                    stars22[4].SetActive(true);
                    stars22[5].SetActive(true);
                    break;
                case 1:
                    stars22[0].SetActive(true);
                    stars22[4].SetActive(true);
                    stars22[5].SetActive(true);
                    break;
                case 2:
                    stars22[0].SetActive(true);
                    stars22[1].SetActive(true);
                    stars22[5].SetActive(true);
                    break;
                case 3:
                    stars22[0].SetActive(true);
                    stars22[1].SetActive(true);
                    stars22[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock23") == 1)
        {
            switch (dataScript.GetLevelStars(23))
            {
                case 0:
                    stars23[3].SetActive(true);
                    stars23[4].SetActive(true);
                    stars23[5].SetActive(true);
                    break;
                case 1:
                    stars23[0].SetActive(true);
                    stars23[4].SetActive(true);
                    stars23[5].SetActive(true);
                    break;
                case 2:
                    stars23[0].SetActive(true);
                    stars23[1].SetActive(true);
                    stars23[5].SetActive(true);
                    break;
                case 3:
                    stars23[0].SetActive(true);
                    stars23[1].SetActive(true);
                    stars23[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock24") == 1)
        {
            switch (dataScript.GetLevelStars(24))
            {
                case 0:
                    stars24[3].SetActive(true);
                    stars24[4].SetActive(true);
                    stars24[5].SetActive(true);
                    break;
                case 1:
                    stars24[0].SetActive(true);
                    stars24[4].SetActive(true);
                    stars24[5].SetActive(true);
                    break;
                case 2:
                    stars24[0].SetActive(true);
                    stars24[1].SetActive(true);
                    stars24[5].SetActive(true);
                    break;
                case 3:
                    stars24[0].SetActive(true);
                    stars24[1].SetActive(true);
                    stars24[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock25") == 1)
        {
            switch (dataScript.GetLevelStars(25))
            {
                case 0:
                    stars25[3].SetActive(true);
                    stars25[4].SetActive(true);
                    stars25[5].SetActive(true);
                    break;
                case 1:
                    stars25[0].SetActive(true);
                    stars25[4].SetActive(true);
                    stars25[5].SetActive(true);
                    break;
                case 2:
                    stars25[0].SetActive(true);
                    stars25[1].SetActive(true);
                    stars25[5].SetActive(true);
                    break;
                case 3:
                    stars25[0].SetActive(true);
                    stars25[1].SetActive(true);
                    stars25[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock26") == 1)
        {
            switch (dataScript.GetLevelStars(26))
            {
                case 0:
                    stars26[3].SetActive(true);
                    stars26[4].SetActive(true);
                    stars26[5].SetActive(true);
                    break;
                case 1:
                    stars26[0].SetActive(true);
                    stars26[4].SetActive(true);
                    stars26[5].SetActive(true);
                    break;
                case 2:
                    stars26[0].SetActive(true);
                    stars26[1].SetActive(true);
                    stars26[5].SetActive(true);
                    break;
                case 3:
                    stars26[0].SetActive(true);
                    stars26[1].SetActive(true);
                    stars26[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock27") == 1)
        {
            switch (dataScript.GetLevelStars(27))
            {
                case 0:
                    stars27[3].SetActive(true);
                    stars27[4].SetActive(true);
                    stars27[5].SetActive(true);
                    break;
                case 1:
                    stars27[0].SetActive(true);
                    stars27[4].SetActive(true);
                    stars27[5].SetActive(true);
                    break;
                case 2:
                    stars27[0].SetActive(true);
                    stars27[1].SetActive(true);
                    stars27[5].SetActive(true);
                    break;
                case 3:
                    stars27[0].SetActive(true);
                    stars27[1].SetActive(true);
                    stars27[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock28") == 1)
        {
            switch (dataScript.GetLevelStars(28))
            {
                case 0:
                    stars28[3].SetActive(true);
                    stars28[4].SetActive(true);
                    stars28[5].SetActive(true);
                    break;
                case 1:
                    stars28[0].SetActive(true);
                    stars28[4].SetActive(true);
                    stars28[5].SetActive(true);
                    break;
                case 2:
                    stars28[0].SetActive(true);
                    stars28[1].SetActive(true);
                    stars28[5].SetActive(true);
                    break;
                case 3:
                    stars28[0].SetActive(true);
                    stars28[1].SetActive(true);
                    stars28[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock29") == 1)
        {
            switch (dataScript.GetLevelStars(29))
            {
                case 0:
                    stars29[3].SetActive(true);
                    stars29[4].SetActive(true);
                    stars29[5].SetActive(true);
                    break;
                case 1:
                    stars29[0].SetActive(true);
                    stars29[4].SetActive(true);
                    stars29[5].SetActive(true);
                    break;
                case 2:
                    stars29[0].SetActive(true);
                    stars29[1].SetActive(true);
                    stars29[5].SetActive(true);
                    break;
                case 3:
                    stars29[0].SetActive(true);
                    stars29[1].SetActive(true);
                    stars29[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Lock30") == 1)
        {
            switch (dataScript.GetLevelStars(30))
            {
                case 0:
                    stars30[3].SetActive(true);
                    stars30[4].SetActive(true);
                    stars30[5].SetActive(true);
                    break;
                case 1:
                    stars30[0].SetActive(true);
                    stars30[4].SetActive(true);
                    stars30[5].SetActive(true);
                    break;
                case 2:
                    stars30[0].SetActive(true);
                    stars30[1].SetActive(true);
                    stars30[5].SetActive(true);
                    break;
                case 3:
                    stars30[0].SetActive(true);
                    stars30[1].SetActive(true);
                    stars30[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }

        if (PlayerPrefs.GetInt("Lock31") == 1)
        {
            switch (dataScript.GetLevelStars(31))
            {
                case 0:
                    stars31[3].SetActive(true);
                    stars31[4].SetActive(true);
                    stars31[5].SetActive(true);
                    break;
                case 1:
                    stars31[0].SetActive(true);
                    stars31[4].SetActive(true);
                    stars31[5].SetActive(true);
                    break;
                case 2:
                    stars31[0].SetActive(true);
                    stars31[1].SetActive(true);
                    stars31[5].SetActive(true);
                    break;
                case 3:
                    stars31[0].SetActive(true);
                    stars31[1].SetActive(true);
                    stars31[2].SetActive(true);
                    break;
                default:
                    break;
            }
        }
    }
}
