using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{

    
    public enum Sound
    {

        Play0,
        Play1,
        Play2,
        Play3,
        //Play4,  // 이건 픽스


        SFX,
        MaxCount
    }
    public enum SoundtrackType0
    {
        S0_0_a,
        S0_0_b,
        S0_1_a,
        S0_1_b,
        S0_2_a,
        S0_2_b,
        S0_3_a,
        S0_3_b,
        MaxCount

    }
    public enum SoundtrackType1
    {
        
        S1_0_a,
        S1_0_b,
        S1_1_a,
        S1_1_b,
        S1_2_a,
        S1_2_b,
        S1_3_a,
        S1_3_b,
        MaxCount

    }
    public enum SoundtrackType2
    {

        S2_0_a,
        S2_0_b,
        S2_1_a,
        S2_1_b,
        S2_2_a,
        S2_2_b,
        S2_3_a,
        S2_3_b,
        MaxCount

    }
    public enum SoundtrackType3
    {
        S3_0_a,
        S3_0_b,
        S3_1_a,
        S3_1_b,
        S3_2_a,
        S3_2_b,
        S3_3_a,
        S3_3_b,



        MaxCount

    }
    
    public enum SFX
    {
        MaxCount
    }
    public enum State
    {
        MaxCount
    }

    public enum Tag
    {
        MaxCount
    }

    /// <summary>
    /// UI Event 종류 지정
    /// </summary>
    public enum UIEvent
    {
        Down,
        Click,
        Drag,
        DragEnd,
        Up,
        Exit,
        Deselect,
    }

    public enum Scenes
    {
        Title,
        Loby,
        Game,
    }

    public enum PoolingType
    {
        
        DontPool,
    }


}