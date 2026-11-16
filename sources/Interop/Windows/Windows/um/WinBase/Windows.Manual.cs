// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Threading;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [return: NativeTypeName("WORD")]
    public static ushort CaptureStackBackTrace(uint FramesToSkip, uint FramesToCapture, void** BackTrace, uint* BackTraceHash)
        => RtlCaptureStackBackTrace(FramesToSkip, FramesToCapture, BackTrace, BackTraceHash);

    [return: NativeTypeName("#define HasOverlappedIoCompleted(lpOverlapped) (((DWORD)(lpOverlapped)->Internal) != STATUS_PENDING)")]
    public static bool HasOverlappedIoCompleted(OVERLAPPED* lpOverlapped)
        => unchecked((uint)lpOverlapped->Internal) != STATUS.STATUS_PENDING;

    [return: NativeTypeName("LPTSTR")]
    public static char* MAKEINTATOM(int i) => (char*)(nuint)unchecked((ushort)i);

    [return: NativeTypeName("int")]
    public static int ProcThreadAttributeValue(PROC_THREAD_ATTRIBUTE_NUM Number, BOOL Thread, BOOL Input, BOOL Additive)
        => (((int)Number & PROC.PROC_THREAD_ATTRIBUTE_NUMBER)
        | ((Thread.Value != 0) ? PROC.PROC_THREAD_ATTRIBUTE_THREAD : 0)
        | ((Input.Value != 0) ? PROC.PROC_THREAD_ATTRIBUTE_INPUT : 0)
        | ((Additive.Value != 0) ? PROC.PROC_THREAD_ATTRIBUTE_ADDITIVE : 0));

    [return: NativeTypeName("BOOL")]
    [DllImport("sechost", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountNameLocalA(sbyte* lpAccountName, void* Sid, uint* cbSid, sbyte* ReferencedDomainName, uint* cchReferencedDomainName, SID_NAME_USE* peUse);

    [return: NativeTypeName("BOOL")]
    [DllImport("sechost", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountNameLocalW(char* lpAccountName, void* Sid, uint* cbSid, char* ReferencedDomainName, uint* cchReferencedDomainName, SID_NAME_USE* peUse);

    [return: NativeTypeName("#define LookupAccountNameLocal LookupAccountNameLocalW")]
    public static BOOL LookupAccountNameLocal(char* lpAccountName, void* Sid, uint* cbSid, char* ReferencedDomainName, uint* cchReferencedDomainName, SID_NAME_USE* peUse)
        => LookupAccountNameLocalW(lpAccountName, Sid, cbSid, ReferencedDomainName, cchReferencedDomainName, peUse);

    [return: NativeTypeName("PVOID")]
    public static void* SecureZeroMemory(void* Ptr, nuint Count) => RtlSecureZeroMemory(Ptr, Count);

    [return: NativeTypeName("PVOID")]
    public static void* SecureZeroMemory2(void* Ptr, nuint Count) => RtlSecureZeroMemory2(Ptr, Count);

    [return: NativeTypeName("unsigned")]
    public static uint InterlockedExchangeSubtract(uint* Addend, uint Value)
    {
        int delta = unchecked(-(int)Value);
        int* addend = (int*)Addend;
        int updated = Interlocked.Add(ref *addend, delta);
        return unchecked((uint)(updated - delta));
    }

    [return: NativeTypeName("unsigned __int64")]
    public static ulong InterlockedExchangeSubtract(ulong* Addend, ulong Value)
    {
        long delta = unchecked(-(long)Value);
        long* addend = (long*)Addend;
        long updated = Interlocked.Add(ref *addend, delta);
        return unchecked((ulong)(updated - delta));
    }
}
