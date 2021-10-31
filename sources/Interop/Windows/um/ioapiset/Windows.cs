// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ioapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateIoCompletionPort([NativeTypeName("HANDLE")] IntPtr FileHandle, [NativeTypeName("HANDLE")] IntPtr ExistingCompletionPort, [NativeTypeName("ULONG_PTR")] nuint CompletionKey, [NativeTypeName("DWORD")] uint NumberOfConcurrentThreads);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetQueuedCompletionStatus([NativeTypeName("HANDLE")] IntPtr CompletionPort, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred, [NativeTypeName("PULONG_PTR")] nuint* lpCompletionKey, [NativeTypeName("LPOVERLAPPED *")] OVERLAPPED** lpOverlapped, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetQueuedCompletionStatusEx([NativeTypeName("HANDLE")] IntPtr CompletionPort, [NativeTypeName("LPOVERLAPPED_ENTRY")] OVERLAPPED_ENTRY* lpCompletionPortEntries, [NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("PULONG")] uint* ulNumEntriesRemoved, [NativeTypeName("DWORD")] uint dwMilliseconds, BOOL fAlertable);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL PostQueuedCompletionStatus([NativeTypeName("HANDLE")] IntPtr CompletionPort, [NativeTypeName("DWORD")] uint dwNumberOfBytesTransferred, [NativeTypeName("ULONG_PTR")] nuint dwCompletionKey, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DeviceIoControl([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwIoControlCode, [NativeTypeName("LPVOID")] void* lpInBuffer, [NativeTypeName("DWORD")] uint nInBufferSize, [NativeTypeName("LPVOID")] void* lpOutBuffer, [NativeTypeName("DWORD")] uint nOutBufferSize, [NativeTypeName("LPDWORD")] uint* lpBytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetOverlappedResult([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred, BOOL bWait);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CancelIoEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CancelIo([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetOverlappedResultEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred, [NativeTypeName("DWORD")] uint dwMilliseconds, BOOL bAlertable);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CancelSynchronousIo([NativeTypeName("HANDLE")] IntPtr hThread);
    }
}
