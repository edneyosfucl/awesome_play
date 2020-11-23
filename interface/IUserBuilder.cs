public interface IUserBuilder{
  UserBuilder id(int? id);
  UserBuilder nickname(string nickname);
  UserBuilder birth(string birth);
  UserBuilder login(string login);
  UserBuilder password(string password);
  User build();
}