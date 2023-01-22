using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class StringLanguages
{
    public string Bangla,Hindi,Urdu,English;
}
[System.Serializable]
public class SoundLanguages
{
    public AudioClip Bangla,Hindi,Urdu,English;

}
public class WordManager : MonoBehaviour
{    
    [SerializeField] Transform item_Parent;
    [SerializeField] private GameObject @null;
    // Start is called before the first frame update
    [SerializeField]Text text;
    public enum Language
    {
        None,Bangla,Hindi,Urdu,English
    }
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    public static WordManager Instance;
   
    public Language language;
    void Start()
    {
        CreateItem( @null) ;
    }
    
    public void  CreateItem(GameObject prefab) 
    {
        Transform currentObject = item_Parent.GetChild(0);
        Destroy(currentObject.gameObject);  
        GameObject newObject=  Instantiate(prefab);
         newObject.transform.parent=item_Parent;
        newObject.transform.position= item_Parent.transform.position;
        newObject.transform.rotation=Quaternion.identity;
        if(text)
        {
            text.text=prefab.transform.GetComponent<Letter_Alphabet>().CurrentWord();

        }
    }
    public GameObject[] belongingWords;//like (alif ba)(baa alif)(ba taa) etc
                                        //it will contain all the words. that can be made with this letter 
    [SerializeField]Transform  upperPose;//for zabar,pesh,do zabar,do pesh
    [SerializeField]Transform lowerPose;//for zer,do zer. etc
    public Pose arriving_letter_Pose;//in which pose! will sit that letter or mark,
    public AudioClip[] clips;//For Letter AndArriving Letters/words
    private AudioSource audioSource;

    private void Awake() 
    {
        if(Instance==null)
        {
          Instance=this; 
        }
        
        if(audioSource==null)
        {
            AudioSource au=gameObject.AddComponent<AudioSource>();
            audioSource=au;
        }
        
    }
    //if there need to creat new word like (baa alif, taa alif  etc)
    //new word should come from  public GameObject[] belongingWords
    public void AddMe(Pose myPose,AudioClip clip,GameObject newWord)
    {
        
    }
     //if there! zabar zer etc
     public void AddMe(Pose myPose,AudioClip clip)
    {
        
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
