using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;
// ��ũ��Ʈ �����ϱ� ���� ��ɾ� ����
// using UnityEditor;

public class ResManager : MonoBehaviour
{
    private static ResManager m_instance;
    // �̱������� ResManager �����
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
        // ��ũ��Ʈ���� �ڽ��� ������Ʈ Asset ��θ� ������ �� �ִ� �ڵ�
        //dataPath = Application.dataPath;
        // ������ �ִ� <�ڽ��� ������Ʈ ���ϸ�>/Scriptables �� �����ϰڴٴ� ��
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

        Debug.LogFormat("���� ���̺�� ���⿡ ����ȴ� -> {0}", Application.persistentDataPath);
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
