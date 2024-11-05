class Animal{
  private string species;
  private string foodinfo;
  private string name;
  private string habitat;
  private int health;
  private int cost;

  public void action(string type){};
  public void feed(Food f){};
}

class Food{
  private string typeOfFood;
  private int cost;
}

class Decoration{
  private string name;
  private double square;
  private string typeDecor;
  private int cost;
}

class Aviary : IZoo{
  private List<Food> foods;
  private double square;
  private List<Animal> animals;
  private double temp;

  public void CreateLivindConditions(float temp, Food food);
  public void set(Animal a){}
  public void set(Decoration d){}
  public void locate(){}
}

class Warehouse : IZoo{
  private List<Animal> animals;
  private List<Decoration> decors;
  private List<Food> foods;
  private int space;
  
  public void orderFood(Animal a){
    Food food = new Food();
  }
  public Food getFood(Animal a){
    Food food = NULL;
    bool inStock = findFoodForAnimal(a);
    if(inStock){
      food = takeFood(a);
    }
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
  }

  public void locate(){}
}

interface IZoo{
  void locate();
}
  
class Zoo {
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
  public placeSubject(IZoo iZoo){
    iZoo.locate();
  }
  public void deleteZoo(){}
  
  public Decoration take(){};
  public void locate(Decoration dec){};
  public void buyFood(Animal a){
    warehouse.orderFood(a);
  }
  public void place(i, Animal animals, Decoration decors){
    foreach(a in animals){
        aviaries[i].set(a);
    }
        foreach(d in decors){
        aviaries[i].set(a);
    }
  }
  public void feedAnimal(Animal a){
    food = warehouse.getFood(a);
    if (food){
      a.feed(food);
    }
    else buyFood(a);
  }
}

class User{
  private int money;
  private Zoo zoo;
  public void save(){};
}
