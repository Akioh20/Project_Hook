using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlideMenu : MonoBehaviour
{

    public GameObject[] levels;
    public GameObject[] locks;
    public GameObject[] titles;

    private Vector2[] menu1Positions;
    private Vector2[] lock1Positions;
    private Vector2[] titlesPositions;
    private bool clickable;
    private int counter;
    private int numberOfSlides;

    void Start()
    {
        clickable = true;
        counter = 0;
        numberOfSlides = 1;

        menu1Positions = new Vector2[levels.Length];
        lock1Positions = new Vector2[locks.Length];
        titlesPositions = new Vector2[titles.Length];

        for (int i = 0; i < menu1Positions.Length; i++)
        {
            menu1Positions[i] = new Vector2(levels[i].gameObject.transform.position.x, levels[i].gameObject.transform.position.y);
        }

        for (int i = 0; i < lock1Positions.Length; i++)
        {
            lock1Positions[i] = new Vector2(locks[i].gameObject.transform.position.x, locks[i].gameObject.transform.position.y);
        }

        for (int i = 0; i < titlesPositions.Length; i++)
        {
            titlesPositions[i] = new Vector2(titles[i].gameObject.transform.position.x, titles[i].gameObject.transform.position.y);
        }
    }

    void Update() { }

    public void SlideToLeft()
    {
        if (clickable && counter < numberOfSlides)
        {
            for (int i = 0; i < menu1Positions.Length; i++)
            {
                menu1Positions[i] = new Vector2(levels[i].gameObject.transform.position.x, levels[i].gameObject.transform.position.y);
                lock1Positions[i] = new Vector2(locks[i].gameObject.transform.position.x, locks[i].gameObject.transform.position.y);
                StartCoroutine("SliderLevelsAndLocksLeft", i);
            }

            for (int i = 0; i < titlesPositions.Length; i++)
            {
                titlesPositions[i] = new Vector2(titles[i].gameObject.transform.position.x, titles[i].gameObject.transform.position.y);
                StartCoroutine("SliderTitlesLeft", i);
            }
            counter++;
        }
    }

    public void SlideToRight()
    {
        if (clickable && counter > 0)
        {
            for (int i = 0; i < menu1Positions.Length; i++)
            {
                menu1Positions[i] = new Vector2(levels[i].gameObject.transform.position.x, levels[i].gameObject.transform.position.y);
                lock1Positions[i] = new Vector2(locks[i].gameObject.transform.position.x, locks[i].gameObject.transform.position.y);
                StartCoroutine("SliderLevelsAndLocksRight", i);
            }

            for (int i = 0; i < titlesPositions.Length; i++)
            {
                titlesPositions[i] = new Vector2(titles[i].gameObject.transform.position.x, titles[i].gameObject.transform.position.y);
                StartCoroutine("SliderTitlesRight", i);
            }
            counter--;
        }
    }

    //WITHOUT SMOOTH
    /*
    IEnumerator SliderLocksRight(int i)
    {
        float value = 0f;
        float duration = 1f;
        while (value < duration)
        {
            value = Mathf.Min(value + Time.unscaledDeltaTime, duration);
            locks[i].transform.position = lock1Positions[i] + new Vector2(1920 * value, 0);
            yield return null;
        }
    }

    IEnumerator SliderLevelsRight(int i)
    {
        float value = 0f;
        float duration = 1f;
        while (value < duration)
        {
            value = Mathf.Min(value + Time.unscaledDeltaTime, duration);
            levels[i].transform.position = menu1Positions[i] + new Vector2(1920 * value, 0);
            yield return null;
        }
    }

    IEnumerator SliderLocksLeft(int i)
    {
        float value = 0f;
        float duration = 1f;
        while (value < duration)
        {
            value = Mathf.Min(value + Time.unscaledDeltaTime, duration);
            locks[i].transform.position = lock1Positions[i] - new Vector2(1920 * value, 0);
            yield return null;
        }
    }

    IEnumerator SliderLevelsLeft(int i)
    {
        float value = 0f;
        float duration = 1f;
        while (value < duration)
        {
            value = Mathf.Min(value + Time.unscaledDeltaTime, duration);
            levels[i].transform.position = menu1Positions[i] - new Vector2(1920 * value, 0);
            yield return null;
        }
    }*/

    //WITH SMOOTH
    IEnumerator SliderLevelsAndLocksRight(int i)
    {
        clickable = false;
        float value = 0f;
        float duration = 1f;
        while (value < duration)
        {
            float t = value / duration;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            levels[i].transform.position = menu1Positions[i] + new Vector2(1920 * t, 0);
            locks[i].transform.position = lock1Positions[i] + new Vector2(1920 * t, 0);
            value += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSecondsRealtime(0.25f);
        clickable = true;
    }

    IEnumerator SliderLevelsAndLocksLeft(int i)
    {
        clickable = false;
        float value = 0f;
        float duration = 1f;
        while (value < duration)
        {
            float t = value / duration;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            levels[i].transform.position = menu1Positions[i] - new Vector2(1920 * t, 0);
            locks[i].transform.position = lock1Positions[i] - new Vector2(1920 * t, 0);
            value += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSecondsRealtime(0.5f);
        clickable = true;
    }

    IEnumerator SliderTitlesRight(int i)
    {
        clickable = false;
        float value = 0f;
        float duration = 1f;
        while (value < duration)
        {
            float t = value / duration;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            titles[i].transform.position = titlesPositions[i] + new Vector2(1920 * t, 0);
            value += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSecondsRealtime(0.5f);
        clickable = true;
    }

    IEnumerator SliderTitlesLeft(int i)
    {
        clickable = false;
        float value = 0f;
        float duration = 1f;
        while (value < duration)
        {
            float t = value / duration;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            titles[i].transform.position = titlesPositions[i] - new Vector2(1920 * t, 0);
            value += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSecondsRealtime(0.5f);
        clickable = true;
    }
}