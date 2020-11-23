public interface ISerieBuilder{
  SerieBuilder id(int? id);
  SerieBuilder name(string name);
  SerieBuilder description(string description);
  SerieBuilder classification(int classification);
  SerieBuilder link(string link);
  SerieBuilder gender(Gender gender);
  SerieBuilder numSeasons(int numSeasons);
  SerieBuilder numEpisodes(int numEpisodes);
  Serie build();
}