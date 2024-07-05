using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp;

namespace AutoRechner.Extra
{
    public class Address
    {
        public Address()
        {

        }

        public Address(string name, string zip, string town, string street)
        {
            Name = name;
            Zip = zip;
            Town = town;
            Street = street;
        }

        public string Name { get; set; }
        public string Zip { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
    }

    public class Invoice
    {
        public Invoice(SettingsManager settings)
        {
            this.settings = settings;
        }

        public void Create(Car car, bool tax, Address address, string note)
        {
            this.car = car;
            this.tax = tax;
            this.address = address;
            this.note = note;

            CreateDocument();
        }

        public bool ExportAsPDF(string filename)
        {
            if (created == false)
                return false;

            PdfDocumentRenderer pdr = new PdfDocumentRenderer
            {
                Document = document
            };
            pdr.RenderDocument();
            pdr.PdfDocument.Save(filename);

            return true;
        }


        private Document document;
        private TextFrame addressFrame;
        private Table table;
        private Car car;
        private bool tax = false;
        private Address address;
        private SettingsManager settings;
        private string note;

        private bool created = false;

        private void CreateDocument()
        {
            // Create a new MigraDoc document
            document = new Document();
            document.Info.Title = Properties.GUIStrings.LabelInvoice;
            document.Info.Subject = $"{car.Brand} {car.Model}";
            document.Info.Author = "AutoRechner";

            DefineStyles();

            CreatePage();

            FillContent();

            created = true;
        }

        private void DefineStyles()
        {
            // Get the predefined style Normal.
            Style style = document.Styles["Normal"];
            // Because all styles are derived from Normal, the next line changes the 
            // font of the whole document. Or, more exactly, it changes the font of
            // all styles and paragraphs that do not redefine the font.
            style.Font.Name = "Verdana";

            style = document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

            style = document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

            // Create a new style called Table based on style Normal
            style = document.Styles.AddStyle("Table", "Normal");
            style.Font.Name = "Verdana";
            style.Font.Name = "Times New Roman";
            style.Font.Size = 9;

            // Create a new style called Reference based on style Normal
            style = document.Styles.AddStyle("Reference", "Normal");
            style.ParagraphFormat.SpaceBefore = "5mm";
            style.ParagraphFormat.SpaceAfter = "5mm";
            style.ParagraphFormat.TabStops.AddTabStop("16cm", TabAlignment.Right);
        }

