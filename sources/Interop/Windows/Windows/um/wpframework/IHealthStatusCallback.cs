// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IHealthStatusCallback.xml' path='doc/member[@name="IHealthStatusCallback"]/*' />
[NativeTypeName("struct IHealthStatusCallback : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IHealthStatusCallback : IHealthStatusCallback.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHealthStatusCallback*, uint>)(lpVtbl[0]))((IHealthStatusCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHealthStatusCallback*, uint>)(lpVtbl[1]))((IHealthStatusCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHealthStatusCallback.xml' path='doc/member[@name="IHealthStatusCallback.ReportHealth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT ReportHealth(BOOL fHealthy)
    {
        return ((delegate* unmanaged[MemberFunction]<IHealthStatusCallback*, BOOL, int>)(lpVtbl[2]))((IHealthStatusCallback*)Unsafe.AsPointer(ref this), fHealthy);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT ReportHealth(BOOL fHealthy);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (BOOL)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> ReportHealth;
    }
}
