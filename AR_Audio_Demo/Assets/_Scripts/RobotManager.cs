using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotManager : MonoBehaviour
{

    public RuntimeAnimatorController[] animatorControllers;
    
    public Animator anim;


	private void Awake()
	{
        anim = GetComponent<Animator>();
		anim.runtimeAnimatorController = animatorControllers[0];
    }
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetAnimationController(int animation)
	{
        if (animation >= 0 && animation <= animatorControllers.Length)
		{
            anim.runtimeAnimatorController = animatorControllers[animation];
        }
		else
		{
            return;
		}
        
    }
}
