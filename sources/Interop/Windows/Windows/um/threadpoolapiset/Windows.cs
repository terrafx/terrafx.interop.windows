// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/threadpoolapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateThreadpool"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern PTP_POOL CreateThreadpool([NativeTypeName("PVOID")] void* reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadpoolThreadMaximum"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void SetThreadpoolThreadMaximum(PTP_POOL ptpp, [NativeTypeName("DWORD")] uint cthrdMost);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadpoolThreadMinimum"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetThreadpoolThreadMinimum(PTP_POOL ptpp, [NativeTypeName("DWORD")] uint cthrdMic);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadpoolStackInformation"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetThreadpoolStackInformation(PTP_POOL ptpp, [NativeTypeName("PTP_POOL_STACK_INFORMATION")] TP_POOL_STACK_INFORMATION* ptpsi);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryThreadpoolStackInformation"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL QueryThreadpoolStackInformation(PTP_POOL ptpp, [NativeTypeName("PTP_POOL_STACK_INFORMATION")] TP_POOL_STACK_INFORMATION* ptpsi);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseThreadpool"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void CloseThreadpool(PTP_POOL ptpp);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateThreadpoolCleanupGroup"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern PTP_CLEANUP_GROUP CreateThreadpoolCleanupGroup();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseThreadpoolCleanupGroupMembers"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void CloseThreadpoolCleanupGroupMembers(PTP_CLEANUP_GROUP ptpcg, BOOL fCancelPendingCallbacks, [NativeTypeName("PVOID")] void* pvCleanupContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseThreadpoolCleanupGroup"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void CloseThreadpoolCleanupGroup(PTP_CLEANUP_GROUP ptpcg);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetEventWhenCallbackReturns"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void SetEventWhenCallbackReturns(PTP_CALLBACK_INSTANCE pci, HANDLE evt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReleaseSemaphoreWhenCallbackReturns"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ReleaseSemaphoreWhenCallbackReturns(PTP_CALLBACK_INSTANCE pci, HANDLE sem, [NativeTypeName("DWORD")] uint crel);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReleaseMutexWhenCallbackReturns"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ReleaseMutexWhenCallbackReturns(PTP_CALLBACK_INSTANCE pci, HANDLE mut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LeaveCriticalSectionWhenCallbackReturns"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void LeaveCriticalSectionWhenCallbackReturns(PTP_CALLBACK_INSTANCE pci, [NativeTypeName("PCRITICAL_SECTION")] CRITICAL_SECTION* pcs);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeLibraryWhenCallbackReturns"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void FreeLibraryWhenCallbackReturns(PTP_CALLBACK_INSTANCE pci, HMODULE mod);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CallbackMayRunLong"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL CallbackMayRunLong(PTP_CALLBACK_INSTANCE pci);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DisassociateCurrentThreadFromCallback"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void DisassociateCurrentThreadFromCallback(PTP_CALLBACK_INSTANCE pci);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TrySubmitThreadpoolCallback"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL TrySubmitThreadpoolCallback([NativeTypeName("PTP_SIMPLE_CALLBACK")] delegate* unmanaged<PTP_CALLBACK_INSTANCE, void*, void> pfns, [NativeTypeName("PVOID")] void* pv, [NativeTypeName("PTP_CALLBACK_ENVIRON")] TP_CALLBACK_ENVIRON_V3* pcbe);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateThreadpoolWork"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern PTP_WORK CreateThreadpoolWork([NativeTypeName("PTP_WORK_CALLBACK")] delegate* unmanaged<PTP_CALLBACK_INSTANCE, void*, PTP_WORK, void> pfnwk, [NativeTypeName("PVOID")] void* pv, [NativeTypeName("PTP_CALLBACK_ENVIRON")] TP_CALLBACK_ENVIRON_V3* pcbe);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SubmitThreadpoolWork"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void SubmitThreadpoolWork(PTP_WORK pwk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitForThreadpoolWorkCallbacks"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void WaitForThreadpoolWorkCallbacks(PTP_WORK pwk, BOOL fCancelPendingCallbacks);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseThreadpoolWork"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void CloseThreadpoolWork(PTP_WORK pwk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateThreadpoolTimer"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern PTP_TIMER CreateThreadpoolTimer([NativeTypeName("PTP_TIMER_CALLBACK")] delegate* unmanaged<PTP_CALLBACK_INSTANCE, void*, PTP_TIMER, void> pfnti, [NativeTypeName("PVOID")] void* pv, [NativeTypeName("PTP_CALLBACK_ENVIRON")] TP_CALLBACK_ENVIRON_V3* pcbe);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadpoolTimer"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void SetThreadpoolTimer(PTP_TIMER pti, [NativeTypeName("PFILETIME")] FILETIME* pftDueTime, [NativeTypeName("DWORD")] uint msPeriod, [NativeTypeName("DWORD")] uint msWindowLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsThreadpoolTimerSet"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsThreadpoolTimerSet(PTP_TIMER pti);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitForThreadpoolTimerCallbacks"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void WaitForThreadpoolTimerCallbacks(PTP_TIMER pti, BOOL fCancelPendingCallbacks);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseThreadpoolTimer"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void CloseThreadpoolTimer(PTP_TIMER pti);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateThreadpoolWait"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern PTP_WAIT CreateThreadpoolWait([NativeTypeName("PTP_WAIT_CALLBACK")] delegate* unmanaged<PTP_CALLBACK_INSTANCE, void*, PTP_WAIT, uint, void> pfnwa, [NativeTypeName("PVOID")] void* pv, [NativeTypeName("PTP_CALLBACK_ENVIRON")] TP_CALLBACK_ENVIRON_V3* pcbe);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadpoolWait"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void SetThreadpoolWait(PTP_WAIT pwa, HANDLE h, [NativeTypeName("PFILETIME")] FILETIME* pftTimeout);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitForThreadpoolWaitCallbacks"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void WaitForThreadpoolWaitCallbacks(PTP_WAIT pwa, BOOL fCancelPendingCallbacks);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseThreadpoolWait"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void CloseThreadpoolWait(PTP_WAIT pwa);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateThreadpoolIo"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern PTP_IO CreateThreadpoolIo(HANDLE fl, [NativeTypeName("PTP_WIN32_IO_CALLBACK")] delegate* unmanaged<PTP_CALLBACK_INSTANCE, void*, void*, uint, nuint, PTP_IO, void> pfnio, [NativeTypeName("PVOID")] void* pv, [NativeTypeName("PTP_CALLBACK_ENVIRON")] TP_CALLBACK_ENVIRON_V3* pcbe);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StartThreadpoolIo"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void StartThreadpoolIo(PTP_IO pio);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CancelThreadpoolIo"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void CancelThreadpoolIo(PTP_IO pio);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitForThreadpoolIoCallbacks"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void WaitForThreadpoolIoCallbacks(PTP_IO pio, BOOL fCancelPendingCallbacks);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseThreadpoolIo"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void CloseThreadpoolIo(PTP_IO pio);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadpoolTimerEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetThreadpoolTimerEx(PTP_TIMER pti, [NativeTypeName("PFILETIME")] FILETIME* pftDueTime, [NativeTypeName("DWORD")] uint msPeriod, [NativeTypeName("DWORD")] uint msWindowLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadpoolWaitEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetThreadpoolWaitEx(PTP_WAIT pwa, HANDLE h, [NativeTypeName("PFILETIME")] FILETIME* pftTimeout, [NativeTypeName("PVOID")] void* Reserved);
}
