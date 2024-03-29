using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] int money;
    public int total_money;
    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
        total_money = PlayerPrefs.GetInt("total_money");
    }

    public void ButtonClick() // ��� ������ ������� �� ������ ����� ����� � ��� ����� ������������� �� �������
    {
        money++;
        total_money++;
        PlayerPrefs.SetInt("money", money); // ��������� ������������� ��������
        PlayerPrefs.SetInt("total_money", total_money);
    }

    public void ToAchievements() // ����� �������� � ���� ����������
    {
        SceneManager.LoadScene(1);
    }

    void Update()
    {
        moneyText.text = money.ToString();
    }
}
