// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IApplicationAssociationRegistrationUI.xml' path='doc/member[@name="IApplicationAssociationRegistrationUI"]/*' />
[Guid("1F76A169-F994-40AC-8FC8-0959E8874710")]
[NativeTypeName("struct IApplicationAssociationRegistrationUI : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IApplicationAssociationRegistrationUI : IApplicationAssociationRegistrationUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationAssociationRegistrationUI));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationAssociationRegistrationUI*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationAssociationRegistrationUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationAssociationRegistrationUI*, uint>)(lpVtbl[1]))((IApplicationAssociationRegistrationUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationAssociationRegistrationUI*, uint>)(lpVtbl[2]))((IApplicationAssociationRegistrationUI*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IApplicationAssociationRegistrationUI.xml' path='doc/member[@name="IApplicationAssociationRegistrationUI.LaunchAdvancedAssociationUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LaunchAdvancedAssociationUI([NativeTypeName("LPCWSTR")] char* pszAppRegistryName)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationAssociationRegistrationUI*, char*, int>)(lpVtbl[3]))((IApplicationAssociationRegistrationUI*)Unsafe.AsPointer(ref this), pszAppRegistryName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LaunchAdvancedAssociationUI([NativeTypeName("LPCWSTR")] char* pszAppRegistryName);
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> LaunchAdvancedAssociationUI;
    }
}
