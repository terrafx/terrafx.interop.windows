// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32EnumProcesses([NativeTypeName("DWORD *")] uint* lpidProcess, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* lpcbNeeded);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32EnumProcessModules([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("HMODULE *")] IntPtr* lphModule, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* lpcbNeeded);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32EnumProcessModulesEx([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("HMODULE *")] IntPtr* lphModule, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* lpcbNeeded, [NativeTypeName("DWORD")] uint dwFilterFlag);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint K32GetModuleBaseNameA([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPSTR")] sbyte* lpBaseName, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint K32GetModuleBaseNameW([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPWSTR")] ushort* lpBaseName, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint K32GetModuleFileNameExA([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint K32GetModuleFileNameExW([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPWSTR")] ushort* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32GetModuleInformation([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPMODULEINFO")] MODULEINFO* lpmodinfo, [NativeTypeName("DWORD")] uint cb);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32EmptyWorkingSet([NativeTypeName("HANDLE")] IntPtr hProcess);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32QueryWorkingSet([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PVOID")] void* pv, [NativeTypeName("DWORD")] uint cb);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32QueryWorkingSetEx([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PVOID")] void* pv, [NativeTypeName("DWORD")] uint cb);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32InitializeProcessForWsWatch([NativeTypeName("HANDLE")] IntPtr hProcess);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32GetWsChanges([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PPSAPI_WS_WATCH_INFORMATION")] PSAPI_WS_WATCH_INFORMATION* lpWatchInfo, [NativeTypeName("DWORD")] uint cb);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32GetWsChangesEx([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PPSAPI_WS_WATCH_INFORMATION_EX")] PSAPI_WS_WATCH_INFORMATION_EX* lpWatchInfoEx, [NativeTypeName("PDWORD")] uint* cb);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint K32GetMappedFileNameW([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPVOID")] void* lpv, [NativeTypeName("LPWSTR")] ushort* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint K32GetMappedFileNameA([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPVOID")] void* lpv, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32EnumDeviceDrivers([NativeTypeName("LPVOID *")] void** lpImageBase, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* lpcbNeeded);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint K32GetDeviceDriverBaseNameA([NativeTypeName("LPVOID")] void* ImageBase, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint K32GetDeviceDriverBaseNameW([NativeTypeName("LPVOID")] void* ImageBase, [NativeTypeName("LPWSTR")] ushort* lpBaseName, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint K32GetDeviceDriverFileNameA([NativeTypeName("LPVOID")] void* ImageBase, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint K32GetDeviceDriverFileNameW([NativeTypeName("LPVOID")] void* ImageBase, [NativeTypeName("LPWSTR")] ushort* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32GetProcessMemoryInfo([NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("PPROCESS_MEMORY_COUNTERS")] PROCESS_MEMORY_COUNTERS* ppsmemCounters, [NativeTypeName("DWORD")] uint cb);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32GetPerformanceInfo([NativeTypeName("PPERFORMANCE_INFORMATION")] PERFORMANCE_INFORMATION* pPerformanceInformation, [NativeTypeName("DWORD")] uint cb);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32EnumPageFilesW([NativeTypeName("PENUM_PAGE_FILE_CALLBACKW")] delegate* unmanaged<void*, ENUM_PAGE_FILE_INFORMATION*, ushort*, int> pCallBackRoutine, [NativeTypeName("LPVOID")] void* pContext);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int K32EnumPageFilesA([NativeTypeName("PENUM_PAGE_FILE_CALLBACKA")] delegate* unmanaged<void*, ENUM_PAGE_FILE_INFORMATION*, sbyte*, int> pCallBackRoutine, [NativeTypeName("LPVOID")] void* pContext);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint K32GetProcessImageFileNameA([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPSTR")] sbyte* lpImageFileName, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint K32GetProcessImageFileNameW([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPWSTR")] ushort* lpImageFileName, [NativeTypeName("DWORD")] uint nSize);

        [NativeTypeName("#define LIST_MODULES_DEFAULT 0x0")]
        public const int LIST_MODULES_DEFAULT = 0x0;

        [NativeTypeName("#define LIST_MODULES_32BIT 0x01")]
        public const int LIST_MODULES_32BIT = 0x01;

        [NativeTypeName("#define LIST_MODULES_64BIT 0x02")]
        public const int LIST_MODULES_64BIT = 0x02;

        [NativeTypeName("#define LIST_MODULES_ALL (LIST_MODULES_32BIT | LIST_MODULES_64BIT)")]
        public const int LIST_MODULES_ALL = (0x01 | 0x02);

        [NativeTypeName("#define PSAPI_VERSION 2")]
        public const int PSAPI_VERSION = 2;

        [NativeTypeName("#define EnumProcessModules K32EnumProcessModules")]
        public static readonly delegate*<IntPtr, IntPtr*, uint, uint*, int> EnumProcessModules = &K32EnumProcessModules;

        [NativeTypeName("#define EnumProcessModulesEx K32EnumProcessModulesEx")]
        public static readonly delegate*<IntPtr, IntPtr*, uint, uint*, uint, int> EnumProcessModulesEx = &K32EnumProcessModulesEx;

        [NativeTypeName("#define QueryWorkingSet K32QueryWorkingSet")]
        public static readonly delegate*<IntPtr, void*, uint, int> QueryWorkingSet = &K32QueryWorkingSet;

        [NativeTypeName("#define QueryWorkingSetEx K32QueryWorkingSetEx")]
        public static readonly delegate*<IntPtr, void*, uint, int> QueryWorkingSetEx = &K32QueryWorkingSetEx;

        [NativeTypeName("#define InitializeProcessForWsWatch K32InitializeProcessForWsWatch")]
        public static readonly delegate*<IntPtr, int> InitializeProcessForWsWatch = &K32InitializeProcessForWsWatch;

        [NativeTypeName("#define GetWsChanges K32GetWsChanges")]
        public static readonly delegate*<IntPtr, PSAPI_WS_WATCH_INFORMATION*, uint, int> GetWsChanges = &K32GetWsChanges;

        [NativeTypeName("#define GetWsChangesEx K32GetWsChangesEx")]
        public static readonly delegate*<IntPtr, PSAPI_WS_WATCH_INFORMATION_EX*, uint*, int> GetWsChangesEx = &K32GetWsChangesEx;

        [NativeTypeName("#define GetMappedFileNameW K32GetMappedFileNameW")]
        public static readonly delegate*<IntPtr, void*, ushort*, uint, uint> GetMappedFileNameW = &K32GetMappedFileNameW;

        [NativeTypeName("#define GetMappedFileNameA K32GetMappedFileNameA")]
        public static readonly delegate*<IntPtr, void*, sbyte*, uint, uint> GetMappedFileNameA = &K32GetMappedFileNameA;

        [NativeTypeName("#define EnumDeviceDrivers K32EnumDeviceDrivers")]
        public static readonly delegate*<void**, uint, uint*, int> EnumDeviceDrivers = &K32EnumDeviceDrivers;

        [NativeTypeName("#define GetDeviceDriverBaseNameA K32GetDeviceDriverBaseNameA")]
        public static readonly delegate*<void*, sbyte*, uint, uint> GetDeviceDriverBaseNameA = &K32GetDeviceDriverBaseNameA;

        [NativeTypeName("#define GetDeviceDriverBaseNameW K32GetDeviceDriverBaseNameW")]
        public static readonly delegate*<void*, ushort*, uint, uint> GetDeviceDriverBaseNameW = &K32GetDeviceDriverBaseNameW;

        [NativeTypeName("#define GetDeviceDriverFileNameA K32GetDeviceDriverFileNameA")]
        public static readonly delegate*<void*, sbyte*, uint, uint> GetDeviceDriverFileNameA = &K32GetDeviceDriverFileNameA;

        [NativeTypeName("#define GetDeviceDriverFileNameW K32GetDeviceDriverFileNameW")]
        public static readonly delegate*<void*, ushort*, uint, uint> GetDeviceDriverFileNameW = &K32GetDeviceDriverFileNameW;

        [NativeTypeName("#define GetPerformanceInfo K32GetPerformanceInfo")]
        public static readonly delegate*<PERFORMANCE_INFORMATION*, uint, int> GetPerformanceInfo = &K32GetPerformanceInfo;

        [NativeTypeName("#define GetProcessImageFileNameA K32GetProcessImageFileNameA")]
        public static readonly delegate*<IntPtr, sbyte*, uint, uint> GetProcessImageFileNameA = &K32GetProcessImageFileNameA;

        [NativeTypeName("#define GetProcessImageFileNameW K32GetProcessImageFileNameW")]
        public static readonly delegate*<IntPtr, ushort*, uint, uint> GetProcessImageFileNameW = &K32GetProcessImageFileNameW;

        [NativeTypeName("#define GetModuleBaseNameA K32GetModuleBaseNameA")]
        public static readonly delegate*<IntPtr, IntPtr, sbyte*, uint, uint> GetModuleBaseNameA = &K32GetModuleBaseNameA;

        [NativeTypeName("#define GetModuleBaseNameW K32GetModuleBaseNameW")]
        public static readonly delegate*<IntPtr, IntPtr, ushort*, uint, uint> GetModuleBaseNameW = &K32GetModuleBaseNameW;

        [NativeTypeName("#define GetModuleFileNameExA K32GetModuleFileNameExA")]
        public static readonly delegate*<IntPtr, IntPtr, sbyte*, uint, uint> GetModuleFileNameExA = &K32GetModuleFileNameExA;

        [NativeTypeName("#define GetModuleFileNameExW K32GetModuleFileNameExW")]
        public static readonly delegate*<IntPtr, IntPtr, ushort*, uint, uint> GetModuleFileNameExW = &K32GetModuleFileNameExW;

        [NativeTypeName("#define EmptyWorkingSet K32EmptyWorkingSet")]
        public static readonly delegate*<IntPtr, int> EmptyWorkingSet = &K32EmptyWorkingSet;

        [NativeTypeName("#define EnumPageFilesW K32EnumPageFilesW")]
        public static readonly delegate*<delegate* unmanaged<void*, ENUM_PAGE_FILE_INFORMATION*, ushort*, int>, void*, int> EnumPageFilesW = &K32EnumPageFilesW;

        [NativeTypeName("#define EnumPageFilesA K32EnumPageFilesA")]
        public static readonly delegate*<delegate* unmanaged<void*, ENUM_PAGE_FILE_INFORMATION*, sbyte*, int>, void*, int> EnumPageFilesA = &K32EnumPageFilesA;

        [NativeTypeName("#define EnumProcesses K32EnumProcesses")]
        public static readonly delegate*<uint*, uint, uint*, int> EnumProcesses = &K32EnumProcesses;

        [NativeTypeName("#define GetProcessMemoryInfo K32GetProcessMemoryInfo")]
        public static readonly delegate*<IntPtr, PROCESS_MEMORY_COUNTERS*, uint, int> GetProcessMemoryInfo = &K32GetProcessMemoryInfo;

        [NativeTypeName("#define GetModuleInformation K32GetModuleInformation")]
        public static readonly delegate*<IntPtr, IntPtr, MODULEINFO*, uint, int> GetModuleInformation = &K32GetModuleInformation;

        [NativeTypeName("#define GetModuleBaseName GetModuleBaseNameW")]
        public static readonly delegate*<IntPtr, IntPtr, ushort*, uint, uint> GetModuleBaseName = &K32GetModuleBaseNameW;

        [NativeTypeName("#define GetModuleFileNameEx GetModuleFileNameExW")]
        public static readonly delegate*<IntPtr, IntPtr, ushort*, uint, uint> GetModuleFileNameEx = &K32GetModuleFileNameExW;

        [NativeTypeName("#define GetMappedFileName GetMappedFileNameW")]
        public static readonly delegate*<IntPtr, void*, ushort*, uint, uint> GetMappedFileName = &K32GetMappedFileNameW;

        [NativeTypeName("#define GetDeviceDriverBaseName GetDeviceDriverBaseNameW")]
        public static readonly delegate*<void*, ushort*, uint, uint> GetDeviceDriverBaseName = &K32GetDeviceDriverBaseNameW;

        [NativeTypeName("#define GetDeviceDriverFileName GetDeviceDriverFileNameW")]
        public static readonly delegate*<void*, ushort*, uint, uint> GetDeviceDriverFileName = &K32GetDeviceDriverFileNameW;

        [NativeTypeName("#define EnumPageFiles EnumPageFilesW")]
        public static readonly delegate*<delegate* unmanaged<void*, ENUM_PAGE_FILE_INFORMATION*, ushort*, int>, void*, int> EnumPageFiles = &K32EnumPageFilesW;

        [NativeTypeName("#define GetProcessImageFileName GetProcessImageFileNameW")]
        public static readonly delegate*<IntPtr, ushort*, uint, uint> GetProcessImageFileName = &K32GetProcessImageFileNameW;
    }
}
