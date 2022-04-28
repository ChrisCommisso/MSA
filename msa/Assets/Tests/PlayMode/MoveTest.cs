using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MoveTest
{
    
    [UnityTest]
    public IEnumerator MoveTestWithEnumeratorPasses()
    {
        GameObject Player = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/Cube"));
        Player.transform.position = Vector3.zero;
        Player.GetComponent<Q3Movement.Q3PlayerController>().isTest = true;
        Player.GetComponent<Q3Movement.Q3PlayerController>().Start();
        Player.GetComponent<Q3Movement.Q3PlayerController>().SetMoveInput(new Vector3(0, 0, 1));
        Player.GetComponent<Q3Movement.Q3PlayerController>().Update();
        yield return new WaitForFixedUpdate();
        Assert.IsTrue(Player.transform.position != Vector3.zero);
    }
}
