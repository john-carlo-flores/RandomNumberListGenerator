# RandomNumberListGenerator
Creates a list of numbers based on provided min and max range in randomized order.

## API
  ```c#
  IEnumerable<T> GenerateRandomList GenerateRandomList(int minRange = 1, int maxRange = 10000)
  ``` 
  - Generate list of random integers ranging from minRange to maxRange (inclusive).
  - Return Type is IEnumerable to hide implementation and prevent tampering.
  
 ## Dependencies
  - .NET Core 6.0.6
  
 ## Usage
  ```c#
  var randomGenerator = new RandomNumberGenerator(new FisherYatesAlgorithm<int>());
  var list = randomGenerator.GenerateRandomList();
  ```
  - Program can be easily extended by creating a new class in Algorithms folder and implementing the IShuffle interface.
  - The new shuffle algorithm can then be injected as a dependency in the RandomNumberGenerator constructor during object instantiation.
  
 ## Algorithm
 The current algorithm used to shuffle is based on the [Modern Fisher-Yates Shuffle](https://en.wikipedia.org/wiki/Fisher–Yates_shuffle).
 - Runtime: O(n)
 - Description: Generate a random number between 0 and last element in tracked list. Random element is moved to the beginning of the untracked list. Tracked list is reduced by one each iteration as untracked list grows larger until there are no more elements in tracked list to move.
  
