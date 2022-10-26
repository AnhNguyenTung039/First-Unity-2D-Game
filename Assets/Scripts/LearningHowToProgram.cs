using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LearningHowToProgram : MonoBehaviour
{
    Player hero;
    public void Start()
    {
        hero = new(100, 50, "Hero");
        hero.Info();
        hero.Attack();
    }

}
