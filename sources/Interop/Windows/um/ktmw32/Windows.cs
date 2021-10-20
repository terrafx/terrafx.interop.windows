// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ktmw32.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateTransaction([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTransactionAttributes, [NativeTypeName("LPGUID")] Guid* UOW, [NativeTypeName("DWORD")] uint CreateOptions, [NativeTypeName("DWORD")] uint IsolationLevel, [NativeTypeName("DWORD")] uint IsolationFlags, [NativeTypeName("DWORD")] uint Timeout, [NativeTypeName("LPWSTR")] ushort* Description);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenTransaction([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("LPGUID")] Guid* TransactionId);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CommitTransaction([NativeTypeName("HANDLE")] IntPtr TransactionHandle);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CommitTransactionAsync([NativeTypeName("HANDLE")] IntPtr TransactionHandle);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RollbackTransaction([NativeTypeName("HANDLE")] IntPtr TransactionHandle);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RollbackTransactionAsync([NativeTypeName("HANDLE")] IntPtr TransactionHandle);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTransactionId([NativeTypeName("HANDLE")] IntPtr TransactionHandle, [NativeTypeName("LPGUID")] Guid* TransactionId);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTransactionInformation([NativeTypeName("HANDLE")] IntPtr TransactionHandle, [NativeTypeName("PDWORD")] uint* Outcome, [NativeTypeName("PDWORD")] uint* IsolationLevel, [NativeTypeName("PDWORD")] uint* IsolationFlags, [NativeTypeName("PDWORD")] uint* Timeout, [NativeTypeName("DWORD")] uint BufferLength, [NativeTypeName("LPWSTR")] ushort* Description);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetTransactionInformation([NativeTypeName("HANDLE")] IntPtr TransactionHandle, [NativeTypeName("DWORD")] uint IsolationLevel, [NativeTypeName("DWORD")] uint IsolationFlags, [NativeTypeName("DWORD")] uint Timeout, [NativeTypeName("LPWSTR")] ushort* Description);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateTransactionManager([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTransactionAttributes, [NativeTypeName("LPWSTR")] ushort* LogFileName, [NativeTypeName("ULONG")] uint CreateOptions, [NativeTypeName("ULONG")] uint CommitStrength);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenTransactionManager([NativeTypeName("LPWSTR")] ushort* LogFileName, [NativeTypeName("ACCESS_MASK")] uint DesiredAccess, [NativeTypeName("ULONG")] uint OpenOptions);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenTransactionManagerById([NativeTypeName("LPGUID")] Guid* TransactionManagerId, [NativeTypeName("ACCESS_MASK")] uint DesiredAccess, [NativeTypeName("ULONG")] uint OpenOptions);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RenameTransactionManager([NativeTypeName("LPWSTR")] ushort* LogFileName, [NativeTypeName("LPGUID")] Guid* ExistingTransactionManagerGuid);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RollforwardTransactionManager([NativeTypeName("HANDLE")] IntPtr TransactionManagerHandle, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RecoverTransactionManager([NativeTypeName("HANDLE")] IntPtr TransactionManagerHandle);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentClockTransactionManager([NativeTypeName("HANDLE")] IntPtr TransactionManagerHandle, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTransactionManagerId([NativeTypeName("HANDLE")] IntPtr TransactionManagerHandle, [NativeTypeName("LPGUID")] Guid* TransactionManagerId);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateResourceManager([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpResourceManagerAttributes, [NativeTypeName("LPGUID")] Guid* ResourceManagerId, [NativeTypeName("DWORD")] uint CreateOptions, [NativeTypeName("HANDLE")] IntPtr TmHandle, [NativeTypeName("LPWSTR")] ushort* Description);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenResourceManager([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("HANDLE")] IntPtr TmHandle, [NativeTypeName("LPGUID")] Guid* ResourceManagerId);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RecoverResourceManager([NativeTypeName("HANDLE")] IntPtr ResourceManagerHandle);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNotificationResourceManager([NativeTypeName("HANDLE")] IntPtr ResourceManagerHandle, [NativeTypeName("PTRANSACTION_NOTIFICATION")] TRANSACTION_NOTIFICATION* TransactionNotification, [NativeTypeName("ULONG")] uint NotificationLength, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("PULONG")] uint* ReturnLength);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNotificationResourceManagerAsync([NativeTypeName("HANDLE")] IntPtr ResourceManagerHandle, [NativeTypeName("PTRANSACTION_NOTIFICATION")] TRANSACTION_NOTIFICATION* TransactionNotification, [NativeTypeName("ULONG")] uint TransactionNotificationLength, [NativeTypeName("PULONG")] uint* ReturnLength, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetResourceManagerCompletionPort([NativeTypeName("HANDLE")] IntPtr ResourceManagerHandle, [NativeTypeName("HANDLE")] IntPtr IoCompletionPortHandle, [NativeTypeName("ULONG_PTR")] nuint CompletionKey);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateEnlistment([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEnlistmentAttributes, [NativeTypeName("HANDLE")] IntPtr ResourceManagerHandle, [NativeTypeName("HANDLE")] IntPtr TransactionHandle, [NativeTypeName("NOTIFICATION_MASK")] uint NotificationMask, [NativeTypeName("DWORD")] uint CreateOptions, [NativeTypeName("PVOID")] void* EnlistmentKey);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenEnlistment([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("HANDLE")] IntPtr ResourceManagerHandle, [NativeTypeName("LPGUID")] Guid* EnlistmentId);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RecoverEnlistment([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("PVOID")] void* EnlistmentKey);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetEnlistmentRecoveryInformation([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("ULONG")] uint BufferSize, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("PULONG")] uint* BufferUsed);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetEnlistmentId([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("LPGUID")] Guid* EnlistmentId);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEnlistmentRecoveryInformation([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("ULONG")] uint BufferSize, [NativeTypeName("PVOID")] void* Buffer);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrepareEnlistment([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrePrepareEnlistment([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CommitEnlistment([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RollbackEnlistment([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrePrepareComplete([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrepareComplete([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadOnlyEnlistment([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CommitComplete([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RollbackComplete([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock);

        [DllImport("ktmw32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SinglePhaseReject([NativeTypeName("HANDLE")] IntPtr EnlistmentHandle, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock);
    }
}
