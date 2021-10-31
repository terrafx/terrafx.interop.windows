// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegCloseKey([NativeTypeName("HKEY")] IntPtr hKey);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegOverridePredefKey([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("HKEY")] IntPtr hNewHKey);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegOpenUserClassesRoot([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("PHKEY")] IntPtr* phkResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegOpenCurrentUser([NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("PHKEY")] IntPtr* phkResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDisablePredefinedCache();

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDisablePredefinedCacheEx();

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegConnectRegistryA([NativeTypeName("LPCSTR")] sbyte* lpMachineName, [NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("PHKEY")] IntPtr* phkResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegConnectRegistryW([NativeTypeName("LPCWSTR")] ushort* lpMachineName, [NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("PHKEY")] IntPtr* phkResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegConnectRegistryExA([NativeTypeName("LPCSTR")] sbyte* lpMachineName, [NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PHKEY")] IntPtr* phkResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegConnectRegistryExW([NativeTypeName("LPCWSTR")] ushort* lpMachineName, [NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PHKEY")] IntPtr* phkResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegCreateKeyA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("PHKEY")] IntPtr* phkResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegCreateKeyW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("PHKEY")] IntPtr* phkResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegCreateKeyExA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("LPSTR")] sbyte* lpClass, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("PHKEY")] IntPtr* phkResult, [NativeTypeName("LPDWORD")] uint* lpdwDisposition);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegCreateKeyExW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("LPWSTR")] ushort* lpClass, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("PHKEY")] IntPtr* phkResult, [NativeTypeName("LPDWORD")] uint* lpdwDisposition);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegCreateKeyTransactedA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("LPSTR")] sbyte* lpClass, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("PHKEY")] IntPtr* phkResult, [NativeTypeName("LPDWORD")] uint* lpdwDisposition, [NativeTypeName("HANDLE")] IntPtr hTransaction, [NativeTypeName("PVOID")] void* pExtendedParemeter);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegCreateKeyTransactedW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("LPWSTR")] ushort* lpClass, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("PHKEY")] IntPtr* phkResult, [NativeTypeName("LPDWORD")] uint* lpdwDisposition, [NativeTypeName("HANDLE")] IntPtr hTransaction, [NativeTypeName("PVOID")] void* pExtendedParemeter);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDeleteKeyA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDeleteKeyW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDeleteKeyExA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Reserved);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDeleteKeyExW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Reserved);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDeleteKeyTransactedA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("HANDLE")] IntPtr hTransaction, [NativeTypeName("PVOID")] void* pExtendedParameter);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDeleteKeyTransactedW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("HANDLE")] IntPtr hTransaction, [NativeTypeName("PVOID")] void* pExtendedParameter);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int RegDisableReflectionKey([NativeTypeName("HKEY")] IntPtr hBase);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int RegEnableReflectionKey([NativeTypeName("HKEY")] IntPtr hBase);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int RegQueryReflectionKey([NativeTypeName("HKEY")] IntPtr hBase, BOOL* bIsReflectionDisabled);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDeleteValueA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpValueName);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDeleteValueW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpValueName);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegEnumKeyA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint cchName);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegEnumKeyW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint cchName);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegEnumKeyExA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* lpName, [NativeTypeName("LPDWORD")] uint* lpcchName, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPSTR")] sbyte* lpClass, [NativeTypeName("LPDWORD")] uint* lpcchClass, [NativeTypeName("PFILETIME")] FILETIME* lpftLastWriteTime);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegEnumKeyExW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* lpName, [NativeTypeName("LPDWORD")] uint* lpcchName, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPWSTR")] ushort* lpClass, [NativeTypeName("LPDWORD")] uint* lpcchClass, [NativeTypeName("PFILETIME")] FILETIME* lpftLastWriteTime);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegEnumValueA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* lpValueName, [NativeTypeName("LPDWORD")] uint* lpcchValueName, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPDWORD")] uint* lpType, [NativeTypeName("LPBYTE")] byte* lpData, [NativeTypeName("LPDWORD")] uint* lpcbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegEnumValueW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* lpValueName, [NativeTypeName("LPDWORD")] uint* lpcchValueName, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPDWORD")] uint* lpType, [NativeTypeName("LPBYTE")] byte* lpData, [NativeTypeName("LPDWORD")] uint* lpcbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegFlushKey([NativeTypeName("HKEY")] IntPtr hKey);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegGetKeySecurity([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("LPDWORD")] uint* lpcbSecurityDescriptor);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegLoadKeyA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("LPCSTR")] sbyte* lpFile);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegLoadKeyW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("LPCWSTR")] ushort* lpFile);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegNotifyChangeKeyValue([NativeTypeName("HKEY")] IntPtr hKey, BOOL bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter, [NativeTypeName("HANDLE")] IntPtr hEvent, BOOL fAsynchronous);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegOpenKeyA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("PHKEY")] IntPtr* phkResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegOpenKeyW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("PHKEY")] IntPtr* phkResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegOpenKeyExA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("DWORD")] uint ulOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("PHKEY")] IntPtr* phkResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegOpenKeyExW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("DWORD")] uint ulOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("PHKEY")] IntPtr* phkResult);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegOpenKeyTransactedA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("DWORD")] uint ulOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("PHKEY")] IntPtr* phkResult, [NativeTypeName("HANDLE")] IntPtr hTransaction, [NativeTypeName("PVOID")] void* pExtendedParemeter);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegOpenKeyTransactedW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("DWORD")] uint ulOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("PHKEY")] IntPtr* phkResult, [NativeTypeName("HANDLE")] IntPtr hTransaction, [NativeTypeName("PVOID")] void* pExtendedParemeter);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegQueryInfoKeyA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPSTR")] sbyte* lpClass, [NativeTypeName("LPDWORD")] uint* lpcchClass, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPDWORD")] uint* lpcSubKeys, [NativeTypeName("LPDWORD")] uint* lpcbMaxSubKeyLen, [NativeTypeName("LPDWORD")] uint* lpcbMaxClassLen, [NativeTypeName("LPDWORD")] uint* lpcValues, [NativeTypeName("LPDWORD")] uint* lpcbMaxValueNameLen, [NativeTypeName("LPDWORD")] uint* lpcbMaxValueLen, [NativeTypeName("LPDWORD")] uint* lpcbSecurityDescriptor, [NativeTypeName("PFILETIME")] FILETIME* lpftLastWriteTime);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegQueryInfoKeyW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPWSTR")] ushort* lpClass, [NativeTypeName("LPDWORD")] uint* lpcchClass, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPDWORD")] uint* lpcSubKeys, [NativeTypeName("LPDWORD")] uint* lpcbMaxSubKeyLen, [NativeTypeName("LPDWORD")] uint* lpcbMaxClassLen, [NativeTypeName("LPDWORD")] uint* lpcValues, [NativeTypeName("LPDWORD")] uint* lpcbMaxValueNameLen, [NativeTypeName("LPDWORD")] uint* lpcbMaxValueLen, [NativeTypeName("LPDWORD")] uint* lpcbSecurityDescriptor, [NativeTypeName("PFILETIME")] FILETIME* lpftLastWriteTime);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegQueryValueA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("LPSTR")] sbyte* lpData, [NativeTypeName("PLONG")] int* lpcbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegQueryValueW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("LPWSTR")] ushort* lpData, [NativeTypeName("PLONG")] int* lpcbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegQueryMultipleValuesA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("PVALENTA")] VALENTA* val_list, [NativeTypeName("DWORD")] uint num_vals, [NativeTypeName("LPSTR")] sbyte* lpValueBuf, [NativeTypeName("LPDWORD")] uint* ldwTotsize);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegQueryMultipleValuesW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("PVALENTW")] VALENTW* val_list, [NativeTypeName("DWORD")] uint num_vals, [NativeTypeName("LPWSTR")] ushort* lpValueBuf, [NativeTypeName("LPDWORD")] uint* ldwTotsize);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegQueryValueExA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpValueName, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPDWORD")] uint* lpType, [NativeTypeName("LPBYTE")] byte* lpData, [NativeTypeName("LPDWORD")] uint* lpcbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegQueryValueExW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpValueName, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPDWORD")] uint* lpType, [NativeTypeName("LPBYTE")] byte* lpData, [NativeTypeName("LPDWORD")] uint* lpcbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegReplaceKeyA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("LPCSTR")] sbyte* lpNewFile, [NativeTypeName("LPCSTR")] sbyte* lpOldFile);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegReplaceKeyW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("LPCWSTR")] ushort* lpNewFile, [NativeTypeName("LPCWSTR")] ushort* lpOldFile);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegRestoreKeyA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpFile, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegRestoreKeyW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpFile, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegRenameKey([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKeyName, [NativeTypeName("LPCWSTR")] ushort* lpNewKeyName);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegSaveKeyA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpFile, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegSaveKeyW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpFile, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegSetKeySecurity([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegSetValueA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCSTR")] sbyte* lpData, [NativeTypeName("DWORD")] uint cbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegSetValueW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCWSTR")] ushort* lpData, [NativeTypeName("DWORD")] uint cbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegSetValueExA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpValueName, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const BYTE *")] byte* lpData, [NativeTypeName("DWORD")] uint cbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegSetValueExW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpValueName, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const BYTE *")] byte* lpData, [NativeTypeName("DWORD")] uint cbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegUnLoadKeyA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegUnLoadKeyW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDeleteKeyValueA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("LPCSTR")] sbyte* lpValueName);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDeleteKeyValueW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("LPCWSTR")] ushort* lpValueName);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegSetKeyValueA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("LPCSTR")] sbyte* lpValueName, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCVOID")] void* lpData, [NativeTypeName("DWORD")] uint cbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegSetKeyValueW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("LPCWSTR")] ushort* lpValueName, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCVOID")] void* lpData, [NativeTypeName("DWORD")] uint cbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDeleteTreeA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegDeleteTreeW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegCopyTreeA([NativeTypeName("HKEY")] IntPtr hKeySrc, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("HKEY")] IntPtr hKeyDest);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegGetValueA([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("LPCSTR")] sbyte* lpValue, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* pdwType, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPDWORD")] uint* pcbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegGetValueW([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("LPCWSTR")] ushort* lpValue, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* pdwType, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPDWORD")] uint* pcbData);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegCopyTreeW([NativeTypeName("HKEY")] IntPtr hKeySrc, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("HKEY")] IntPtr hKeyDest);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegLoadMUIStringA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("LPSTR")] sbyte* pszOutBuf, [NativeTypeName("DWORD")] uint cbOutBuf, [NativeTypeName("LPDWORD")] uint* pcbData, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPCSTR")] sbyte* pszDirectory);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegLoadMUIStringW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* pszValue, [NativeTypeName("LPWSTR")] ushort* pszOutBuf, [NativeTypeName("DWORD")] uint cbOutBuf, [NativeTypeName("LPDWORD")] uint* pcbData, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPCWSTR")] ushort* pszDirectory);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegLoadAppKeyA([NativeTypeName("LPCSTR")] sbyte* lpFile, [NativeTypeName("PHKEY")] IntPtr* phkResult, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("DWORD")] uint Reserved);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegLoadAppKeyW([NativeTypeName("LPCWSTR")] ushort* lpFile, [NativeTypeName("PHKEY")] IntPtr* phkResult, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("DWORD")] uint Reserved);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL InitiateSystemShutdownA([NativeTypeName("LPSTR")] sbyte* lpMachineName, [NativeTypeName("LPSTR")] sbyte* lpMessage, [NativeTypeName("DWORD")] uint dwTimeout, BOOL bForceAppsClosed, BOOL bRebootAfterShutdown);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL InitiateSystemShutdownW([NativeTypeName("LPWSTR")] ushort* lpMachineName, [NativeTypeName("LPWSTR")] ushort* lpMessage, [NativeTypeName("DWORD")] uint dwTimeout, BOOL bForceAppsClosed, BOOL bRebootAfterShutdown);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AbortSystemShutdownA([NativeTypeName("LPSTR")] sbyte* lpMachineName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AbortSystemShutdownW([NativeTypeName("LPWSTR")] ushort* lpMachineName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL InitiateSystemShutdownExA([NativeTypeName("LPSTR")] sbyte* lpMachineName, [NativeTypeName("LPSTR")] sbyte* lpMessage, [NativeTypeName("DWORD")] uint dwTimeout, BOOL bForceAppsClosed, BOOL bRebootAfterShutdown, [NativeTypeName("DWORD")] uint dwReason);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL InitiateSystemShutdownExW([NativeTypeName("LPWSTR")] ushort* lpMachineName, [NativeTypeName("LPWSTR")] ushort* lpMessage, [NativeTypeName("DWORD")] uint dwTimeout, BOOL bForceAppsClosed, BOOL bRebootAfterShutdown, [NativeTypeName("DWORD")] uint dwReason);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint InitiateShutdownA([NativeTypeName("LPSTR")] sbyte* lpMachineName, [NativeTypeName("LPSTR")] sbyte* lpMessage, [NativeTypeName("DWORD")] uint dwGracePeriod, [NativeTypeName("DWORD")] uint dwShutdownFlags, [NativeTypeName("DWORD")] uint dwReason);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint InitiateShutdownW([NativeTypeName("LPWSTR")] ushort* lpMachineName, [NativeTypeName("LPWSTR")] ushort* lpMessage, [NativeTypeName("DWORD")] uint dwGracePeriod, [NativeTypeName("DWORD")] uint dwShutdownFlags, [NativeTypeName("DWORD")] uint dwReason);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CheckForHiberboot([NativeTypeName("PBOOLEAN")] byte* pHiberboot, [NativeTypeName("BOOLEAN")] byte bClearFlag);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegSaveKeyExA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* lpFile, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int RegSaveKeyExW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* lpFile, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint Flags);

        [NativeTypeName("#define RRF_RT_REG_NONE 0x00000001")]
        public const int RRF_RT_REG_NONE = 0x00000001;

        [NativeTypeName("#define RRF_RT_REG_SZ 0x00000002")]
        public const int RRF_RT_REG_SZ = 0x00000002;

        [NativeTypeName("#define RRF_RT_REG_EXPAND_SZ 0x00000004")]
        public const int RRF_RT_REG_EXPAND_SZ = 0x00000004;

        [NativeTypeName("#define RRF_RT_REG_BINARY 0x00000008")]
        public const int RRF_RT_REG_BINARY = 0x00000008;

        [NativeTypeName("#define RRF_RT_REG_DWORD 0x00000010")]
        public const int RRF_RT_REG_DWORD = 0x00000010;

        [NativeTypeName("#define RRF_RT_REG_MULTI_SZ 0x00000020")]
        public const int RRF_RT_REG_MULTI_SZ = 0x00000020;

        [NativeTypeName("#define RRF_RT_REG_QWORD 0x00000040")]
        public const int RRF_RT_REG_QWORD = 0x00000040;

        [NativeTypeName("#define RRF_RT_DWORD (RRF_RT_REG_BINARY | RRF_RT_REG_DWORD)")]
        public const int RRF_RT_DWORD = (0x00000008 | 0x00000010);

        [NativeTypeName("#define RRF_RT_QWORD (RRF_RT_REG_BINARY | RRF_RT_REG_QWORD)")]
        public const int RRF_RT_QWORD = (0x00000008 | 0x00000040);

        [NativeTypeName("#define RRF_RT_ANY 0x0000ffff")]
        public const int RRF_RT_ANY = 0x0000ffff;

        [NativeTypeName("#define RRF_SUBKEY_WOW6464KEY 0x00010000")]
        public const int RRF_SUBKEY_WOW6464KEY = 0x00010000;

        [NativeTypeName("#define RRF_SUBKEY_WOW6432KEY 0x00020000")]
        public const int RRF_SUBKEY_WOW6432KEY = 0x00020000;

        [NativeTypeName("#define RRF_WOW64_MASK 0x00030000")]
        public const int RRF_WOW64_MASK = 0x00030000;

        [NativeTypeName("#define RRF_NOEXPAND 0x10000000")]
        public const int RRF_NOEXPAND = 0x10000000;

        [NativeTypeName("#define RRF_ZEROONFAILURE 0x20000000")]
        public const int RRF_ZEROONFAILURE = 0x20000000;

        [NativeTypeName("#define REG_PROCESS_APPKEY 0x00000001")]
        public const int REG_PROCESS_APPKEY = 0x00000001;

        [NativeTypeName("#define REG_USE_CURRENT_SECURITY_CONTEXT 0x00000002")]
        public const int REG_USE_CURRENT_SECURITY_CONTEXT = 0x00000002;

        [NativeTypeName("#define HKEY_CLASSES_ROOT (( HKEY ) (ULONG_PTR)((LONG)0x80000000) )")]
        public static IntPtr HKEY_CLASSES_ROOT => unchecked((nint)((nuint)((int)(0x80000000))));

        [NativeTypeName("#define HKEY_CURRENT_USER (( HKEY ) (ULONG_PTR)((LONG)0x80000001) )")]
        public static IntPtr HKEY_CURRENT_USER => unchecked((nint)((nuint)((int)(0x80000001))));

        [NativeTypeName("#define HKEY_LOCAL_MACHINE (( HKEY ) (ULONG_PTR)((LONG)0x80000002) )")]
        public static IntPtr HKEY_LOCAL_MACHINE => unchecked((nint)((nuint)((int)(0x80000002))));

        [NativeTypeName("#define HKEY_USERS (( HKEY ) (ULONG_PTR)((LONG)0x80000003) )")]
        public static IntPtr HKEY_USERS => unchecked((nint)((nuint)((int)(0x80000003))));

        [NativeTypeName("#define HKEY_PERFORMANCE_DATA (( HKEY ) (ULONG_PTR)((LONG)0x80000004) )")]
        public static IntPtr HKEY_PERFORMANCE_DATA => unchecked((nint)((nuint)((int)(0x80000004))));

        [NativeTypeName("#define HKEY_PERFORMANCE_TEXT (( HKEY ) (ULONG_PTR)((LONG)0x80000050) )")]
        public static IntPtr HKEY_PERFORMANCE_TEXT => unchecked((nint)((nuint)((int)(0x80000050))));

        [NativeTypeName("#define HKEY_PERFORMANCE_NLSTEXT (( HKEY ) (ULONG_PTR)((LONG)0x80000060) )")]
        public static IntPtr HKEY_PERFORMANCE_NLSTEXT => unchecked((nint)((nuint)((int)(0x80000060))));

        [NativeTypeName("#define HKEY_CURRENT_CONFIG (( HKEY ) (ULONG_PTR)((LONG)0x80000005) )")]
        public static IntPtr HKEY_CURRENT_CONFIG => unchecked((nint)((nuint)((int)(0x80000005))));

        [NativeTypeName("#define HKEY_DYN_DATA (( HKEY ) (ULONG_PTR)((LONG)0x80000006) )")]
        public static IntPtr HKEY_DYN_DATA => unchecked((nint)((nuint)((int)(0x80000006))));

        [NativeTypeName("#define HKEY_CURRENT_USER_LOCAL_SETTINGS (( HKEY ) (ULONG_PTR)((LONG)0x80000007) )")]
        public static IntPtr HKEY_CURRENT_USER_LOCAL_SETTINGS => unchecked((nint)((nuint)((int)(0x80000007))));

        [NativeTypeName("#define PROVIDER_KEEPS_VALUE_LENGTH 0x1")]
        public const int PROVIDER_KEEPS_VALUE_LENGTH = 0x1;

        [NativeTypeName("#define WIN31_CLASS NULL")]
        public const int WIN31_CLASS = 0;

        [NativeTypeName("#define REG_MUI_STRING_TRUNCATE 0x00000001")]
        public const int REG_MUI_STRING_TRUNCATE = 0x00000001;

        [NativeTypeName("#define REG_SECURE_CONNECTION 1")]
        public const int REG_SECURE_CONNECTION = 1;

        [NativeTypeName("#define RegConnectRegistry RegConnectRegistryW")]
        public static delegate*<ushort*, IntPtr, IntPtr*, int> RegConnectRegistry => &RegConnectRegistryW;

        [NativeTypeName("#define RegConnectRegistryEx RegConnectRegistryExW")]
        public static delegate*<ushort*, IntPtr, uint, IntPtr*, int> RegConnectRegistryEx => &RegConnectRegistryExW;

        [NativeTypeName("#define RegCreateKey RegCreateKeyW")]
        public static delegate*<IntPtr, ushort*, IntPtr*, int> RegCreateKey => &RegCreateKeyW;

        [NativeTypeName("#define RegCreateKeyEx RegCreateKeyExW")]
        public static delegate*<IntPtr, ushort*, uint, ushort*, uint, uint, SECURITY_ATTRIBUTES*, IntPtr*, uint*, int> RegCreateKeyEx => &RegCreateKeyExW;

        [NativeTypeName("#define RegCreateKeyTransacted RegCreateKeyTransactedW")]
        public static delegate*<IntPtr, ushort*, uint, ushort*, uint, uint, SECURITY_ATTRIBUTES*, IntPtr*, uint*, IntPtr, void*, int> RegCreateKeyTransacted => &RegCreateKeyTransactedW;

        [NativeTypeName("#define RegDeleteKey RegDeleteKeyW")]
        public static delegate*<IntPtr, ushort*, int> RegDeleteKey => &RegDeleteKeyW;

        [NativeTypeName("#define RegDeleteKeyEx RegDeleteKeyExW")]
        public static delegate*<IntPtr, ushort*, uint, uint, int> RegDeleteKeyEx => &RegDeleteKeyExW;

        [NativeTypeName("#define RegDeleteKeyTransacted RegDeleteKeyTransactedW")]
        public static delegate*<IntPtr, ushort*, uint, uint, IntPtr, void*, int> RegDeleteKeyTransacted => &RegDeleteKeyTransactedW;

        [NativeTypeName("#define RegDeleteValue RegDeleteValueW")]
        public static delegate*<IntPtr, ushort*, int> RegDeleteValue => &RegDeleteValueW;

        [NativeTypeName("#define RegEnumKey RegEnumKeyW")]
        public static delegate*<IntPtr, uint, ushort*, uint, int> RegEnumKey => &RegEnumKeyW;

        [NativeTypeName("#define RegEnumKeyEx RegEnumKeyExW")]
        public static delegate*<IntPtr, uint, ushort*, uint*, uint*, ushort*, uint*, FILETIME*, int> RegEnumKeyEx => &RegEnumKeyExW;

        [NativeTypeName("#define RegEnumValue RegEnumValueW")]
        public static delegate*<IntPtr, uint, ushort*, uint*, uint*, uint*, byte*, uint*, int> RegEnumValue => &RegEnumValueW;

        [NativeTypeName("#define RegLoadKey RegLoadKeyW")]
        public static delegate*<IntPtr, ushort*, ushort*, int> RegLoadKey => &RegLoadKeyW;

        [NativeTypeName("#define RegOpenKey RegOpenKeyW")]
        public static delegate*<IntPtr, ushort*, IntPtr*, int> RegOpenKey => &RegOpenKeyW;

        [NativeTypeName("#define RegOpenKeyEx RegOpenKeyExW")]
        public static delegate*<IntPtr, ushort*, uint, uint, IntPtr*, int> RegOpenKeyEx => &RegOpenKeyExW;

        [NativeTypeName("#define RegOpenKeyTransacted RegOpenKeyTransactedW")]
        public static delegate*<IntPtr, ushort*, uint, uint, IntPtr*, IntPtr, void*, int> RegOpenKeyTransacted => &RegOpenKeyTransactedW;

        [NativeTypeName("#define RegQueryInfoKey RegQueryInfoKeyW")]
        public static delegate*<IntPtr, ushort*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, FILETIME*, int> RegQueryInfoKey => &RegQueryInfoKeyW;

        [NativeTypeName("#define RegQueryValue RegQueryValueW")]
        public static delegate*<IntPtr, ushort*, ushort*, int*, int> RegQueryValue => &RegQueryValueW;

        [NativeTypeName("#define RegQueryMultipleValues RegQueryMultipleValuesW")]
        public static delegate*<IntPtr, VALENTW*, uint, ushort*, uint*, int> RegQueryMultipleValues => &RegQueryMultipleValuesW;

        [NativeTypeName("#define RegQueryValueEx RegQueryValueExW")]
        public static delegate*<IntPtr, ushort*, uint*, uint*, byte*, uint*, int> RegQueryValueEx => &RegQueryValueExW;

        [NativeTypeName("#define RegReplaceKey RegReplaceKeyW")]
        public static delegate*<IntPtr, ushort*, ushort*, ushort*, int> RegReplaceKey => &RegReplaceKeyW;

        [NativeTypeName("#define RegRestoreKey RegRestoreKeyW")]
        public static delegate*<IntPtr, ushort*, uint, int> RegRestoreKey => &RegRestoreKeyW;

        [NativeTypeName("#define RegSaveKey RegSaveKeyW")]
        public static delegate*<IntPtr, ushort*, SECURITY_ATTRIBUTES*, int> RegSaveKey => &RegSaveKeyW;

        [NativeTypeName("#define RegSetValue RegSetValueW")]
        public static delegate*<IntPtr, ushort*, uint, ushort*, uint, int> RegSetValue => &RegSetValueW;

        [NativeTypeName("#define RegSetValueEx RegSetValueExW")]
        public static delegate*<IntPtr, ushort*, uint, uint, byte*, uint, int> RegSetValueEx => &RegSetValueExW;

        [NativeTypeName("#define RegUnLoadKey RegUnLoadKeyW")]
        public static delegate*<IntPtr, ushort*, int> RegUnLoadKey => &RegUnLoadKeyW;

        [NativeTypeName("#define RegDeleteKeyValue RegDeleteKeyValueW")]
        public static delegate*<IntPtr, ushort*, ushort*, int> RegDeleteKeyValue => &RegDeleteKeyValueW;

        [NativeTypeName("#define RegSetKeyValue RegSetKeyValueW")]
        public static delegate*<IntPtr, ushort*, ushort*, uint, void*, uint, int> RegSetKeyValue => &RegSetKeyValueW;

        [NativeTypeName("#define RegDeleteTree RegDeleteTreeW")]
        public static delegate*<IntPtr, ushort*, int> RegDeleteTree => &RegDeleteTreeW;

        [NativeTypeName("#define RegGetValue RegGetValueW")]
        public static delegate*<IntPtr, ushort*, ushort*, uint, uint*, void*, uint*, int> RegGetValue => &RegGetValueW;

        [NativeTypeName("#define RegCopyTree RegCopyTreeW")]
        public static delegate*<IntPtr, ushort*, IntPtr, int> RegCopyTree => &RegCopyTreeW;

        [NativeTypeName("#define RegLoadMUIString RegLoadMUIStringW")]
        public static delegate*<IntPtr, ushort*, ushort*, uint, uint*, uint, ushort*, int> RegLoadMUIString => &RegLoadMUIStringW;

        [NativeTypeName("#define RegLoadAppKey RegLoadAppKeyW")]
        public static delegate*<ushort*, IntPtr*, uint, uint, uint, int> RegLoadAppKey => &RegLoadAppKeyW;

        [NativeTypeName("#define InitiateSystemShutdown InitiateSystemShutdownW")]
        public static delegate*<ushort*, ushort*, uint, BOOL, BOOL, BOOL> InitiateSystemShutdown => &InitiateSystemShutdownW;

        [NativeTypeName("#define AbortSystemShutdown AbortSystemShutdownW")]
        public static delegate*<ushort*, BOOL> AbortSystemShutdown => &AbortSystemShutdownW;

        [NativeTypeName("#define REASON_SWINSTALL (SHTDN_REASON_MAJOR_SOFTWARE|SHTDN_REASON_MINOR_INSTALLATION)")]
        public const int REASON_SWINSTALL = (0x00030000 | 0x00000002);

        [NativeTypeName("#define REASON_HWINSTALL (SHTDN_REASON_MAJOR_HARDWARE|SHTDN_REASON_MINOR_INSTALLATION)")]
        public const int REASON_HWINSTALL = (0x00010000 | 0x00000002);

        [NativeTypeName("#define REASON_SERVICEHANG (SHTDN_REASON_MAJOR_SOFTWARE|SHTDN_REASON_MINOR_HUNG)")]
        public const int REASON_SERVICEHANG = (0x00030000 | 0x00000005);

        [NativeTypeName("#define REASON_UNSTABLE (SHTDN_REASON_MAJOR_SYSTEM|SHTDN_REASON_MINOR_UNSTABLE)")]
        public const int REASON_UNSTABLE = (0x00050000 | 0x00000006);

        [NativeTypeName("#define REASON_SWHWRECONF (SHTDN_REASON_MAJOR_SOFTWARE|SHTDN_REASON_MINOR_RECONFIG)")]
        public const int REASON_SWHWRECONF = (0x00030000 | 0x00000004);

        [NativeTypeName("#define REASON_OTHER (SHTDN_REASON_MAJOR_OTHER|SHTDN_REASON_MINOR_OTHER)")]
        public const int REASON_OTHER = (0x00000000 | 0x00000000);

        [NativeTypeName("#define REASON_UNKNOWN SHTDN_REASON_UNKNOWN")]
        public const int REASON_UNKNOWN = 0x000000ff;

        [NativeTypeName("#define REASON_LEGACY_API SHTDN_REASON_LEGACY_API")]
        public const uint REASON_LEGACY_API = (0x00070000 | 0x80000000);

        [NativeTypeName("#define REASON_PLANNED_FLAG SHTDN_REASON_FLAG_PLANNED")]
        public const uint REASON_PLANNED_FLAG = 0x80000000;

        [NativeTypeName("#define MAX_SHUTDOWN_TIMEOUT (10*365*24*60*60)")]
        public const int MAX_SHUTDOWN_TIMEOUT = (10 * 365 * 24 * 60 * 60);

        [NativeTypeName("#define InitiateSystemShutdownEx InitiateSystemShutdownExW")]
        public static delegate*<ushort*, ushort*, uint, BOOL, BOOL, uint, BOOL> InitiateSystemShutdownEx => &InitiateSystemShutdownExW;

        [NativeTypeName("#define SHUTDOWN_FORCE_OTHERS 0x00000001")]
        public const int SHUTDOWN_FORCE_OTHERS = 0x00000001;

        [NativeTypeName("#define SHUTDOWN_FORCE_SELF 0x00000002")]
        public const int SHUTDOWN_FORCE_SELF = 0x00000002;

        [NativeTypeName("#define SHUTDOWN_RESTART 0x00000004")]
        public const int SHUTDOWN_RESTART = 0x00000004;

        [NativeTypeName("#define SHUTDOWN_POWEROFF 0x00000008")]
        public const int SHUTDOWN_POWEROFF = 0x00000008;

        [NativeTypeName("#define SHUTDOWN_NOREBOOT 0x00000010")]
        public const int SHUTDOWN_NOREBOOT = 0x00000010;

        [NativeTypeName("#define SHUTDOWN_GRACE_OVERRIDE 0x00000020")]
        public const int SHUTDOWN_GRACE_OVERRIDE = 0x00000020;

        [NativeTypeName("#define SHUTDOWN_INSTALL_UPDATES 0x00000040")]
        public const int SHUTDOWN_INSTALL_UPDATES = 0x00000040;

        [NativeTypeName("#define SHUTDOWN_RESTARTAPPS 0x00000080")]
        public const int SHUTDOWN_RESTARTAPPS = 0x00000080;

        [NativeTypeName("#define SHUTDOWN_SKIP_SVC_PRESHUTDOWN 0x00000100")]
        public const int SHUTDOWN_SKIP_SVC_PRESHUTDOWN = 0x00000100;

        [NativeTypeName("#define SHUTDOWN_HYBRID 0x00000200")]
        public const int SHUTDOWN_HYBRID = 0x00000200;

        [NativeTypeName("#define SHUTDOWN_RESTART_BOOTOPTIONS 0x00000400")]
        public const int SHUTDOWN_RESTART_BOOTOPTIONS = 0x00000400;

        [NativeTypeName("#define SHUTDOWN_SOFT_REBOOT 0x00000800")]
        public const int SHUTDOWN_SOFT_REBOOT = 0x00000800;

        [NativeTypeName("#define SHUTDOWN_MOBILE_UI 0x00001000")]
        public const int SHUTDOWN_MOBILE_UI = 0x00001000;

        [NativeTypeName("#define SHUTDOWN_ARSO 0x00002000")]
        public const int SHUTDOWN_ARSO = 0x00002000;

        [NativeTypeName("#define SHUTDOWN_CHECK_SAFE_FOR_SERVER 0x00004000")]
        public const int SHUTDOWN_CHECK_SAFE_FOR_SERVER = 0x00004000;

        [NativeTypeName("#define SHUTDOWN_VAIL_CONTAINER 0x00008000")]
        public const int SHUTDOWN_VAIL_CONTAINER = 0x00008000;

        [NativeTypeName("#define InitiateShutdown InitiateShutdownW")]
        public static delegate*<ushort*, ushort*, uint, uint, uint, uint> InitiateShutdown => &InitiateShutdownW;

        [NativeTypeName("#define RegSaveKeyEx RegSaveKeyExW")]
        public static delegate*<IntPtr, ushort*, SECURITY_ATTRIBUTES*, uint, int> RegSaveKeyEx => &RegSaveKeyExW;
    }
}
