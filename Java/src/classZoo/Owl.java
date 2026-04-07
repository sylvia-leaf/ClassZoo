package classZoo;

public class Owl extends Animal {

	public Owl(String inputName, int inputID, float inputWeight, float inputHeight) {
		super(inputName, inputID, inputWeight, inputHeight);
	}
	
	public void printSpecies() {
		System.out.println("Animal Species: Owl");
	}
	
	public void animalSound() {
		System.out.printf("%s hoots\n", this.getName());
	}

}
