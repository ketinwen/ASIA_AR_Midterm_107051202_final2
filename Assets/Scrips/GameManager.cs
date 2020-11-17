using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("大雞")]
    public Transform chicken;
    [Header("小雞")]
    public Transform chick;
    [Header("虛擬搖桿")]
    public FixedJoystick Joystick;
    [Header("旋轉速度"), Range(0.1f, 20f)]
    public float turn = 1.5f;
    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.3f;
    public float Speed = 1.5f;
    [Header("縮放"), Range(0.1f, 1f)]
    public float Size = 0f;
    [Header("大雞動畫元件")]
    public Animator anigugu;
    [Header("小雞動畫元件")]
    public Animator anigugugu;
    private void Start()
    {
        
    }
    public float test = 1;
    private void Update()
    {
        

        

        chicken.Rotate(0, Joystick.Horizontal * Speed, 0);
        chick.Rotate(0, Joystick.Horizontal * Speed, 0);
        chicken.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * Size;
        chicken.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(chicken.localScale.x, 0.5f, 2f);
        chick.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * Size;
        chick.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(chick.localScale.x, 0.5f, 2f);
       
    }
    public void Attack()
    {
        print("走路");
        anigugu.SetTrigger("走路");
        anigugugu.SetTrigger("走路");

    }
    public void PlayAnimation(string aniName)
    {
        print(aniName);
        anigugu.SetTrigger(aniName);
        anigugugu.SetTrigger(aniName);


    }
}
