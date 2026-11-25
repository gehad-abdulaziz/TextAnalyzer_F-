module TextAnalyzer.Models

type Options =
    { TopN: int
      MinWordLength: int
      IgnoreCommon: bool
      IgnoreNumbers: bool }

type WordCount =
    { Rank: int
      Word: string
      Count: int
      Percent: float }

type AnalysisResult =
    { Words: int
      Sentences: int
      Paragraphs: int
      Lines: int
      Characters: int
      CharactersWithSpaces: int
      UniqueWords: int
      LexicalDiversity: float
      AverageSentenceLength: float
      AverageWordLength: float
      WordsPerParagraph: float
      LongestWord: string
      LongestSentenceWords: int
      ReadingMinutes: float
      ReadingLevel: string
      FleschScore: float option
      FleschLabel: string
      TopWords: WordCount list }
