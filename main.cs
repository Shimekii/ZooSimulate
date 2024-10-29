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
  public Food []foods;
  public double square;
}

class Warehouse{
  public Animal []animals;
  public Decoration []decors;
  public Food []foods;
}

class Zoo{
  public Aviary []avlaries;
  public Decoration []decors;
  public Warehouse warehouse;
}
