// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostMethodExtension.xml' path='doc/member[@name="IAppHostMethodExtension"]/*' />
[Guid("70184AC9-7673-4770-96B1-445CE035CF70")]
[NativeTypeName("struct IAppHostMethodExtension : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostMethodExtension : IAppHostMethodExtension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostMethodExtension);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodExtension*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostMethodExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodExtension*, uint>)(lpVtbl[1]))((IAppHostMethodExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodExtension*, uint>)(lpVtbl[2]))((IAppHostMethodExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostMethodExtension.xml' path='doc/member[@name="IAppHostMethodExtension.ProvideMethod"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ProvideMethod(IAppHostMethod* pMethod, IAppHostMethodInstance* pMethodInstance, IAppHostElement* pElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodExtension*, IAppHostMethod*, IAppHostMethodInstance*, IAppHostElement*, int>)(lpVtbl[3]))((IAppHostMethodExtension*)Unsafe.AsPointer(ref this), pMethod, pMethodInstance, pElement);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ProvideMethod(IAppHostMethod* pMethod, IAppHostMethodInstance* pMethodInstance, IAppHostElement* pElement);
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

        [NativeTypeName("HRESULT (IAppHostMethod *, IAppHostMethodInstance *, IAppHostElement *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostMethod*, IAppHostMethodInstance*, IAppHostElement*, int> ProvideMethod;
    }
}
