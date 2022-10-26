using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ExecuteSomthing());
    }
    
    IEnumerator ExecuteSomthing ()
    {
        yield return new WaitForSeconds(2f);

        Debug.Log("Something Cool");
    }
}
