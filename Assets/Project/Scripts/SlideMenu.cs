using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideMenu : MonoBehaviour
{
    public Animator animatorLevels1;
    public Animator animatorLocks1;
    public Animator animatorExtraLevels;
    public Animator animatorExtraLocks;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SlideToLeft()
    {
        animatorLevels1.Play("SlideLeft");
        animatorLocks1.Play("SlideLeft");
        animatorExtraLevels.Play("SlideLeft");
    }

    public void SlideToRight()
    {
        animatorLevels1.Play("SlideRight");
        animatorLocks1.Play("SlideRight");
    }
}
