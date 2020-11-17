using System;

[Serializable]
class Gender{

  private MediaType type;
  private string name;

  public Gender(MediaType type, string name){
    this.type = type;
    this.name = name;
  }

  public MediaType getType(){
    return type;
  }

  public void setType(MediaType type){
    this.type = type;
  }

  public string getName(){
    return name;
  }

  public void setName(string name){
    this.name = name;
  }

  public string toString(){
    return "{name='"+name+"', type="+type.ToString()+"}";
  }
}