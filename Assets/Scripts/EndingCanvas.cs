using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCanvas : MonoBehaviour
{
    public GameObject Canvas;

    private IEnumerator WaitForEnding()
    {
        yield return new WaitForSeconds(5);
        Canvas.SetActive(true);
    }

    private void Update()
    {
        StartCoroutine(WaitForEnding());
    }
}
