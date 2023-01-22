using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter_Alphabet : MonoBehaviour
{
    public StringLanguages wordName;
    public SoundLanguages sound;
    public GameObject wordEffect;
    public Reward reward;
    public GameObject emmojiEffect;   
    public string CurrentWord()
    {
        if(WordManager.Instance.language==WordManager.Language.Bangla)
        {
            return wordName.Bangla;
        } else
        if(WordManager.Instance.language==WordManager.Language.Hindi)
        {
            return wordName.Hindi;
        } 
        else
        if(WordManager.Instance.language==WordManager.Language.Urdu)
        {
            return wordName.Urdu;
        }  
        else
        if(WordManager.Instance.language==WordManager.Language.English)
        {
            return wordName.English;
        }          
        else
        return wordName.Bangla;        
    
    }   
     public AudioClip CurrentSound()
    {
        if(WordManager.Instance.language==WordManager.Language.Bangla)
        {
            return sound.Bangla;
        } else
        if(WordManager.Instance.language==WordManager.Language.Hindi)
        {
            return sound.Hindi;
        } 
        else
        if(WordManager.Instance.language==WordManager.Language.Urdu)
        {
            return sound.Urdu;
        }  
        else
        if(WordManager.Instance.language==WordManager.Language.English)
        {
            return sound.English;
        }          
        else
        return sound.Bangla;        
    
    }   
    
    
}
