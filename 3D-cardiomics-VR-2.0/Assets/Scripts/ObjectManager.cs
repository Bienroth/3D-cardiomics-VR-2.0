using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject modelExtensionPrefab;
    public GameObject modelPrefab;
    private GameObject temp;
    public int childNumber;
    public List<GameObject> ModelObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
    }

    private void countObjects()
    {
        foreach (Transform child in transform)
        {
            foreach (Transform childchild in child.transform)
            {
                childNumber++;
            }
        }
    }

    public int addCopytoList(GameObject obj)
    {
        ModelObjects.Add(obj);
        return ModelObjects.IndexOf(obj);
    }

    public int getNumberofCopy(string name)
    {
        return ModelObjects.IndexOf(GameObject.Find(name));
    }

    public void loadModel()
    {
        temp = Instantiate(modelExtensionPrefab);

        Instantiate(modelPrefab).transform.SetParent(GameObject.Find("Heart(Clone)").transform.GetChild(0).transform);

        var index = addCopytoList(temp);

        temp.name = index.ToString();
    }
}
