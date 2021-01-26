using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button reset;
    public Button firstbutton;
    public Button secondbutton;
    public Button thirdbutton;
    [SerializeField]
    private Animator _firstanim;


    void Start()
    {
        reset.onClick.AddListener(() => Restart());
        firstbutton.onClick.AddListener(() => FirstButton());
        secondbutton.onClick.AddListener(() => SecondButton());
        thirdbutton.onClick.AddListener(() => ThirdButton());

    }


    private void Update()
    {
       
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void FirstButton()
    {
        _firstanim.SetTrigger("MoveFirstCube");
    }

    void SecondButton()
    {
        _firstanim.SetTrigger("MoveCubeTwo");
    }
    void ThirdButton()
    {
       _firstanim.SetTrigger("MoveThirdCube");
    }


}
