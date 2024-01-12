from abc import ABC, abstractmethod

class DocumentPart(ABC):
    def _init_(self, part_name, part_position):
        self.part_name = part_name
        self.part_position = part_position
    
    @abstractmethod
    def paint(self):
        pass
    
    @abstractmethod
    def save(self):
        pass

class WordDocument:
    def _init_(self):
        self.part_list = []

    def open(self):
        for doc_part in self.part_list:
            doc_part.paint()

    def save(self):
        for doc_part in self.part_list:
            doc_part.save()

class Header(DocumentPart):
    def _init_(self, title, position):
        super()._init_('Header', position)
        self.title = title
    
    def paint(self):
       
        pass
    
    def save(self):
       
        pass

class Footer(DocumentPart):
    def _init_(self, text, position):
        super()._init_('Footer', position)
        self.text = text
    
    def paint(self):
       
        pass
    
    def save(self):
       
        pass

class Paragraph(DocumentPart):
    def _init_(self, content, lines, position):
        super()._init_('Paragraph', position)
        self.content = content
        self.lines = lines
    
    def paint(self):
        
        pass
    
    def save(self):
      
        pass

class Hyperlink(DocumentPart):
    def _init_(self, link, position):
        super()._init_('Hyperlink', position)
        self.link = link
    
    def paint(self):
        
        pass
    
    def save(self):
        
        pass

if __name__ == "_main_":
    print("Hello World")
