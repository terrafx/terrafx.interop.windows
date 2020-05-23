// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sysinfoapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", EntryPoint = "GlobalMemoryStatusEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GlobalMemoryStatusEx([NativeTypeName("LPMEMORYSTATUSEX")] MEMORYSTATUSEX* lpBuffer);

        [DllImport("kernel32", EntryPoint = "GetSystemInfo", ExactSpelling = true)]
        public static extern void GetSystemInfo([NativeTypeName("LPSYSTEM_INFO")] SYSTEM_INFO* lpSystemInfo);

        [DllImport("kernel32", EntryPoint = "GetSystemTime", ExactSpelling = true)]
        public static extern void GetSystemTime([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpSystemTime);

        [DllImport("kernel32", EntryPoint = "GetSystemTimeAsFileTime", ExactSpelling = true)]
        public static extern void GetSystemTimeAsFileTime([NativeTypeName("LPFILETIME")] FILETIME* lpSystemTimeAsFileTime);

        [DllImport("kernel32", EntryPoint = "GetLocalTime", ExactSpelling = true)]
        public static extern void GetLocalTime([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpSystemTime);

        [DllImport("kernel32", EntryPoint = "IsUserCetAvailableInEnvironment", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsUserCetAvailableInEnvironment([NativeTypeName("DWORD")] uint UserCetEnvironment);

        [DllImport("kernel32", EntryPoint = "GetSystemLeapSecondInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemLeapSecondInformation([NativeTypeName("PBOOL")] int* Enabled, [NativeTypeName("PDWORD")] uint* Flags);

        [DllImport("kernel32", EntryPoint = "GetVersion", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetVersion();

        [DllImport("kernel32", EntryPoint = "SetLocalTime", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetLocalTime([NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* lpSystemTime);

        [DllImport("kernel32", EntryPoint = "GetTickCount", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTickCount();

        [DllImport("kernel32", EntryPoint = "GetTickCount64", ExactSpelling = true)]
        [return: NativeTypeName("ULONGLONG")]
        public static extern ulong GetTickCount64();

        [DllImport("kernel32", EntryPoint = "GetSystemTimeAdjustment", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemTimeAdjustment([NativeTypeName("PDWORD")] uint* lpTimeAdjustment, [NativeTypeName("PDWORD")] uint* lpTimeIncrement, [NativeTypeName("PBOOL")] int* lpTimeAdjustmentDisabled);

        [DllImport("api-ms-win-core-version-l1-2-3", EntryPoint = "GetSystemTimeAdjustmentPrecise", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemTimeAdjustmentPrecise([NativeTypeName("PDWORD64")] ulong* lpTimeAdjustment, [NativeTypeName("PDWORD64")] ulong* lpTimeIncrement, [NativeTypeName("PBOOL")] int* lpTimeAdjustmentDisabled);

        [DllImport("kernel32", EntryPoint = "GetSystemDirectoryA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemDirectoryA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("UINT")] uint uSize);

        [DllImport("kernel32", EntryPoint = "GetSystemDirectoryW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemDirectoryW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("UINT")] uint uSize);

        [DllImport("kernel32", EntryPoint = "GetWindowsDirectoryA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWindowsDirectoryA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("UINT")] uint uSize);

        [DllImport("kernel32", EntryPoint = "GetWindowsDirectoryW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWindowsDirectoryW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("UINT")] uint uSize);

        [DllImport("kernel32", EntryPoint = "GetSystemWindowsDirectoryA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemWindowsDirectoryA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("UINT")] uint uSize);

        [DllImport("kernel32", EntryPoint = "GetSystemWindowsDirectoryW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemWindowsDirectoryW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("UINT")] uint uSize);

        [DllImport("kernel32", EntryPoint = "GetComputerNameExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComputerNameExA(COMPUTER_NAME_FORMAT NameType, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport("kernel32", EntryPoint = "GetComputerNameExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComputerNameExW(COMPUTER_NAME_FORMAT NameType, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport("kernel32", EntryPoint = "SetComputerNameExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetComputerNameExW(COMPUTER_NAME_FORMAT NameType, [NativeTypeName("LPCWSTR")] ushort* lpBuffer);

        [DllImport("kernel32", EntryPoint = "SetSystemTime", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemTime([NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* lpSystemTime);

        [DllImport("kernel32", EntryPoint = "GetVersionExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVersionExA([NativeTypeName("LPOSVERSIONINFOA")] OSVERSIONINFOA* lpVersionInformation);

        [DllImport("kernel32", EntryPoint = "GetVersionExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVersionExW([NativeTypeName("LPOSVERSIONINFOW")] OSVERSIONINFOW* lpVersionInformation);

        [DllImport("kernel32", EntryPoint = "GetLogicalProcessorInformation", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLogicalProcessorInformation([NativeTypeName("PSYSTEM_LOGICAL_PROCESSOR_INFORMATION")] SYSTEM_LOGICAL_PROCESSOR_INFORMATION* Buffer, [NativeTypeName("PDWORD")] uint* ReturnedLength);

        [DllImport("kernel32", EntryPoint = "GetLogicalProcessorInformationEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLogicalProcessorInformationEx(LOGICAL_PROCESSOR_RELATIONSHIP RelationshipType, [NativeTypeName("PSYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX")] SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX* Buffer, [NativeTypeName("PDWORD")] uint* ReturnedLength);

        [DllImport("kernel32", EntryPoint = "GetNativeSystemInfo", ExactSpelling = true)]
        public static extern void GetNativeSystemInfo([NativeTypeName("LPSYSTEM_INFO")] SYSTEM_INFO* lpSystemInfo);

        [DllImport("kernel32", EntryPoint = "GetSystemTimePreciseAsFileTime", ExactSpelling = true)]
        public static extern void GetSystemTimePreciseAsFileTime([NativeTypeName("LPFILETIME")] FILETIME* lpSystemTimeAsFileTime);

        [DllImport("kernel32", EntryPoint = "GetProductInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProductInfo([NativeTypeName("DWORD")] uint dwOSMajorVersion, [NativeTypeName("DWORD")] uint dwOSMinorVersion, [NativeTypeName("DWORD")] uint dwSpMajorVersion, [NativeTypeName("DWORD")] uint dwSpMinorVersion, [NativeTypeName("PDWORD")] uint* pdwReturnedProductType);

        [DllImport("kernel32", EntryPoint = "VerSetConditionMask", ExactSpelling = true)]
        [return: NativeTypeName("ULONGLONG")]
        public static extern ulong VerSetConditionMask([NativeTypeName("ULONGLONG")] ulong ConditionMask, [NativeTypeName("ULONG")] uint TypeMask, [NativeTypeName("UCHAR")] byte Condition);

        [DllImport("kernel32", EntryPoint = "GetOsSafeBootMode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetOsSafeBootMode([NativeTypeName("PDWORD")] uint* Flags);

        [DllImport("kernel32", EntryPoint = "EnumSystemFirmwareTables", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint EnumSystemFirmwareTables([NativeTypeName("DWORD")] uint FirmwareTableProviderSignature, [NativeTypeName("PVOID")] void* pFirmwareTableEnumBuffer, [NativeTypeName("DWORD")] uint BufferSize);

        [DllImport("kernel32", EntryPoint = "GetSystemFirmwareTable", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemFirmwareTable([NativeTypeName("DWORD")] uint FirmwareTableProviderSignature, [NativeTypeName("DWORD")] uint FirmwareTableID, [NativeTypeName("PVOID")] void* pFirmwareTableBuffer, [NativeTypeName("DWORD")] uint BufferSize);

        [DllImport("kernel32", EntryPoint = "DnsHostnameToComputerNameExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DnsHostnameToComputerNameExW([NativeTypeName("LPCWSTR")] ushort* Hostname, [NativeTypeName("LPWSTR")] ushort* ComputerName, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport("kernel32", EntryPoint = "GetPhysicallyInstalledSystemMemory", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPhysicallyInstalledSystemMemory([NativeTypeName("PULONGLONG")] ulong* TotalMemoryInKilobytes);

        [DllImport("kernel32", EntryPoint = "SetComputerNameEx2W", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetComputerNameEx2W(COMPUTER_NAME_FORMAT NameType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPCWSTR")] ushort* lpBuffer);

        [DllImport("kernel32", EntryPoint = "SetSystemTimeAdjustment", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemTimeAdjustment([NativeTypeName("DWORD")] uint dwTimeAdjustment, [NativeTypeName("BOOL")] int bTimeAdjustmentDisabled);

        [DllImport("api-ms-win-core-version-l1-2-3", EntryPoint = "SetSystemTimeAdjustmentPrecise", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemTimeAdjustmentPrecise([NativeTypeName("DWORD64")] ulong dwTimeAdjustment, [NativeTypeName("BOOL")] int bTimeAdjustmentDisabled);

        [DllImport("kernel32", EntryPoint = "InstallELAMCertificateInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InstallELAMCertificateInfo([NativeTypeName("HANDLE")] IntPtr ELAMFile);

        [DllImport("kernel32", EntryPoint = "GetProcessorSystemCycleTime", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessorSystemCycleTime([NativeTypeName("USHORT")] ushort Group, [NativeTypeName("PSYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION")] SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION* Buffer, [NativeTypeName("PDWORD")] uint* ReturnedLength);

        [DllImport("kernel32", EntryPoint = "GetOsManufacturingMode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetOsManufacturingMode([NativeTypeName("PBOOL")] int* pbEnabled);

        [DllImport("KernelBase", EntryPoint = "GetIntegratedDisplaySize", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetIntegratedDisplaySize([NativeTypeName("double *")] double* sizeInInches);

        [DllImport("kernel32", EntryPoint = "SetComputerNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetComputerNameA([NativeTypeName("LPCSTR")] sbyte* lpComputerName);

        [DllImport("kernel32", EntryPoint = "SetComputerNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetComputerNameW([NativeTypeName("LPCWSTR")] ushort* lpComputerName);

        [DllImport("kernel32", EntryPoint = "SetComputerNameExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetComputerNameExA(COMPUTER_NAME_FORMAT NameType, [NativeTypeName("LPCSTR")] sbyte* lpBuffer);
    }
}
