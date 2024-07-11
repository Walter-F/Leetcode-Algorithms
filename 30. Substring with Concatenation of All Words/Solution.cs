using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        IList<int> result = new List<int>();

        if (s.Length == 0 || words.Length == 0)
            return result;

        int wordLength = words[0].Length; // Length of each word in the words array
        int totalWords = words.Length; // Total number of words in the words array
        int substringLength = wordLength * totalWords; // Length of the concatenated substring

        if (s.Length < substringLength)
            return result;

        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        
        // Count the occurrences of each word in the words array
        foreach (string word in words) {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        // Sliding window approach
        for (int i = 0; i < wordLength; i++) {
            Dictionary<string, int> currentWordCount = new Dictionary<string, int>(); // Track counts of words in the current window
            int wordsFound = 0; // Total number of words found in the current window
            int left = i; // Left index of the sliding window

            // Move the window one word length at a time
            for (int j = i; j <= s.Length - wordLength; j += wordLength) {
                string currentWord = s.Substring(j, wordLength);

                // If the current word is in the wordCount dictionary, update the counts
                if (wordCount.ContainsKey(currentWord)) {
                    if (currentWordCount.ContainsKey(currentWord))
                        currentWordCount[currentWord]++;
                    else
                        currentWordCount[currentWord] = 1;

                    wordsFound++;

                    // Adjust the left index of the window if any word count exceeds the required count
                    while (currentWordCount[currentWord] > wordCount[currentWord]) {
                        string leftWord = s.Substring(left, wordLength);
                        currentWordCount[leftWord]--;
                        wordsFound--;
                        left += wordLength;
                    }

                    // If all words are found, add the left index to the result
                    if (wordsFound == totalWords) {
                        result.Add(left);
                        string leftWord = s.Substring(left, wordLength);
                        currentWordCount[leftWord]--;
                        wordsFound--;
                        left += wordLength;
                    }
                }
                // If the current word is not in the wordCount dictionary, reset the counts and move the left index
                else {
                    currentWordCount.Clear();
                    wordsFound = 0;
                    left = j + wordLength;
                }
            }
        }

        return result;
    }
}