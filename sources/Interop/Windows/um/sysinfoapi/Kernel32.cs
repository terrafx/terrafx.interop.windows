// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sysinfoapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Kernel32
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GlobalMemoryStatusEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GlobalMemoryStatusEx([NativeTypeName("LPMEMORYSTATUSEX")] MEMORYSTATUSEX* lpBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemInfo", ExactSpelling = true)]
        public static extern void GetSystemInfo([NativeTypeName("LPSYSTEM_INFO")] SYSTEM_INFO* lpSystemInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemTime", ExactSpelling = true)]
        public static extern void GetSystemTime([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpSystemTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemTimeAsFileTime", ExactSpelling = true)]
        public static extern void GetSystemTimeAsFileTime([NativeTypeName("LPFILETIME")] FILETIME* lpSystemTimeAsFileTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLocalTime", ExactSpelling = true)]
        public static extern void GetLocalTime([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpSystemTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemLeapSecondInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemLeapSecondInformation([NativeTypeName("PBOOL")] int* Enabled, [NativeTypeName("PDWORD")] uint* Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetVersion", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetVersion();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetLocalTime", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetLocalTime([NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* lpSystemTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTickCount", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTickCount();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTickCount64", ExactSpelling = true)]
        [return: NativeTypeName("ULONGLONG")]
        public static extern ulong GetTickCount64();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemTimeAdjustment", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemTimeAdjustment([NativeTypeName("PDWORD")] uint* lpTimeAdjustment, [NativeTypeName("PDWORD")] uint* lpTimeIncrement, [NativeTypeName("PBOOL")] int* lpTimeAdjustmentDisabled);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemTimeAdjustmentPrecise", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemTimeAdjustmentPrecise([NativeTypeName("PDWORD64")] ulong* lpTimeAdjustment, [NativeTypeName("PDWORD64")] ulong* lpTimeIncrement, [NativeTypeName("PBOOL")] int* lpTimeAdjustmentDisabled);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemDirectoryA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemDirectoryA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("UINT")] uint uSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemDirectoryW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemDirectoryW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("UINT")] uint uSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowsDirectoryA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWindowsDirectoryA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("UINT")] uint uSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowsDirectoryW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWindowsDirectoryW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("UINT")] uint uSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemWindowsDirectoryA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemWindowsDirectoryA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("UINT")] uint uSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemWindowsDirectoryW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemWindowsDirectoryW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("UINT")] uint uSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetComputerNameExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComputerNameExA(COMPUTER_NAME_FORMAT NameType, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetComputerNameExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComputerNameExW(COMPUTER_NAME_FORMAT NameType, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetComputerNameExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetComputerNameExW(COMPUTER_NAME_FORMAT NameType, [NativeTypeName("LPCWSTR")] ushort* lpBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetSystemTime", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemTime([NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* lpSystemTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetVersionExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVersionExA([NativeTypeName("LPOSVERSIONINFOA")] OSVERSIONINFOA* lpVersionInformation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetVersionExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVersionExW([NativeTypeName("LPOSVERSIONINFOW")] OSVERSIONINFOW* lpVersionInformation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLogicalProcessorInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLogicalProcessorInformation([NativeTypeName("PSYSTEM_LOGICAL_PROCESSOR_INFORMATION")] SYSTEM_LOGICAL_PROCESSOR_INFORMATION* Buffer, [NativeTypeName("PDWORD")] uint* ReturnedLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLogicalProcessorInformationEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLogicalProcessorInformationEx(LOGICAL_PROCESSOR_RELATIONSHIP RelationshipType, [NativeTypeName("PSYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX")] SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX* Buffer, [NativeTypeName("PDWORD")] uint* ReturnedLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetNativeSystemInfo", ExactSpelling = true)]
        public static extern void GetNativeSystemInfo([NativeTypeName("LPSYSTEM_INFO")] SYSTEM_INFO* lpSystemInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemTimePreciseAsFileTime", ExactSpelling = true)]
        public static extern void GetSystemTimePreciseAsFileTime([NativeTypeName("LPFILETIME")] FILETIME* lpSystemTimeAsFileTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProductInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProductInfo([NativeTypeName("DWORD")] uint dwOSMajorVersion, [NativeTypeName("DWORD")] uint dwOSMinorVersion, [NativeTypeName("DWORD")] uint dwSpMajorVersion, [NativeTypeName("DWORD")] uint dwSpMinorVersion, [NativeTypeName("PDWORD")] uint* pdwReturnedProductType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "VerSetConditionMask", ExactSpelling = true)]
        [return: NativeTypeName("ULONGLONG")]
        public static extern ulong VerSetConditionMask([NativeTypeName("ULONGLONG")] ulong ConditionMask, [NativeTypeName("ULONG")] uint TypeMask, [NativeTypeName("UCHAR")] byte Condition);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetOsSafeBootMode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetOsSafeBootMode([NativeTypeName("PDWORD")] uint* Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumSystemFirmwareTables", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint EnumSystemFirmwareTables([NativeTypeName("DWORD")] uint FirmwareTableProviderSignature, [NativeTypeName("PVOID")] void* pFirmwareTableEnumBuffer, [NativeTypeName("DWORD")] uint BufferSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemFirmwareTable", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemFirmwareTable([NativeTypeName("DWORD")] uint FirmwareTableProviderSignature, [NativeTypeName("DWORD")] uint FirmwareTableID, [NativeTypeName("PVOID")] void* pFirmwareTableBuffer, [NativeTypeName("DWORD")] uint BufferSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DnsHostnameToComputerNameExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DnsHostnameToComputerNameExW([NativeTypeName("LPCWSTR")] ushort* Hostname, [NativeTypeName("LPWSTR")] ushort* ComputerName, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPhysicallyInstalledSystemMemory", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPhysicallyInstalledSystemMemory([NativeTypeName("PULONGLONG")] ulong* TotalMemoryInKilobytes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetComputerNameEx2W", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetComputerNameEx2W(COMPUTER_NAME_FORMAT NameType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPCWSTR")] ushort* lpBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetSystemTimeAdjustment", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemTimeAdjustment([NativeTypeName("DWORD")] uint dwTimeAdjustment, [NativeTypeName("BOOL")] int bTimeAdjustmentDisabled);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetSystemTimeAdjustmentPrecise", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemTimeAdjustmentPrecise([NativeTypeName("DWORD64")] ulong dwTimeAdjustment, [NativeTypeName("BOOL")] int bTimeAdjustmentDisabled);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InstallELAMCertificateInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InstallELAMCertificateInfo([NativeTypeName("HANDLE")] IntPtr ELAMFile);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessorSystemCycleTime", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessorSystemCycleTime([NativeTypeName("USHORT")] ushort Group, [NativeTypeName("PSYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION")] SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION* Buffer, [NativeTypeName("PDWORD")] uint* ReturnedLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetOsManufacturingMode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetOsManufacturingMode([NativeTypeName("PBOOL")] int* pbEnabled);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetIntegratedDisplaySize", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetIntegratedDisplaySize([NativeTypeName("double *")] double* sizeInInches);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetComputerNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetComputerNameA([NativeTypeName("LPCSTR")] sbyte* lpComputerName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetComputerNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetComputerNameW([NativeTypeName("LPCWSTR")] ushort* lpComputerName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetComputerNameExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetComputerNameExA(COMPUTER_NAME_FORMAT NameType, [NativeTypeName("LPCSTR")] sbyte* lpBuffer);
    }
}
