// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostMappingExtension.xml' path='doc/member[@name="IAppHostMappingExtension"]/*' />
[Guid("31A83EA0-C0E4-4A2C-8A01-353CC2A4C60A")]
[NativeTypeName("struct IAppHostMappingExtension : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostMappingExtension : IAppHostMappingExtension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostMappingExtension));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMappingExtension*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostMappingExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMappingExtension*, uint>)(lpVtbl[1]))((IAppHostMappingExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMappingExtension*, uint>)(lpVtbl[2]))((IAppHostMappingExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostMappingExtension.xml' path='doc/member[@name="IAppHostMappingExtension.GetSiteNameFromSiteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSiteNameFromSiteId([NativeTypeName("DWORD")] uint dwSiteId, [NativeTypeName("BSTR *")] char** pbstrSiteName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMappingExtension*, uint, char**, int>)(lpVtbl[3]))((IAppHostMappingExtension*)Unsafe.AsPointer(ref this), dwSiteId, pbstrSiteName);
    }

    /// <include file='IAppHostMappingExtension.xml' path='doc/member[@name="IAppHostMappingExtension.GetSiteIdFromSiteName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSiteIdFromSiteName([NativeTypeName("BSTR")] char* bstrSiteName, [NativeTypeName("DWORD *")] uint* pdwSiteId)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMappingExtension*, char*, uint*, int>)(lpVtbl[4]))((IAppHostMappingExtension*)Unsafe.AsPointer(ref this), bstrSiteName, pdwSiteId);
    }

    /// <include file='IAppHostMappingExtension.xml' path='doc/member[@name="IAppHostMappingExtension.GetSiteElementFromSiteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSiteElementFromSiteId([NativeTypeName("DWORD")] uint dwSiteId, IAppHostElement** ppSiteElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMappingExtension*, uint, IAppHostElement**, int>)(lpVtbl[5]))((IAppHostMappingExtension*)Unsafe.AsPointer(ref this), dwSiteId, ppSiteElement);
    }

    /// <include file='IAppHostMappingExtension.xml' path='doc/member[@name="IAppHostMappingExtension.MapPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT MapPath([NativeTypeName("BSTR")] char* bstrSiteName, [NativeTypeName("BSTR")] char* bstrVirtualPath, [NativeTypeName("BSTR *")] char** pbstrPhysicalPath, IAppHostElement** ppVirtualDirectoryElement, IAppHostElement** ppApplicationElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMappingExtension*, char*, char*, char**, IAppHostElement**, IAppHostElement**, int>)(lpVtbl[6]))((IAppHostMappingExtension*)Unsafe.AsPointer(ref this), bstrSiteName, bstrVirtualPath, pbstrPhysicalPath, ppVirtualDirectoryElement, ppApplicationElement);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSiteNameFromSiteId([NativeTypeName("DWORD")] uint dwSiteId, [NativeTypeName("BSTR *")] char** pbstrSiteName);

        [VtblIndex(4)]
        HRESULT GetSiteIdFromSiteName([NativeTypeName("BSTR")] char* bstrSiteName, [NativeTypeName("DWORD *")] uint* pdwSiteId);

        [VtblIndex(5)]
        HRESULT GetSiteElementFromSiteId([NativeTypeName("DWORD")] uint dwSiteId, IAppHostElement** ppSiteElement);

        [VtblIndex(6)]
        HRESULT MapPath([NativeTypeName("BSTR")] char* bstrSiteName, [NativeTypeName("BSTR")] char* bstrVirtualPath, [NativeTypeName("BSTR *")] char** pbstrPhysicalPath, IAppHostElement** ppVirtualDirectoryElement, IAppHostElement** ppApplicationElement);
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

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, int> GetSiteNameFromSiteId;

        [NativeTypeName("HRESULT (BSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, int> GetSiteIdFromSiteName;

        [NativeTypeName("HRESULT (DWORD, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IAppHostElement**, int> GetSiteElementFromSiteId;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR *, IAppHostElement **, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char**, IAppHostElement**, IAppHostElement**, int> MapPath;
    }
}
