// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IApplicationDocumentLists.xml' path='doc/member[@name="IApplicationDocumentLists"]/*' />
[Guid("3C594F9F-9F30-47A1-979A-C9E83D3D0A06")]
[NativeTypeName("struct IApplicationDocumentLists : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IApplicationDocumentLists : IApplicationDocumentLists.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IApplicationDocumentLists);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDocumentLists*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDocumentLists*, uint>)(lpVtbl[1]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDocumentLists*, uint>)(lpVtbl[2]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IApplicationDocumentLists.xml' path='doc/member[@name="IApplicationDocumentLists.SetAppID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAppID([NativeTypeName("LPCWSTR")] char* pszAppID)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDocumentLists*, char*, int>)(lpVtbl[3]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this), pszAppID);
    }

    /// <include file='IApplicationDocumentLists.xml' path='doc/member[@name="IApplicationDocumentLists.GetList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetList(APPDOCLISTTYPE listtype, uint cItemsDesired, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDocumentLists*, APPDOCLISTTYPE, uint, Guid*, void**, int>)(lpVtbl[4]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this), listtype, cItemsDesired, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAppID([NativeTypeName("LPCWSTR")] char* pszAppID);

        [VtblIndex(4)]
        HRESULT GetList(APPDOCLISTTYPE listtype, uint cItemsDesired, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetAppID;

        [NativeTypeName("HRESULT (APPDOCLISTTYPE, UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, APPDOCLISTTYPE, uint, Guid*, void**, int> GetList;
    }
}
