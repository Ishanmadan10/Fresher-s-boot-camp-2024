class Predicate:
    def __init__(self, target_string):
        self.target_string = target_string

    def test(self, word):
        return self.target_string in word


class StringFilter:
    def __init__(self, word_array):
        self.word_array = word_array

    def apply_filter(self, predicate):
        filtered_words = [word for word in self.word_array if predicate.test(word)]
        return filtered_words


words_array = ["apple", "banana", "cherry", "grape"]
target_predicate = Predicate("an")
filter_instance = StringFilter(words_array)
result = filter_instance.apply_filter(target_predicate)

print(f"Words containing '{target_predicate.target_string}': {result}")
