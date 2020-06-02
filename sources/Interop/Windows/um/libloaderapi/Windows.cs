// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", EntryPoint = "DisableThreadLibraryCalls", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DisableThreadLibraryCalls([NativeTypeName("HMODULE")] IntPtr hLibModule);

        [DllImport("kernel32", EntryPoint = "FindResourceExW", ExactSpelling = true)]
        [return: NativeTypeName("HRSRC")]
        public static extern IntPtr FindResourceExW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("WORD")] ushort wLanguage);

        [DllImport("kernel32", EntryPoint = "FindStringOrdinal", ExactSpelling = true, SetLastError = true)]
        public static extern int FindStringOrdinal([NativeTypeName("DWORD")] uint dwFindStringOrdinalFlags, [NativeTypeName("LPCWSTR")] ushort* lpStringSource, int cchSource, [NativeTypeName("LPCWSTR")] ushort* lpStringValue, int cchValue, [NativeTypeName("BOOL")] int bIgnoreCase);

        [DllImport("kernel32", EntryPoint = "FreeLibrary", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FreeLibrary([NativeTypeName("HMODULE")] IntPtr hLibModule);

        [DllImport("kernel32", EntryPoint = "FreeLibraryAndExitThread", ExactSpelling = true)]
        public static extern void FreeLibraryAndExitThread([NativeTypeName("HMODULE")] IntPtr hLibModule, [NativeTypeName("DWORD")] uint dwExitCode);

        [DllImport("kernel32", EntryPoint = "FreeResource", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FreeResource([NativeTypeName("HGLOBAL")] IntPtr hResData);

        [DllImport("kernel32", EntryPoint = "GetModuleFileNameA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetModuleFileNameA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "GetModuleFileNameW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetModuleFileNameW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPWSTR")] ushort* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "GetModuleHandleA", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr GetModuleHandleA([NativeTypeName("LPCSTR")] sbyte* lpModuleName);

        [DllImport("kernel32", EntryPoint = "GetModuleHandleW", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr GetModuleHandleW([NativeTypeName("LPCWSTR")] ushort* lpModuleName);

        [DllImport("kernel32", EntryPoint = "GetModuleHandleExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetModuleHandleExA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* lpModuleName, [NativeTypeName("HMODULE *")] IntPtr* phModule);

        [DllImport("kernel32", EntryPoint = "GetModuleHandleExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetModuleHandleExW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* lpModuleName, [NativeTypeName("HMODULE *")] IntPtr* phModule);

        [DllImport("kernel32", EntryPoint = "GetProcAddress", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("FARPROC")]
        public static extern delegate* stdcall<int> GetProcAddress([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpProcName);

        [DllImport("kernel32", EntryPoint = "LoadLibraryExA", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadLibraryExA([NativeTypeName("LPCSTR")] sbyte* lpLibFileName, [NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "LoadLibraryExW", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadLibraryExW([NativeTypeName("LPCWSTR")] ushort* lpLibFileName, [NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "LoadResource", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern IntPtr LoadResource([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("HRSRC")] IntPtr hResInfo);

        [DllImport("kernel32", EntryPoint = "LoadStringA", ExactSpelling = true)]
        public static extern int LoadStringA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("UINT")] uint uID, [NativeTypeName("LPSTR")] sbyte* lpBuffer, int cchBufferMax);

        [DllImport("kernel32", EntryPoint = "LoadStringW", ExactSpelling = true)]
        public static extern int LoadStringW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("UINT")] uint uID, [NativeTypeName("LPWSTR")] ushort* lpBuffer, int cchBufferMax);

        [DllImport("kernel32", EntryPoint = "LockResource", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* LockResource([NativeTypeName("HGLOBAL")] IntPtr hResData);

        [DllImport("kernel32", EntryPoint = "SizeofResource", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SizeofResource([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("HRSRC")] IntPtr hResInfo);

        [DllImport("kernel32", EntryPoint = "AddDllDirectory", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DLL_DIRECTORY_COOKIE")]
        public static extern void* AddDllDirectory([NativeTypeName("PCWSTR")] ushort* NewDirectory);

        [DllImport("kernel32", EntryPoint = "RemoveDllDirectory", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDllDirectory([NativeTypeName("DLL_DIRECTORY_COOKIE")] void* Cookie);

        [DllImport("kernel32", EntryPoint = "SetDefaultDllDirectories", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDefaultDllDirectories([NativeTypeName("DWORD")] uint DirectoryFlags);

        [DllImport("kernel32", EntryPoint = "EnumResourceLanguagesExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceLanguagesExA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("ENUMRESLANGPROCA")] delegate* stdcall<IntPtr, sbyte*, sbyte*, ushort, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", EntryPoint = "EnumResourceLanguagesExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceLanguagesExW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("ENUMRESLANGPROCW")] delegate* stdcall<IntPtr, ushort*, ushort*, ushort, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", EntryPoint = "EnumResourceNamesExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceNamesExA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("ENUMRESNAMEPROCA")] delegate* stdcall<IntPtr, sbyte*, sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", EntryPoint = "EnumResourceNamesExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceNamesExW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("ENUMRESNAMEPROCW")] delegate* stdcall<IntPtr, ushort*, ushort*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", EntryPoint = "EnumResourceTypesExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceTypesExA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("ENUMRESTYPEPROCA")] delegate* stdcall<IntPtr, sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", EntryPoint = "EnumResourceTypesExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceTypesExW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("ENUMRESTYPEPROCW")] delegate* stdcall<IntPtr, ushort*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", EntryPoint = "FindResourceW", ExactSpelling = true)]
        [return: NativeTypeName("HRSRC")]
        public static extern IntPtr FindResourceW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpType);

        [DllImport("kernel32", EntryPoint = "LoadLibraryA", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadLibraryA([NativeTypeName("LPCSTR")] sbyte* lpLibFileName);

        [DllImport("kernel32", EntryPoint = "LoadLibraryW", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadLibraryW([NativeTypeName("LPCWSTR")] ushort* lpLibFileName);

        [DllImport("kernel32", EntryPoint = "EnumResourceNamesW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceNamesW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("ENUMRESNAMEPROCW")] delegate* stdcall<IntPtr, ushort*, ushort*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);
    }
}
