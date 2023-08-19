using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //NameSurname
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField surnameInput;
    private string Name;
    private string surname;

    //Gendler
    private string gendler;

    
    public void GoToSurvey()
    {
        SceneManager.LoadScene(1);
    }

    public void InputField()
    {
        Name = nameInput.text;
        surname = surnameInput.text;
    }

    public void MaleToggle()
    {
        gendler = "Erkek";
    }
    public void FemaleToggle()
    {
        gendler = "Kadýn";
    }
}