using System;

class Program
{
  static void Main(string[] args)
  {
    DocumentFactory factory;

    factory = new WordDocumentFactory();
    IDocument doc1 = factory.CreateDocument();
    doc1.Open();

    factory = new PdfDocumentFactory();
    IDocument doc2 = factory.CreateDocument();
    doc2.Open();

    factory = new ExcelDocumentFactory();
    IDocument doc3 = factory.CreateDocument();
    doc3.Open();
  }
}
