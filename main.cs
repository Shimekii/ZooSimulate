class Animal{
  public string species;
  public string foodinfo;
  public string name;
  public string habitat;
  public int health;

  public void action(string type){};
{ 

class Food{
  public string typeOfFood;
}

class Decoration{
  public string name;
  public double square;
}

class Aviary{
  public List<Food> foods;
  public double square;
}

class Warehouse{
  public List<Animal> animals;
  public List<Decoration> decors;
  public List<Food> foods;
}

interface ILocate{
  void locate();
}
  
class Zoo : ILocate {
  public List<Aviary> aviaries;
  public List<Decoration> decors;
  public Warehouse warehouse;

  public decor take(Decoration decor){};
  public void locate(){};
}

class User{
  public int money;
  public Zoo zoo;

  public void buildZoo(){};
  public void deleteZoo(){};
  public void save(){};
}
