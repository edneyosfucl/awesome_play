using System;

[Serializable]
abstract class Media{
  
  private int? id;
  private int classification;
  private string name, description, link;
  
  public abstract string toString();

  public int? getId(){
    return id;
  }

  public void setId(int? id){
    this.id = id;
  }

  public int getClassification(){
    return classification;
  }

  public void setClassification(int classification){
    this.classification = classification;
  }

  public string getName(){
    return name;
  }

  public void setName(string name){
    this.name = name;
  }

  public string getDescription(){
    return description;
  }

  public void setDescription(string description){
    this.description = description;
  }

  public string getLink(){
    return link;
  }

  public void setLink(string link){
    this.link = link;
  }
}