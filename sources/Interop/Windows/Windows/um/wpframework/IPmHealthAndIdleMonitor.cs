// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IPmHealthAndIdleMonitor.xml' path='doc/member[@name="IPmHealthAndIdleMonitor"]/*' />
[NativeTypeName("struct IPmHealthAndIdleMonitor : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IPmHealthAndIdleMonitor : IPmHealthAndIdleMonitor.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPmHealthAndIdleMonitor*, uint>)(lpVtbl[0]))((IPmHealthAndIdleMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPmHealthAndIdleMonitor*, uint>)(lpVtbl[1]))((IPmHealthAndIdleMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPmHealthAndIdleMonitor.xml' path='doc/member[@name="IPmHealthAndIdleMonitor.CheckIdle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT CheckIdle(BOOL* pfIdle)
    {
        return ((delegate* unmanaged[MemberFunction]<IPmHealthAndIdleMonitor*, BOOL*, int>)(lpVtbl[2]))((IPmHealthAndIdleMonitor*)Unsafe.AsPointer(ref this), pfIdle);
    }

    /// <include file='IPmHealthAndIdleMonitor.xml' path='doc/member[@name="IPmHealthAndIdleMonitor.CheckHealth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CheckHealth(IHealthStatusCallback* pIHealthStatusCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IPmHealthAndIdleMonitor*, IHealthStatusCallback*, int>)(lpVtbl[3]))((IPmHealthAndIdleMonitor*)Unsafe.AsPointer(ref this), pIHealthStatusCallback);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT CheckIdle(BOOL* pfIdle);

        [VtblIndex(3)]
        HRESULT CheckHealth(IHealthStatusCallback* pIHealthStatusCallback);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (BOOL *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> CheckIdle;

        [NativeTypeName("HRESULT (IHealthStatusCallback *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHealthStatusCallback*, int> CheckHealth;
    }
}
