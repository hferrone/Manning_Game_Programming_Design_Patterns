using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Model Data", menuName = "ScriptableObjects/Model Data")]
public class ModelDataSO : ScriptableObject
{
    public PrimitiveType primitiveType;
    public string goName;
    public Vector3 scale;
}

public class Utilities
{
    public static GameObject Create(string so)
    {
        ModelDataSO data = Resources.Load<ScriptableObject>(so) as ModelDataSO;

        GameObject go = GameObject.CreatePrimitive(data.primitiveType);
        go.name = data.name;
        go.transform.localScale = data.scale;

        return go;
    }
}