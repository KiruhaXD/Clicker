using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AchMenu : MonoBehaviour
{
    public int total_money; // ����� ����� ������������ �����
    [SerializeField] Button firstAch; 
    [SerializeField] bool isFirst; // ���������� ��� ����, �������� �� ���������� ��� ���

    void Start()
    {
        total_money = PlayerPrefs.GetInt("total_money"); // �������� ��������
        isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;

        // ���� � ��� ������ ��� ����� 10 ����� � ���������� isFalse ����� false,
        // �� ���� �� �� �������� ��� ����������, �� ����� interactable
        // ���� ��� ����������� ������ �� ����������
        if (total_money >= 10 && !isFirst) // ���������� isFirst � ������ !
                                           // �������� ��� �� ��������� �������� ������ ���������� ���� false
            firstAch.interactable = true;

        // ����� ��� ��� ������� �� �����������, �� �� �� ������ ������ �� ������ ����������
        else 
            firstAch.interactable = false;
    }

    // ����� ��� ��������� ������� ����������
    public void GetFirst() 
    {
        int money = PlayerPrefs.GetInt("money"); // ������� ��������� ���������� money, � �� ��������� �������� �� �������
        money += 10; 
        PlayerPrefs.SetInt("money", money); // ��������� �������
        isFirst = true; // �������� ����������
        PlayerPrefs.SetInt("isFirst", isFirst ? 1 : 0); // ��������� ���������� � ������ � ������� ���������� ���������
    }

    public void ToMenu() 
    {
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        
    }
}
