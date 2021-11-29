using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenü : MonoBehaviour
{
   public void PlayGame()
   {
        SceneManager.LoadScene(19);
   }
    public void QuitGame()
    {
        Debug.Log("Oyundan Çıktık");
        Application.Quit();
        
    }
    public void ReturnToMeinMenu()
    {
        SceneManager.LoadScene("MainMenü");
    }
    public void ReturnKış()
    {
        SceneManager.LoadScene(5);
    }
    public void ReturnİlkBahar()
    {
        SceneManager.LoadScene(1);
    }
    public void SettingsMenü()
    {
        SceneManager.LoadScene(9);
    }
    public void ReturnYaz()
    {
        SceneManager.LoadScene(10);
    }
    public void ReturnSonbahar()
    {
        SceneManager.LoadScene(14);
    }
    public void PlayTurkey()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayTurkeyMap()
    {
        SceneManager.LoadScene(20);
    }
    public void PlayChınaMap()
    {
        SceneManager.LoadScene(21);
    }
    public void PlayChınalevel()
    {
        SceneManager.LoadScene(22);
    }
    public void RestartChına1()
    {
        SceneManager.LoadScene(22);
    }
    public void RestartChına2()
    {
        SceneManager.LoadScene(26);
    }
    public void RestartChına3()
    {
        SceneManager.LoadScene(30);
    }
    public void RestartChına4()
    {
        SceneManager.LoadScene(34);
    }
    public void GoToABD()
    {
        SceneManager.LoadScene(38);
    }
    public void abd1()
    {
        SceneManager.LoadScene(39);
    }
    

}
