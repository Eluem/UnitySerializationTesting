using AYellowpaper.SerializedCollections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourWithDictionary : MonoBehaviour
{
    //Hitting the plus and creating a new entry seems to create a new key/value pair but the defaults aren't based on the default values set at the top of the class
    [SerializedDictionary("Name", "Data")]
    [SerializeField] SerializedDictionary<string, CustomClass> _testSerializedDictionary = new SerializedDictionary<string, CustomClass>();

    [SerializeField] CustomClass _customClassGoodDefaults = new CustomClass(); //If I initialize it, unity correctly uses the defaults
    [SerializeField] CustomClass _customClassBadDefaults; //If I leave it null and let unity assume the defaults, they end up standard (0 for the floats in this case)


    public CustomClass GetData(string pName)
    {
        if(_testSerializedDictionary.ContainsKey(pName))
        {
            return _testSerializedDictionary[pName];
        }

        return null;
    }
}
