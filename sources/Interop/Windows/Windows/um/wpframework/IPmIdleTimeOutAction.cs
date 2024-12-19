// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IPmIdleTimeOutAction.xml' path='doc/member[@name="IPmIdleTimeOutAction"]/*' />
[NativeTypeName("struct IPmIdleTimeOutAction : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IPmIdleTimeOutAction : IPmIdleTimeOutAction.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPmIdleTimeOutAction*, uint>)(lpVtbl[0]))((IPmIdleTimeOutAction*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPmIdleTimeOutAction*, uint>)(lpVtbl[1]))((IPmIdleTimeOutAction*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPmIdleTimeOutAction.xml' path='doc/member[@name="IPmIdleTimeOutAction.SuspendProcess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT SuspendProcess()
    {
        return ((delegate* unmanaged[MemberFunction]<IPmIdleTimeOutAction*, int>)(lpVtbl[2]))((IPmIdleTimeOutAction*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT SuspendProcess();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SuspendProcess;
    }
}
