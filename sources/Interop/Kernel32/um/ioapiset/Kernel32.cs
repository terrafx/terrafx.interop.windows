// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ioapiset.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Kernel32
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateIoCompletionPort", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateIoCompletionPort([NativeTypeName("HANDLE")] IntPtr FileHandle, [NativeTypeName("HANDLE")] IntPtr ExistingCompletionPort, [NativeTypeName("ULONG_PTR")] uint CompletionKey, [NativeTypeName("DWORD")] uint NumberOfConcurrentThreads);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetQueuedCompletionStatus", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetQueuedCompletionStatus([NativeTypeName("HANDLE")] IntPtr CompletionPort, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred, [NativeTypeName("PULONG_PTR")] uint* lpCompletionKey, [NativeTypeName("LPOVERLAPPED *")] OVERLAPPED** lpOverlapped, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetQueuedCompletionStatusEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetQueuedCompletionStatusEx([NativeTypeName("HANDLE")] IntPtr CompletionPort, [NativeTypeName("LPOVERLAPPED_ENTRY")] OVERLAPPED_ENTRY* lpCompletionPortEntries, [NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("PULONG")] uint* ulNumEntriesRemoved, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("BOOL")] int fAlertable);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PostQueuedCompletionStatus", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostQueuedCompletionStatus([NativeTypeName("HANDLE")] IntPtr CompletionPort, [NativeTypeName("DWORD")] uint dwNumberOfBytesTransferred, [NativeTypeName("ULONG_PTR")] uint dwCompletionKey, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeviceIoControl", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeviceIoControl([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwIoControlCode, [NativeTypeName("LPVOID")] void* lpInBuffer, [NativeTypeName("DWORD")] uint nInBufferSize, [NativeTypeName("LPVOID")] void* lpOutBuffer, [NativeTypeName("DWORD")] uint nOutBufferSize, [NativeTypeName("LPDWORD")] uint* lpBytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetOverlappedResult", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetOverlappedResult([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred, [NativeTypeName("BOOL")] int bWait);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CancelIoEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelIoEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CancelIo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelIo([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetOverlappedResultEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetOverlappedResultEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("BOOL")] int bAlertable);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CancelSynchronousIo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelSynchronousIo([NativeTypeName("HANDLE")] IntPtr hThread);
    }
}
