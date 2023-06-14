using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScintillaNET;
using System.Drawing;
using System.Windows.Forms;

namespace ConvertGPT.Global.Component
{
    internal class CodeTextBox
    {
        public static void customizeSyntaxHighlighting(string selectLanguage, ScintillaNET.Scintilla TextBox)
        {
            switch (selectLanguage)
            {
                case "Cpp":
                case "C++":
                    CodeTextBox.customizeSyntaxHighlighting_Cpp(TextBox);
                    break;
                case "C#":
                case "CSharp":
                    CodeTextBox.customizeSyntaxHighlighting_CSharp(TextBox);
                    break;
                case "Java":
                    CodeTextBox.customizeSyntaxHighlighting_Java(TextBox);
                    break;
                case "Javascript":
                case "JavaScript":
                    CodeTextBox.customizeSyntaxHighlighting_JS(TextBox);
                    break;
                case "Swift":
                    CodeTextBox.customizeSyntaxHighlighting_Swift(TextBox);
                    break;
                case "Python":
                    CodeTextBox.customizeSyntaxHighlighting_Python(TextBox);
                    break;
                default:
                    MessageBox.Show(selectLanguage +"언어는 CodeTextBox 에서 지원하지 않은 언어입니다.");
                    break;
            }
        }

        private static void customizeSyntaxHighlighting_Cpp(ScintillaNET.Scintilla TextBox)
        {
            // Cpp syntax highlighting customization code
            TextBox.StyleResetDefault();
            TextBox.Styles[ScintillaNET.Style.Default].Font = "Consolas";
            TextBox.Styles[ScintillaNET.Style.Default].Size = 12;
            
            TextBox.StyleClearAll();

            // Cpp Lexer Style 설정
            TextBox.Styles[ScintillaNET.Style.Cpp.Default].ForeColor = Color.Silver;
            TextBox.Styles[ScintillaNET.Style.Cpp.Comment].ForeColor = Color.FromArgb(0, 128, 0);
            TextBox.Styles[ScintillaNET.Style.Cpp.CommentLine].ForeColor = Color.FromArgb(0, 128, 0);
            TextBox.Styles[ScintillaNET.Style.Cpp.CommentLineDoc].ForeColor = Color.FromArgb(128, 128, 128);
            TextBox.Styles[ScintillaNET.Style.Cpp.Number].ForeColor = Color.Olive;
            TextBox.Styles[ScintillaNET.Style.Cpp.Word].ForeColor = Color.Blue;
            TextBox.Styles[ScintillaNET.Style.Cpp.Word2].ForeColor = Color.OrangeRed;
            TextBox.Styles[ScintillaNET.Style.Cpp.String].ForeColor = Color.FromArgb(163, 21, 21);
            TextBox.Styles[ScintillaNET.Style.Cpp.Character].ForeColor = Color.FromArgb(163, 21, 21);
            TextBox.Styles[ScintillaNET.Style.Cpp.Verbatim].ForeColor = Color.FromArgb(163, 21, 21);
            TextBox.Styles[ScintillaNET.Style.Cpp.StringEol].BackColor = Color.Pink;
            TextBox.Styles[ScintillaNET.Style.Cpp.Operator].ForeColor = Color.Purple;
            TextBox.Styles[ScintillaNET.Style.Cpp.Preprocessor].ForeColor = Color.Maroon;
            TextBox.Lexer = Lexer.Cpp;

            // Cpp keywords 설정
            TextBox.SetKeywords(0, "abstract asm auto bool break case catch char class const const_cast continue default delete do double dynamic_cast else enum explicit export extern false float for friend goto if inline int long mutable namespace new noexcept not not_eq nullptr operator or or_eq private protected public register reinterpret_cast return short signed sizeof static static_assert static_cast struct switch template this throw true try typedef typeid typename union unsigned using virtual void volatile wchar_t while xor xor_eq");
            TextBox.SetKeywords(1, "alignas alignof and and_eq bitand bitor char16_t char32_t compl constexpr decltype nullptr or_eq xor_eq");
        }

