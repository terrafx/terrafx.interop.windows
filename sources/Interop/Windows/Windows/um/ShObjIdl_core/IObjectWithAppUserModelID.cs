// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IObjectWithAppUserModelID.xml' path='doc/member[@name="IObjectWithAppUserModelID"]/*' />
[Guid("36DB0196-9665-46D1-9BA7-D3709EECF9ED")]
[NativeTypeName("struct IObjectWithAppUserModelID : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IObjectWithAppUserModelID : IObjectWithAppUserModelID.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IObjectWithAppUserModelID));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IObjectWithAppUserModelID*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithAppUserModelID*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IObjectWithAppUserModelID*, uint>)(lpVtbl[1]))((IObjectWithAppUserModelID*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IObjectWithAppUserModelID*, uint>)(lpVtbl[2]))((IObjectWithAppUserModelID*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IObjectWithAppUserModelID.xml' path='doc/member[@name="IObjectWithAppUserModelID.SetAppID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAppID([NativeTypeName("LPCWSTR")] char* pszAppID)
    {
        return ((delegate* unmanaged[MemberFunction]<IObjectWithAppUserModelID*, char*, int>)(lpVtbl[3]))((IObjectWithAppUserModelID*)Unsafe.AsPointer(ref this), pszAppID);
    }

    /// <include file='IObjectWithAppUserModelID.xml' path='doc/member[@name="IObjectWithAppUserModelID.GetAppID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAppID([NativeTypeName("LPWSTR *")] char** ppszAppID)
    {
        return ((delegate* unmanaged[MemberFunction]<IObjectWithAppUserModelID*, char**, int>)(lpVtbl[4]))((IObjectWithAppUserModelID*)Unsafe.AsPointer(ref this), ppszAppID);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAppID([NativeTypeName("LPCWSTR")] char* pszAppID);

        [VtblIndex(4)]
        HRESULT GetAppID([NativeTypeName("LPWSTR *")] char** ppszAppID);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetAppID;
    }
}
