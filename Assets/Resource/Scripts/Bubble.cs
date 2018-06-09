using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {
    private bool update;
    // Use this for initialization
    public GameController sc;
	void Start () {
        sc = GameObject.FindGameObjectWithTag("Player").GetComponent<GameController>();
	}
    void OnMouseDown()
    {
        if (tag == "Bubble1")
        {
            GameObject[] obj = GameObject.FindGameObjectsWithTag("other1");
            for (int i = 1; i <= obj.Length; i++)
            {
                if (Vector3.Distance(transform.position, obj[i - 1].transform.position) < 5f)
                    Destroy(obj[i - 1]);
            }
            Destroy(gameObject);
            sc.score++;
            sc.bubble.Play();
        }
        else if (tag == "Bubble2")
        {
            GameObject[] obj = GameObject.FindGameObjectsWithTag("other2");
            for (int i = 1; i <= obj.Length; i++)
            {
                if (Vector3.Distance(transform.position, obj[i - 1].transform.position) < 5f)
                    Destroy(obj[i - 1]);
            }
            Destroy(gameObject);
            sc.score++;
            sc.bubble.Play();
        }
        else if (tag == "Bubble3")
        {
            GameObject[] obj = GameObject.FindGameObjectsWithTag("other3");
            for (int i = 1; i <= obj.Length; i++)
            {
                if (Vector3.Distance(transform.position, obj[i - 1].transform.position) < 5f)
                    Destroy(obj[i - 1]);
            }
            Destroy(gameObject);
            sc.score++;
            sc.bubble.Play();
        }
        else if (tag == "Bubble4")
        {
            GameObject[] obj = GameObject.FindGameObjectsWithTag("other4");
            for (int i = 1; i <= obj.Length; i++)
            {
                if (Vector3.Distance(transform.position, obj[i - 1].transform.position) < 5f)
                    Destroy(obj[i - 1]);
            }
            Destroy(gameObject);
            sc.score++;
            sc.bubble.Play();
        }
        else if (tag == "Bubble5")
        {
            GameObject[] obj = GameObject.FindGameObjectsWithTag("other5");
            for (int i = 1; i <= obj.Length; i++)
            {
                if(Vector3.Distance(transform.position,obj[i-1].transform.position)<5f)
                          Destroy(obj[i - 1]);
            }
               
            Destroy(gameObject);
            sc.score++;
            sc.bubble.Play();
        }
        else
            update = false;
    }
}
