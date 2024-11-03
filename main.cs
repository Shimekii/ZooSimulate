class Animal{
  private string species;
  private string foodinfo;
  private string name;
  private string habitat;
  private int health;

  public void action(string type){};
  public void feed(Food f){};
}

class Food{
  private string typeOfFood;
}

class Decoration{
  private string name;
  private double square;
}

class Aviary{
  private List<Food> foods;
  private double square;

  public void CreateLivindConditions(float temp, Food food);
  public void set(Animal a){}
  public void set(Decoration d){}
}

class Warehouse{
  private List<Animal> animals;
  private List<Decoration> decors;
  private List<Food> foods;
  private int space;
  public void orderFood(Food f){}
  public Food getFood(Animal a){
    return food;
  }
  public Animal takeAnimals(string species){
    return animals;
  }
  public Decoration takeDecors(string type){
    return decors;
  }
  public bool findFoodForAnimal(Animal a){
    return true;
  }
  public Food takeFood(Animal a){
    return food;
  };
}

interface ILocate{
  void locate();
}
  
class Zoo : ILocate {
  private List<Aviary> aviaries;
  private List<Decoration> decors;
  private Warehouse warehouse;

  public void buildZoo(){
        Animal tempAnimals = new Animal();
        Decoration tempDecors = new Decoration();
        animals = warehouse.takeAnimals(species);
        decors = warehouse.takeDecors(species);
        place(animals, decors);

        decors = warehouse.takeDecors(type);
        locate(decors);

        Food food = new Food();
        food = warehouse.getFood(tempAnimals);

        aviaries.CreateLivindConditions(temp, food);
  }
  public void deleteZoo(){}
  
  public Decoration take(){};
  public void locate(Decoration dec){};
  public void buyFood(){}
  public void place(Animal animals, Decoration decors){
    foreach(a in animals){
        aviaries.set(a);
    }
        foreach(d in decors){
        aviaries.set(a);
    }
  }
  public void feedAnimal(Animal a){};
  
}

class User{
  private int money;
  private Zoo zoo;
  public void save(){};
}
