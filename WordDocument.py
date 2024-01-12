from abc import ABC, abstractmethod

class DocumentPart(ABC):
    def __init__(self, name, position):
        self.name = name
        self.position = position

    @abstractmethod
    def save(self):
        pass

    @abstractmethod
    def paint(self):
        pass


class Paragraph(DocumentPart):
    def __init__(self, name, position, content):
        super().__init__(name, position)
        self.content = content

    def save(self):  
        pass

    def paint(self):
        pass


class Hyperlink(DocumentPart):
    def __init__(self, name, position, url):
        super()._init_(name, position)
        self.url = url

    def save(self):
        pass

    def paint(self):
        pass


class Header(DocumentPart):
    def __init__(self, name, position, title):
        super().__init__(name, position)
        self.title = title

    def save(self): 
        pass

    def paint(self): 
        pass


class Footer(DocumentPart):
    def __init__(self, name, position, text):
        super().__init__(name, position)
        self.text = text

    def save(self):
        pass

    def paint(self): 
        pass


class Document:
    def __init__(self):
        self.parts = []

    def open(self):
        pass


def main():
    
    document = Document()

    paragraph = Paragraph("Para1", 1, "This is a paragraph.")
    hyperlink = Hyperlink("Link1", 2, "https://example.com")
    header = Header("Header1", 3, "Document Header")
    footer = Footer("Footer1", 4, "Document Footer")

    document.parts.extend([paragraph, hyperlink, header, footer])

    
    for part in document.parts:
        part.save()
        part.paint()

    document.open()


if __name__ == "_main_":
    main()
