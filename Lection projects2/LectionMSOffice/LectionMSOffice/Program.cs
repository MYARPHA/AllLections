using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;

Console.WriteLine("MS Office");

//ПОГАНЫЙ ВОРД КОТОРЫЙ СЛОМАЛСЯ
/* var wordApp = new Word.Application();
wordApp.Visible = true;

string templateTest = Path.Combine(Environment.CurrentDirectory, "Шаблоны", "Отчет.docx");
var document = wordApp.Documents.Add(templateTest);
string filenameTest = Path.Combine(Environment.CurrentDirectory, "Файлы", "2.pdf");
document.SaveAs(filenameTest, Word.WdSaveFormat.wdFormatPDF);

document.Close(false);
wordApp.Quit();

if (document != null)
    Marshal.ReleaseComObject(document);
if (wordApp != null)
    Marshal.ReleaseComObject(wordApp);
document = null;
wordApp = null;
GC.Collect();  */

// Инициализация екселя
var app = new Excel.Application();
app.Visible = true;

// Добавление листов
app.SheetsInNewWorkbook = 10;
var workbook = app.Workbooks.Add();

workbook.Worksheets.Add(); // 11
workbook.Worksheets.Add(After: workbook.Worksheets[3], Count: 2); // 13 12

var worksheet = workbook.Worksheets[1];
worksheet.Name = "12345";

// Диапазон
//Excel.Range range = worksheet.range[worksheet.Cells[2][5], worksheet.Cells[8][10]];  //1 способ
Excel.Range range = worksheet.range[worksheet.Cells[5, 2], worksheet.Cells[10, 8]];   // 2 способ
//range.Merge();

/* worksheet.Cells[1, 2] = "sfdasdhjghlshlgahsjhgajshdgasjdhg\naskjdfgajfgajdofhgoaijfgajfig\nasjdfajdgjasdjaisdgjirafga";
range.Value = 0; */

// Формулы
worksheet.Cells[2, 2] = "=MAX(B5:B10)";
range.Formula = "1";

// Настройка текста
/* range.Font.Bold = true;
range.Font.Italic = true;
range.Font.Underline = true;
range.Font.Size = 20;

range.Font.Color = ColorTranslator.ToOle(Color.Green);
range.Interior.Color = ColorTranslator.ToOle(Color.LightYellow);

range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
range.VerticalAlignment = Excel.XlVAlign.xlVAlignBottom; */

// Формат ячеек
range.NumberFormat = "0.00 $";

// Границы
/* range.Borders.LineStyle = Excel.XlLineStyle.xlSlantDashDot;

range.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle =
range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle =
Excel.XlLineStyle.xlContinuous; */

// Чето там с переводом число столбца в букву
/* int columnNumber = 5;
int codeA = (int)'A';
char columnName = (char)(codeA + columnNumber - 1);
Console.WriteLine(columnName); */

//Вставка строк и столбцов
/* range = worksheet.Cells[8, 1];
range.EntireRow.Insert();
range = worksheet.Cells[1, 8]; //Можно писать буквой [1, "B"];
range.EntireColumn.Insert(); */

//подбор размера под содержимое
worksheet.Columns.Autofit();
worksheet.Rows.Autofit();

//Удаление строк и столбцов
worksheet.Range["2:5"].Delete();
worksheet.Range["C:F"].Delete();

//string template = Path.Combine(Environment.CurrentDirectory, "Шаблоны", "Отчет.xlsx");
//var workbook = excelApp.Workbooks.Add(template);
/* string filename = Path.Combine(Environment.CurrentDirectory, "Файлы", "2.html");
workbook.SaveAs(filename, Excel.XlFileFormat.xlHtml);

workbook.Close(false);
excelApp.Quit();

if (workbook != null)
    Marshal.ReleaseComObject(workbook);
if (excelApp != null)
    Marshal.ReleaseComObject(excelApp);
workbook = null;
excelApp = null;
GC.Collect();

var processes = Process.GetProcessesByName("Excel");
foreach (var process in processes)
    process.Kill(); */