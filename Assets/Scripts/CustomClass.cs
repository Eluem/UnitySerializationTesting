using UnityEngine;

[System.Serializable]
public class CustomClass
{
    [SerializeField] float _someFloatOne = 1; //These default values are all it should take to get unity to respect the defaults correctly (if the variable is initialized)
    [SerializeField] float _someFloatTwo = 2;

    public float SomeFloatOne
    {
        get
        {
            return _someFloatOne;
        }
    }

    public float SomeFloatTwo
    {
        get
        {
            return _someFloatTwo;
        }
    }


    //If you comment this out and then remove and readd _customClassBadDefaults to BehaviourWithDictionary, it'll actually use the defaults above
    public CustomClass(float pSomeFloatOne = 1, float pSomeFloatTwo = 2)
    {
        _someFloatOne = pSomeFloatOne;
        _someFloatTwo = pSomeFloatTwo;
    }
}
