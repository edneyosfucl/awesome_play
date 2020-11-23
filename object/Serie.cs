using System;

[Serializable]
public class Serie:Media{
  
  private int numSeasons, numEpisodes;

	public Serie(int? id, string name, string description, int classification, string link, int numEpisodes, int numSeasons, Gender gender){

    this.id = id;
    this.name = name;
    this.description = description;
    this.classification = classification;
    this.link = link;
    this.gender = gender;

    this.numEpisodes = numEpisodes;
    this.numSeasons = numSeasons;
  }

  public static Serie operator ++(Serie serie){
    serie.setId(serie.getId() + 1);

    return serie;
  }

  public void setNumSeasons(int numSeasons){
    this.numSeasons = numSeasons;
  }

  public int getNumSeasons() => numSeasons;

  public void setNumEpisodes(int numEpisodes){
    this.numEpisodes = numEpisodes;
  }

  public int getNumEpisodes() => numEpisodes;

	public override string ToString(){
    return "{id="+getId().ToString()+", name='"+getName()+"', description='"+getDescription()+"', classification="+getClassification()+", link='"+getLink()+"', gender="+(getGender() != null ? getGender().ToString() : "null")+", num_episodes="+getNumEpisodes().ToString()+", num_seasons="+getNumSeasons().ToString()+"}";
  }
}