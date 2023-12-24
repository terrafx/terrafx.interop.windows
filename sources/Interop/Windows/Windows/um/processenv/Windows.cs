// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processenv.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetEnvironmentStringsW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL SetEnvironmentStringsW([NativeTypeName("LPWCH")] char* NewEnvironment);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetStdHandle"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SuppressGCTransition]
    public static extern HANDLE GetStdHandle([NativeTypeName("DWORD")] uint nStdHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetStdHandle"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetStdHandle([NativeTypeName("DWORD")] uint nStdHandle, HANDLE hHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetStdHandleEx"]/*' />
    [DllImport("api-ms-win-core-processenvironment-l1-1-0", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL SetStdHandleEx([NativeTypeName("DWORD")] uint nStdHandle, HANDLE hHandle, [NativeTypeName("PHANDLE")] HANDLE* phPrevValue);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCommandLineA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* GetCommandLineA();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCommandLineW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern char* GetCommandLineW();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnvironmentStringsA"]/*' />
    [DllImport("kernel32", EntryPoint = "GetEnvironmentStrings", ExactSpelling = true)]
    [return: NativeTypeName("LPCH")]
    public static extern sbyte* GetEnvironmentStringsA();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnvironmentStringsW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPWCH")]
    public static extern char* GetEnvironmentStringsW();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeEnvironmentStringsA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FreeEnvironmentStringsA([NativeTypeName("LPCH")] sbyte* penv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeEnvironmentStringsW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FreeEnvironmentStringsW([NativeTypeName("LPWCH")] char* penv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnvironmentVariableA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetEnvironmentVariableA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnvironmentVariableW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetEnvironmentVariableW([NativeTypeName("LPCWSTR")] char* lpName, [NativeTypeName("LPWSTR")] char* lpBuffer, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetEnvironmentVariableA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetEnvironmentVariableA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpValue);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetEnvironmentVariableW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetEnvironmentVariableW([NativeTypeName("LPCWSTR")] char* lpName, [NativeTypeName("LPCWSTR")] char* lpValue);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExpandEnvironmentStringsA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint ExpandEnvironmentStringsA([NativeTypeName("LPCSTR")] sbyte* lpSrc, [NativeTypeName("LPSTR")] sbyte* lpDst, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExpandEnvironmentStringsW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint ExpandEnvironmentStringsW([NativeTypeName("LPCWSTR")] char* lpSrc, [NativeTypeName("LPWSTR")] char* lpDst, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCurrentDirectoryA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetCurrentDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCurrentDirectoryW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetCurrentDirectoryW([NativeTypeName("LPCWSTR")] char* lpPathName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentDirectoryA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCurrentDirectoryA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentDirectoryW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCurrentDirectoryW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] char* lpBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SearchPathW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SearchPathW([NativeTypeName("LPCWSTR")] char* lpPath, [NativeTypeName("LPCWSTR")] char* lpFileName, [NativeTypeName("LPCWSTR")] char* lpExtension, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] char* lpBuffer, [NativeTypeName("LPWSTR *")] char** lpFilePart);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SearchPathA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SearchPathA([NativeTypeName("LPCSTR")] sbyte* lpPath, [NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPCSTR")] sbyte* lpExtension, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPSTR *")] sbyte** lpFilePart);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NeedCurrentDirectoryForExePathA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL NeedCurrentDirectoryForExePathA([NativeTypeName("LPCSTR")] sbyte* ExeName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NeedCurrentDirectoryForExePathW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL NeedCurrentDirectoryForExePathW([NativeTypeName("LPCWSTR")] char* ExeName);

    [NativeTypeName("#define SetEnvironmentStrings SetEnvironmentStringsW")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static delegate*<char*, BOOL> SetEnvironmentStrings => &SetEnvironmentStringsW;

    [NativeTypeName("#define GetCommandLine GetCommandLineW")]
    public static delegate*<char*> GetCommandLine => &GetCommandLineW;

    [NativeTypeName("#define GetEnvironmentStrings GetEnvironmentStringsW")]
    public static delegate*<char*> GetEnvironmentStrings => &GetEnvironmentStringsW;

    [NativeTypeName("#define FreeEnvironmentStrings FreeEnvironmentStringsW")]
    public static delegate*<char*, BOOL> FreeEnvironmentStrings => &FreeEnvironmentStringsW;

    [NativeTypeName("#define GetEnvironmentVariable GetEnvironmentVariableW")]
    public static delegate*<char*, char*, uint, uint> GetEnvironmentVariable => &GetEnvironmentVariableW;

    [NativeTypeName("#define SetEnvironmentVariable SetEnvironmentVariableW")]
    public static delegate*<char*, char*, BOOL> SetEnvironmentVariable => &SetEnvironmentVariableW;

    [NativeTypeName("#define ExpandEnvironmentStrings ExpandEnvironmentStringsW")]
    public static delegate*<char*, char*, uint, uint> ExpandEnvironmentStrings => &ExpandEnvironmentStringsW;

    [NativeTypeName("#define SetCurrentDirectory SetCurrentDirectoryW")]
    public static delegate*<char*, BOOL> SetCurrentDirectory => &SetCurrentDirectoryW;

    [NativeTypeName("#define GetCurrentDirectory GetCurrentDirectoryW")]
    public static delegate*<uint, char*, uint> GetCurrentDirectory => &GetCurrentDirectoryW;

    [NativeTypeName("#define SearchPath SearchPathW")]
    public static delegate*<char*, char*, char*, uint, char*, char**, uint> SearchPath => &SearchPathW;

    [NativeTypeName("#define NeedCurrentDirectoryForExePath NeedCurrentDirectoryForExePathW")]
    public static delegate*<char*, BOOL> NeedCurrentDirectoryForExePath => &NeedCurrentDirectoryForExePathW;
}
