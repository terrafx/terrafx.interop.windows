// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IStaticVerbProvider.xml' path='doc/member[@name="IStaticVerbProvider"]/*' />
[Guid("4B770DA6-D111-4015-96FD-8C1C56F06C55")]
[NativeTypeName("struct IStaticVerbProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStaticVerbProvider : IStaticVerbProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStaticVerbProvider);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStaticVerbProvider*, Guid*, void**, int>)(lpVtbl[0]))((IStaticVerbProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStaticVerbProvider*, uint>)(lpVtbl[1]))((IStaticVerbProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStaticVerbProvider*, uint>)(lpVtbl[2]))((IStaticVerbProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStaticVerbProvider.xml' path='doc/member[@name="IStaticVerbProvider.IsVerbSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsVerbSupported([NativeTypeName("LPCWSTR")] char* verbName, BOOL* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IStaticVerbProvider*, char*, BOOL*, int>)(lpVtbl[3]))((IStaticVerbProvider*)Unsafe.AsPointer(ref this), verbName, result);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsVerbSupported([NativeTypeName("LPCWSTR")] char* verbName, BOOL* result);
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

        [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL*, int> IsVerbSupported;
    }
}
