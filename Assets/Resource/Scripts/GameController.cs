using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
    public GameObject[] prefabs;
    public GameObject yellow;
    public float speed = 1.5f;
    private GameObject obj;
    public  int score=0;
    public Text display;
    public AudioSource bubble;
	void Start ()
    {
        produce();
       
    }
	void produce()
    {
        Vector3 pos = new Vector3(-3-1.4f, -13-1.4f, -1);
        Instantiate(prefabs[1],pos, new Quaternion());
        for(int i=1;i<=5;i++)
        {
            int ran = Random.Range(1, 4);
            int rancolor = Random.Range(0, 8);
            int othercolor = Random.Range(0, 8);
            while(othercolor==rancolor)
            {
                othercolor = Random.Range(0, 8);
            }
            for(int j=1;j<=4;j++)
            {
                if (ran == j)
                {

                    GameObject t = Instantiate(prefabs[rancolor], pos + new Vector3(j * 1.4f, i * 1.4f, 0f), prefabs[rancolor].transform.rotation) as GameObject;
                    t.tag = "Bubble"+i;
                    t.GetComponent<Rigidbody>().velocity= new Vector3(0f, speed, 0f);
                    if (i == 1)
                        obj = t;
                }
                else
                {
                   GameObject t2=   Instantiate(prefabs[othercolor], pos + new Vector3(j * 1.4f, i * 1.4f, 0f), prefabs[othercolor].transform.rotation) as GameObject;
                     t2.GetComponent<Rigidbody>().velocity = new Vector3(0f, speed, 0f);
                    t2.tag = "other" + i;
                }
            }     
        }
    }
    void Update()
    {
        if (obj.transform.position.y >-6.07f)
        {
           produce();
           speed = speed +0.1f;
        }
        display.text = "得分：" + score * 10;
    }
           
	
}
