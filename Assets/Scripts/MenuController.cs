using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject left;
    [SerializeField] GameObject right;
    Animator leftAnim;
    Animator rightAnim;

    void Start(){
        leftAnim = left.GetComponent<Animator>();
        rightAnim = right.GetComponent<Animator>();
    }

    public void StartGame(){
        leftAnim.SetBool("isRun",true);
        rightAnim.SetBool("isRun",true);
    }

    public void QuitGame(){
        Application.Quit();
    }

}
