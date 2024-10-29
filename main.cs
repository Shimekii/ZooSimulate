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

class Zoo{
  public List<Aviary> avlaries;
  public List<Decoration> decors;
  public Warehouse warehouse;

  public decor take
}

class User{
  public int money;
  public Zoo zoo;

  public void buildZoo(){};
  public void deleteZoo(){};
  public void save(){};
}

interface ILocate{
  void locate();
}
