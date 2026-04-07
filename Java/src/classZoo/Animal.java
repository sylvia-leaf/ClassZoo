package classZoo;

class Animal {
	private String name;
	private int id;
	private float weight;
	private float height;
	
	public Animal(String inputName, int inputID, float inputWeight, float inputHeight) {
		name = inputName;
		id = inputID;
		weight = inputWeight;
		height = inputHeight;
	}
	
	// Getters
	public String getName() {
		return name;
	}
	public int getID() {
		return id;
	}
	public float getWeight() {
		return weight;
	}
	public float getHeight() {
		return height;
	}
	
	// Setters
	public void setName(String newName) {
		name = newName;
	}
	public void setID(int newID) {
		id = newID;
	}
	public void setWeight(float newWeight) {
		weight = newWeight;
	}
	public void setHeight(float newHeight) {
		height = newHeight;
	}
	
	// Print information
	public void printInfo() {
		System.out.printf("Animal Name: %s\nAnimal ID: %d\nAnimal Weight: %.3f kg\nAnimal Height: %.2f m\n", name, id, weight, height);
	}
	
	// Print species information, specified by subclass
	public void printSpecies() {
		System.out.println("Animal Species: Not Specified");
	}
	
	public void animalSound() {
		System.out.printf("%s makes a sound\n", name);
	}
}
