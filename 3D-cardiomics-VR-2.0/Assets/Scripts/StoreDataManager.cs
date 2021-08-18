using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoreDataManager : MonoBehaviour
{
    public Hashtable currentData = new Hashtable();
    public string geneName = "";

    public void addData(string heartpiece, string expressionValue)
    {
        currentData.Add(heartpiece, expressionValue);
    }

    public void addName(string geneName)
    {
        this.geneName = geneName;
        setLabel(geneName);
    }

    private void setLabel(string geneName)
    {
        gameObject.transform.GetChild(0).Find("Extensions").Find("GeneOrigName").GetComponentInChildren<Text>().text = geneName;
    }
}
