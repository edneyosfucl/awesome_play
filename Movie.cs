using System;

[Serializable]
class Movie:Media {

  private string durationTime;
  private Gender gender;

  public Movie(int? id, string name, string description, int classification, string link, string durationTime, Gender gender){
    setId(id);
    setName(name);
    setDescription(description);
    setClassification(classification);
    setLink(link);
    setDurationTime(durationTime);
    setGender(gender);
    this.durationTime = durationTime;
    this.gender = gender;
  }

  public string getDurationTime(){
    return durationTime;
  }

  public void setDurationTime(string durationTime){
    this.durationTime = durationTime;
  }

  public Gender getGender(){
    return gender;
  }

  public void setGender(Gender gender){
    this.gender = gender;
  }

  public override string toString(){
    return "{id="+getId().ToString()+", name='"+getName()+"', description='"+getDescription()+"', classification="+getClassification()+", link='"+getLink()+"', durationTime='"+getDurationTime()+"', gender="+getGender().toString()+"}";
  }
}