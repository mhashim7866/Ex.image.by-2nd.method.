﻿internal class Program
{
    private static void Main(string[] args)
    {
        int[] xPos = { 45, 82, 43, 77, 41, 75, 40, 73, 35, 67, 35, 59, 30, 57, 25, 56, 23, 55, 23, 53, 23, 51, 23, 49, 49, 33, 33, 32, 31, 30, 30, 30, 80 };
        int[] yPos = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 20, 25 };
        string[] asciiChars = { "//,/", "-~ |", "// / |", "__--~  /  ,", "/'/ / /", " __~~ /", "( ( / /'", "_ -~    _-~ ,/'", ",,)))));,/~--", "__--~~__-| _-~  _/,",
         "___(((((((((((;,/~- ",
        " _--~~--~~  __--~~  --~~  --/,", "--/((((((''''(((((((((( >~  /", "  /         __--~~ /-~~ _-~ ",
        "--==//////((''  ,      ')))))), /", " /         --~~   __--~'  _-~ ~|", "         ))|  @     ;-.     (((,/",
         " /               __--~~'~~/", " ( '|      /   )     ))))))/", "))/          ~~~~__/__---~~__--~--_",
         "            |    _/   |", "  (/          ----~~__/__---~~__--~--_--           '",
         "            o_);      ;       /", "  /          ----~~/           /,-~~/   |         /|",
         "                    ;        (", "   (          ----~~/           ':::|   |;|        < >",

          "    '--------~~~~'     /          ':|     /;/------//",
           "_______/|/   -                        /             /      ~-------~",
            "/~;;.____/;;'    /          ____----(          ';;;/",
            "/ // _;________;'-------~~~~     |;;/              /",
             "// | |                           /  |          /;;,,",
             "(<_  | ;                         /',/-------'      _>",
             " (_| ||_                        //~;~~~~~~~~~~~~~~~",
              "      '(_|                     (,~~", "                                ~~/",
               "                                ~~-->", "             DESIGN BY HASHIM                   " };

        for (int i = 0; i < xPos.Length; i++)
        {
            Console.SetCursorPosition(xPos[i], yPos[i]);
            Console.WriteLine(asciiChars[i]);
        }
    }
}