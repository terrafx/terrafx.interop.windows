// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.filters.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpCacheControl.xml' path='doc/member[@name="IHttpCacheControl"]/*' />
[Guid("C77E1CB4-3CEA-4EB5-AC85-04E186E63AB7")]
[NativeTypeName("struct IHttpCacheControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpCacheControl : IHttpCacheControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCacheControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheControl*, Guid*, void**, int>)(lpVtbl[0]))((IHttpCacheControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheControl*, uint>)(lpVtbl[1]))((IHttpCacheControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheControl*, uint>)(lpVtbl[2]))((IHttpCacheControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheControl*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpCacheControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheControl*, HSTRING*, int>)(lpVtbl[4]))((IHttpCacheControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheControl*, TrustLevel*, int>)(lpVtbl[5]))((IHttpCacheControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpCacheControl.xml' path='doc/member[@name="IHttpCacheControl.get_ReadBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ReadBehavior([NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheReadBehavior *")] HttpCacheReadBehavior* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheControl*, HttpCacheReadBehavior*, int>)(lpVtbl[6]))((IHttpCacheControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCacheControl.xml' path='doc/member[@name="IHttpCacheControl.put_ReadBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ReadBehavior([NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheReadBehavior")] HttpCacheReadBehavior value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheControl*, HttpCacheReadBehavior, int>)(lpVtbl[7]))((IHttpCacheControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCacheControl.xml' path='doc/member[@name="IHttpCacheControl.get_WriteBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_WriteBehavior([NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheWriteBehavior *")] HttpCacheWriteBehavior* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheControl*, HttpCacheWriteBehavior*, int>)(lpVtbl[8]))((IHttpCacheControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCacheControl.xml' path='doc/member[@name="IHttpCacheControl.put_WriteBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_WriteBehavior([NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheWriteBehavior")] HttpCacheWriteBehavior value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheControl*, HttpCacheWriteBehavior, int>)(lpVtbl[9]))((IHttpCacheControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ReadBehavior([NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheReadBehavior *")] HttpCacheReadBehavior* value);

        [VtblIndex(7)]
        HRESULT put_ReadBehavior([NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheReadBehavior")] HttpCacheReadBehavior value);

        [VtblIndex(8)]
        HRESULT get_WriteBehavior([NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheWriteBehavior *")] HttpCacheWriteBehavior* value);

        [VtblIndex(9)]
        HRESULT put_WriteBehavior([NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheWriteBehavior")] HttpCacheWriteBehavior value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Filters::HttpCacheReadBehavior *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HttpCacheReadBehavior*, int> get_ReadBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Filters::HttpCacheReadBehavior) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HttpCacheReadBehavior, int> put_ReadBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Filters::HttpCacheWriteBehavior *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HttpCacheWriteBehavior*, int> get_WriteBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Filters::HttpCacheWriteBehavior) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HttpCacheWriteBehavior, int> put_WriteBehavior;
    }
}
