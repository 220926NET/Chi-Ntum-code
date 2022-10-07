using System;
using System.Collections;
using System.Collections.Generic;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class main{

    static void Main(string[] args)
    {
        //sets up class with serialization methods
        demo demo = new demo("Test");
        //open a stream to create document to write to
        Stream stream = File.Open("demo.txt", FileMode.Create);
        //open binary formatter
        BinaryFormatter bf = new BinaryFormatter();
        //sends data(demo) to file(stream)
        bf.Serialize(stream, demo);
        //close stream
        stream.Close();

        //opens file
        stream = File.Open("demo.txt", FileMode.Open);
        //create new formatter
        bf = new BinaryFormatter();
        //deserialize(retrieve) information into demo
        demo = (demo)bf.Deserialize(stream);
        //close stream
        stream.Close();
        //write information to console
        Console.WriteLine(demo.ToString());

    }
}