        private static void customizeSyntaxHighlighting_Swift(ScintillaNET.Scintilla TextBox)
        {
            // Swift syntax highlighting customization code
            TextBox.StyleResetDefault();
            TextBox.Styles[ScintillaNET.Style.Default].Font = "Consolas";
            TextBox.Styles[ScintillaNET.Style.Default].Size = 10;
            TextBox.StyleClearAll();

            // Swift Lexer Style 설정
            TextBox.Styles[ScintillaNET.Style.Cpp.Default].ForeColor = Color.Silver;
            TextBox.Styles[ScintillaNET.Style.Cpp.Comment].ForeColor = Color.FromArgb(0, 128, 0);
            TextBox.Styles[ScintillaNET.Style.Cpp.CommentLine].ForeColor = Color.FromArgb(0, 128, 0);
            TextBox.Styles[ScintillaNET.Style.Cpp.CommentLineDoc].ForeColor = Color.FromArgb(128, 128, 128);
            TextBox.Styles[ScintillaNET.Style.Cpp.Number].ForeColor = Color.Olive;
            TextBox.Styles[ScintillaNET.Style.Cpp.Word].ForeColor = Color.Blue;
            TextBox.Styles[ScintillaNET.Style.Cpp.Word2].ForeColor = Color.OrangeRed;
            TextBox.Styles[ScintillaNET.Style.Cpp.String].ForeColor = Color.FromArgb(163, 21, 21);
            TextBox.Styles[ScintillaNET.Style.Cpp.Character].ForeColor = Color.FromArgb(163, 21, 21);
            TextBox.Styles[ScintillaNET.Style.Cpp.Verbatim].ForeColor = Color.FromArgb(163, 21, 21);
            TextBox.Styles[ScintillaNET.Style.Cpp.StringEol].BackColor = Color.Pink;
            TextBox.Styles[ScintillaNET.Style.Cpp.Operator].ForeColor = Color.Purple;
            TextBox.Styles[ScintillaNET.Style.Cpp.Preprocessor].ForeColor = Color.Maroon;
            TextBox.Lexer = Lexer.Cpp;

            // Swift keywords 설정
            TextBox.SetKeywords(0, "as associatedtype break case catch class continue default defer deinit do else enum extension fallthrough false fileprivate for func guard if import in inout internal is let nil open operator private protocol public repeat rethrows return self static struct subscript super switch throw throws true try typealias var where while");
            TextBox.SetKeywords(1, "Any AnyObject AnyClass AnyHashable @autoclosure @available @discardableResult @escaping @objc @objcMembers @discardableResult @convention @convention @nonobjc @noescape @noreturn @NSCopying @NSManaged @NSApplicationMain @UIApplicationMain @IBOutlet @IBAction @inlinable @escaping @nonmutating @dynamicCallable @dynamicMemberLookup @propertyWrapper");

        }


