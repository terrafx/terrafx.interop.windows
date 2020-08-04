// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", EntryPoint = "AllocConsole", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AllocConsole();

        [DllImport("kernel32", EntryPoint = "FreeConsole", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FreeConsole();

        [DllImport("kernel32", EntryPoint = "AttachConsole", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AttachConsole([NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport("kernel32", EntryPoint = "GetConsoleCP", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetConsoleCP();

        [DllImport("kernel32", EntryPoint = "GetConsoleOutputCP", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetConsoleOutputCP();

        [DllImport("kernel32", EntryPoint = "GetConsoleMode", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetConsoleMode([NativeTypeName("HANDLE")] IntPtr hConsoleHandle, [NativeTypeName("LPDWORD")] uint* lpMode);

        [DllImport("kernel32", EntryPoint = "SetConsoleMode", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleMode([NativeTypeName("HANDLE")] IntPtr hConsoleHandle, [NativeTypeName("DWORD")] uint dwMode);

        [DllImport("kernel32", EntryPoint = "GetNumberOfConsoleInputEvents", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumberOfConsoleInputEvents([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("LPDWORD")] uint* lpNumberOfEvents);

        [DllImport("kernel32", EntryPoint = "ReadConsoleInputA", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleInputA([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);

        [DllImport("kernel32", EntryPoint = "ReadConsoleInputW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleInputW([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);

        [DllImport("kernel32", EntryPoint = "PeekConsoleInputA", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PeekConsoleInputA([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);

        [DllImport("kernel32", EntryPoint = "PeekConsoleInputW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PeekConsoleInputW([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);

        [DllImport("kernel32", EntryPoint = "ReadConsoleA", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleA([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead, [NativeTypeName("PCONSOLE_READCONSOLE_CONTROL")] CONSOLE_READCONSOLE_CONTROL* pInputControl);

        [DllImport("kernel32", EntryPoint = "ReadConsoleW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleW([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead, [NativeTypeName("PCONSOLE_READCONSOLE_CONTROL")] CONSOLE_READCONSOLE_CONTROL* pInputControl);

        [DllImport("kernel32", EntryPoint = "WriteConsoleA", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const void *")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten, [NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("kernel32", EntryPoint = "WriteConsoleW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const void *")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten, [NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("kernel32", EntryPoint = "SetConsoleCtrlHandler", ExactSpelling = true, SetLastError = true)]
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

        [NativeTypeName("#define ATTACH_PARENT_PROCESS ((DWORD)-1)")]
        public const uint ATTACH_PARENT_PROCESS = unchecked((uint)(-1));

        [NativeTypeName("#define ENABLE_PROCESSED_INPUT 0x0001")]
        public const int ENABLE_PROCESSED_INPUT = 0x0001;

        [NativeTypeName("#define ENABLE_LINE_INPUT 0x0002")]
        public const int ENABLE_LINE_INPUT = 0x0002;

        [NativeTypeName("#define ENABLE_ECHO_INPUT 0x0004")]
        public const int ENABLE_ECHO_INPUT = 0x0004;

        [NativeTypeName("#define ENABLE_WINDOW_INPUT 0x0008")]
        public const int ENABLE_WINDOW_INPUT = 0x0008;

        [NativeTypeName("#define ENABLE_MOUSE_INPUT 0x0010")]
        public const int ENABLE_MOUSE_INPUT = 0x0010;

        [NativeTypeName("#define ENABLE_INSERT_MODE 0x0020")]
        public const int ENABLE_INSERT_MODE = 0x0020;

        [NativeTypeName("#define ENABLE_QUICK_EDIT_MODE 0x0040")]
        public const int ENABLE_QUICK_EDIT_MODE = 0x0040;

        [NativeTypeName("#define ENABLE_EXTENDED_FLAGS 0x0080")]
        public const int ENABLE_EXTENDED_FLAGS = 0x0080;

        [NativeTypeName("#define ENABLE_AUTO_POSITION 0x0100")]
        public const int ENABLE_AUTO_POSITION = 0x0100;

        [NativeTypeName("#define ENABLE_VIRTUAL_TERMINAL_INPUT 0x0200")]
        public const int ENABLE_VIRTUAL_TERMINAL_INPUT = 0x0200;

        [NativeTypeName("#define ENABLE_PROCESSED_OUTPUT 0x0001")]
        public const int ENABLE_PROCESSED_OUTPUT = 0x0001;

        [NativeTypeName("#define ENABLE_WRAP_AT_EOL_OUTPUT 0x0002")]
        public const int ENABLE_WRAP_AT_EOL_OUTPUT = 0x0002;

        [NativeTypeName("#define ENABLE_VIRTUAL_TERMINAL_PROCESSING 0x0004")]
        public const int ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;

        [NativeTypeName("#define DISABLE_NEWLINE_AUTO_RETURN 0x0008")]
        public const int DISABLE_NEWLINE_AUTO_RETURN = 0x0008;

        [NativeTypeName("#define ENABLE_LVB_GRID_WORLDWIDE 0x0010")]
        public const int ENABLE_LVB_GRID_WORLDWIDE = 0x0010;

        [NativeTypeName("#define ReadConsoleInput ReadConsoleInputW")]
        public static readonly delegate*<IntPtr, INPUT_RECORD*, uint, uint*, int> ReadConsoleInput = &ReadConsoleInputW;

        [NativeTypeName("#define PeekConsoleInput PeekConsoleInputW")]
        public static readonly delegate*<IntPtr, INPUT_RECORD*, uint, uint*, int> PeekConsoleInput = &PeekConsoleInputW;

        [NativeTypeName("#define ReadConsole ReadConsoleW")]
        public static readonly delegate*<IntPtr, void*, uint, uint*, CONSOLE_READCONSOLE_CONTROL*, int> ReadConsole = &ReadConsoleW;

        [NativeTypeName("#define WriteConsole WriteConsoleW")]
        public static readonly delegate*<IntPtr, void*, uint, uint*, void*, int> WriteConsole = &WriteConsoleW;

        [NativeTypeName("#define CTRL_C_EVENT 0")]
        public const int CTRL_C_EVENT = 0;

        [NativeTypeName("#define CTRL_BREAK_EVENT 1")]
        public const int CTRL_BREAK_EVENT = 1;

        [NativeTypeName("#define CTRL_CLOSE_EVENT 2")]
        public const int CTRL_CLOSE_EVENT = 2;

        [NativeTypeName("#define CTRL_LOGOFF_EVENT 5")]
        public const int CTRL_LOGOFF_EVENT = 5;

        [NativeTypeName("#define CTRL_SHUTDOWN_EVENT 6")]
        public const int CTRL_SHUTDOWN_EVENT = 6;

        [NativeTypeName("#define PSEUDOCONSOLE_INHERIT_CURSOR (0x1)")]
        public const int PSEUDOCONSOLE_INHERIT_CURSOR = (0x1);
    }
}
