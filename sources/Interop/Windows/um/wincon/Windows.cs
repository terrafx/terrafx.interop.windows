// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", EntryPoint = "AllocConsole", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AllocConsole();

        [DllImport("kernel32", EntryPoint = "FreeConsole", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FreeConsole();

        [DllImport("kernel32", EntryPoint = "AttachConsole", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AttachConsole([NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport("kernel32", EntryPoint = "GetConsoleCP", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetConsoleCP();

        [DllImport("kernel32", EntryPoint = "GetConsoleOutputCP", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetConsoleOutputCP();

        [DllImport("kernel32", EntryPoint = "GetConsoleMode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetConsoleMode([NativeTypeName("HANDLE")] IntPtr hConsoleHandle, [NativeTypeName("LPDWORD")] uint* lpMode);

        [DllImport("kernel32", EntryPoint = "SetConsoleMode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleMode([NativeTypeName("HANDLE")] IntPtr hConsoleHandle, [NativeTypeName("DWORD")] uint dwMode);

        [DllImport("kernel32", EntryPoint = "GetNumberOfConsoleInputEvents", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumberOfConsoleInputEvents([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("LPDWORD")] uint* lpNumberOfEvents);

        [DllImport("kernel32", EntryPoint = "ReadConsoleInputA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleInputA([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);

        [DllImport("kernel32", EntryPoint = "ReadConsoleInputW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleInputW([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);

        [DllImport("kernel32", EntryPoint = "PeekConsoleInputA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PeekConsoleInputA([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);

        [DllImport("kernel32", EntryPoint = "PeekConsoleInputW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PeekConsoleInputW([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);

        [DllImport("kernel32", EntryPoint = "ReadConsoleA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleA([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead, [NativeTypeName("PCONSOLE_READCONSOLE_CONTROL")] CONSOLE_READCONSOLE_CONTROL* pInputControl);

        [DllImport("kernel32", EntryPoint = "ReadConsoleW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleW([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead, [NativeTypeName("PCONSOLE_READCONSOLE_CONTROL")] CONSOLE_READCONSOLE_CONTROL* pInputControl);

        [DllImport("kernel32", EntryPoint = "WriteConsoleA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const void *")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten, [NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("kernel32", EntryPoint = "WriteConsoleW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const void *")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten, [NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("kernel32", EntryPoint = "SetConsoleCtrlHandler", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleCtrlHandler([NativeTypeName("PHANDLER_ROUTINE")] delegate* stdcall<uint, int> HandlerRoutine, [NativeTypeName("BOOL")] int Add);

        [DllImport("kernel32", EntryPoint = "CreatePseudoConsole", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreatePseudoConsole(COORD size, [NativeTypeName("HANDLE")] IntPtr hInput, [NativeTypeName("HANDLE")] IntPtr hOutput, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HPCON *")] void** phPC);

        [DllImport("kernel32", EntryPoint = "ResizePseudoConsole", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ResizePseudoConsole([NativeTypeName("HPCON")] void* hPC, COORD size);

        [DllImport("kernel32", EntryPoint = "ClosePseudoConsole", ExactSpelling = true)]
        public static extern void ClosePseudoConsole([NativeTypeName("HPCON")] void* hPC);

        [DllImport("kernel32", EntryPoint = "FillConsoleOutputCharacterA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillConsoleOutputCharacterA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("CHAR")] sbyte cCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten);

        [DllImport("kernel32", EntryPoint = "FillConsoleOutputCharacterW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillConsoleOutputCharacterW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("WCHAR")] ushort cCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten);

        [DllImport("kernel32", EntryPoint = "FillConsoleOutputAttribute", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillConsoleOutputAttribute([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("WORD")] ushort wAttribute, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfAttrsWritten);

        [DllImport("kernel32", EntryPoint = "GenerateConsoleCtrlEvent", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GenerateConsoleCtrlEvent([NativeTypeName("DWORD")] uint dwCtrlEvent, [NativeTypeName("DWORD")] uint dwProcessGroupId);

        [DllImport("kernel32", EntryPoint = "CreateConsoleScreenBuffer", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateConsoleScreenBuffer([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* lpScreenBufferData);

        [DllImport("kernel32", EntryPoint = "SetConsoleActiveScreenBuffer", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleActiveScreenBuffer([NativeTypeName("HANDLE")] IntPtr hConsoleOutput);

        [DllImport("kernel32", EntryPoint = "FlushConsoleInputBuffer", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlushConsoleInputBuffer([NativeTypeName("HANDLE")] IntPtr hConsoleInput);

        [DllImport("kernel32", EntryPoint = "SetConsoleCP", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleCP([NativeTypeName("UINT")] uint wCodePageID);

        [DllImport("kernel32", EntryPoint = "SetConsoleOutputCP", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleOutputCP([NativeTypeName("UINT")] uint wCodePageID);

        [DllImport("kernel32", EntryPoint = "GetConsoleCursorInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetConsoleCursorInfo([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCONSOLE_CURSOR_INFO")] CONSOLE_CURSOR_INFO* lpConsoleCursorInfo);

        [DllImport("kernel32", EntryPoint = "SetConsoleCursorInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleCursorInfo([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const CONSOLE_CURSOR_INFO *")] CONSOLE_CURSOR_INFO* lpConsoleCursorInfo);

        [DllImport("kernel32", EntryPoint = "GetConsoleScreenBufferInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetConsoleScreenBufferInfo([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCONSOLE_SCREEN_BUFFER_INFO")] CONSOLE_SCREEN_BUFFER_INFO* lpConsoleScreenBufferInfo);

        [DllImport("kernel32", EntryPoint = "GetConsoleScreenBufferInfoEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetConsoleScreenBufferInfoEx([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCONSOLE_SCREEN_BUFFER_INFOEX")] CONSOLE_SCREEN_BUFFER_INFOEX* lpConsoleScreenBufferInfoEx);

        [DllImport("kernel32", EntryPoint = "SetConsoleScreenBufferInfoEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleScreenBufferInfoEx([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCONSOLE_SCREEN_BUFFER_INFOEX")] CONSOLE_SCREEN_BUFFER_INFOEX* lpConsoleScreenBufferInfoEx);

        [DllImport("kernel32", EntryPoint = "SetConsoleScreenBufferSize", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleScreenBufferSize([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, COORD dwSize);

        [DllImport("kernel32", EntryPoint = "SetConsoleCursorPosition", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleCursorPosition([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, COORD dwCursorPosition);

        [DllImport("kernel32", EntryPoint = "GetLargestConsoleWindowSize", ExactSpelling = true)]
        public static extern COORD GetLargestConsoleWindowSize([NativeTypeName("HANDLE")] IntPtr hConsoleOutput);

        [DllImport("kernel32", EntryPoint = "SetConsoleTextAttribute", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleTextAttribute([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("WORD")] ushort wAttributes);

        [DllImport("kernel32", EntryPoint = "SetConsoleWindowInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleWindowInfo([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("BOOL")] int bAbsolute, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpConsoleWindow);

        [DllImport("kernel32", EntryPoint = "WriteConsoleOutputCharacterA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleOutputCharacterA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPCSTR")] sbyte* lpCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten);

        [DllImport("kernel32", EntryPoint = "WriteConsoleOutputCharacterW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleOutputCharacterW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPCWSTR")] ushort* lpCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten);

        [DllImport("kernel32", EntryPoint = "WriteConsoleOutputAttribute", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleOutputAttribute([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const WORD *")] ushort* lpAttribute, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfAttrsWritten);

        [DllImport("kernel32", EntryPoint = "ReadConsoleOutputCharacterA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleOutputCharacterA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPSTR")] sbyte* lpCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwReadCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead);

        [DllImport("kernel32", EntryPoint = "ReadConsoleOutputCharacterW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleOutputCharacterW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPWSTR")] ushort* lpCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwReadCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead);

        [DllImport("kernel32", EntryPoint = "ReadConsoleOutputAttribute", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleOutputAttribute([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPWORD")] ushort* lpAttribute, [NativeTypeName("DWORD")] uint nLength, COORD dwReadCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfAttrsRead);

        [DllImport("kernel32", EntryPoint = "WriteConsoleInputA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleInputA([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("const INPUT_RECORD *")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsWritten);

        [DllImport("kernel32", EntryPoint = "WriteConsoleInputW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleInputW([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("const INPUT_RECORD *")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsWritten);

        [DllImport("kernel32", EntryPoint = "ScrollConsoleScreenBufferA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScrollConsoleScreenBufferA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpScrollRectangle, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpClipRectangle, COORD dwDestinationOrigin, [NativeTypeName("const CHAR_INFO *")] CHAR_INFO* lpFill);

        [DllImport("kernel32", EntryPoint = "ScrollConsoleScreenBufferW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScrollConsoleScreenBufferW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpScrollRectangle, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpClipRectangle, COORD dwDestinationOrigin, [NativeTypeName("const CHAR_INFO *")] CHAR_INFO* lpFill);

        [DllImport("kernel32", EntryPoint = "WriteConsoleOutputA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleOutputA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const CHAR_INFO *")] CHAR_INFO* lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, [NativeTypeName("PSMALL_RECT")] SMALL_RECT* lpWriteRegion);

        [DllImport("kernel32", EntryPoint = "WriteConsoleOutputW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleOutputW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const CHAR_INFO *")] CHAR_INFO* lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, [NativeTypeName("PSMALL_RECT")] SMALL_RECT* lpWriteRegion);

        [DllImport("kernel32", EntryPoint = "ReadConsoleOutputA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleOutputA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCHAR_INFO")] CHAR_INFO* lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, [NativeTypeName("PSMALL_RECT")] SMALL_RECT* lpReadRegion);

        [DllImport("kernel32", EntryPoint = "ReadConsoleOutputW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleOutputW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCHAR_INFO")] CHAR_INFO* lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, [NativeTypeName("PSMALL_RECT")] SMALL_RECT* lpReadRegion);

        [DllImport("kernel32", EntryPoint = "GetConsoleTitleA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleTitleA([NativeTypeName("LPSTR")] sbyte* lpConsoleTitle, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "GetConsoleTitleW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleTitleW([NativeTypeName("LPWSTR")] ushort* lpConsoleTitle, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "GetConsoleOriginalTitleA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleOriginalTitleA([NativeTypeName("LPSTR")] sbyte* lpConsoleTitle, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "GetConsoleOriginalTitleW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleOriginalTitleW([NativeTypeName("LPWSTR")] ushort* lpConsoleTitle, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "SetConsoleTitleA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleTitleA([NativeTypeName("LPCSTR")] sbyte* lpConsoleTitle);

        [DllImport("kernel32", EntryPoint = "SetConsoleTitleW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleTitleW([NativeTypeName("LPCWSTR")] ushort* lpConsoleTitle);

        [DllImport("kernel32", EntryPoint = "GetNumberOfConsoleMouseButtons", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumberOfConsoleMouseButtons([NativeTypeName("LPDWORD")] uint* lpNumberOfMouseButtons);

        [DllImport("kernel32", EntryPoint = "GetConsoleFontSize", ExactSpelling = true)]
        public static extern COORD GetConsoleFontSize([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("DWORD")] uint nFont);

        [DllImport("kernel32", EntryPoint = "GetCurrentConsoleFont", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentConsoleFont([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("BOOL")] int bMaximumWindow, [NativeTypeName("PCONSOLE_FONT_INFO")] CONSOLE_FONT_INFO* lpConsoleCurrentFont);

        [DllImport("kernel32", EntryPoint = "GetCurrentConsoleFontEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentConsoleFontEx([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("BOOL")] int bMaximumWindow, [NativeTypeName("PCONSOLE_FONT_INFOEX")] CONSOLE_FONT_INFOEX* lpConsoleCurrentFontEx);

        [DllImport("kernel32", EntryPoint = "SetCurrentConsoleFontEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCurrentConsoleFontEx([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("BOOL")] int bMaximumWindow, [NativeTypeName("PCONSOLE_FONT_INFOEX")] CONSOLE_FONT_INFOEX* lpConsoleCurrentFontEx);

        [DllImport("kernel32", EntryPoint = "GetConsoleSelectionInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetConsoleSelectionInfo([NativeTypeName("PCONSOLE_SELECTION_INFO")] CONSOLE_SELECTION_INFO* lpConsoleSelectionInfo);

        [DllImport("kernel32", EntryPoint = "GetConsoleHistoryInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetConsoleHistoryInfo([NativeTypeName("PCONSOLE_HISTORY_INFO")] CONSOLE_HISTORY_INFO* lpConsoleHistoryInfo);

        [DllImport("kernel32", EntryPoint = "SetConsoleHistoryInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleHistoryInfo([NativeTypeName("PCONSOLE_HISTORY_INFO")] CONSOLE_HISTORY_INFO* lpConsoleHistoryInfo);

        [DllImport("kernel32", EntryPoint = "GetConsoleDisplayMode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetConsoleDisplayMode([NativeTypeName("LPDWORD")] uint* lpModeFlags);

        [DllImport("kernel32", EntryPoint = "SetConsoleDisplayMode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleDisplayMode([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCOORD")] COORD* lpNewScreenBufferDimensions);

        [DllImport("kernel32", EntryPoint = "GetConsoleWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("kernel32", EntryPoint = "AddConsoleAliasA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddConsoleAliasA([NativeTypeName("LPSTR")] sbyte* Source, [NativeTypeName("LPSTR")] sbyte* Target, [NativeTypeName("LPSTR")] sbyte* ExeName);

        [DllImport("kernel32", EntryPoint = "AddConsoleAliasW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddConsoleAliasW([NativeTypeName("LPWSTR")] ushort* Source, [NativeTypeName("LPWSTR")] ushort* Target, [NativeTypeName("LPWSTR")] ushort* ExeName);

        [DllImport("kernel32", EntryPoint = "GetConsoleAliasA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleAliasA([NativeTypeName("LPSTR")] sbyte* Source, [NativeTypeName("LPSTR")] sbyte* TargetBuffer, [NativeTypeName("DWORD")] uint TargetBufferLength, [NativeTypeName("LPSTR")] sbyte* ExeName);

        [DllImport("kernel32", EntryPoint = "GetConsoleAliasW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleAliasW([NativeTypeName("LPWSTR")] ushort* Source, [NativeTypeName("LPWSTR")] ushort* TargetBuffer, [NativeTypeName("DWORD")] uint TargetBufferLength, [NativeTypeName("LPWSTR")] ushort* ExeName);

        [DllImport("kernel32", EntryPoint = "GetConsoleAliasesLengthA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleAliasesLengthA([NativeTypeName("LPSTR")] sbyte* ExeName);

        [DllImport("kernel32", EntryPoint = "GetConsoleAliasesLengthW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleAliasesLengthW([NativeTypeName("LPWSTR")] ushort* ExeName);

        [DllImport("kernel32", EntryPoint = "GetConsoleAliasExesLengthA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleAliasExesLengthA();

        [DllImport("kernel32", EntryPoint = "GetConsoleAliasExesLengthW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleAliasExesLengthW();

        [DllImport("kernel32", EntryPoint = "GetConsoleAliasesA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleAliasesA([NativeTypeName("LPSTR")] sbyte* AliasBuffer, [NativeTypeName("DWORD")] uint AliasBufferLength, [NativeTypeName("LPSTR")] sbyte* ExeName);

        [DllImport("kernel32", EntryPoint = "GetConsoleAliasesW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleAliasesW([NativeTypeName("LPWSTR")] ushort* AliasBuffer, [NativeTypeName("DWORD")] uint AliasBufferLength, [NativeTypeName("LPWSTR")] ushort* ExeName);

        [DllImport("kernel32", EntryPoint = "GetConsoleAliasExesA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleAliasExesA([NativeTypeName("LPSTR")] sbyte* ExeNameBuffer, [NativeTypeName("DWORD")] uint ExeNameBufferLength);

        [DllImport("kernel32", EntryPoint = "GetConsoleAliasExesW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleAliasExesW([NativeTypeName("LPWSTR")] ushort* ExeNameBuffer, [NativeTypeName("DWORD")] uint ExeNameBufferLength);

        [DllImport("kernel32", EntryPoint = "ExpungeConsoleCommandHistoryA", ExactSpelling = true)]
        public static extern void ExpungeConsoleCommandHistoryA([NativeTypeName("LPSTR")] sbyte* ExeName);

        [DllImport("kernel32", EntryPoint = "ExpungeConsoleCommandHistoryW", ExactSpelling = true)]
        public static extern void ExpungeConsoleCommandHistoryW([NativeTypeName("LPWSTR")] ushort* ExeName);

        [DllImport("kernel32", EntryPoint = "SetConsoleNumberOfCommandsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleNumberOfCommandsA([NativeTypeName("DWORD")] uint Number, [NativeTypeName("LPSTR")] sbyte* ExeName);

        [DllImport("kernel32", EntryPoint = "SetConsoleNumberOfCommandsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleNumberOfCommandsW([NativeTypeName("DWORD")] uint Number, [NativeTypeName("LPWSTR")] ushort* ExeName);

        [DllImport("kernel32", EntryPoint = "GetConsoleCommandHistoryLengthA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleCommandHistoryLengthA([NativeTypeName("LPSTR")] sbyte* ExeName);

        [DllImport("kernel32", EntryPoint = "GetConsoleCommandHistoryLengthW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleCommandHistoryLengthW([NativeTypeName("LPWSTR")] ushort* ExeName);

        [DllImport("kernel32", EntryPoint = "GetConsoleCommandHistoryA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleCommandHistoryA([NativeTypeName("LPSTR")] sbyte* Commands, [NativeTypeName("DWORD")] uint CommandBufferLength, [NativeTypeName("LPSTR")] sbyte* ExeName);

        [DllImport("kernel32", EntryPoint = "GetConsoleCommandHistoryW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleCommandHistoryW([NativeTypeName("LPWSTR")] ushort* Commands, [NativeTypeName("DWORD")] uint CommandBufferLength, [NativeTypeName("LPWSTR")] ushort* ExeName);

        [DllImport("kernel32", EntryPoint = "GetConsoleProcessList", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleProcessList([NativeTypeName("LPDWORD")] uint* lpdwProcessList, [NativeTypeName("DWORD")] uint dwProcessCount);
    }
}
