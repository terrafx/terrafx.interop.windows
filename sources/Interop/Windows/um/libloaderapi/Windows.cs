// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DisableThreadLibraryCalls([NativeTypeName("HMODULE")] IntPtr hLibModule);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HRSRC")]
        public static extern IntPtr FindResourceExW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("WORD")] ushort wLanguage);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern int FindStringOrdinal([NativeTypeName("DWORD")] uint dwFindStringOrdinalFlags, [NativeTypeName("LPCWSTR")] ushort* lpStringSource, int cchSource, [NativeTypeName("LPCWSTR")] ushort* lpStringValue, int cchValue, [NativeTypeName("BOOL")] int bIgnoreCase);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FreeLibrary([NativeTypeName("HMODULE")] IntPtr hLibModule);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void FreeLibraryAndExitThread([NativeTypeName("HMODULE")] IntPtr hLibModule, [NativeTypeName("DWORD")] uint dwExitCode);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FreeResource([NativeTypeName("HGLOBAL")] IntPtr hResData);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetModuleFileNameA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetModuleFileNameW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPWSTR")] ushort* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr GetModuleHandleA([NativeTypeName("LPCSTR")] sbyte* lpModuleName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr GetModuleHandleW([NativeTypeName("LPCWSTR")] ushort* lpModuleName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetModuleHandleExA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* lpModuleName, [NativeTypeName("HMODULE *")] IntPtr* phModule);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetModuleHandleExW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* lpModuleName, [NativeTypeName("HMODULE *")] IntPtr* phModule);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("FARPROC")]
        public static extern delegate* unmanaged<int> GetProcAddress([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpProcName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadLibraryExA([NativeTypeName("LPCSTR")] sbyte* lpLibFileName, [NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadLibraryExW([NativeTypeName("LPCWSTR")] ushort* lpLibFileName, [NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern IntPtr LoadResource([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("HRSRC")] IntPtr hResInfo);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* LockResource([NativeTypeName("HGLOBAL")] IntPtr hResData);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SizeofResource([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("HRSRC")] IntPtr hResInfo);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DLL_DIRECTORY_COOKIE")]
        public static extern void* AddDllDirectory([NativeTypeName("PCWSTR")] ushort* NewDirectory);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDllDirectory([NativeTypeName("DLL_DIRECTORY_COOKIE")] void* Cookie);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDefaultDllDirectories([NativeTypeName("DWORD")] uint DirectoryFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceLanguagesExA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("ENUMRESLANGPROCA")] delegate* unmanaged<IntPtr, sbyte*, sbyte*, ushort, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceLanguagesExW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("ENUMRESLANGPROCW")] delegate* unmanaged<IntPtr, ushort*, ushort*, ushort, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceNamesExA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("ENUMRESNAMEPROCA")] delegate* unmanaged<IntPtr, sbyte*, sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceNamesExW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("ENUMRESNAMEPROCW")] delegate* unmanaged<IntPtr, ushort*, ushort*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceTypesExA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("ENUMRESTYPEPROCA")] delegate* unmanaged<IntPtr, sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceTypesExW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("ENUMRESTYPEPROCW")] delegate* unmanaged<IntPtr, ushort*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HRSRC")]
        public static extern IntPtr FindResourceW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadLibraryA([NativeTypeName("LPCSTR")] sbyte* lpLibFileName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadLibraryW([NativeTypeName("LPCWSTR")] ushort* lpLibFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceNamesW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("ENUMRESNAMEPROCW")] delegate* unmanaged<IntPtr, ushort*, ushort*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceNamesA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("ENUMRESNAMEPROCA")] delegate* unmanaged<IntPtr, sbyte*, sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [NativeTypeName("#define FIND_RESOURCE_DIRECTORY_TYPES (0x0100)")]
        public const int FIND_RESOURCE_DIRECTORY_TYPES = (0x0100);

        [NativeTypeName("#define FIND_RESOURCE_DIRECTORY_NAMES (0x0200)")]
        public const int FIND_RESOURCE_DIRECTORY_NAMES = (0x0200);

        [NativeTypeName("#define FIND_RESOURCE_DIRECTORY_LANGUAGES (0x0400)")]
        public const int FIND_RESOURCE_DIRECTORY_LANGUAGES = (0x0400);

        [NativeTypeName("#define RESOURCE_ENUM_LN (0x0001)")]
        public const int RESOURCE_ENUM_LN = (0x0001);

        [NativeTypeName("#define RESOURCE_ENUM_MUI (0x0002)")]
        public const int RESOURCE_ENUM_MUI = (0x0002);

        [NativeTypeName("#define RESOURCE_ENUM_MUI_SYSTEM (0x0004)")]
        public const int RESOURCE_ENUM_MUI_SYSTEM = (0x0004);

        [NativeTypeName("#define RESOURCE_ENUM_VALIDATE (0x0008)")]
        public const int RESOURCE_ENUM_VALIDATE = (0x0008);

        [NativeTypeName("#define RESOURCE_ENUM_MODULE_EXACT (0x0010)")]
        public const int RESOURCE_ENUM_MODULE_EXACT = (0x0010);

        [NativeTypeName("#define SUPPORT_LANG_NUMBER 32")]
        public const int SUPPORT_LANG_NUMBER = 32;

        [NativeTypeName("#define FindResourceEx FindResourceExW")]
        public static delegate*<IntPtr, ushort*, ushort*, ushort, IntPtr> FindResourceEx => &FindResourceExW;

        [NativeTypeName("#define GetModuleFileName GetModuleFileNameW")]
        public static delegate*<IntPtr, ushort*, uint, uint> GetModuleFileName => &GetModuleFileNameW;

        [NativeTypeName("#define GetModuleHandle GetModuleHandleW")]
        public static delegate*<ushort*, IntPtr> GetModuleHandle => &GetModuleHandleW;

        [NativeTypeName("#define GET_MODULE_HANDLE_EX_FLAG_PIN (0x00000001)")]
        public const int GET_MODULE_HANDLE_EX_FLAG_PIN = (0x00000001);

        [NativeTypeName("#define GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT (0x00000002)")]
        public const int GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT = (0x00000002);

        [NativeTypeName("#define GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS (0x00000004)")]
        public const int GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS = (0x00000004);

        [NativeTypeName("#define GetModuleHandleEx GetModuleHandleExW")]
        public static delegate*<uint, ushort*, IntPtr*, int> GetModuleHandleEx => &GetModuleHandleExW;

        [NativeTypeName("#define CURRENT_IMPORT_REDIRECTION_VERSION 1")]
        public const int CURRENT_IMPORT_REDIRECTION_VERSION = 1;

        [NativeTypeName("#define LoadLibraryEx LoadLibraryExW")]
        public static delegate*<ushort*, IntPtr, uint, IntPtr> LoadLibraryEx => &LoadLibraryExW;

        [NativeTypeName("#define DONT_RESOLVE_DLL_REFERENCES 0x00000001")]
        public const int DONT_RESOLVE_DLL_REFERENCES = 0x00000001;

        [NativeTypeName("#define LOAD_LIBRARY_AS_DATAFILE 0x00000002")]
        public const int LOAD_LIBRARY_AS_DATAFILE = 0x00000002;

        [NativeTypeName("#define LOAD_WITH_ALTERED_SEARCH_PATH 0x00000008")]
        public const int LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008;

        [NativeTypeName("#define LOAD_IGNORE_CODE_AUTHZ_LEVEL 0x00000010")]
        public const int LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x00000010;

        [NativeTypeName("#define LOAD_LIBRARY_AS_IMAGE_RESOURCE 0x00000020")]
        public const int LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x00000020;

        [NativeTypeName("#define LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE 0x00000040")]
        public const int LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x00000040;

        [NativeTypeName("#define LOAD_LIBRARY_REQUIRE_SIGNED_TARGET 0x00000080")]
        public const int LOAD_LIBRARY_REQUIRE_SIGNED_TARGET = 0x00000080;

        [NativeTypeName("#define LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR 0x00000100")]
        public const int LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 0x00000100;

        [NativeTypeName("#define LOAD_LIBRARY_SEARCH_APPLICATION_DIR 0x00000200")]
        public const int LOAD_LIBRARY_SEARCH_APPLICATION_DIR = 0x00000200;

        [NativeTypeName("#define LOAD_LIBRARY_SEARCH_USER_DIRS 0x00000400")]
        public const int LOAD_LIBRARY_SEARCH_USER_DIRS = 0x00000400;

        [NativeTypeName("#define LOAD_LIBRARY_SEARCH_SYSTEM32 0x00000800")]
        public const int LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800;

        [NativeTypeName("#define LOAD_LIBRARY_SEARCH_DEFAULT_DIRS 0x00001000")]
        public const int LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 0x00001000;

        [NativeTypeName("#define LOAD_LIBRARY_SAFE_CURRENT_DIRS 0x00002000")]
        public const int LOAD_LIBRARY_SAFE_CURRENT_DIRS = 0x00002000;

        [NativeTypeName("#define LOAD_LIBRARY_SEARCH_SYSTEM32_NO_FORWARDER 0x00004000")]
        public const int LOAD_LIBRARY_SEARCH_SYSTEM32_NO_FORWARDER = 0x00004000;

        [NativeTypeName("#define LOAD_LIBRARY_OS_INTEGRITY_CONTINUITY 0x00008000")]
        public const int LOAD_LIBRARY_OS_INTEGRITY_CONTINUITY = 0x00008000;

        [NativeTypeName("#define EnumResourceLanguagesEx EnumResourceLanguagesExW")]
        public static delegate*<IntPtr, ushort*, ushort*, delegate* unmanaged<IntPtr, ushort*, ushort*, ushort, nint, int>, nint, uint, ushort, int> EnumResourceLanguagesEx => &EnumResourceLanguagesExW;

        [NativeTypeName("#define EnumResourceNamesEx EnumResourceNamesExW")]
        public static delegate*<IntPtr, ushort*, delegate* unmanaged<IntPtr, ushort*, ushort*, nint, int>, nint, uint, ushort, int> EnumResourceNamesEx => &EnumResourceNamesExW;

        [NativeTypeName("#define EnumResourceTypesEx EnumResourceTypesExW")]
        public static delegate*<IntPtr, delegate* unmanaged<IntPtr, ushort*, nint, int>, nint, uint, ushort, int> EnumResourceTypesEx => &EnumResourceTypesExW;

        [NativeTypeName("#define FindResource FindResourceW")]
        public static delegate*<IntPtr, ushort*, ushort*, IntPtr> FindResource => &FindResourceW;

        [NativeTypeName("#define LoadLibrary LoadLibraryW")]
        public static delegate*<ushort*, IntPtr> LoadLibrary => &LoadLibraryW;

        [NativeTypeName("#define EnumResourceNames EnumResourceNamesW")]
        public static delegate*<IntPtr, ushort*, delegate* unmanaged<IntPtr, ushort*, ushort*, nint, int>, nint, int> EnumResourceNames => &EnumResourceNamesW;
    }
}
