# Anagram-Norepeat-CodeTest-

We are doing a code test where we sort words that are an anagram, and another assignment where we return the character that is not being repeated in a word.


Assigment 1 - Anagram

Data Structures & Algorithms

I will use a Dictionary<string, List<string>>, where:
The key is the sorted version of each word (e.g., "listen" → "eilnst").
The value is a list of words that share the same sorted key (i.e., anagrams).
I will iterate through the list once, ensuring an efficient solution.

Potential Challenges & Solutions

* Handling large inputs efficiently:
Using a dictionary keeps lookups fast, preventing performance bottlenecks.

* Handling words with different lengths:
Since we sort each word independently, length differences don’t affect correctness.

* Edge cases like empty lists or single words:
If the list is empty, we return an empty result.
Single-word inputs still get grouped correctly.

_________________________________________________________________________


Assignment 2 - No repeat

Data Structures & Algorithm

I will use a Dictionary<char, int> to count how many times each character appears in the string.
Then, I will iterate through the string again to find the first character that has a count of 1.
If no unique character is found, the function will return '_'.

Challenges & Solutions

* Handling large inputs efficiently:
Using a dictionary keeps lookups fast, preventing performance bottlenecks.

* Handling edge cases
If all characters are repeated ("aabb"), return '_'.
If the string is empty (""), return '_'.



