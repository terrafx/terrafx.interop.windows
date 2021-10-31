// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* VirtualAlloc([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flAllocationType, [NativeTypeName("DWORD")] uint flProtect);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualProtect([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flNewProtect, [NativeTypeName("PDWORD")] uint* lpflOldProtect);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualFree([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint dwFreeType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint VirtualQuery([NativeTypeName("LPCVOID")] void* lpAddress, [NativeTypeName("PMEMORY_BASIC_INFORMATION")] MEMORY_BASIC_INFORMATION* lpBuffer, [NativeTypeName("SIZE_T")] nuint dwLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* VirtualAllocEx([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flAllocationType, [NativeTypeName("DWORD")] uint flProtect);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualProtectEx([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flNewProtect, [NativeTypeName("PDWORD")] uint* lpflOldProtect);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint VirtualQueryEx([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPCVOID")] void* lpAddress, [NativeTypeName("PMEMORY_BASIC_INFORMATION")] MEMORY_BASIC_INFORMATION* lpBuffer, [NativeTypeName("SIZE_T")] nuint dwLength);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern BOOL ReadProcessMemory([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPCVOID")] void* lpBaseAddress, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] nuint nSize, [NativeTypeName("SIZE_T *")] nuint* lpNumberOfBytesRead);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WriteProcessMemory([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPVOID")] void* lpBaseAddress, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] nuint nSize, [NativeTypeName("SIZE_T *")] nuint* lpNumberOfBytesWritten);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileMappingW([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenFileMappingW([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* MapViewOfFile([NativeTypeName("HANDLE")] IntPtr hFileMappingObject, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToMap);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* MapViewOfFileEx([NativeTypeName("HANDLE")] IntPtr hFileMappingObject, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToMap, [NativeTypeName("LPVOID")] void* lpBaseAddress);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualFreeEx([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint dwFreeType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL FlushViewOfFile([NativeTypeName("LPCVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToFlush);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnmapViewOfFile([NativeTypeName("LPCVOID")] void* lpBaseAddress);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint GetLargePageMinimum();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetProcessWorkingSetSize([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PSIZE_T")] nuint* lpMinimumWorkingSetSize, [NativeTypeName("PSIZE_T")] nuint* lpMaximumWorkingSetSize);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern BOOL GetProcessWorkingSetSizeEx([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PSIZE_T")] nuint* lpMinimumWorkingSetSize, [NativeTypeName("PSIZE_T")] nuint* lpMaximumWorkingSetSize, [NativeTypeName("PDWORD")] uint* Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetProcessWorkingSetSize([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("SIZE_T")] nuint dwMinimumWorkingSetSize, [NativeTypeName("SIZE_T")] nuint dwMaximumWorkingSetSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetProcessWorkingSetSizeEx([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("SIZE_T")] nuint dwMinimumWorkingSetSize, [NativeTypeName("SIZE_T")] nuint dwMaximumWorkingSetSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualLock([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualUnlock([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWriteWatch([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] nuint dwRegionSize, [NativeTypeName("PVOID *")] void** lpAddresses, [NativeTypeName("ULONG_PTR *")] nuint* lpdwCount, [NativeTypeName("LPDWORD")] uint* lpdwGranularity);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ResetWriteWatch([NativeTypeName("LPVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] nuint dwRegionSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMemoryResourceNotification(MEMORY_RESOURCE_NOTIFICATION_TYPE NotificationType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL QueryMemoryResourceNotification([NativeTypeName("HANDLE")] IntPtr ResourceNotificationHandle, [NativeTypeName("PBOOL")] BOOL* ResourceState);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetSystemFileCacheSize([NativeTypeName("PSIZE_T")] nuint* lpMinimumFileCacheSize, [NativeTypeName("PSIZE_T")] nuint* lpMaximumFileCacheSize, [NativeTypeName("PDWORD")] uint* lpFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetSystemFileCacheSize([NativeTypeName("SIZE_T")] nuint MinimumFileCacheSize, [NativeTypeName("SIZE_T")] nuint MaximumFileCacheSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileMappingNumaW([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint nndPreferred);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL PrefetchVirtualMemory([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("ULONG_PTR")] nuint NumberOfEntries, [NativeTypeName("PWIN32_MEMORY_RANGE_ENTRY")] WIN32_MEMORY_RANGE_ENTRY* VirtualAddresses, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileMappingFromApp([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("PSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* SecurityAttributes, [NativeTypeName("ULONG")] uint PageProtection, [NativeTypeName("ULONG64")] ulong MaximumSize, [NativeTypeName("PCWSTR")] ushort* Name);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* MapViewOfFileFromApp([NativeTypeName("HANDLE")] IntPtr hFileMappingObject, [NativeTypeName("ULONG")] uint DesiredAccess, [NativeTypeName("ULONG64")] ulong FileOffset, [NativeTypeName("SIZE_T")] nuint NumberOfBytesToMap);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnmapViewOfFileEx([NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("ULONG")] uint UnmapFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AllocateUserPhysicalPages([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PULONG_PTR")] nuint* NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL FreeUserPhysicalPages([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PULONG_PTR")] nuint* NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL MapUserPhysicalPages([NativeTypeName("PVOID")] void* VirtualAddress, [NativeTypeName("ULONG_PTR")] nuint NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AllocateUserPhysicalPagesNuma([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PULONG_PTR")] nuint* NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray, [NativeTypeName("DWORD")] uint nndPreferred);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* VirtualAllocExNuma([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flAllocationType, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint nndPreferred);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetMemoryErrorHandlingCapabilities([NativeTypeName("PULONG")] uint* Capabilities);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* RegisterBadMemoryNotification([NativeTypeName("PBAD_MEMORY_CALLBACK_ROUTINE")] delegate* unmanaged<void> Callback);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnregisterBadMemoryNotification([NativeTypeName("PVOID")] void* RegistrationHandle);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OfferVirtualMemory([NativeTypeName("PVOID")] void* VirtualAddress, [NativeTypeName("SIZE_T")] nuint Size, OFFER_PRIORITY Priority);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ReclaimVirtualMemory([NativeTypeName("const void *")] void* VirtualAddress, [NativeTypeName("SIZE_T")] nuint Size);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DiscardVirtualMemory([NativeTypeName("PVOID")] void* VirtualAddress, [NativeTypeName("SIZE_T")] nuint Size);

        [DllImport("kernelbase", ExactSpelling = true)]
        public static extern BOOL SetProcessValidCallTargets([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PVOID")] void* VirtualAddress, [NativeTypeName("SIZE_T")] nuint RegionSize, [NativeTypeName("ULONG")] uint NumberOfOffsets, [NativeTypeName("PCFG_CALL_TARGET_INFO")] CFG_CALL_TARGET_INFO* OffsetInformation);

        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* VirtualAllocFromApp([NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint Protection);

        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualProtectFromApp([NativeTypeName("PVOID")] void* Address, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ULONG")] uint NewProtection, [NativeTypeName("PULONG")] uint* OldProtection);

        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenFileMappingFromApp([NativeTypeName("ULONG")] uint DesiredAccess, BOOL InheritHandle, [NativeTypeName("PCWSTR")] ushort* Name);

        [DllImport("api-ms-win-core-memory-l1-1-4", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL QueryVirtualMemoryInformation([NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("const void *")] void* VirtualAddress, WIN32_MEMORY_INFORMATION_CLASS MemoryInformationClass, [NativeTypeName("PVOID")] void* MemoryInformation, [NativeTypeName("SIZE_T")] nuint MemoryInformationSize, [NativeTypeName("PSIZE_T")] nuint* ReturnSize);

        [DllImport("api-ms-win-core-memory-l1-1-5", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* MapViewOfFileNuma2([NativeTypeName("HANDLE")] IntPtr FileMappingHandle, [NativeTypeName("HANDLE")] IntPtr ProcessHandle, [NativeTypeName("ULONG64")] ulong Offset, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint ViewSize, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, [NativeTypeName("ULONG")] uint PreferredNode);

        [return: NativeTypeName("PVOID")]
        public static void* MapViewOfFile2([NativeTypeName("HANDLE")] IntPtr FileMappingHandle, [NativeTypeName("HANDLE")] IntPtr ProcessHandle, [NativeTypeName("ULONG64")] ulong Offset, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint ViewSize, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection)
        {
            return MapViewOfFileNuma2(FileMappingHandle, ProcessHandle, Offset, BaseAddress, ViewSize, AllocationType, PageProtection, unchecked((uint)(-1)));
        }

        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnmapViewOfFile2([NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("ULONG")] uint UnmapFlags);

        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* VirtualAlloc2([NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);

        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* MapViewOfFile3([NativeTypeName("HANDLE")] IntPtr FileMapping, [NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("ULONG64")] ulong Offset, [NativeTypeName("SIZE_T")] nuint ViewSize, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);

        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* VirtualAlloc2FromApp([NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);

        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* MapViewOfFile3FromApp([NativeTypeName("HANDLE")] IntPtr FileMapping, [NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("ULONG64")] ulong Offset, [NativeTypeName("SIZE_T")] nuint ViewSize, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);

        [DllImport("kernelbase", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileMapping2([NativeTypeName("HANDLE")] IntPtr File, SECURITY_ATTRIBUTES* SecurityAttributes, [NativeTypeName("ULONG")] uint DesiredAccess, [NativeTypeName("ULONG")] uint PageProtection, [NativeTypeName("ULONG")] uint AllocationAttributes, [NativeTypeName("ULONG64")] ulong MaximumSize, [NativeTypeName("PCWSTR")] ushort* Name, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);

        [NativeTypeName("#define FILE_MAP_WRITE SECTION_MAP_WRITE")]
        public const int FILE_MAP_WRITE = 0x0002;

        [NativeTypeName("#define FILE_MAP_READ SECTION_MAP_READ")]
        public const int FILE_MAP_READ = 0x0004;

        [NativeTypeName("#define FILE_MAP_ALL_ACCESS SECTION_ALL_ACCESS")]
        public const int FILE_MAP_ALL_ACCESS = ((0x000F0000) | 0x0001 | 0x0002 | 0x0004 | 0x0008 | 0x0010);

        [NativeTypeName("#define FILE_MAP_EXECUTE SECTION_MAP_EXECUTE_EXPLICIT")]
        public const int FILE_MAP_EXECUTE = 0x0020;

        [NativeTypeName("#define FILE_MAP_COPY 0x00000001")]
        public const int FILE_MAP_COPY = 0x00000001;

        [NativeTypeName("#define FILE_MAP_RESERVE 0x80000000")]
        public const uint FILE_MAP_RESERVE = 0x80000000;

        [NativeTypeName("#define FILE_MAP_TARGETS_INVALID 0x40000000")]
        public const int FILE_MAP_TARGETS_INVALID = 0x40000000;

        [NativeTypeName("#define FILE_MAP_LARGE_PAGES 0x20000000")]
        public const int FILE_MAP_LARGE_PAGES = 0x20000000;

        [NativeTypeName("#define CreateFileMapping CreateFileMappingW")]
        public static delegate*<IntPtr, SECURITY_ATTRIBUTES*, uint, uint, uint, ushort*, IntPtr> CreateFileMapping => &CreateFileMappingW;

        [NativeTypeName("#define OpenFileMapping OpenFileMappingW")]
        public static delegate*<uint, BOOL, ushort*, IntPtr> OpenFileMapping => &OpenFileMappingW;

        [NativeTypeName("#define FILE_CACHE_MAX_HARD_ENABLE 0x00000001")]
        public const int FILE_CACHE_MAX_HARD_ENABLE = 0x00000001;

        [NativeTypeName("#define FILE_CACHE_MAX_HARD_DISABLE 0x00000002")]
        public const int FILE_CACHE_MAX_HARD_DISABLE = 0x00000002;

        [NativeTypeName("#define FILE_CACHE_MIN_HARD_ENABLE 0x00000004")]
        public const int FILE_CACHE_MIN_HARD_ENABLE = 0x00000004;

        [NativeTypeName("#define FILE_CACHE_MIN_HARD_DISABLE 0x00000008")]
        public const int FILE_CACHE_MIN_HARD_DISABLE = 0x00000008;

        [NativeTypeName("#define CreateFileMappingNuma CreateFileMappingNumaW")]
        public static delegate*<IntPtr, SECURITY_ATTRIBUTES*, uint, uint, uint, ushort*, uint, IntPtr> CreateFileMappingNuma => &CreateFileMappingNumaW;

        [NativeTypeName("#define MEHC_PATROL_SCRUBBER_PRESENT 0x1")]
        public const int MEHC_PATROL_SCRUBBER_PRESENT = 0x1;
    }
}
