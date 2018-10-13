using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

    public Questions[] questions;
    private Questions currentQuestion;
    public Text q;
    void start ()
    {
        q.text = currentQuestion.facts;
    
    }

}
