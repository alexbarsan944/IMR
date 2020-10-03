using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamDistance : MonoBehaviour
{
    public GameObject object1, object2;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(object1.transform.position, object2.transform.position);
        if(distance <= 11)
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);

        }

    }
}
