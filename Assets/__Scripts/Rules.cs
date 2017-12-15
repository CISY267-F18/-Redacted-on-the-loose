using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    public int currentPage;
    public GameObject Rules1;
    public GameObject Rules2;
    public GameObject Rules3;
    public GameObject Rules4;
    public GameObject Rules5;
    public GameObject Rules6;
    public GameObject Rules7;
    public GameObject Rules8;
    public GameObject BackButton;
    public GameObject NextButton;

    void Start()
    {
        currentPage = 1;
        Rules1.SetActive(true);
        BackButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPage == 1)
        {
            Rules1.SetActive(true);
            Rules2.SetActive(false);
            Rules3.SetActive(false);
            Rules4.SetActive(false);
            Rules5.SetActive(false);
            Rules6.SetActive(false);
            Rules7.SetActive(false);
            Rules8.SetActive(false);
            BackButton.SetActive(false);
        }
        if (currentPage == 2)
        {
            Rules1.SetActive(false);
            Rules2.SetActive(true);
            Rules3.SetActive(false);
            Rules4.SetActive(false);
            Rules5.SetActive(false);
            Rules6.SetActive(false);
            Rules7.SetActive(false);
            Rules8.SetActive(false);
            BackButton.SetActive(true);
        }
        if (currentPage == 3)
        {
            Rules1.SetActive(false);
            Rules2.SetActive(false);
            Rules3.SetActive(true);
            Rules4.SetActive(false);
            Rules5.SetActive(false);
            Rules6.SetActive(false);
            Rules7.SetActive(false);
            Rules8.SetActive(false);
        }
        if (currentPage == 4)
        {
            Rules1.SetActive(false);
            Rules2.SetActive(false);
            Rules3.SetActive(false);
            Rules4.SetActive(true);
            Rules5.SetActive(false);
            Rules6.SetActive(false);
            Rules7.SetActive(false);
            Rules8.SetActive(false);
        }
        if (currentPage == 5)
        {
            Rules1.SetActive(false);
            Rules2.SetActive(false);
            Rules3.SetActive(false);
            Rules4.SetActive(false);
            Rules5.SetActive(true);
            Rules6.SetActive(false);
            Rules7.SetActive(false);
            Rules8.SetActive(false);
        }
        if (currentPage == 6)
        {
            Rules1.SetActive(false);
            Rules2.SetActive(false);
            Rules3.SetActive(false);
            Rules4.SetActive(false);
            Rules5.SetActive(false);
            Rules6.SetActive(true);
            Rules7.SetActive(false);
            Rules8.SetActive(false);
        }
        if (currentPage == 7)
        {
            Rules1.SetActive(false);
            Rules2.SetActive(false);
            Rules3.SetActive(false);
            Rules4.SetActive(false);
            Rules5.SetActive(false);
            Rules6.SetActive(false);
            Rules7.SetActive(true);
            Rules8.SetActive(false);
            NextButton.SetActive(true);
        }
        if (currentPage == 8)
        {
            Rules1.SetActive(false);
            Rules2.SetActive(false);
            Rules3.SetActive(false);
            Rules4.SetActive(false);
            Rules5.SetActive(false);
            Rules6.SetActive(false);
            Rules7.SetActive(false);
            Rules8.SetActive(true);
            NextButton.SetActive(false);
        }
    }
    public void nextButtonPush()
    {
        currentPage++;
    }
    public void previousButtonPush()
    {
        currentPage--;
    }
}
       