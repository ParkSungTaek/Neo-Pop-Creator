using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncController : MonoBehaviour
{
    #region Singleton
    static SyncController _sync;
    static SyncController sync { get { Init();  return _sync; } set { _sync = value; } } 
    SyncController() { }
    #endregion Singleton

    #region Data
    public const float SyncTime = 10.909f;
    bool nowPlaying = false;
    public static bool APart { get; set; } = false;

    public static float NextTick { get; private set; }
    #endregion Data

    #region Initiator
    static void Init()
    {
        if(_sync == null)
        {
            GameObject gm = GameObject.Find("SyncController");
            if(gm == null)
            {
                gm = new GameObject { name = "SyncController" };
                gm.AddComponent<SyncController>();
            }
            _sync = gm.GetComponent<SyncController>();

        }
    }
    #endregion Initiator

    #region SyncSystem



    public static Action JobCollector_Start_A_OneTime { get; set; }
    public static Action JobCollector_Start_B_OneTime { get; set; }

    public static Action JobCollector_Start_A { get; set; }
    public static Action JobCollector_End_A { get; set; }
    public static Action JobCollector_Start_B { get; set; }
    public static Action JobCollector_End_B { get; set; }
                        
    public static Action JobCollector_Start_Player0_A { get; set; }
    public static Action JobCollector_Start_Player0_B { get; set; }
                        
    public static Action JobCollector_Start_Player1_A { get; set; }
    public static Action JobCollector_Start_Player1_B { get; set; }
                        
    public static Action JobCollector_Start_Player2_A { get; set; }
    public static Action JobCollector_Start_Player2_B { get; set; }
    public static Action JobCollector_Start_Player3_A { get; set; }
    public static Action JobCollector_Start_Player3_B { get; set; }
    

    Coroutine coroutine;
    
    public static void Flush()
    {
        if (!sync.nowPlaying)
        {
            sync.nowPlaying = true;
            sync.coroutine = sync.StartCoroutine(SyncSystem());

        }
    }
    public static void EndFlush()
    {
        if (sync.nowPlaying)
        {
            sync.nowPlaying =false;
            sync.StopCoroutine(sync.coroutine);

        }
    }

    WaitForSeconds seconds = new WaitForSeconds(SyncTime);
    static IEnumerator SyncSystem()
    {
        yield return new WaitForSeconds(0.2f);
        while (true)
        {
            if (!APart)
            {

                APart = true;
                JobCollector_Start_A_OneTime?.Invoke();
                JobCollector_Start_A?.Invoke(); 
                JobCollector_Start_Player0_A?.Invoke();
                JobCollector_Start_Player1_A?.Invoke();
                JobCollector_Start_Player2_A?.Invoke();
                JobCollector_Start_Player3_A?.Invoke();
                JobCollector_Start_A_OneTime = null;

                NextTick = Time.time + SyncTime;
                JobCollector_End_A?.Invoke();

                yield return sync.seconds;
                

            }
            if (APart)
            {
                APart = false;
                JobCollector_Start_B_OneTime?.Invoke();
                JobCollector_Start_B?.Invoke();
                JobCollector_Start_Player0_B?.Invoke();
                JobCollector_Start_Player1_B?.Invoke();
                JobCollector_Start_Player2_B?.Invoke();
                JobCollector_Start_Player3_B?.Invoke();
                JobCollector_Start_B_OneTime = null;

                NextTick = Time.time + SyncTime;
                JobCollector_End_B?.Invoke();

                yield return sync.seconds;
                
            }

        }

    }
    #endregion SyncSystem
}
