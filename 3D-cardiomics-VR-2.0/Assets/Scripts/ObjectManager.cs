using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectManager : MonoBehaviour
{
    public GameObject modelExtensionPrefab;
    public GameObject modelPrefab;
    private GameObject temp;
    private GameObject temp2;
    public int childNumber;
    public int numberOfSlices;
    private int offset = 1;
    public List<GameObject> ModelObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        setCounterText();
    }

    private void countPiecesOfObjects(GameObject obj)
    {
        foreach (Transform child in obj.transform.GetChild(0).transform)
        {
            if (child.name != "Extensions")
            {
                foreach (Transform childchild in child.transform)
                {
                    foreach (Transform childchilds in childchild.transform)
                    {
                        childNumber++;
                    }
                }
            }
        }
    }

    public int addCopytoList(GameObject obj)
    {
        ModelObjects.Add(obj);
        return ModelObjects.IndexOf(obj);
    }

    public void initiateModel()
    {
        loadModel();
        countPiecesOfObjects(temp);
    }

    public void loadModel()
    {
        temp = Instantiate(modelExtensionPrefab);
        temp.transform.position = new Vector3(temp.transform.position.x + offset, temp.transform.position.y, temp.transform.position.z);
        offset += 2;

        temp2 = Instantiate(modelPrefab);
        temp2.transform.SetParent(GameObject.Find("Heart(Clone)").transform.GetChild(0).transform);
        temp2.transform.localPosition = new Vector3(-500, 0, 0);
        var index = addCopytoList(temp);
        temp.name = index.ToString();
        setCounterText();


        foreach (Transform childchild in temp2.transform)
        {
            foreach (Transform childchilds in childchild.transform)
            {
                childchilds.gameObject.AddComponent<Rigidbody>();
                StartCoroutine(delay());
                childchilds.gameObject.GetComponent<Rigidbody>().useGravity = false;
                childchilds.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                StartCoroutine(delay());
                childchilds.gameObject.AddComponent<OVRGrabbable>();
                childchilds.gameObject.GetComponent<OVRGrabbable>().enabled = true;
            }
        }
    }



    public int getPiecesOfObject()
    {
        return childNumber;

    }

    public void addModel()
    {
        loadModel();
    }

    public void deleteModel()
    {
        int temp = ModelObjects.Count - 1;
        ModelObjects.Remove(GameObject.Find(temp.ToString()));
        Destroy(GameObject.Find(temp.ToString()));
        offset -= 2;
        setCounterText();
    }

    private void setCounterText()
    {
        try
        {
            GameObject.Find("ModelDisplayText").GetComponent<Text>().text = ModelObjects.Count.ToString();
        }
        catch (Exception e) { }

    }

    IEnumerator delay()
    {
        yield return 0;
    }
}
