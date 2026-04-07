package classZoo;

public class ClassZoo {
	public static void main(String[] args) {
		Zoo myZoo = new Zoo(10, "My Zoo");
		myZoo.addAnimal(new Lion("Amy", 1, 240.5f, 2.8f));
		myZoo.addAnimal(new Bear("Bella", 2, 310.8f, 4.5f));
		myZoo.addAnimal(new Animal("Undefined", 3, 0.0f, 0.0f));
		myZoo.addAnimal(new Owl("Caitlyn", 4, 4.2f, 0.48f));
		myZoo.freeAnimal(3);
		myZoo.getAnimal(4).setID(3);
		myZoo.listAnimals();
		myZoo.getAnimal(1).animalSound();
		myZoo.getAnimal(2).animalSound();
		myZoo.getAnimal(3).animalSound();

	}
}