using FerrariAwardGenerator.Service.PDFGenerator.Classes;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrariAwardGenerator.Service.PDFGenerator.Services
{
    public class FerrariAwardPDFGeneratorService
    {
        public FerrariAwardPDFGeneratorService()
        {

        }

        public void GenerateFerrariAwardPDF(List<ScoreResults> ScoreResults, JudgingInfo judgingInfo)
        {
            ScoreResults = ScoreResults.OrderByDescending(x => x.Score).ToList();
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(20);

                    //  page.Header()


                    page.Content().AlignCenter()
                        .Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            table.Cell().RowSpan(1).ColumnSpan(1).Element(HeaderBlock).Width(91).Height(181).Image("G:\\VS Projects\\FerrariAwardGenerator\\FerrariAwardGenerator\\Images\\Ferrari logo.png");
                            table.Cell().RowSpan(1).ColumnSpan(2).Element(HeaderBlock).AlignCenter().Text(text =>
                            {
                                text.Line("Concorso Ferrari " + DateTime.Now.Year.ToString()).SemiBold().FontSize(26).FontColor(Colors.Black).Underline();
                                text.Line("Awards Summary").SemiBold().FontSize(20).FontColor(Colors.Black);
                                text.Line(judgingInfo.ClassInfo).SemiBold().FontSize(20).FontColor(Colors.Black);
                            });


                            table.Cell().RowSpan(1).ColumnSpan(3).Element(Block).Text("CCJ:   " + judgingInfo.CCJ).SemiBold().FontSize(14).Underline();

                            table.Cell().RowSpan(1).ColumnSpan(3).Element(Block).Text("Class Judge:   " + judgingInfo.Judge1Name).SemiBold().FontSize(14).Underline();

                            table.Cell().RowSpan(1).ColumnSpan(3).Element(Block).Text("Class Judge:   " + judgingInfo.Judge2Name).SemiBold().FontSize(14).Underline();


                            foreach (var scoreResult in ScoreResults)
                            {

                                table.Cell().RowSpan(3).ColumnSpan(1).Element(InnerScoreBlock).EnsureSpace(5).AlignCenter().AlignMiddle().Text(scoreResult.CalculatedGrade + " / " + scoreResult.Score.ToString()).SemiBold().FontSize(20);

                                table.Cell().RowSpan(1).ColumnSpan(1).Element(InnerScoreBlock).EnsureSpace(5).AlignMiddle().AlignLeft().Text("Year / Model").SemiBold().FontSize(14);
                                table.Cell().RowSpan(1).ColumnSpan(1).Element(InnerScoreBlock).EnsureSpace(5).AlignMiddle().AlignCenter().Text(scoreResult.CarYear.ToString() + " | " + scoreResult.Model).SemiBold().FontSize(14);

                                table.Cell().RowSpan(1).ColumnSpan(1).Element(InnerScoreBlock).EnsureSpace(5).AlignMiddle().AlignLeft().Text("Owner").SemiBold().FontSize(14);
                                table.Cell().RowSpan(1).ColumnSpan(1).Element(InnerScoreBlock).EnsureSpace(5).AlignMiddle().AlignCenter().Text(scoreResult.OwnerName).SemiBold().FontSize(14);

                                table.Cell().RowSpan(1).ColumnSpan(1).Element(InnerScoreBlock).EnsureSpace(5).AlignMiddle().AlignLeft().Text("SN#").SemiBold().FontSize(14);
                                table.Cell().RowSpan(1).ColumnSpan(1).Element(InnerScoreBlock).EnsureSpace(5).AlignMiddle().AlignCenter().Text(scoreResult.SerialNumber.ToString()).SemiBold().FontSize(14);

                                table.Cell().RowSpan(1).ColumnSpan(3).Text("");
                            }

                            page.Footer()
                                .AlignCenter()
                                .Text(text =>
                                {
                                    text.CurrentPageNumber();
                                    text.Span(" / ");
                                    text.TotalPages();
                                });

                            static IContainer HeaderBlock(IContainer container)
                            {
                                return container
                                    .ShowOnce()
                                    .MinWidth(50)
                                    .MinHeight(50)
                                    .AlignCenter()
                                    .AlignMiddle()
                                    .PaddingTop(1);
                            }

                            static IContainer Block(IContainer container)
                            {
                                return container
                                    .ShowOnce()
                                    .MinWidth(50)
                                    //.Background(Colors.Black)
                                    .MinHeight(50);
                            }

                            static IContainer ScoreBlock(IContainer container)
                            {
                                return container
                                    .Border(1)
                                    .Background(Colors.Yellow.Accent4)
                                    .ShowOnce()
                                    .MinHeight(30);
                            }
                            static IContainer InnerScoreBlock(IContainer container)
                            {
                                return container
                                    .Border(1)
                                    .Background(Colors.Grey.Lighten3)
                                    .MinHeight(30)
                                    .EnsureSpace(5)
                                    .PaddingBottom(10)
                                    .PaddingTop(10);
                            }
                        });
                });

            })
                //.ShowInPreviewer();
                
                .GeneratePdf(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + judgingInfo.ClassInfo + ".pdf");
        }
    }
}
