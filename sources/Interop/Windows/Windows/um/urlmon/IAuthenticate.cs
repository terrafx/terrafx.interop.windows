// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAuthenticate.xml' path='doc/member[@name="IAuthenticate"]/*' />
[Guid("79EAC9D0-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IAuthenticate : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAuthenticate : IAuthenticate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAuthenticate));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAuthenticate*, Guid*, void**, int>)(lpVtbl[0]))((IAuthenticate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAuthenticate*, uint>)(lpVtbl[1]))((IAuthenticate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAuthenticate*, uint>)(lpVtbl[2]))((IAuthenticate*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAuthenticate.xml' path='doc/member[@name="IAuthenticate.Authenticate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Authenticate(HWND* phwnd, [NativeTypeName("LPWSTR *")] char** pszUsername, [NativeTypeName("LPWSTR *")] char** pszPassword)
    {
        return ((delegate* unmanaged[MemberFunction]<IAuthenticate*, HWND*, char**, char**, int>)(lpVtbl[3]))((IAuthenticate*)Unsafe.AsPointer(ref this), phwnd, pszUsername, pszPassword);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Authenticate(HWND* phwnd, [NativeTypeName("LPWSTR *")] char** pszUsername, [NativeTypeName("LPWSTR *")] char** pszPassword);
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

        [NativeTypeName("HRESULT (HWND *, LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND*, char**, char**, int> Authenticate;
    }
}