        private void CreatePage()
        {
            // Each MigraDoc document needs at least one section.
            Section section = document.AddSection();

            // Put a logo in the header
            //Image image = section.Headers.Primary.AddImage("../../PowerBooks.png");
            //image.Height = "2.5cm";
            //image.LockAspectRatio = true;
            //image.RelativeVertical = RelativeVertical.Line;
            //image.RelativeHorizontal = RelativeHorizontal.Margin;
            //image.Top = ShapePosition.Top;
            //image.Left = ShapePosition.Right;
            //image.WrapFormat.Style = WrapStyle.Through;

            // Create footer
            Paragraph paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddText($"{settings.SellerAddress.Name} · {settings.SellerAddress.Street} · {settings.SellerAddress.Zip} {settings.SellerAddress.Town}");
            paragraph.Format.Font.Size = 9;
            paragraph.Format.Alignment = ParagraphAlignment.Center;

            // Create the text frame for the address
            this.addressFrame = section.AddTextFrame();
            this.addressFrame.Height = "3.0cm";
            this.addressFrame.Width = "7.0cm";
            this.addressFrame.Left = ShapePosition.Left;
            this.addressFrame.RelativeHorizontal = RelativeHorizontal.Margin;
            this.addressFrame.Top = "5.0cm";
            this.addressFrame.RelativeVertical = RelativeVertical.Page;

            // Put sender in address frame
            paragraph = addressFrame.AddParagraph($"{settings.SellerAddress.Name} · {settings.SellerAddress.Street} · {settings.SellerAddress.Zip} {settings.SellerAddress.Town}");
            paragraph.Format.Font.Name = "Times New Roman";
            paragraph.Format.Font.Size = 7;
            paragraph.Format.SpaceAfter = 3;

            // Add the print date field
            paragraph = section.AddParagraph();
            paragraph.Format.SpaceBefore = "8cm";
            paragraph.Style = "Reference";
            paragraph.AddFormattedText(Properties.GUIStrings.LabelInvoice, TextFormat.Bold);
            paragraph.AddTab();
            paragraph.AddText($"{settings.SellerAddress.Town}, ");
            paragraph.AddDateField("dd.MM.yyyy");

            // Create the item table
            table = section.AddTable();
            table.Style = "Table";
            table.Borders.Color = Colors.Black;
            table.Borders.Width = 0.25;
            table.Borders.Left.Width = 0.5;
            table.Borders.Right.Width = 0.5;
            table.Rows.LeftIndent = 0;

            // Before you can add a row, you must define the columns
            Column column = table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = table.AddColumn("11cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("3cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            // Create the header of the table
            Row row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;
            row.Shading.Color = Colors.LightBlue;
            row.Cells[0].AddParagraph(Properties.GUIStrings.LabelID);
            row.Cells[0].Format.Font.Bold = false;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
            row.Cells[1].AddParagraph($"{car.Brand} {car.Model} ({car.Comment})");
            row.Cells[1].Format.Alignment = ParagraphAlignment.Left;

            row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;
            row.Shading.Color = Colors.LightBlue;
            row.Cells[1].AddParagraph(Properties.GUIStrings.LabelDescription);
            row.Cells[1].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[2].AddParagraph(Properties.GUIStrings.LabelPrice);
            row.Cells[2].Format.Alignment = ParagraphAlignment.Left;

           //  table.SetEdge(0, 0, 3, 2, Edge.Box, BorderStyle.Single, 0.75, Color.Empty);
        }

        private void FillContent()
        {

            Paragraph paragraph2 = addressFrame.AddParagraph();
            paragraph2.AddText(address.Name);
            paragraph2.AddLineBreak();
            paragraph2.AddText(address.Street);
            paragraph2.AddLineBreak();
            paragraph2.AddText(address.Zip + " " + address.Town);

            // Iterate the invoice items
            double totalPrice = 0;

            int itemNumber = 1;
            foreach(Item item in car.Costs)
            {
                double price = item.Price;

                // Each item fills two rows
                Row row1 = table.AddRow();
                row1.TopPadding = 1.5;
                row1.Cells[0].Shading.Color = Colors.Gray;
                row1.Cells[0].VerticalAlignment = VerticalAlignment.Center;
                row1.Cells[1].Format.Alignment = ParagraphAlignment.Left;

                row1.Cells[0].AddParagraph(itemNumber.ToString());
                row1.Cells[1].AddParagraph(item.Position);
                row1.Cells[2].AddParagraph(price.ToString("0.00") + " €");

                totalPrice += price;

                itemNumber++;
            }

            // Add an invisible row as a space line to the table
            Row row = table.AddRow();
            row.Borders.Visible = false;

            // Add the total price row
            row = table.AddRow();
            row.Cells[0].Borders.Visible = false;
            row.Cells[1].Borders.Visible = false;
            row.Cells[1].AddParagraph(Properties.GUIStrings.LabelSum);
            row.Cells[1].Format.Font.Bold = true;
            row.Cells[1].Format.Alignment = ParagraphAlignment.Right;
            // row.Cells[0].MergeRight = 4;
            row.Cells[2].AddParagraph(totalPrice.ToString("0.00") + " €");

            // Add the VAT row

            if (tax)
            { 
                row = table.AddRow();
                row.Cells[0].Borders.Visible = false;
                row.Cells[1].Borders.Visible = false;
                row.Cells[1].AddParagraph("MwSt (19%)");
                row.Cells[1].Format.Font.Bold = true;
                row.Cells[1].Format.Alignment = ParagraphAlignment.Right;
                // row.Cells[0].MergeRight = 4;
                row.Cells[2].AddParagraph((0.19 * totalPrice).ToString("0.00") + " €");

                totalPrice += 0.19 * totalPrice;
            }

            row = table.AddRow();
            row.Borders.Visible = false;

            row = table.AddRow();
            row.Cells[0].Borders.Visible = false;
            row.Cells[1].Borders.Visible = false;
            row.Cells[1].AddParagraph("Zu zahlen:");
            row.Cells[1].Format.Font.Bold = true;
            row.Cells[1].Format.Alignment = ParagraphAlignment.Right;
            
            row.Cells[2].AddParagraph(totalPrice.ToString("0.00") + " €");

            // Add the additional fee row
            //row = table.AddRow();
            //row.Cells[0].Borders.Visible = false;
            //row.Cells[0].AddParagraph("Shipping and Handling");
            //row.Cells[5].AddParagraph(0.ToString("0.00") + " €");
            //row.Cells[0].Format.Font.Bold = true;
            //row.Cells[0].Format.Alignment = ParagraphAlignment.Right;
            //row.Cells[0].MergeRight = 4;

            // Add the total due row
            //row = table.AddRow();
            //row.Cells[0].AddParagraph("Total Due");
            //row.Cells[0].Borders.Visible = false;
            //row.Cells[0].Format.Font.Bold = true;
            //row.Cells[0].Format.Alignment = ParagraphAlignment.Right;
            //row.Cells[0].MergeRight = 4;
            //totalExtendedPrice += 0.19 * totalExtendedPrice;
            //row.Cells[5].AddParagraph(totalExtendedPrice.ToString("0.00") + " €");

            // Set the borders of the specified cell range
            // table.SetEdge(5, thisable.Rows.Count - 1, 1, 3, Edge.Box, BorderStyle.Single, 0.75);

            // Add the notes paragraph
            Paragraph paragraph = document.LastSection.AddParagraph();
            paragraph.Format.SpaceBefore = "1cm";
            paragraph.Format.Borders.Width = 0.75;
            paragraph.Format.Borders.Distance = 3;
            paragraph.Format.Borders.Color = Colors.Black;
            paragraph.Format.Shading.Color = Colors.Gray;
            paragraph.AddText(note);
        }
    }
}
