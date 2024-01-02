using UnityEngine;
using UnityEngine.UI;

public class leaderCards : MonoBehaviour
{    
    void Update()
    {
        if (GetComponent<Animator>().GetBool("fly"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Animator>().SetTrigger("enter");
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                GetComponent<Animator>().SetBool("fall", true);
                GetComponent<Animator>().SetBool("fly", false);
            }
        }
    }

    public void button()
    {
        GetComponent<Animator>().SetBool("fly", true);
        GetComponent<Animator>().SetBool("fall", false);
    }
}