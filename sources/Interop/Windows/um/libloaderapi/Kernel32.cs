// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Kernel32
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DisableThreadLibraryCalls", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DisableThreadLibraryCalls([NativeTypeName("HMODULE")] IntPtr hLibModule);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindResourceExW", ExactSpelling = true)]
        [return: NativeTypeName("HRSRC")]
        public static extern IntPtr FindResourceExW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("WORD")] ushort wLanguage);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindStringOrdinal", ExactSpelling = true)]
        public static extern int FindStringOrdinal([NativeTypeName("DWORD")] uint dwFindStringOrdinalFlags, [NativeTypeName("LPCWSTR")] ushort* lpStringSource, int cchSource, [NativeTypeName("LPCWSTR")] ushort* lpStringValue, int cchValue, [NativeTypeName("BOOL")] int bIgnoreCase);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FreeLibrary", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FreeLibrary([NativeTypeName("HMODULE")] IntPtr hLibModule);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FreeLibraryAndExitThread", ExactSpelling = true)]
        public static extern void FreeLibraryAndExitThread([NativeTypeName("HMODULE")] IntPtr hLibModule, [NativeTypeName("DWORD")] uint dwExitCode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FreeResource", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FreeResource([NativeTypeName("HGLOBAL")] IntPtr hResData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetModuleFileNameA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetModuleFileNameA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetModuleFileNameW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetModuleFileNameW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPWSTR")] ushort* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetModuleHandleA", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr GetModuleHandleA([NativeTypeName("LPCSTR")] sbyte* lpModuleName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetModuleHandleW", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr GetModuleHandleW([NativeTypeName("LPCWSTR")] ushort* lpModuleName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetModuleHandleExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetModuleHandleExA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* lpModuleName, [NativeTypeName("HMODULE *")] IntPtr* phModule);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetModuleHandleExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetModuleHandleExW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* lpModuleName, [NativeTypeName("HMODULE *")] IntPtr* phModule);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
        [return: NativeTypeName("FARPROC")]
        public static extern IntPtr GetProcAddress([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpProcName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadLibraryExA", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadLibraryExA([NativeTypeName("LPCSTR")] sbyte* lpLibFileName, [NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadLibraryExW", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadLibraryExW([NativeTypeName("LPCWSTR")] ushort* lpLibFileName, [NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadResource", ExactSpelling = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern IntPtr LoadResource([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("HRSRC")] IntPtr hResInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadStringA", ExactSpelling = true)]
        public static extern int LoadStringA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("UINT")] uint uID, [NativeTypeName("LPSTR")] sbyte* lpBuffer, int cchBufferMax);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadStringW", ExactSpelling = true)]
        public static extern int LoadStringW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("UINT")] uint uID, [NativeTypeName("LPWSTR")] ushort* lpBuffer, int cchBufferMax);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LockResource", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* LockResource([NativeTypeName("HGLOBAL")] IntPtr hResData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SizeofResource", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SizeofResource([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("HRSRC")] IntPtr hResInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AddDllDirectory", ExactSpelling = true)]
        [return: NativeTypeName("DLL_DIRECTORY_COOKIE")]
        public static extern void* AddDllDirectory([NativeTypeName("PCWSTR")] ushort* NewDirectory);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RemoveDllDirectory", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDllDirectory([NativeTypeName("DLL_DIRECTORY_COOKIE")] void* Cookie);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDefaultDllDirectories", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDefaultDllDirectories([NativeTypeName("DWORD")] uint DirectoryFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumResourceLanguagesExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceLanguagesExA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("ENUMRESLANGPROCA")] IntPtr lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumResourceLanguagesExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceLanguagesExW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("ENUMRESLANGPROCW")] IntPtr lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumResourceNamesExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceNamesExA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("ENUMRESNAMEPROCA")] IntPtr lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumResourceNamesExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceNamesExW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("ENUMRESNAMEPROCW")] IntPtr lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumResourceTypesExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceTypesExA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("ENUMRESTYPEPROCA")] IntPtr lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumResourceTypesExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceTypesExW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("ENUMRESTYPEPROCW")] IntPtr lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindResourceW", ExactSpelling = true)]
        [return: NativeTypeName("HRSRC")]
        public static extern IntPtr FindResourceW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadLibraryA", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadLibraryA([NativeTypeName("LPCSTR")] sbyte* lpLibFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadLibraryW", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadLibraryW([NativeTypeName("LPCWSTR")] ushort* lpLibFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumResourceNamesW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceNamesW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("ENUMRESNAMEPROCW")] IntPtr lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);
    }
}
