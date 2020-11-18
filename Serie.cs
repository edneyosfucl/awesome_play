using System;

[Serializable]
class Serie:Media{
  
  private int numEpisodes, numSeasons;
  private Gender gender;

	public Serie(int? id, string name, string description, int classification, string link, int numEpisodes, int numSeasons, Gender gender){

    setId(id);
    setName(name);
    setDescription(description);
    setClassification(classification);
    setLink(link);
    setGender(gender);

    this.numEpisodes = numEpisodes;
    this.numSeasons = numSeasons;
    this.gender = gender;
  }

  public int getNumEpisodes(){
    return numEpisodes;
  }
  public void setNumEpisodes(int numEpisodes){
    this.numEpisodes = numEpisodes;
  }


  public int getNumSeasons(){
    return numSeasons;
  }
  public void setNumSeasons(int numSeasons){
    this.numSeasons = numSeasons;
  }


  public Gender getGender(){
    return gender;
  }
  public void setGender(Gender gender){
    this.gender = gender;
  }


	public override string toString(){
    return "{id="+getId().ToString()+", name='"+getName()+"', description='"+getDescription()+"', classification="+getClassification()+", link='"+getLink()+"', gender="+getGender().toString()+", num_episodes="+getNumEpisodes().ToString()+", num_seasons="+getNumSeasons().ToString()+"}";
  }
}