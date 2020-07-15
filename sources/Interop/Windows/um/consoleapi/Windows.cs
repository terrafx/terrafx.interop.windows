// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.19041.0
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
    }
}
