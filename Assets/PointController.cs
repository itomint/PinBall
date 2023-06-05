using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    GameObject pointText;
    private int point = 0;


   


    // Start is called before the first frame update
    void Start()
    {
        this.pointText = GameObject.Find("PointText");
    }





    // Update is called once per frame
    void Update()
    {
        this.pointText.GetComponent<Text>().text = this.point.ToString() + " Point";
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            point += 5;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            point += 10;
        }

        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            point += 20;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            point += 30;
        }
    }
}
