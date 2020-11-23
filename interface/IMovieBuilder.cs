public interface IMovieBuilder{
  MovieBuilder id(int? id);
  MovieBuilder name(string name);
  MovieBuilder description(string description);
  MovieBuilder classification(int classification);
  MovieBuilder link(string link);
  MovieBuilder durationTime(string durationTime);
  MovieBuilder gender(Gender gender);
  Movie build();
}