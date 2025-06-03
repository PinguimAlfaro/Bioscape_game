using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    public int Choice1;
    public int Choice2;
    public int Choice3;
    public string Result;
    GameObject[] Yellow;
    GameObject[] Red;
    GameObject[] Green;

    // Start is called before the first frame update
    void Start()
    {






    }

    // Update is called once per frame
    void Update()
    {
        
                Choices();
        if (Result.Equals("Green"))    
        {
            Debug.Log("Green");
        }
        if (Result.Equals("Yellow"))
        {
            Debug.Log("Yellow");
        }
        if (Result.Equals("Red"))
        {
            Debug.Log("Red");
        }
    }
    public void Choices()
    {
        switch (Choice1)
        {
            case 1:
                switch (Choice2)
                {
                    case 1:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Red";
                                break;
                            case 2:
                                Result = "Red";
                                break;
                            case 3:
                                Result = "Red";
                                break;
                            case 4:
                                Result = "Red";
                                break;
                            default:
                                break;


                        }
                        break;
                    case 2:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Yellow";
                                break;
                            case 2:
                                Result = "Yellow";
                                break;
                            case 3:
                                Result = "Yellow";
                                break;
                            case 4:
                                Result = "Red";
                                break;
                            default:
                                break;


                        }
                        break;
                    case 3:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Yellow";
                                break;
                            case 2:
                                Result = "Yellow";
                                break;
                            case 3:
                                Result = "Yellow";
                                break;
                            case 4:
                                Result = "Red";
                                break;
                            default:
                                break;


                        }
                        break;
                    case 4:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Red";
                                break;
                            case 2:
                                Result = "Red";
                                break;
                            case 3:
                                Result = "Red";
                                break;
                            default:
                                break;


                        }
                        break;
                    default:
                        break;


                }
                break;
            case 2:
                switch (Choice2)
                {
                    case 1:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Yellow";
                                break;
                            case 2:
                                Result = "Yellow";
                                break;
                            case 3:
                                Result = "Yellow";
                                break;
                            case 4:
                                Result = "Red";
                                break;
                            default:
                                break;


                        }
                        break;

                    case 2:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Yellow";
                                break;
                            case 2:
                                Result = "Yellow";
                                break;
                            case 3:
                                Result = "Yellow";
                                break;
                            case 4:
                                Result = "Yellow";
                                break;
                            default:
                                break;


                        }
                        break;

                    case 3:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Yellow";
                                break;
                            case 2:
                                Result = "Yellow";
                                break;
                            case 3:
                                Result = "Yellow";
                                break;
                            case 4:
                                Result = "Yellow";
                                break;
                            default:
                                break;


                        }
                        break;

                    case 4:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Red";
                                break;
                            case 2:
                                Result = "Red";
                                break;
                            case 3:
                                Result = "Red";
                                break;

                            default:
                                break;


                        }
                        break;

                    default:
                        break;


                }
                break;
            case 3:
                switch (Choice2)
                {
                    case 1:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Yellow";
                                break;
                            case 2:
                                Result = "Yellow";
                                break;
                            case 3:
                                Result = "Green";
                                break;
                            case 4:
                                Result = "Yellow";
                                break;
                            default:
                                break;


                        }
                        break;

                    case 2:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Green";
                                break;
                            case 2:
                                Result = "Green";
                                break;
                            case 3:
                                Result = "Green";
                                break;
                            case 4:
                                Result = "Green";
                                break;
                            default:
                                break;


                        }
                        break;

                    case 3:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Green";
                                break;
                            case 2:
                                Result = "Green";
                                break;
                            case 3:
                                Result = "Green";
                                break;
                            case 4:
                                Result = "Green";
                                break;
                            default:
                                break;


                        }
                        break;

                    case 4:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Yellow";
                                break;
                            case 2:
                                Result = "Yellow";
                                break;
                            case 3:
                                Result = "Yellow";
                                break;

                            default:
                                break;


                        }
                        break;

                    default:
                        break;


                }
                break;
            case 4:
                switch (Choice2)
                {
                    case 1:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Yellow";
                                break;
                            case 2:
                                Result = "Yellow";
                                break;
                            case 3:
                                Result = "Red";
                                break;
                            default:
                                break;


                        }
                        break;
                    case 2:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Yellow";
                                break;
                            case 2:
                                Result = "Yellow";
                                break;
                            case 3:
                                Result = "Red";
                                break;

                            default:
                                break;


                        }
                        break;
                    case 3:
                        switch (Choice3)
                        {
                            case 1:
                                Result = "Red";
                                break;
                            case 2:
                                Result = "Red";
                                break;
                            case 3:
                                Result = "Red";
                                break;
                            case 4:
                                Result = "Red";
                                break;
                            default:
                                break;


                        }
                        break;
                    default:
                        break;


                }
                break;
            default:
                break;


        }


    }

    public void choice1(int i)
    {
        PlayerPrefs.SetInt("Choice1", i);
        Choice1 = PlayerPrefs.GetInt("Choice1");
    }

    public void choice2(int i)
    {
        PlayerPrefs.SetInt("Choice2", i);
        Choice2 = PlayerPrefs.GetInt("Choice2");
    }

    public void choice3(int i)
    {
        PlayerPrefs.SetInt("Choice3", i);
        Choice3 = PlayerPrefs.GetInt("Choice3");
    }
}
