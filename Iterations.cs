using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        /*
           Welcome to Interation

           In each method below you will see instructions that detail the requirements
           the method must implement to make the test pass.

           To start on a method comment out, or remove, the line
           `throw new System.NotImplementedException();`

           As you write and save your code, you can look in your terminal where you
           ran `dotnet watch test` to see if your code is working. The tests
           continuously check your work each time you save. If a test is failing
           you have not yet completed that method. Once you finish a method and have
           it correct, the test will tell you how the next method is working.
        */
        //  
        // 1) Complete the method named `yelling` that takes a list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        {
            var newUpperCaseWords = words.Select(word => word.ToUpper());
            return newUpperCaseWords;

        }
        // 
        // 2) Complete the method named `Double` that takes a list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        // 
        public static IEnumerable<int> Double(List<int> numbers)
        {
            Func<int, int> MultiplyBy2 = score => score * 2;

            var newNumbers = numbers.Select(MultiplyBy2);

            return newNumbers;
        }
        // 
        // 3) Complete the method `StringyIndexes` that takes a list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        // 
        public static IEnumerable<string> StringyIndexes(List<string> words)
        {
            var newList = words.Select((word, index) => $"{word} is at index {index}");
            return newList;
        }
        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts a list of
        //    numbers and returns only the elements that are even.
        // 
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> numbers)
        {
            var evenNumbersOnly = numbers.Where(number => number % 2 == 0);
            return evenNumbersOnly;
        }
        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts a
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> numbers)
        {
            var evenNumbers = numbers.Where((number, index) => index % 2 == 0);
            return evenNumbers;

        }

        // 
        // 6) Complete the method BestMoviesOfTheYear that accepts a list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.

        // A movie object looks like this:
        // 
        // new Movie() {
        //   Name: "Get Out",
        //   Year: "2017",
        //   Score: 99
        // }
        // 
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> movies, int yearToMatch)
        {

            var coolMovies = movies.Where(movie => movie.Year == yearToMatch && movie.Score >= 90).Select(movies => movies.Name);

            return coolMovies;
        }
        // 
        // 7) Complete the method EveryoneIsOdd that accepts a list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> numbers)
        {
            var areThereOddNumbers = numbers.All(number => number % 2 != 0);
            return areThereOddNumbers;
        }


        // 
        // 8) Complete the method FindTheNeedle that accepts a list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> sentences)
        {

            var containsNeedle = sentences.First(sentence => sentence.Contains("needle"));

            return containsNeedle;

        }

        // 
        // 9) Complete the method FindTheNeedleIndex that accepts a list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> sentences)
        {
            var containsNeedle = sentences.FindIndex(index => index.Contains("needle"));

            return containsNeedle;
        }

        // 
        // 10) Complete the method SomeoneToLove that accepts a list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> words)
        {
            var hasFourChar = words.Any(word => word.Length == 4);
            return hasFourChar;

        }
    }
}
