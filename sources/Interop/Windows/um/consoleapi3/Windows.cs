// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
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
