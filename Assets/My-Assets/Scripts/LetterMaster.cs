using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterMaster : MonoBehaviour
{
public enum ArabicLetter
{
    alif,ba,ta,sa,jim,ha,kha,dal,zal,ra,za,sin,shin,
    sod,zod,to,zo,ain,gain,fa,kof,kaf,lam,mim
    ,nun,wao,hha,hamza,ya
    
}
public enum LetterType
{
    letter,mark
}
public enum LetterPose
{
    none,up,down,left,right        
}
public ArabicLetter arabicLetter;
public LetterType letterType;
public LetterPose letterPose;

public static LetterMaster instance;
private void Awake() 
{
    if(instance==null)
    {
        instance=this;
    }
    
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
