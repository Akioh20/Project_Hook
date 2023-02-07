using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprites : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBodySprite(string bodySpriteName)
    {
        PlayerPrefs.SetString("Body", bodySpriteName);
    }

    public void SetJointSprite(string JointSpriteName)
    {
        PlayerPrefs.SetString("Joint", JointSpriteName);
    }

    public void SetArmSprite(string ArmSpriteName)
    {
        PlayerPrefs.SetString("Arm", ArmSpriteName);
    }

    public void SetHandSprite(string HandSpriteName)
    {
        PlayerPrefs.SetString("Hand", HandSpriteName);
    }

    public void SetBrokenArmSprite(string BrokenArmSpriteName)
    {
        PlayerPrefs.SetString("BrokenArm", BrokenArmSpriteName);
    }
}
