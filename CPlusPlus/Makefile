CXX=g++
CXXFLAGS=-std=c++20 

clean-build:
	@make clean
	@make build

build: src/ClassZoo.cpp src/Animal.o src/Bear.o src/Lion.o src/Owl.o src/Zoo.o
	$(CXX) -o ClassZoo $^ $(CXXFLAGS)

src/%.o: src/%.c
	$(CXX) -c -o $@ $< $(CXXFLAGS)

clean:
	@rm -rf ClassZoo src/*.o