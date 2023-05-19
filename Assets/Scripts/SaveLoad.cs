using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //save();
        load();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void load()
    {
        string path = Application.dataPath + "/Log.txt";
        if (File.Exists(path))
        {
            // can use an array and loop for large amouts of save data
            FileInfo f = new FileInfo(path);
            StreamReader read = f.OpenText();

            string sIn = read.ReadLine();
            int val;
            int.TryParse(sIn, out val);
            GameObject.Find("Player").GetComponent<PlayerStats>().scoreIn = val;
        }
        if (!File.Exists(path))
        {
            string s = "000000 \n";
            File.AppendAllText(path, s);
        }
    }
    public void save()
    {
        string path = Application.dataPath + "/Log.txt";
        if (!File.Exists(path))
        {
            string s = "000000 \n";
            File.AppendAllText(path, s);
        }
        if (File.Exists(path))
        {
            File.WriteAllText(path, "");
            string s = "" + GameObject.Find("Player").GetComponent<PlayerStats>().score;
            File.AppendAllText(path, s);
        }
    }
}
