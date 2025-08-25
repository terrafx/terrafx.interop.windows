// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.filters.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpBaseProtocolFilter2.xml' path='doc/member[@name="IHttpBaseProtocolFilter2"]/*' />
[Guid("2EC30013-9427-4900-A017-FA7DA3B5C9AE")]
[NativeTypeName("struct IHttpBaseProtocolFilter2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpBaseProtocolFilter2 : IHttpBaseProtocolFilter2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpBaseProtocolFilter2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter2*, Guid*, void**, int>)(lpVtbl[0]))((IHttpBaseProtocolFilter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter2*, uint>)(lpVtbl[1]))((IHttpBaseProtocolFilter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter2*, uint>)(lpVtbl[2]))((IHttpBaseProtocolFilter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter2*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpBaseProtocolFilter2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter2*, HSTRING*, int>)(lpVtbl[4]))((IHttpBaseProtocolFilter2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter2*, TrustLevel*, int>)(lpVtbl[5]))((IHttpBaseProtocolFilter2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpBaseProtocolFilter2.xml' path='doc/member[@name="IHttpBaseProtocolFilter2.get_MaxVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MaxVersion([NativeTypeName("ABI::Windows::Web::Http::HttpVersion *")] HttpVersion* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter2*, HttpVersion*, int>)(lpVtbl[6]))((IHttpBaseProtocolFilter2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpBaseProtocolFilter2.xml' path='doc/member[@name="IHttpBaseProtocolFilter2.put_MaxVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MaxVersion([NativeTypeName("ABI::Windows::Web::Http::HttpVersion")] HttpVersion value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter2*, HttpVersion, int>)(lpVtbl[7]))((IHttpBaseProtocolFilter2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MaxVersion([NativeTypeName("ABI::Windows::Web::Http::HttpVersion *")] HttpVersion* value);

        [VtblIndex(7)]
        HRESULT put_MaxVersion([NativeTypeName("ABI::Windows::Web::Http::HttpVersion")] HttpVersion value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::HttpVersion *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HttpVersion*, int> get_MaxVersion;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::HttpVersion) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HttpVersion, int> put_MaxVersion;
    }
}
