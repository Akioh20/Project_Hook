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

    private Vector2[] menu1Positions;
    private Vector2[] lock1Positions;

    void Start()
    {
        menu1Positions = new Vector2[levels.Length];
        lock1Positions = new Vector2[locks.Length];

        for (int i = 0; i < menu1Positions.Length; i++)
        {
            menu1Positions[i] = new Vector2(levels[i].gameObject.transform.position.x, levels[i].gameObject.transform.position.y);
        }

        for (int i = 0; i < lock1Positions.Length; i++)
        {
            lock1Positions[i] = new Vector2(locks[i].gameObject.transform.position.x, locks[i].gameObject.transform.position.y);
        }
    }

    void Update()
    {

    }

    public void SlideToLeft()
    {
        for (int i = 0; i < menu1Positions.Length; i++)
        {
            menu1Positions[i] = new Vector2(levels[i].gameObject.transform.position.x, levels[i].gameObject.transform.position.y);
            StartCoroutine("SliderLevelsLeft", i);
        }

        for (int i = 0; i < lock1Positions.Length; i++)
        {
            lock1Positions[i] = new Vector2(locks[i].gameObject.transform.position.x, locks[i].gameObject.transform.position.y);
            StartCoroutine("SliderLocksLeft", i);
        }
    }

    public void SlideToRight()
    {
        for (int i = 0; i < menu1Positions.Length; i++)
        {
            menu1Positions[i] = new Vector2(levels[i].gameObject.transform.position.x, levels[i].gameObject.transform.position.y);
            StartCoroutine("SliderLevelsRight", i);
        }

        for (int i = 0; i < lock1Positions.Length; i++)
        {
            lock1Positions[i] = new Vector2(locks[i].gameObject.transform.position.x, locks[i].gameObject.transform.position.y);
            StartCoroutine("SliderLocksRight", i);
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
      IEnumerator SliderLocksRight(int i)
    {
        float value = 0f;
        float duration = 1f;
        while (value < duration)
        {
            float t = value / duration;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            locks[i].transform.position = lock1Positions[i] + new Vector2(1920 * t, 0);
            value += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator SliderLevelsRight(int i)
    {
        float value = 0f;
        float duration = 1f;
        while (value < duration)
        {
            float t = value / duration;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            levels[i].transform.position = menu1Positions[i] + new Vector2(1920 * t, 0);
            value += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator SliderLocksLeft(int i)
    {
        float value = 0f;
        float duration = 1f;
        while (value < duration)
        {
            float t = value / duration;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            locks[i].transform.position = lock1Positions[i] - new Vector2(1920 * t, 0);
            value += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator SliderLevelsLeft(int i)
    {
        float value = 0f;
        float duration = 1f;
        while (value < duration)
        {
            float t = value / duration;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            levels[i].transform.position = menu1Positions[i] - new Vector2(1920 * t, 0);
            value += Time.deltaTime;
            yield return null;
        }
    }
}
