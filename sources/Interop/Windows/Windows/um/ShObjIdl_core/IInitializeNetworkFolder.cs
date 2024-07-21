// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IInitializeNetworkFolder.xml' path='doc/member[@name="IInitializeNetworkFolder"]/*' />
[Guid("6E0F9881-42A8-4F2A-97F8-8AF4E026D92D")]
[NativeTypeName("struct IInitializeNetworkFolder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInitializeNetworkFolder : IInitializeNetworkFolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInitializeNetworkFolder));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeNetworkFolder*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeNetworkFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeNetworkFolder*, uint>)(lpVtbl[1]))((IInitializeNetworkFolder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeNetworkFolder*, uint>)(lpVtbl[2]))((IInitializeNetworkFolder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInitializeNetworkFolder.xml' path='doc/member[@name="IInitializeNetworkFolder.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlTarget, uint uDisplayType, [NativeTypeName("LPCWSTR")] char* pszResName, [NativeTypeName("LPCWSTR")] char* pszProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeNetworkFolder*, ITEMIDLIST*, ITEMIDLIST*, uint, char*, char*, int>)(lpVtbl[3]))((IInitializeNetworkFolder*)Unsafe.AsPointer(ref this), pidl, pidlTarget, uDisplayType, pszResName, pszProvider);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlTarget, uint uDisplayType, [NativeTypeName("LPCWSTR")] char* pszResName, [NativeTypeName("LPCWSTR")] char* pszProvider);
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

        [NativeTypeName("HRESULT (LPCITEMIDLIST, LPCITEMIDLIST, UINT, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITEMIDLIST*, ITEMIDLIST*, uint, char*, char*, int> Initialize;
    }
}
