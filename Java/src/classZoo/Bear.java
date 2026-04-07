package classZoo;

public class Bear extends Animal {
	public Bear(String inputName, int inputID, float inputWeight, float inputHeight) {
		super(inputName, inputID, inputWeight, inputHeight);
	}
	
	public void printSpecies() {
		System.out.println("Animal Species: Bear");
	}
	
	public void animalSound() {
		System.out.printf("%s growls\n", this.getName());
	}
}
