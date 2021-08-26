using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatmapCompareManager : MonoBehaviour
{
    private Hashtable data1;
    private Hashtable data2;
    private Hashtable tempData;
    GameObject model1;
    GameObject model2;

    public void TBDFunction()
    {
        setModelsToCompare(GameObject.Find("0"), GameObject.Find("1"));
        readDataForModel();
    }
    
    public void setModelsToCompare(GameObject model1, GameObject model2)
    {
        this.model1 = model1;
        this.model2 = model2;
    }
        
    public void readDataForModel()
    {       
        //de.Key = A_1 usw. sort alphabetially or match both components
        data1 = model1.GetComponent<StoreDataManager>().getDataTable();
        int max = 0;
        int min = 0;
        foreach (DictionaryEntry de in data1)
        {
            Debug.Log(de.Value);
            data2 = model2.GetComponent<StoreDataManager>().getDataTable();
            foreach (DictionaryEntry des in data2)
            {
                if (de.Key == des.Key)
                {
                    // Calculate Differences, Max and Min Values
                    int x = Math.Abs(int.Parse(de.Value.ToString()) - int.Parse(des.Value.ToString()));
                    max = Math.Max(max, Math.Max(int.Parse(de.Value.ToString()), int.Parse(des.Value.ToString())));
                    min = Math.Min(min, Math.Min(int.Parse(de.Value.ToString()), int.Parse(des.Value.ToString())));
                    GameObject.Find("ScriptHolder").GetComponent<Colour>().setModelGameobject(model1);
                    GameObject.Find("ScriptHolder").GetComponent<Colour>().colourHeartPiece(de.Key.ToString(), x, max, min, false);
                    Debug.Log(de.Key.ToString());
                }
            }                          
        }

        model1.GetComponent<StoreDataManager>().clearTable();
        model2.GetComponent<StoreDataManager>().clearTable();

        // compare both
        // calculate diff
        // Call colour function with main heart an delete second one
        // save in Store Manager and add a bool heatmap and not original 
        // add gene Text info
    }



}
