using UnityEngine;
using Sirenix.OdinInspector;
using System;

//Naming is crucial!
//Again, naming is crucial!
//Very descriptive class and method names (long names are fine as along as they are clear as to what they do)

//Test scripts should start with "Test_TempLoadUserDetails" (and preferably kept in a Test folder)
//these are in my mind scripts that would be thrown away at the end of the project in theory
//Every script should be in a subfolder (or more) of the Scripts folder
//Public variables start with capital letters
//private is lowercase and Public is uppercase (includes variables and methods)
//ODIN is your friend! - All fields that are intended to be assigned must have the [Required] component added!

#region DONT DOS

//No people names in scripts ever!
//No scripts ending in Custom. e.g., HeroChildManager and HeroChildManager_Custom

#endregion

public class ScriptConventionExample : MonoBehaviour
{
    //Try to use the strictest scope level you can get away with (i.e., aim to make it private unless really necessary)

    //The [SerializeField] attribute allows fields to be assigned in the editor but we can keep them private
    //This should be the default for variables that need to be assigned 
    //(public is only if another script needs to see it which you should generally try to avoid as this creates strong dependencies between scripts!)
    [SerializeField] private string assignMeInTheInspector;
    [Required] [SerializeField] private Transform targetToFollow;

    //Variables should only be marked as public if you need to access them from another script
    public string AccessMeFromAnotherScriptAndSetMeInEditor;
    //If the variable should not be edited in the inspector then please include the hideininspector attribute
    [HideInInspector] public bool AccessMeFromAnotherScriptButDontSetMeInEditor;

    //You should also try to use properties with getter setter methods to only access what you need
    //E.g., if I want to access the hasFired bool of this script from a script, say WeaponManager,
    //but I don't want WeaponManager to be able to change the value of hasFired, then use e.g,
    public bool IsTriggered { get; private set; }
    //Properties are not visible in the inspector

    public event Action<int> somethingHappened = delegate {}; //We set events to a default empty delegate so we don't have to check if they aren't null
    
    //Private variables are only for use in this script
    private bool internalBool;

    //Variables should always be set up as in the order above
    //i.e, All [Serializable] private, then public, then public properties, then public events, then private fields.

    #region Unity methods should all be first

    private void Awake()
    {
        //References that need to be found programtically should be done here
        //Resources that need to be loaded should be done here
    }

    private void OnEnable()
    {
        //Register for events
    }

    private void OnDisable()
    {
        //Deregister for events
    }

    #endregion

    #region Other methods

    //public methods then private methods



    #endregion

}
