using System;

[Serializable]
public abstract class Media{
  
  protected int? id;
  protected int classification;
  protected string name, description, link;
  protected Gender gender;

  public void setId(int? id){ 
    this.id = id; 
  }

  public int? getId() => id;

  public void setClassification(int classification){
    this.classification = classification;
  }

  public int getClassification() => classification;

  public void setName(string name){
    this.name = name;
  }

  public string getName() => name;

  public void setDescription(string description){
    this.description = description;
  }

  public string getDescription() => description;

  public void setLink(string link){
    this.link = link;
  }

  public string getLink() => link;

  public void setGender(Gender gender){
    this.gender = gender;
  }

  public Gender getGender() => gender;
}