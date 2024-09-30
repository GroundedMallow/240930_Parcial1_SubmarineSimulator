using System.Collections;
using UnityEngine;

public class Objective
{
    public string Description { get; set; }
    public bool Completed { get; set; }
    public int CurrentAmount { get; set; }
    public int RequiredAmount { get; set; }

    public virtual void Init()
    {
        //default init

    }

    public void Evaluate() 
    {
        //checks all completed missions/objectives
        if (CurrentAmount >= RequiredAmount)
        {
            Complete();
        }
    }

    public void Complete()
    {
        //win condition
        Completed = true;
    }
}
