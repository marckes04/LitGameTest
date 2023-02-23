using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Animations : MonoBehaviour
{
    public Animator playerAnimated;

public void Animation1(){
    playerAnimated.Play("Animation1");
}

public void Animation2(){
    playerAnimated.Play("Animation2");
}

public void Animation3(){
    playerAnimated.Play("Animation3");
}

public void Animation4(){
    playerAnimated.Play("Animation4");
    StartCoroutine(NextScene());
}

IEnumerator NextScene(){
    SceneManager.LoadScene("Scene 2");
    yield return new WaitForSeconds(30f);
}

}
