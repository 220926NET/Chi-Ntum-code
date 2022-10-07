using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


//implements serializable interface
[Serializable()]
class demo : ISerializable{
    public string Name {get; set;}
    public int id {get; set;}

    public demo(){}

    public demo(string Name = "Name"){
        this.Name = Name;
    }

    public override string ToString()
    {
        return string.Format("{0} is Name", Name);
    }

    //takes in info to be serialized,
    //SerializationInfo holds key/value pairs
    //is implemented in serialization?(https://learn.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable.getobjectdata?view=net-6.0)
    public void GetObjectData(SerializationInfo info, StreamingContext context){
        info.AddValue("Name", Name);
    }

    //retrieves value from file
    public demo(SerializationInfo info, StreamingContext context){
        Name = (string)info.GetValue("Name", typeof(string));
    }
}