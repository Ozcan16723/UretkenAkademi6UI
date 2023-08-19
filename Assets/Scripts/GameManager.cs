using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    #region Variables
    [Header("surveyPanel")]
    [SerializeField] GameObject surveyPanel;
    [Header("Idenity")]
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField surnameInput;
    [SerializeField] private TMP_InputField ageInput;
    private string Name;
    private string surname;
    private string age;

    [Header("Gendler")]
    private string gendler;

    [Header("Evaluation")]
    [SerializeField] private Slider courseEvaluationSlider;
    [SerializeField] private Text coursePercent;
    [SerializeField] private Slider platformEvaluationSlider;
    [SerializeField] private Text platformPercent;
    string courseEvalutionValue;
    string platformEvaluationValue;

    [Header("Questions")]
    [SerializeField] private TMP_InputField question_One;
    [SerializeField] private TMP_InputField question_Two;
    [SerializeField] private TMP_InputField question_Three;
    private string question_OneValue;
    private string question_TwoValue;
    private string question_ThreeValue;

    [Header("Result Panel")]
    [SerializeField] GameObject resultPanel;
    [SerializeField] TMP_Text nameResult;
    [SerializeField] TMP_Text surnameResult;
    [SerializeField] TMP_Text ageResult;
    [SerializeField] TMP_Text gendlerResult;
    [SerializeField] TMP_Text courseEvuolationResult;
    [SerializeField] TMP_Text platformEvaluationResult;
    [SerializeField] TMP_Text questionOneResult;
    [SerializeField] TMP_Text questionTwoResult;
    [SerializeField] TMP_Text questionThreeResult;
    #endregion

    public void GoToSurvey()
    {
        SceneManager.LoadScene(1);
    }

    public void Identity()
    {
        Name = nameInput.text;
        surname = surnameInput.text;
        age = ageInput.text;
    }

    public void MaleToggle()
    {
        gendler = "Erkek";
    }
    public void FemaleToggle()
    {
        gendler = "Kadýn";
    }

    public void CourseEvaluationSlider()

    {
        courseEvalutionValue = courseEvaluationSlider.value.ToString();
        coursePercent.text = "% " + courseEvalutionValue;
    }
    public void PlatformEvalutionSlider()
    {
        platformEvaluationValue = platformEvaluationSlider.value.ToString();
        platformPercent.text = "% " + platformEvaluationValue;
    }

    public void Questions()
    {
        question_OneValue = question_One.text;
        question_TwoValue = question_Two.text;
        question_ThreeValue = question_Three.text;
    }

    public void NextButton()
    {
        surveyPanel.gameObject.SetActive(false);
        resultPanel.gameObject.SetActive(true);
        nameResult.text += Name;
        surnameResult.text += surname;
        ageResult.text += age;
        gendlerResult.text += gendler;
        courseEvuolationResult.text += courseEvalutionValue;
        platformEvaluationResult.text += platformEvaluationValue;
        questionOneResult.text += question_OneValue;
        questionTwoResult.text += question_TwoValue;
        questionThreeResult.text += question_ThreeValue;
    }
}