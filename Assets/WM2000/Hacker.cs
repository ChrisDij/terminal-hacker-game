using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int level;

    enum Screen { MainMenu, Password, WinScreen }
    Screen currentScreen = Screen.MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }
    void ShowMainMenu()
    {
        Screen currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello User1");
        Terminal.WriteLine("What would you like to hack into today?");
        Terminal.WriteLine("1)  Local Buisnesss");
        Terminal.WriteLine("2)  The Pentagon");
        Terminal.WriteLine("3)  White House ");
        Terminal.WriteLine("The choices are yours and yours alone");
    }
    //Main menu Inputs


    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }

        else if (input == "2")
        {
            level = 2;
            StartGame();
        }

        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
        }
    }

    //GameStart
    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("Level " + level + " selected");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
