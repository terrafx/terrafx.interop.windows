// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/heapapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Kernel32
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapCreate", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr HeapCreate([NativeTypeName("DWORD")] uint flOptions, [NativeTypeName("SIZE_T")] nuint dwInitialSize, [NativeTypeName("SIZE_T")] nuint dwMaximumSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapDestroy", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapDestroy([NativeTypeName("HANDLE")] IntPtr hHeap);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapAlloc", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* HeapAlloc([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("SIZE_T")] nuint dwBytes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapReAlloc", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* HeapReAlloc([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* lpMem, [NativeTypeName("SIZE_T")] nuint dwBytes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapFree", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapFree([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* lpMem);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapSize", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint HeapSize([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpMem);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessHeap", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetProcessHeap();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapCompact", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint HeapCompact([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapSetInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapSetInformation([NativeTypeName("HANDLE")] IntPtr HeapHandle, HEAP_INFORMATION_CLASS HeapInformationClass, [NativeTypeName("PVOID")] void* HeapInformation, [NativeTypeName("SIZE_T")] nuint HeapInformationLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapValidate", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapValidate([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpMem);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapSummary", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapSummary([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPHEAP_SUMMARY")] HEAP_SUMMARY* lpSummary);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessHeaps", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProcessHeaps([NativeTypeName("DWORD")] uint NumberOfHeaps, [NativeTypeName("PHANDLE")] IntPtr* ProcessHeaps);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapLock", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapLock([NativeTypeName("HANDLE")] IntPtr hHeap);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapUnlock", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapUnlock([NativeTypeName("HANDLE")] IntPtr hHeap);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapWalk", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapWalk([NativeTypeName("HANDLE")] IntPtr hHeap, [NativeTypeName("LPPROCESS_HEAP_ENTRY")] PROCESS_HEAP_ENTRY* lpEntry);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HeapQueryInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HeapQueryInformation([NativeTypeName("HANDLE")] IntPtr HeapHandle, HEAP_INFORMATION_CLASS HeapInformationClass, [NativeTypeName("PVOID")] void* HeapInformation, [NativeTypeName("SIZE_T")] nuint HeapInformationLength, [NativeTypeName("PSIZE_T")] nuint* ReturnLength);
    }
}
