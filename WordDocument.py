from abc import ABC, abstractmethod

class DocumentPart(ABC):
    def _init_(self, name, position):
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
    def _init_(self, title):
        super()._init_("", "")
        self.title = title
    
    def paint(self):
        print("paint header")
    
    def save(self):
        print("save header")
    
    def convert(self, i_converter):
        i_converter.convertheader(self)

class Paragraph(DocumentPart):
    def _init_(self, content, lines):
        super()._init_("", "")
        self.content = content
        self.lines = lines
    
    def paint(self):
        print("paint paragraph")
    
    def save(self):
        print("save paragraph")
    
    def convert(self, i_converter):
        i_converter.convertparagraph(self)

class HyperLink(DocumentPart):
    def _init_(self, url, text):
        super()._init_("", "")
        self.url = url
        self.text = text
    
    def paint(self):
        print("paint hyperlink")
    
    def save(self):
        print("save hyperlink")
    
    def convert(self, i_converter):
        i_converter.converthyperlink(self)

class Footer(DocumentPart):
    def _init_(self, text):
        super()._init_("", "")
        self.text = text
    
    def paint(self):
        print("paint footer")
    
    def save(self):
        print("save footer")
    
    def convert(self, i_converter):
        i_converter.convertfooter(self)

class WordDocument:
    def _init_(self, document_part_list):
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
    def convertheader(self, header_item):
        pass
    
    @abstractmethod
    def convertparagraph(self, paragraph_item):
        pass
    
    @abstractmethod
    def converthyperlink(self, hyperlink_item):
        pass
    
    @abstractmethod
    def convertfooter(self, footer_item):
        pass

class HTMLConverter(ConverterInterface):
    def convertheader(self, header_item):
        print("header converted")
    
    def convertparagraph(self, paragraph_item):
        print("paragraph converted")
    
    def converthyperlink(self, hyperlink_item):
        print("hyperlink converted")
    
    def convertfooter(self, footer_item):
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
