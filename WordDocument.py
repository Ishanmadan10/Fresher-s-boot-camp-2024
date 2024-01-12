from abc import ABC, abstractmethod

class DocumentPart(ABC):
    def __init__(self, name, position):
        self.name = name
        self.position = position
    
    @abstractmethod
    def paint(self):
        pass
    
    @abstractmethod
    def save(self):
        pass
    
    @abstractmethod
    def convert(self, i_converter):
        pass

class Header(DocumentPart):
    def __init__(self, title):
        super().__init__("", "")
        self.title = title
    
    def paint(self):
        print("paint header")
    
    def save(self):
        print("save header")
    
    def convert(self, i_converter):
        i_converter.convertHeader(self)

class Paragraph(DocumentPart):
    def __init__(self, content, lines):
        super().__init__("", "")
        self.content = content
        self.lines = lines
    
    def paint(self):
        print("paint paragraph")
    
    def save(self):
        print("save paragraph")
    
    def convert(self, i_converter):
        i_converter.convertParagraph(self)

class HyperLink(DocumentPart):
    def __init__(self, url, text):
        super().__init__("", "")
        self.url = url
        self.text = text
    
    def paint(self):
        print("paint hyperlink")
    
    def save(self):
        print("save hyperlink")
    
    def convert(self, i_converter):
        i_converter.convertHyperlink(self)

class Footer(DocumentPart):
    def __init__(self, text):
        super().__init__("", "")
        self.text = text
    
    def paint(self):
        print("paint footer")
    
    def save(self):
        print("save footer")
    
    def convert(self, i_converter):
        i_converter.convertFooter(self)

class WordDocument:
    def __init__(self, document_part_list):
        self.document_parts = document_part_list
    
    def open(self):
        for part_item in self.document_parts:
            part_item.paint()
            part_item.save()
    
    def convert(self, i_converter):
        for part_item in self.document_parts:
            part_item.convert(i_converter)

class ConverterInterface(ABC):
    @abstractmethod
    def convertHeader(self):
        pass
    
    @abstractmethod
    def convertParagraph(self):
        pass
    
    @abstractmethod
    def convertHyperlink(self):
        pass
    
    @abstractmethod
    def convertFooter(self):
        pass

class HTMLConverter(ConverterInterface):
    def convertHeader(self):
        print("header converted")
    
    def convertParagraph(self):
        print("paragraph converted")
    
    def convertHyperlink(self):
        print("hyperlink converted")
    
    def convertFooter(self):
        print("footer converted")

if __name__ == "_main_":
    header1 = Header("header", "hhhhh")
    paragraph1 = Paragraph("para","this is a paragraph")
    hyperlink1 = HyperLink("hyperlinkr", "https://example.com")
    footer1 = Footer("footer","example")
    
    document_part_list = [header1, paragraph1, hyperlink1, footer1]
    word_document1 = WordDocument(document_part_list)
    html_converter = HTMLConverter()
    
    word_document1.convert(html_converter)
