public class MovieBuilder: IMovieBuilder{

  private Movie movie = new Movie(
    null, "", "", 0, "", "", null
  );

  public MovieBuilder(){ }

  public MovieBuilder id(int? id){
    movie.setId(id);
    return this;
  }

  public MovieBuilder name(string name){
    movie.setName(name);
    return this;
  }

  public MovieBuilder description(string description){
    movie.setDescription(description);
    return this;
  }

  public MovieBuilder classification(int classification){
    movie.setClassification(classification);
    return this;
  }

  public MovieBuilder link(string link){
    movie.setLink(link);
    return this;
  }

  public MovieBuilder durationTime(string durationTime){
    movie.setDurationTime(durationTime);
    return this;
  }

  public MovieBuilder gender(Gender gender){
    movie.setGender(gender);
    return this;
  }

  public Movie build() => movie;
}