using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimations : MonoBehaviour
{
    private Animator knightAnimation;
    // Start is called before the first frame update
    private void Start()
    {
        knightAnimation = GetComponent<Animator>();
    }

    public void isStartWalking()
    {
        knightAnimation.SetBool("isWalking", true);
    }
    public void isStopWalking()
    {
        knightAnimation.SetBool("isWalking", false);
    }
}
