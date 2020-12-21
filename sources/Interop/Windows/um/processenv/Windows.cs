// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processenv.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEnvironmentStringsW([NativeTypeName("LPWCH")] ushort* NewEnvironment);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetStdHandle([NativeTypeName("DWORD")] uint nStdHandle);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetStdHandle([NativeTypeName("DWORD")] uint nStdHandle, [NativeTypeName("HANDLE")] IntPtr hHandle);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetStdHandleEx([NativeTypeName("DWORD")] uint nStdHandle, [NativeTypeName("HANDLE")] IntPtr hHandle, [NativeTypeName("PHANDLE")] IntPtr* phPrevValue);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* GetCommandLineA();

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* GetCommandLineW();

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetEnvironmentStrings", ExactSpelling = true)]
        [return: NativeTypeName("LPCH")]
        public static extern sbyte* GetEnvironmentStringsA();

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPWCH")]
        public static extern ushort* GetEnvironmentStringsW();

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FreeEnvironmentStringsA([NativeTypeName("LPCH")] sbyte* penv);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FreeEnvironmentStringsW([NativeTypeName("LPWCH")] ushort* penv);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetEnvironmentVariableA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetEnvironmentVariableW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEnvironmentVariableA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpValue);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEnvironmentVariableW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpValue);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ExpandEnvironmentStringsA([NativeTypeName("LPCSTR")] sbyte* lpSrc, [NativeTypeName("LPSTR")] sbyte* lpDst, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ExpandEnvironmentStringsW([NativeTypeName("LPCWSTR")] ushort* lpSrc, [NativeTypeName("LPWSTR")] ushort* lpDst, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCurrentDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCurrentDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCurrentDirectoryA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCurrentDirectoryW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SearchPathW([NativeTypeName("LPCWSTR")] ushort* lpPath, [NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPCWSTR")] ushort* lpExtension, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPWSTR *")] ushort** lpFilePart);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SearchPathA([NativeTypeName("LPCSTR")] sbyte* lpPath, [NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPCSTR")] sbyte* lpExtension, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPSTR *")] sbyte** lpFilePart);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int NeedCurrentDirectoryForExePathA([NativeTypeName("LPCSTR")] sbyte* ExeName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int NeedCurrentDirectoryForExePathW([NativeTypeName("LPCWSTR")] ushort* ExeName);

        [NativeTypeName("#define SetEnvironmentStrings SetEnvironmentStringsW")]
        public static readonly delegate*<ushort*, int> SetEnvironmentStrings = &SetEnvironmentStringsW;

        [NativeTypeName("#define GetCommandLine GetCommandLineW")]
        public static readonly delegate*<ushort*> GetCommandLine = &GetCommandLineW;

        [NativeTypeName("#define GetEnvironmentStrings GetEnvironmentStringsW")]
        public static readonly delegate*<ushort*> GetEnvironmentStrings = &GetEnvironmentStringsW;

        [NativeTypeName("#define FreeEnvironmentStrings FreeEnvironmentStringsW")]
        public static readonly delegate*<ushort*, int> FreeEnvironmentStrings = &FreeEnvironmentStringsW;

        [NativeTypeName("#define GetEnvironmentVariable GetEnvironmentVariableW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint> GetEnvironmentVariable = &GetEnvironmentVariableW;

        [NativeTypeName("#define SetEnvironmentVariable SetEnvironmentVariableW")]
        public static readonly delegate*<ushort*, ushort*, int> SetEnvironmentVariable = &SetEnvironmentVariableW;

        [NativeTypeName("#define ExpandEnvironmentStrings ExpandEnvironmentStringsW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint> ExpandEnvironmentStrings = &ExpandEnvironmentStringsW;

        [NativeTypeName("#define SetCurrentDirectory SetCurrentDirectoryW")]
        public static readonly delegate*<ushort*, int> SetCurrentDirectory = &SetCurrentDirectoryW;

        [NativeTypeName("#define GetCurrentDirectory GetCurrentDirectoryW")]
        public static readonly delegate*<uint, ushort*, uint> GetCurrentDirectory = &GetCurrentDirectoryW;

        [NativeTypeName("#define SearchPath SearchPathW")]
        public static readonly delegate*<ushort*, ushort*, ushort*, uint, ushort*, ushort**, uint> SearchPath = &SearchPathW;

        [NativeTypeName("#define NeedCurrentDirectoryForExePath NeedCurrentDirectoryForExePathW")]
        public static readonly delegate*<ushort*, int> NeedCurrentDirectoryForExePath = &NeedCurrentDirectoryForExePathW;
    }
}
