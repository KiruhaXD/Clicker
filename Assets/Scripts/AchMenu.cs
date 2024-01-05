using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AchMenu : MonoBehaviour
{
    public int total_money; // общее число заработанных очков
    [SerializeField] Button firstAch; 
    [SerializeField] bool isFirst; // переменная для того, получено ли достижение или нет

    void Start()
    {
        total_money = PlayerPrefs.GetInt("total_money"); // получаем значение
        isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;

        // если у нас больше или равно 10 монет и переменная isFalse равна false,
        // то есть мы не получали это достижение, то метод interactable
        // даст нам возможность нажать на достижение
        if (total_money >= 10 && !isFirst) // переменная isFirst с знаком !
                                           // означает что мы присвоили значение данной переменной типа false
            firstAch.interactable = true;

        // еслиу нас эти условия не выполнились, то мы не сможем нажать на данное достижение
        else 
            firstAch.interactable = false;
    }

    // метод для поулчения первого достижения
    public void GetFirst() 
    {
        int money = PlayerPrefs.GetInt("money"); // создаем локальную переменную money, в неё загружаем значение из реестра
        money += 10; 
        PlayerPrefs.SetInt("money", money); // загружаем обратно
        isFirst = true; // получили достижение
        PlayerPrefs.SetInt("isFirst", isFirst ? 1 : 0); // сохраняем достижение в реестр с помощью тернарного оператора
    }

    public void ToMenu() 
    {
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        
    }
}
