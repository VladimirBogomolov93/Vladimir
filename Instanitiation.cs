using UnityEngine;
using System.Collections;

public class Instanitiation : MonoBehaviour {
    public GameObject[] prefablist = new GameObject[7];
    public Control stop;
    void Start () {
        Sozdatb();
	}
	
	// Update is called once per frame
	void Update () {
        Checkbot();
}

    void Checkbot() {
        if (stop.bot == true)
        {
            Sozdatb();
        }
    }  
    void Sozdatb() {
        Instantiate(prefablist[Random.Range(0, prefablist.Length)], new Vector3(-1, 13, 0), Quaternion.identity);
    }
}
