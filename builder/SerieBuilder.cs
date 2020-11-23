public class SerieBuilder: ISerieBuilder{
  
  private Serie serie = new Serie(null, "", "", 0, "", 0, 0, null);

  public SerieBuilder(){ }

  public SerieBuilder id(int? id){
    serie.setId(id);
    return this;
  }

  public SerieBuilder name(string name){
    serie.setName(name);
    return this;
  }

  public SerieBuilder description(string description){
    serie.setDescription(description);
    return this;
  }

  public SerieBuilder classification(int classification){
    serie.setClassification(classification);
    return this;
  }

  public SerieBuilder link(string link){
    serie.setLink(link);
    return this;
  }

  public SerieBuilder gender(Gender gender){
    serie.setGender(gender);
    return this;
  }

  public SerieBuilder numSeasons(int numSeasons){
    serie.setNumSeasons(numSeasons);
    return this;
  }

  public SerieBuilder numEpisodes(int numEpisodes){
    serie.setNumEpisodes(numEpisodes);
    return this;
  }

  public Serie build() => serie;
}