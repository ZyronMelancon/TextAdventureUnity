using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandManager : MonoBehaviour {

    public InputField m_InputField;
    public Text m_OutputText;
    public RoomManager m_RoomManager;

    [HideInInspector]
    private string theCommand;
    private string lastCommand;

	// Use this for initialization
	void Start ()
    {
		
	}
	
    void getCommand(string com)
    {
        if (lastCommand == "move")
            switch(com)
            {
                case "up":
                    m_OutputText.text = "Moving up.";
                    lastCommand = "";
                    break;
                case "down":
                    m_OutputText.text = "Moving down.";
                    lastCommand = "";
                    break;
                case "left":
                    m_OutputText.text = "Moving left.";
                    lastCommand = "";
                    break;
                case "right":
                    m_OutputText.text = "Moving right.";
                    lastCommand = "";
                    break;
                default:
                    m_OutputText.text = "Invalid Input!";
                    break;
            }

        else if (lastCommand == "item")
            switch(com)
            {
                case "1":
                    m_OutputText.text = "Using item 1";
                    lastCommand = "";
                    break;
                case "2":
                    m_OutputText.text = "Using item 2";
                    lastCommand = "";
                    break;
                case "3":
                    m_OutputText.text = "Using item 3";
                    lastCommand = "";
                    break;
                default:
                    m_OutputText.text = "Invalid Input!";
                    break;
            }

        else
            switch(com)
            {
                case "move":
                    m_OutputText.text = "Move where? ";
                    lastCommand = "move";
                    break;
                case "talk":
                    break;
                case "item":
                    m_OutputText.text = "Which item?";
                    lastCommand = "item";
                    break;
                case "pickup":
                    break;
                default:
                    m_OutputText.text = "Invalid Input!";
                    break;
            }
    }

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            theCommand = m_InputField.textComponent.text;
            m_InputField.text = "";
            getCommand(theCommand);
            m_InputField.Select();
            m_InputField.ActivateInputField();
        }
	}
}
