package classZoo;

class Lion extends Animal {

	public Lion(String inputName, int inputID, float inputWeight, float inputHeight) {
		super(inputName, inputID, inputWeight, inputHeight);
	}
	
	public void printSpecies() {
		System.out.println("Animal Species: Lion");
	}
	
	public void animalSound() {
		System.out.printf("%s roars\n", this.getName());
	}

}
