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

class ConsoleDisplayController:
    content = None

    def set_content(self, msg):
        self.content = msg

    def display(self):
        print(self.content)

class StartsWithStrategy:
    startsWithChar = None
    
    def setStartsWithChar(self, key):
        self.startsWithChar = key
        
    def invokeStrategy(self, string):
        if string[0] == self.startsWithChar: 
            return True 
        else:
            return False

class StringFilterController:
    predicate = StartsWithStrategy()
    result = []
       

words_array = ["apple", "banana", "cherry", "grape"]

target_predicate = Predicate("an")
filter_instance = StringFilter(words_array)
result = filter_instance.apply_filter(target_predicate)

display_controller = ConsoleDisplayController()
display_controller.set_content(result)
display_controller.display()
result = filter_instance.apply_filter(target_predicate)

print(f"Words containing '{target_predicate.target_string}': {result}")
