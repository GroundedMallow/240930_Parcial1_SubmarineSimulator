using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_Objective : Objective
{
    public int ObjectiveID { get; set; }

    public PickUp_Objective(int objectiveID, string description, bool completed, int currentAmount, int requiredAmount)
    {
        this.ObjectiveID = objectiveID;
        this.Description = description;
        this.Completed = completed;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = requiredAmount;
    }

    public override void Init()
    {
        base.Init();
    }

    void PickedUp()
    {

    }
}
