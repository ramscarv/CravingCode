using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroLevel : MonoBehaviour {

	public void StraightLevelClick()
    {
        SceneManager.LoadScene("LevelReta");
    }

    public void RotatedLevelClick()
    {
        SceneManager.LoadScene("LevelCurva");
    }
}
