// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/heapapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr HeapCreate([NativeTypeName("DWORD")] uint flOptions, [NativeTypeName("SIZE_T")] nuint dwInitialSize, [NativeTypeName("SIZE_T")] nuint dwMaximumSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapDestroy([NativeTypeName("HANDLE")] IntPtr hHeap);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* HeapAlloc([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("SIZE_T")] nuint dwBytes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* HeapReAlloc([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* lpMem, [NativeTypeName("SIZE_T")] nuint dwBytes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapFree([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* lpMem);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint HeapSize([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpMem);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetProcessHeap();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint HeapCompact([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapSetInformation([NativeTypeName("HANDLE")] IntPtr HeapHandle, HEAP_INFORMATION_CLASS HeapInformationClass, [NativeTypeName("PVOID")] void* HeapInformation, [NativeTypeName("SIZE_T")] nuint HeapInformationLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapValidate([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpMem);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapSummary([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPHEAP_SUMMARY")] HEAP_SUMMARY* lpSummary);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProcessHeaps([NativeTypeName("DWORD")] uint NumberOfHeaps, [NativeTypeName("PHANDLE")] IntPtr* ProcessHeaps);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapLock([NativeTypeName("HANDLE")] IntPtr hHeap);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapUnlock([NativeTypeName("HANDLE")] IntPtr hHeap);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapWalk([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("LPPROCESS_HEAP_ENTRY")] PROCESS_HEAP_ENTRY* lpEntry);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapQueryInformation([NativeTypeName("HANDLE")] IntPtr HeapHandle, HEAP_INFORMATION_CLASS HeapInformationClass, [NativeTypeName("PVOID")] void* HeapInformation, [NativeTypeName("SIZE_T")] nuint HeapInformationLength, [NativeTypeName("PSIZE_T")] nuint* ReturnLength);
    }
}
