using System;
using System.Collections.Generic;

[Serializable]
public class Movie: Media{

  private string durationTime;

  public Movie(int? id, string name, string description, int classification, string link, string durationTime, Gender gender){

    this.id = id;
    this.name = name;
    this.description = description;
    this.classification = classification;
    this.link = link;
    this.gender = gender;

    this.durationTime = durationTime;
  }

  public static Movie operator ++(Movie movie){
    movie.setId(movie.getId() + 1);

    return movie;
  }

  public string getDurationTime() => durationTime;

  public void setDurationTime(string durationTime){
    this.durationTime = durationTime;
  }
  
  public override string ToString(){
    return "{id="+getId().ToString()+", name='"+getName()+"', description='"+getDescription()+"', classification="+getClassification()+", link='"+getLink()+"', durationTime='"+getDurationTime()+"', gender="+(getGender() != null ? getGender().ToString() : "null")+"}";
  }
}