package classZoo;

import java.util.ArrayList;

class Zoo {
	private ArrayList<Animal> animals;
	private int zooSize;
	private String zooName;
	
	// Constructors
	public Zoo(int inputZooSize, String inputZooName) {
		animals = new ArrayList<Animal>(0);
		zooSize = inputZooSize;
		zooName = inputZooName;
	}
	public Zoo(int inputZooSize, String inputZooName, Animal inputAnimal) {
		animals = new ArrayList<Animal>(0);
		animals.add(inputAnimal);
		zooSize = inputZooSize;
		zooName = inputZooName;
	}
	public Zoo(int inputZooSize, String inputZooName, ArrayList<Animal> inputAnimals) {
		animals = inputAnimals;
		zooSize = inputZooSize;
		zooName = inputZooName;
	}
	
	public void addAnimal(Animal inputAnimal) throws RuntimeException {
		if (animals.size() >= zooSize) {
			throw new RuntimeException(String.format("Zoo %s cannot have more than %d animals", zooName, zooSize));
		}
		for (int a = 0; a < animals.size(); a++) {
			if (animals.get(a).getID() == inputAnimal.getID()) {
				throw new RuntimeException(String.format("ID collision in %s: %d",zooName, inputAnimal.getID()));
			}
		}
		animals.add(inputAnimal);
	}
	
	public Animal getAnimal(int inputID) throws RuntimeException {
		if (animals.isEmpty()) {
			throw new RuntimeException(String.format("Empty zoo: %s", zooName));
		} else {
			for (int a = 0; a < animals.size(); a++) {
				if (animals.get(a).getID() == inputID) {
					return animals.get(a);
				}
			}
			// Animal ID not found
			throw new RuntimeException(String.format("Animal ID not found in %s: %d", zooName, inputID));
		}
	}
	
	public void freeAnimal(int inputID) throws RuntimeException {
		boolean deleted = false;
		if (animals.isEmpty()) {
			throw new RuntimeException(String.format("Empty zoo: %s", zooName));
		} else {
			for (int a = 0; a < animals.size(); a++) {
				if ((animals.get(a).getID() == inputID) && deleted == false) {
					animals.remove(a);
					deleted = true;
					break;
				}
			}
			if (!deleted) {
				throw new RuntimeException(String.format("Animal ID not found in %s: %d", zooName, inputID));
			}
		}
	}
	
	// Get info from animal ID
	// TODO: learn iterators
	public void animalInfo(int inputID) throws RuntimeException {
		boolean found = false;
		if (animals.isEmpty()) {
			throw new RuntimeException(String.format("Empty zoo: %s", zooName));
		} else {
			for (int a = 0; a < animals.size(); a++) {
				if (animals.get(a).getID() == inputID) {
					animals.get(a).printInfo();
					animals.get(a).printSpecies();
					found = true;
					break;
				}
			}
			if (!found) {
				throw new RuntimeException(String.format("Animal ID not found in %s: %d", zooName, inputID));
			}
		}
	}
	
	// List all animals
	// TODO: learn iterators
	public void listAnimals() {
		System.out.printf("=== Information for zoo %s ===\n",zooName);
		if (animals.isEmpty()) {
			System.out.println("No animals in zoo.");
		} else {
			for (int a = 0; a < animals.size(); a++) {
				System.out.println("=== Animal Information ===");
				animals.get(a).printInfo();
				animals.get(a).printSpecies();
			}
			System.out.println("=== Information end ===");
		}
	}
	
	public ArrayList<Animal> getAllAnimals() {
		return animals;
	}	
	
	
}