        private static void customizeSyntaxHighlighting_CSharp(ScintillaNET.Scintilla TextBox)
        {
            // C# syntax highlighting customization code
            TextBox.StyleResetDefault();
            TextBox.Styles[ScintillaNET.Style.Default].Font = "Consolas";
            TextBox.Styles[ScintillaNET.Style.Default].Size = 12;
            TextBox.StyleClearAll();

            // C# Lexer Style 설정
            TextBox.Styles[ScintillaNET.Style.Cpp.Default].ForeColor = Color.Silver;
            TextBox.Styles[ScintillaNET.Style.Cpp.Comment].ForeColor = Color.FromArgb(0, 128, 0);
            TextBox.Styles[ScintillaNET.Style.Cpp.CommentLine].ForeColor = Color.FromArgb(0, 128, 0);
            TextBox.Styles[ScintillaNET.Style.Cpp.CommentLineDoc].ForeColor = Color.FromArgb(128, 128, 128);
            TextBox.Styles[ScintillaNET.Style.Cpp.Number].ForeColor = Color.Olive;
            TextBox.Styles[ScintillaNET.Style.Cpp.Word].ForeColor = Color.Blue;
            TextBox.Styles[ScintillaNET.Style.Cpp.Word2].ForeColor = Color.OrangeRed;
            TextBox.Styles[ScintillaNET.Style.Cpp.String].ForeColor = Color.FromArgb(163, 21, 21);
            TextBox.Styles[ScintillaNET.Style.Cpp.Character].ForeColor = Color.FromArgb(163, 21, 21);
            TextBox.Styles[ScintillaNET.Style.Cpp.Verbatim].ForeColor = Color.FromArgb(163, 21, 21);
            TextBox.Styles[ScintillaNET.Style.Cpp.StringEol].BackColor = Color.Pink;
            TextBox.Styles[ScintillaNET.Style.Cpp.Operator].ForeColor = Color.Purple;
            TextBox.Styles[ScintillaNET.Style.Cpp.Preprocessor].ForeColor = Color.Maroon;
            TextBox.Lexer = Lexer.Cpp;

            // C# keywords 설정
            TextBox.SetKeywords(0, "abstract as base break case catch checked continue default delegate do else event explicit extern false finally fixed for foreach goto if implicit in interface internal is lock namespace new null object operator out override params private protected public readonly ref return sealed sizeof stackalloc switch this throw true try typeof unchecked unsafe using virtual while get set");
            TextBox.SetKeywords(1, "bool byte char class const decimal double enum float int long sbyte short static string struct uint ulong ushort void");
        }

        public static void customizeSyntaxHighlighting_Java(ScintillaNET.Scintilla TextBox)
        {
            // Java syntax highlighting customization code
            TextBox.StyleResetDefault();
            TextBox.Styles[ScintillaNET.Style.Default].Font = "Consolas";
            TextBox.Styles[ScintillaNET.Style.Default].Size = 12;
            TextBox.StyleClearAll();

            // Java Lexer Style 설정
            TextBox.Styles[ScintillaNET.Style.Cpp.Default].ForeColor = Color.FromArgb(64, 64, 64);  // 전체 기본 색상
            TextBox.Styles[ScintillaNET.Style.Cpp.Comment].ForeColor = Color.DarkGreen;  // 주석 색상
            TextBox.Styles[ScintillaNET.Style.Cpp.CommentLine].ForeColor = Color.Green;  // 한 줄 주석 색상
            TextBox.Styles[ScintillaNET.Style.Cpp.CommentLineDoc].ForeColor = Color.Gray;  // 문서 주석 색상
            TextBox.Styles[ScintillaNET.Style.Cpp.Number].ForeColor = Color.DarkOliveGreen;  // 숫자 색상
            TextBox.Styles[ScintillaNET.Style.Cpp.Word].ForeColor = Color.DarkBlue;  // 키워드 색상
            TextBox.Styles[ScintillaNET.Style.Cpp.Word2].ForeColor = Color.DarkRed;  // 키워드2 색상
            TextBox.Styles[ScintillaNET.Style.Cpp.String].ForeColor = Color.FromArgb(128, 0, 0);  // 문자열 색상
            TextBox.Styles[ScintillaNET.Style.Cpp.Character].ForeColor = Color.FromArgb(128, 0, 0);  // 문자 색상
            TextBox.Styles[ScintillaNET.Style.Cpp.Verbatim].ForeColor = Color.FromArgb(128, 0, 0);  // 리터럴 문자열 색상
            TextBox.Styles[ScintillaNET.Style.Cpp.StringEol].BackColor = Color.LightPink;  // 문자열 끝 색상
            TextBox.Styles[ScintillaNET.Style.Cpp.Operator].ForeColor = Color.Purple;  // 연산자 색상
            TextBox.Styles[ScintillaNET.Style.Cpp.Preprocessor].ForeColor = Color.Maroon;  // 전처리기 지시문 색상
            TextBox.Lexer = Lexer.Cpp;

            // Java 키워드 설정
            TextBox.SetKeywords(0, "abstract assert break case catch class const continue default do else enum extends final finally for if implements import instanceof interface native new null package private protected public return static strictfp super switch synchronized this throw throws transient true try void volatile while void");
            TextBox.SetKeywords(1, "boolean byte char double float int long short");
        }

