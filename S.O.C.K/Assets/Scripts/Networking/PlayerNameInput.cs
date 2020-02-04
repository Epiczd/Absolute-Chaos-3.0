﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using Photon.Pun;

public class PlayerNameInput : MonoBehaviour
{

    [SerializeField] private InputField nameInputField = null;
    [SerializeField] private Button continueButton = null;

    private const string PlayerPrefsNameKey = "PlayerName";
    // Start is called before the first frame update
    void Start()
    {
        SetUpInputField();
    }

    private void SetUpInputField()
    {
        if(!PlayerPrefs.HasKey(PlayerPrefsNameKey)) { return;  }

        string defaultName = PlayerPrefs.GetString(PlayerPrefsNameKey);

        nameInputField.text = defaultName;

        SetPlayerName(defaultName);
    }

    public void SetPlayerName(string name)
    {
        continueButton.interactable = !string.IsNullOrEmpty(name);
    }

    public void SavePlayerName()
    {
        string playerName = nameInputField.text;

        PhotonNetwork.NickName = playerName;

        PlayerPrefs.SetString(PlayerPrefsNameKey, playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
