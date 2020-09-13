using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotCom : MonoBehaviour
{
    public GameObject[] robots;


	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRobotsToIdle()
	{
        robots = GameObject.FindGameObjectsWithTag("Robot");

        if (robots != null)
		{
            for (int i = 0; i < robots.Length; i++)
            {
                robots[i].GetComponent<RobotManager>().SetAnimationController(0);
            }
        }

	}

    public void SetRobotsToDance(int animation)
    {
        robots = GameObject.FindGameObjectsWithTag("Robot");

        if (robots != null)
        {
			for (int i = 0; i < robots.Length; i++)
            {
				robots[i].GetComponent<RobotManager>().SetAnimationController(animation);
            }
        }

    }

   
}
