using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doors : MonoBehaviour
{
    public static Doors doors;
    [SerializeField] private string _level;
    private string _HeIsIn;
    private int _spawnID;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //first "if" verifys where he is (_HeIsIn), and the second "if" verifys where he want to go "_level"


        //example
        if (_HeIsIn.Equals("Hallway"))// if he is in hallway 
        {
            Missions.missions.Tutorial1("Hallway",1);
            PlayerPrefs.SetInt("_Hallway", 1);
            if (_level.Equals("SampleScene")) // if he is going to SleepRoom
            {
                SceneManager.LoadScene(_level);
                PlayerController.playercontroller.GetValues(1); //spawnpoint
                _HeIsIn = _level;
                _spawnID = 1;
                SaveLevel();
            }
            if (_level.Equals("kitchen")) // if he is going to kitchen
            {
                SceneManager.LoadScene(_level);
                PlayerController.playercontroller.GetValues(2); //spawnpoint
                _HeIsIn = _level;
                _spawnID = 2;
                SaveLevel();
            }
            if (_level.Equals("Bathroom")) // if he is going to BathRoom
            {
                SceneManager.LoadScene(_level);
                PlayerController.playercontroller.GetValues(3); //spawnpoint
                _HeIsIn = _level;
                _spawnID = 3;
                SaveLevel();
            }
        } 

        if (_HeIsIn.Equals("SampleScene"))
        {
           
            PlayerPrefs.SetInt("_SampleScene", 1);
            if (_level.Equals("Hallway"))
            { 
                SceneManager.LoadScene(_level);
                PlayerController.playercontroller.GetValues(4);
                _HeIsIn = _level;
                _spawnID = 4;
                SaveLevel();
            }
        }

       

        if (_HeIsIn.Equals("kitchen"))
        {
            Missions.missions.Tutorial1("kitchen",1);
            PlayerPrefs.SetInt("_kitchen", 1);

            
            if (_level.Equals("Hallway"))
            {
                Debug.Log("Sai da cozinha e fui para o corredor ");
                SceneManager.LoadScene(_level);
                PlayerController.playercontroller.GetValues(6);
                
                 Debug.Log("Spawn---------------x "+_spawnID);
                _HeIsIn = _level;
                _spawnID = 5;
                SaveLevel();

            }
            if (PlayerPrefs.GetInt("_DidHeGo") == 1) {
                if (PlayerPrefs.GetInt("tutorialmission") == 1)
                {
                     if (_level.Equals("Outside"))
                     {
                        SceneManager.LoadScene(_level);
                        PlayerController.playercontroller.GetValues(9);
                        _HeIsIn = _level;
                        _spawnID = 6;
                        SaveLevel();
                     }
                    if (_level.Equals("Garden"))
                    {
                        SceneManager.LoadScene(_level);
                        PlayerController.playercontroller.GetValues(9);
                        _spawnID = 7;
                        SaveLevel();
                        _HeIsIn = _level;
                    }
                }
            }
            if (PlayerPrefs.GetInt("_Key") == 1)
            {
                if (_level.Equals("FirstMission"))
                {
                    SceneManager.LoadScene(_level);
                    _HeIsIn = _level;
                }
            }
        }

        if (_HeIsIn.Equals("Bathroom"))
        {
            Missions.missions.Tutorial1("Bathroom",1);
            PlayerPrefs.SetInt("_Bathroom", 1);
            if (_level.Equals("Hallway"))
            {
                SceneManager.LoadScene(_level);
                PlayerController.playercontroller.GetValues(7);
                _HeIsIn = _level;
                _spawnID = 8;
                SaveLevel();
            }
        }

        if (_HeIsIn.Equals("Garden"))
        {

                
                if (PlayerPrefs.GetInt("_DidHeGo") == 1)
                {
                    PlayerPrefs.SetInt("_Garden", 1);
                    if (_level.Equals("kitchen"))
                    {
                        SceneManager.LoadScene(_level);
                        PlayerController.playercontroller.GetValues(10);
                        _HeIsIn = _level;
                        _spawnID = 9;   
                        SaveLevel();
                    }
                }
            
        }

            PlayerPrefs.SetString("heisin", _HeIsIn);
       
        

    }
    public void Start()
    {
        
        doors = this;

    }
    public void Update()
    {
        //Check if he has already been through all the rooms.
        _HeIsIn = PlayerPrefs.GetString("heisin");
        var a = PlayerPrefs.GetInt("_SampleScene");
        if (a == 1) {
             a = PlayerPrefs.GetInt("_Hallway");
            if (a == 1)
            {
                a = PlayerPrefs.GetInt("_kitchen");
                if (a == 1)
                {
                        a = PlayerPrefs.GetInt("_Bathroom");
                        if (a == 1)
                        {
                            PlayerPrefs.SetInt("_DidHeGo",1);
                        }                   
                }
            }
        }
    }
    private void OnApplicationQuit()
    { //reset all variables
        PlayerPrefs.SetString("heisin", "SampleScene");
        PlayerPrefs.SetInt("_SampleScene", 0);
        PlayerPrefs.SetInt("_Hallway", 0);
        PlayerPrefs.SetInt("_kitchen", 0);
        PlayerPrefs.SetInt("_Quarto2", 0);
        PlayerPrefs.SetInt("_Bathroom", 0);
        PlayerPrefs.SetInt("_Garden", 0);
        PlayerPrefs.SetInt("_DidHeGo", 0);
        PlayerPrefs.SetInt("_Key", 0);
    }

    public void NewScene(string _Level) //scene loader
    {
        SceneManager.LoadScene(_level);
        if (_level == "SampleScene")
        { PlayerController.playercontroller.GetValues(1); }

    }
    public void SaveLevel(){
         PlayerPrefs.SetString("__Level",_level);
         PlayerPrefs.SetInt("_spawnID",_spawnID);
         PlayerPrefs.Save();
    }
     public static string GetLevel(){
        string resultado = PlayerPrefs.GetString("__Level");
        return resultado;
    }

    public static int GetSpawnID(){
        int resultado = PlayerPrefs.GetInt("_spawnID");
        return resultado;
    }
}
