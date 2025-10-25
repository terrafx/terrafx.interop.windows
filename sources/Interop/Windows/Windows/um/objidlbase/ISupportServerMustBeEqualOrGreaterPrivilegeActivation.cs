// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISupportServerMustBeEqualOrGreaterPrivilegeActivation.xml' path='doc/member[@name="ISupportServerMustBeEqualOrGreaterPrivilegeActivation"]/*' />
[Guid("5BDB3EE2-46BC-4313-B5FB-801C360BA5F9")]
[NativeTypeName("struct ISupportServerMustBeEqualOrGreaterPrivilegeActivation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISupportServerMustBeEqualOrGreaterPrivilegeActivation : ISupportServerMustBeEqualOrGreaterPrivilegeActivation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISupportServerMustBeEqualOrGreaterPrivilegeActivation);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISupportServerMustBeEqualOrGreaterPrivilegeActivation*, Guid*, void**, int>)(lpVtbl[0]))((ISupportServerMustBeEqualOrGreaterPrivilegeActivation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISupportServerMustBeEqualOrGreaterPrivilegeActivation*, uint>)(lpVtbl[1]))((ISupportServerMustBeEqualOrGreaterPrivilegeActivation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISupportServerMustBeEqualOrGreaterPrivilegeActivation*, uint>)(lpVtbl[2]))((ISupportServerMustBeEqualOrGreaterPrivilegeActivation*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;
    }
}