        public static void customizeSyntaxHighlighting_JS(ScintillaNET.Scintilla TextBox)
        {
            // JavaScript syntax highlighting customization code
            TextBox.StyleResetDefault();
            TextBox.Styles[ScintillaNET.Style.Default].Font = "Consolas";
            TextBox.Styles[ScintillaNET.Style.Default].Size = 12;
            TextBox.StyleClearAll();

            // Lexer Style 설정
            TextBox.Styles[ScintillaNET.Style.Default].ForeColor = Color.Black;
            TextBox.Styles[ScintillaNET.Style.Default].BackColor = Color.White;
            TextBox.Styles[ScintillaNET.Style.Cpp.Default].ForeColor = Color.Black;
            TextBox.Styles[ScintillaNET.Style.Cpp.Default].BackColor = Color.White;
            TextBox.Styles[ScintillaNET.Style.Cpp.Comment].ForeColor = Color.Green;
            TextBox.Styles[ScintillaNET.Style.Cpp.CommentLine].ForeColor = Color.Green;
            TextBox.Styles[ScintillaNET.Style.Cpp.CommentLineDoc].ForeColor = Color.Gray;
            TextBox.Styles[ScintillaNET.Style.Cpp.Number].ForeColor = Color.DarkOliveGreen;
            TextBox.Styles[ScintillaNET.Style.Cpp.Word].ForeColor = Color.DarkBlue;
            TextBox.Styles[ScintillaNET.Style.Cpp.Word2].ForeColor = Color.DodgerBlue;
            TextBox.Styles[ScintillaNET.Style.Cpp.String].ForeColor = Color.DarkRed;
            TextBox.Styles[ScintillaNET.Style.Cpp.Character].ForeColor = Color.DarkRed;
            TextBox.Styles[ScintillaNET.Style.Cpp.Verbatim].ForeColor = Color.DarkRed;
            TextBox.Styles[ScintillaNET.Style.Cpp.StringEol].BackColor = Color.LightPink;
            TextBox.Styles[ScintillaNET.Style.Cpp.Operator].ForeColor = Color.Purple;
            TextBox.Styles[ScintillaNET.Style.Cpp.Preprocessor].ForeColor = Color.Maroon;
            TextBox.Lexer = Lexer.Cpp;


            // JS keywords 설정
            TextBox.SetKeywords(0, "enum implements interface let package private protected public static yield await break case catch class const continue debugger default delete do else export extends false finally for function if import in instanceof new null return super switch this throw true try typeof var void while with");
            TextBox.SetKeywords(1, "int");
        }

