using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public GameObject tutorial;
    // Start is called before the first frame update
    void Start()
    {
        tutorial.SetActive(true);
        StartCoroutine("RemoveTutorial");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator RemoveTutorial()
    {
        yield return new WaitForSeconds(5);
        tutorial.SetActive(false);
    }
}
