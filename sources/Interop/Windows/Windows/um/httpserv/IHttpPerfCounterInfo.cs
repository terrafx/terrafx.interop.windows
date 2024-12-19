// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpPerfCounterInfo.xml' path='doc/member[@name="IHttpPerfCounterInfo"]/*' />
[Guid("BDFC4C4A-12A4-4744-87D8-765EB320C59F")]
public unsafe partial struct IHttpPerfCounterInfo : IHttpPerfCounterInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpPerfCounterInfo));

    public void** lpVtbl;

    /// <include file='IHttpPerfCounterInfo.xml' path='doc/member[@name="IHttpPerfCounterInfo.IncrementCounter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void IncrementCounter([NativeTypeName("DWORD")] uint dwCounterIndex, [NativeTypeName("DWORD")] uint dwValue = 1)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpPerfCounterInfo*, uint, uint, void>)(lpVtbl[0]))((IHttpPerfCounterInfo*)Unsafe.AsPointer(ref this), dwCounterIndex, dwValue);
    }

    /// <include file='IHttpPerfCounterInfo.xml' path='doc/member[@name="IHttpPerfCounterInfo.DecrementCounter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void DecrementCounter([NativeTypeName("DWORD")] uint dwCounterIndex, [NativeTypeName("DWORD")] uint dwValue = 1)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpPerfCounterInfo*, uint, uint, void>)(lpVtbl[1]))((IHttpPerfCounterInfo*)Unsafe.AsPointer(ref this), dwCounterIndex, dwValue);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        void IncrementCounter([NativeTypeName("DWORD")] uint dwCounterIndex, [NativeTypeName("DWORD")] uint dwValue = 1);

        [VtblIndex(1)]
        void DecrementCounter([NativeTypeName("DWORD")] uint dwCounterIndex, [NativeTypeName("DWORD")] uint dwValue = 1);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, void> IncrementCounter;

        [NativeTypeName("void (DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, void> DecrementCounter;
    }
}