        public static void customizeSyntaxHighlighting_Python(ScintillaNET.Scintilla TextBox)
        {
            // Python syntax highlighting customization code
            TextBox.StyleResetDefault();
            TextBox.Styles[ScintillaNET.Style.Default].Font = "Consolas";
            TextBox.Styles[ScintillaNET.Style.Default].Size = 12;
            TextBox.StyleClearAll();

            // Set the styles
            TextBox.Styles[ScintillaNET.Style.Python.Default].ForeColor = Color.FromArgb(0x80, 0x80, 0x80); // 기본 스타일의 전경색 설정
            TextBox.Styles[ScintillaNET.Style.Python.CommentLine].ForeColor = Color.FromArgb(0x00, 0x7F, 0x00); // 한 줄 주석 스타일의 전경색 설정
            TextBox.Styles[ScintillaNET.Style.Python.CommentLine].Italic = true; // 한 줄 주석 스타일을 이탤릭체로 설정
            TextBox.Styles[ScintillaNET.Style.Python.Number].ForeColor = Color.Olive;
            TextBox.Styles[ScintillaNET.Style.Python.Word].ForeColor = Color.FromArgb(0x00, 0x00, 0x7F); // 키워드 스타일의 전경색 설정
            TextBox.Styles[ScintillaNET.Style.Python.Word].Bold = true; // 키워드 스타일을 굵게 설정
            TextBox.Styles[ScintillaNET.Style.Python.Word2].ForeColor = Color.Green;
            TextBox.Styles[ScintillaNET.Style.Python.String].ForeColor = Color.FromArgb(163, 21, 21);
            TextBox.Styles[ScintillaNET.Style.Python.Character].ForeColor = Color.FromArgb(163, 21, 21);
            TextBox.Styles[ScintillaNET.Style.Python.StringEol].ForeColor = Color.FromArgb(0x00, 0x00, 0x00);
            TextBox.Styles[ScintillaNET.Style.Python.StringEol].BackColor = Color.FromArgb(0xE0, 0xC0, 0xE0);
            TextBox.Styles[ScintillaNET.Style.Python.Operator].ForeColor = Color.Purple;
            TextBox.Styles[ScintillaNET.Style.Python.Operator].Bold = true;
            TextBox.Styles[ScintillaNET.Style.Python.Triple].ForeColor = Color.FromArgb(0x7F, 0x00, 0x00); // 삼중 따옴표 문자열 스타일의 전경색 설정
            TextBox.Styles[ScintillaNET.Style.Python.TripleDouble].ForeColor = Color.FromArgb(0x7F, 0x00, 0x00); // 쌍삼중 따옴표 문자열 스타일의 전경색 설정
            TextBox.Styles[ScintillaNET.Style.Python.ClassName].ForeColor = Color.FromArgb(0x00, 0x00, 0xFF); // 클래스 이름 스타일의 전경색 설정
            TextBox.Styles[ScintillaNET.Style.Python.ClassName].Bold = true; // 클래스 이름 스타일을 굵게 설정
            TextBox.Styles[ScintillaNET.Style.Python.DefName].ForeColor = Color.FromArgb(0x00, 0x7F, 0x7F);  // 함수 정의 스타일의 전경색 설정
            TextBox.Styles[ScintillaNET.Style.Python.DefName].Bold = true; // 함수 정의 스타일을 굵게 설정
            TextBox.Styles[ScintillaNET.Style.Python.CommentBlock].ForeColor = Color.FromArgb(0x7F, 0x7F, 0x7F); // 블록 주석 스타일의 전경색 설정
            TextBox.Styles[ScintillaNET.Style.Python.CommentBlock].Italic = true; // 블록 주석 스타일을 이탤릭체로 설정

            // Python Lexer Style 설정
            TextBox.Lexer = Lexer.Python;

            // Python keywords 설정
            TextBox.SetKeywords(0, "and as assert break class continue def del elif else except exec finally for from global if import in is lambda not or pass print raise return try while with yield" +
                "False None True and as assert break class continue def del elif else except finally for from global if import in is lambda nonlocal not or pass raise return try while with yield" +
                "cdef cimport cpdef" +
                "");
            TextBox.SetKeywords(1, "bool byte char class const decimal double enum float int long sbyte short static string struct uint ulong ushort void" +
                "append extend insert pop remove count index sort reverse copy abs all any bin bool chr divmod float hex int len max min oct ord pow range round sorted str type keys" +
                "");

            // Important for Python
            TextBox.ViewWhitespace = WhitespaceMode.VisibleAlways; // 공백 문자 항상 표시하기
        }
    }
}
