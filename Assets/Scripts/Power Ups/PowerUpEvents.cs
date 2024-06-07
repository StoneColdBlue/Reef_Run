using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public static class PowerUpEvents 
{
    [System.Serializable] public class SpeedBoostEvent : UnityEvent<float,float> { }
    [System.Serializable] public class ScoreMultiplierEvent : UnityEvent<float> { }
    [System.Serializable] public class PowerUpEvent : UnityEvent { }
    
    public static SpeedBoostEvent OnSpeedBoost = new SpeedBoostEvent();
    public static ScoreMultiplierEvent OnScoreMultiplier = new ScoreMultiplierEvent();
    public static PowerUpEvent OnPowerUpCollected = new PowerUpEvent();

}
