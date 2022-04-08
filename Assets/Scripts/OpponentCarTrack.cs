using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentCarTrack : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject[] MarkList;
    public int MarkTracker;

    void Start()
    {
        MarkTracker = 0;

        if (MarkList == null)
        {
            MarkList = GameObject.FindGameObjectsWithTag("OpponentMark");
        }
    }

    void Update()
    {
        TheMarker.transform.position = MarkList[MarkTracker].transform.position;
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "OpponentCar")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == MarkList.Length)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
