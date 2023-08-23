// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IApplicationAssociationRegistration.xml' path='doc/member[@name="IApplicationAssociationRegistration"]/*' />
[Guid("4E530B0A-E611-4C77-A3AC-9031D022281B")]
[NativeTypeName("struct IApplicationAssociationRegistration : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IApplicationAssociationRegistration : IApplicationAssociationRegistration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationAssociationRegistration));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistration*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistration*, uint>)(lpVtbl[1]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistration*, uint>)(lpVtbl[2]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IApplicationAssociationRegistration.xml' path='doc/member[@name="IApplicationAssociationRegistration.QueryCurrentDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryCurrentDefault([NativeTypeName("LPCWSTR")] char* pszQuery, ASSOCIATIONTYPE atQueryType, ASSOCIATIONLEVEL alQueryLevel, [NativeTypeName("LPWSTR *")] char** ppszAssociation)
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistration*, char*, ASSOCIATIONTYPE, ASSOCIATIONLEVEL, char**, int>)(lpVtbl[3]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this), pszQuery, atQueryType, alQueryLevel, ppszAssociation);
    }

    /// <include file='IApplicationAssociationRegistration.xml' path='doc/member[@name="IApplicationAssociationRegistration.QueryAppIsDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT QueryAppIsDefault([NativeTypeName("LPCWSTR")] char* pszQuery, ASSOCIATIONTYPE atQueryType, ASSOCIATIONLEVEL alQueryLevel, [NativeTypeName("LPCWSTR")] char* pszAppRegistryName, BOOL* pfDefault)
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistration*, char*, ASSOCIATIONTYPE, ASSOCIATIONLEVEL, char*, BOOL*, int>)(lpVtbl[4]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this), pszQuery, atQueryType, alQueryLevel, pszAppRegistryName, pfDefault);
    }

    /// <include file='IApplicationAssociationRegistration.xml' path='doc/member[@name="IApplicationAssociationRegistration.QueryAppIsDefaultAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QueryAppIsDefaultAll(ASSOCIATIONLEVEL alQueryLevel, [NativeTypeName("LPCWSTR")] char* pszAppRegistryName, BOOL* pfDefault)
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistration*, ASSOCIATIONLEVEL, char*, BOOL*, int>)(lpVtbl[5]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this), alQueryLevel, pszAppRegistryName, pfDefault);
    }

    /// <include file='IApplicationAssociationRegistration.xml' path='doc/member[@name="IApplicationAssociationRegistration.SetAppAsDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAppAsDefault([NativeTypeName("LPCWSTR")] char* pszAppRegistryName, [NativeTypeName("LPCWSTR")] char* pszSet, ASSOCIATIONTYPE atSetType)
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistration*, char*, char*, ASSOCIATIONTYPE, int>)(lpVtbl[6]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this), pszAppRegistryName, pszSet, atSetType);
    }

    /// <include file='IApplicationAssociationRegistration.xml' path='doc/member[@name="IApplicationAssociationRegistration.SetAppAsDefaultAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetAppAsDefaultAll([NativeTypeName("LPCWSTR")] char* pszAppRegistryName)
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistration*, char*, int>)(lpVtbl[7]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this), pszAppRegistryName);
    }

    /// <include file='IApplicationAssociationRegistration.xml' path='doc/member[@name="IApplicationAssociationRegistration.ClearUserAssociations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ClearUserAssociations()
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistration*, int>)(lpVtbl[8]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryCurrentDefault([NativeTypeName("LPCWSTR")] char* pszQuery, ASSOCIATIONTYPE atQueryType, ASSOCIATIONLEVEL alQueryLevel, [NativeTypeName("LPWSTR *")] char** ppszAssociation);

        [VtblIndex(4)]
        HRESULT QueryAppIsDefault([NativeTypeName("LPCWSTR")] char* pszQuery, ASSOCIATIONTYPE atQueryType, ASSOCIATIONLEVEL alQueryLevel, [NativeTypeName("LPCWSTR")] char* pszAppRegistryName, BOOL* pfDefault);

        [VtblIndex(5)]
        HRESULT QueryAppIsDefaultAll(ASSOCIATIONLEVEL alQueryLevel, [NativeTypeName("LPCWSTR")] char* pszAppRegistryName, BOOL* pfDefault);

        [VtblIndex(6)]
        HRESULT SetAppAsDefault([NativeTypeName("LPCWSTR")] char* pszAppRegistryName, [NativeTypeName("LPCWSTR")] char* pszSet, ASSOCIATIONTYPE atSetType);

        [VtblIndex(7)]
        HRESULT SetAppAsDefaultAll([NativeTypeName("LPCWSTR")] char* pszAppRegistryName);

        [VtblIndex(8)]
        HRESULT ClearUserAssociations();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, ASSOCIATIONTYPE, ASSOCIATIONLEVEL, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, char*, ASSOCIATIONTYPE, ASSOCIATIONLEVEL, char**, int> QueryCurrentDefault;

        [NativeTypeName("HRESULT (LPCWSTR, ASSOCIATIONTYPE, ASSOCIATIONLEVEL, LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, char*, ASSOCIATIONTYPE, ASSOCIATIONLEVEL, char*, BOOL*, int> QueryAppIsDefault;

        [NativeTypeName("HRESULT (ASSOCIATIONLEVEL, LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ASSOCIATIONLEVEL, char*, BOOL*, int> QueryAppIsDefaultAll;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, ASSOCIATIONTYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, char*, char*, ASSOCIATIONTYPE, int> SetAppAsDefault;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, char*, int> SetAppAsDefaultAll;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearUserAssociations;
    }
}
