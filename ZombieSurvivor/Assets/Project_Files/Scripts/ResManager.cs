using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;
// 스크립트 접근하기 위한 명령어 모음
// using UnityEditor;

public class ResManager : MonoBehaviour
{
    private static ResManager m_instance;
    // 싱글턴으로 ResManager 만들기
    public static ResManager instance 
    {
        get 
        {
            if (m_instance == null)
            {
                m_instance = FindObjectOfType<ResManager>();
            }
            return m_instance;
        }
    }

    //private string dataPath = default;
    private static string zombieDataPath = default;
    public ZombieData zombieData_default = default;

    private void Awake()
    {
        // 스크립트에서 자신의 프로젝트 Asset 경로를 접근할 수 있는 코드
        //dataPath = Application.dataPath;
        // 하위에 있는 <자신의 프로젝트 파일명>/Scriptables 에 접근하겠다는 것
        //zombieDataPath = string.Format("{0}/{1}", Application.dataPath, "Project_Files/Resources/Scriptables");

        //byte[] byteZombieData = System.IO.File.ReadAllBytes(zombieDataPath + "/Zombie Default");



        //zombieDataPath = "Assets/Project_Files/Resources/Scriptables";
        zombieDataPath = "Scriptables";
        //zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "/Zombie Default.asset");
        zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "Zombie Default");

        //ZombieData zombieData_ = AssetDatabase.LoadAssetAtPath<ZombieData>(zombieDataPath);
        zombieData_default = Resources.Load<ZombieData>(zombieDataPath);

        //Debug.LogFormat("Zombie data path: {0}", zombieDataPath);
        //Debug.LogFormat("Zombie data: {0}, {1}, {2}", zombieData_.health, zombieData_.damage, zombieData_.speed);

        //Debug.Log(dataPath);
        //Debug.LogFormat("Zombie Data path: {0}", zombieDataPath);

        Debug.LogFormat("게임 세이브는 여기에 저장된다 -> {0}", Application.persistentDataPath);
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
