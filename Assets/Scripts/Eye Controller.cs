using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeController : MonoBehaviour
{
    private int distance = 5;
    private int movement = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MoveBat");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        if (collision.gameObject.CompareTag("fire"))
            Destroy(gameObject);
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
            Destroy(gameObject);
    }
    IEnumerator MoveBat()
    {
        while (true)
        {
            transform.Translate(new Vector2(0, .2f) * movement);
            distance = -1;
            if (distance <= 0)
            {
                distance = 5;
                movement *= -1; 
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
