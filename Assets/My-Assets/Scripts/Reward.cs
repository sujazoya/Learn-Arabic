using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    public int rewardCount;
    public AudioClip sound;
    public GameObject rewardEffect;
    public enum RewardType
    {
        None,Coin,Diemond,Sticker
    }
    public RewardType rewardType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
