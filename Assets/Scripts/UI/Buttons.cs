using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

  private int nextSceneLoad;
  private int lastSceneLoad;
  public Animator transitionAnim;
  

  void Start()
  {
    nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    lastSceneLoad = SceneManager.GetActiveScene().buildIndex - 1;
  }
    public void LoadCurrentScene()
    {
      StartCoroutine(TransAnim());
      SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);   
    }

    public void LoadHome()
    {
      StartCoroutine(TransAnim());
      SceneManager.LoadScene("LevelSelection");
    }

    public void LoadNextScene()
    {
      SceneManager.LoadScene(nextSceneLoad);

      if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
      {
        PlayerPrefs.SetInt("levelAt", nextSceneLoad);
      }
    }

    public void LoadLastScene()
    {
      SceneManager.LoadScene(lastSceneLoad);
    }

    IEnumerator TransAnim()
    {
      transitionAnim.SetTrigger("end");
      yield return new WaitForSeconds(1.5f);
    }

    public void RestartGame()
    {
      PlayerPrefs.DeleteAll();
    }

    public void Load1()
    {
      SceneManager.LoadScene("1");
    }
    public void Load2()
    {
      SceneManager.LoadScene("2");
    }
    public void Load3()
    {
      SceneManager.LoadScene("3");
    }
    public void Load4()
    {
      SceneManager.LoadScene("4");
    }
    public void  Load5()
    {
      SceneManager.LoadScene("5");
    }
    public void Load6()
    {
      SceneManager.LoadScene("6");
    }
    public void Load7()
    {
      SceneManager.LoadScene("7");
    }
    public void Load8()
    {
      SceneManager.LoadScene("8");
    }
    public void Load9()
    {
      SceneManager.LoadScene("9");
    }
    public void Load10()
    {
      SceneManager.LoadScene("10");
    }
    public void Load11()
    {
      SceneManager.LoadScene("11");
    }
    public void Load12()
    {
      SceneManager.LoadScene("12");
    }
    public void Load13()
    {
      SceneManager.LoadScene("13");
    }
    public void Load14()
    {
      SceneManager.LoadScene("14");
    }
    public void Load15()
    {
      SceneManager.LoadScene("15");
    }
    public void Load16()
    {
      SceneManager.LoadScene("16");
    }
    public void Load17()
    {
      SceneManager.LoadScene("17");
    }
    public void Load18()
    {
      SceneManager.LoadScene("18");
    }
    public void Load19()
    {
      SceneManager.LoadScene("19");
    }
    public void Load20()
    {
      SceneManager.LoadScene("20");
    }
    public void Load21()
    {
      SceneManager.LoadScene("21");
    }
    public void Load22()
    {
      SceneManager.LoadScene("22");
    }
    public void Load23()
    {
      SceneManager.LoadScene("23");
    }
    public void Load24()
    {
      SceneManager.LoadScene("24");
    }
    public void Load25()
    {
      SceneManager.LoadScene("25");
    }
     public void Load26()
    {
      SceneManager.LoadScene("26");
    }
     public void Load27()
    {
      SceneManager.LoadScene("27");
    }
     public void Load28()
    {
      SceneManager.LoadScene("28");
    }
     public void Load29()
    {
      SceneManager.LoadScene("29");
    }
     public void Load30()
    {
      SceneManager.LoadScene("30");
    }
     public void Load31()
    {
      SceneManager.LoadScene("31");
    }
    public void Load32()
    {
      SceneManager.LoadScene("32");
    }
    public void Load33()
    {
      SceneManager.LoadScene("33");
    }
    public void Load34()
    {
      SceneManager.LoadScene("34");
    }
    public void Load35()
    {
      SceneManager.LoadScene("35");
    }
    public void Load36()
    {
      SceneManager.LoadScene("36");
    }
}
