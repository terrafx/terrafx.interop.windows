// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4E530B0A-E611-4C77-A3AC-9031D022281B")]
    [NativeTypeName("struct IApplicationAssociationRegistration : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IApplicationAssociationRegistration
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IApplicationAssociationRegistration*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApplicationAssociationRegistration*, uint>)(lpVtbl[1]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApplicationAssociationRegistration*, uint>)(lpVtbl[2]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCurrentDefault([NativeTypeName("LPCWSTR")] ushort* pszQuery, ASSOCIATIONTYPE atQueryType, ASSOCIATIONLEVEL alQueryLevel, [NativeTypeName("LPWSTR *")] ushort** ppszAssociation)
        {
            return ((delegate* unmanaged<IApplicationAssociationRegistration*, ushort*, ASSOCIATIONTYPE, ASSOCIATIONLEVEL, ushort**, int>)(lpVtbl[3]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this), pszQuery, atQueryType, alQueryLevel, ppszAssociation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int QueryAppIsDefault([NativeTypeName("LPCWSTR")] ushort* pszQuery, ASSOCIATIONTYPE atQueryType, ASSOCIATIONLEVEL alQueryLevel, [NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName, BOOL* pfDefault)
        {
            return ((delegate* unmanaged<IApplicationAssociationRegistration*, ushort*, ASSOCIATIONTYPE, ASSOCIATIONLEVEL, ushort*, BOOL*, int>)(lpVtbl[4]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this), pszQuery, atQueryType, alQueryLevel, pszAppRegistryName, pfDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int QueryAppIsDefaultAll(ASSOCIATIONLEVEL alQueryLevel, [NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName, BOOL* pfDefault)
        {
            return ((delegate* unmanaged<IApplicationAssociationRegistration*, ASSOCIATIONLEVEL, ushort*, BOOL*, int>)(lpVtbl[5]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this), alQueryLevel, pszAppRegistryName, pfDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetAppAsDefault([NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName, [NativeTypeName("LPCWSTR")] ushort* pszSet, ASSOCIATIONTYPE atSetType)
        {
            return ((delegate* unmanaged<IApplicationAssociationRegistration*, ushort*, ushort*, ASSOCIATIONTYPE, int>)(lpVtbl[6]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this), pszAppRegistryName, pszSet, atSetType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetAppAsDefaultAll([NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName)
        {
            return ((delegate* unmanaged<IApplicationAssociationRegistration*, ushort*, int>)(lpVtbl[7]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this), pszAppRegistryName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int ClearUserAssociations()
        {
            return ((delegate* unmanaged<IApplicationAssociationRegistration*, int>)(lpVtbl[8]))((IApplicationAssociationRegistration*)Unsafe.AsPointer(ref this));
        }
    }
}
