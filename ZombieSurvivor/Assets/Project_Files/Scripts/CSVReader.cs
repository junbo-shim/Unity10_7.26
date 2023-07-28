using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CSVReader : MonoBehaviour
{
    private static string zombieDataPath = default;
    public ZombieData zombieData_default = default;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ReadCSV() 
    {
        StreamReader reader = new StreamReader(Application.dataPath + 
            "/Project_Files/Resources/ZombieDatas/" + "Zombie Survival Datas - Zombie Datas.csv"); 


    }
}
