// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IXblIdpAuthTokenResult2.xml' path='doc/member[@name="IXblIdpAuthTokenResult2"]/*' />
[Guid("75D760B0-60B9-412D-994F-26B2CD5F7812")]
[NativeTypeName("struct IXblIdpAuthTokenResult2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXblIdpAuthTokenResult2 : IXblIdpAuthTokenResult2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IXblIdpAuthTokenResult2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IXblIdpAuthTokenResult2*, Guid*, void**, int>)(lpVtbl[0]))((IXblIdpAuthTokenResult2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IXblIdpAuthTokenResult2*, uint>)(lpVtbl[1]))((IXblIdpAuthTokenResult2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IXblIdpAuthTokenResult2*, uint>)(lpVtbl[2]))((IXblIdpAuthTokenResult2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXblIdpAuthTokenResult2.xml' path='doc/member[@name="IXblIdpAuthTokenResult2.GetModernGamertag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetModernGamertag([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXblIdpAuthTokenResult2*, char**, int>)(lpVtbl[3]))((IXblIdpAuthTokenResult2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXblIdpAuthTokenResult2.xml' path='doc/member[@name="IXblIdpAuthTokenResult2.GetModernGamertagSuffix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetModernGamertagSuffix([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXblIdpAuthTokenResult2*, char**, int>)(lpVtbl[4]))((IXblIdpAuthTokenResult2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXblIdpAuthTokenResult2.xml' path='doc/member[@name="IXblIdpAuthTokenResult2.GetUniqueModernGamertag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetUniqueModernGamertag([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXblIdpAuthTokenResult2*, char**, int>)(lpVtbl[5]))((IXblIdpAuthTokenResult2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetModernGamertag([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(4)]
        HRESULT GetModernGamertagSuffix([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(5)]
        HRESULT GetUniqueModernGamertag([NativeTypeName("LPWSTR *")] char** value);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetModernGamertag;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetModernGamertagSuffix;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetUniqueModernGamertag;
    }
}
