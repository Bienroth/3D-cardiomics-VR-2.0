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
    List<GameObject> objList = new List<GameObject>();
    private int i = 0;

    public void TBDFunction()
    {
        // collison if heart grabber and heart grabber → set bool true and wait for ovr released
        // then get transform.root and cal set Models
        // change label
        // delete one of the hearts 

        setModelsToCompare(GameObject.Find("0"), GameObject.Find("1"));
        readDataForModel();
    }
    
    public void setModelsToCompare(GameObject model1, GameObject model2)
    {
        this.model1 = model1;
        this.model2 = model2;
        readDataForModel();
    }
        
    public void readDataForModel()
    {
        
        //de.Key = A_1 usw. sort alphabetially or match both components
        data1 = model1.GetComponent<StoreDataManager>().getDataTable();
        int max = 0;
        int min = 0;
        
        foreach (DictionaryEntry de in data1)
        {

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
        gameObject.GetComponent<ObjectManager>().deleteSpecificModel(model2.name);
        model1.GetComponent<StoreDataManager>().customLabel("Compare");
    }

    public void safeToSH(GameObject obj)
    {
        if (this.gameObject.name == "ScriptHolder")
        {
            if (obj != null)
            {
                objList.Add(obj);
                i++;
                if (i == 2)
                {
                    i = 0;
                    callHeatmap();
                }
            }
        }

    }

    private void callHeatmap()
    {
        Debug.Log(objList[0].name);
        Debug.Log(objList[1].name);
        setModelsToCompare(objList[0], objList[1]);
    }

}
