// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpMethodStatics.xml' path='doc/member[@name="IHttpMethodStatics"]/*' />
[Guid("64D171F0-D99A-4153-8DC6-D68CC4CCE317")]
[NativeTypeName("struct IHttpMethodStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpMethodStatics : IHttpMethodStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpMethodStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, Guid*, void**, int>)(lpVtbl[0]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, uint>)(lpVtbl[1]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, uint>)(lpVtbl[2]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, HSTRING*, int>)(lpVtbl[4]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, TrustLevel*, int>)(lpVtbl[5]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpMethodStatics.xml' path='doc/member[@name="IHttpMethodStatics.get_Delete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Delete([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, IHttpMethod**, int>)(lpVtbl[6]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpMethodStatics.xml' path='doc/member[@name="IHttpMethodStatics.get_Get"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Get([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, IHttpMethod**, int>)(lpVtbl[7]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpMethodStatics.xml' path='doc/member[@name="IHttpMethodStatics.get_Head"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Head([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, IHttpMethod**, int>)(lpVtbl[8]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpMethodStatics.xml' path='doc/member[@name="IHttpMethodStatics.get_Options"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Options([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, IHttpMethod**, int>)(lpVtbl[9]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpMethodStatics.xml' path='doc/member[@name="IHttpMethodStatics.get_Patch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Patch([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, IHttpMethod**, int>)(lpVtbl[10]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpMethodStatics.xml' path='doc/member[@name="IHttpMethodStatics.get_Post"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Post([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, IHttpMethod**, int>)(lpVtbl[11]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpMethodStatics.xml' path='doc/member[@name="IHttpMethodStatics.get_Put"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Put([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMethodStatics*, IHttpMethod**, int>)(lpVtbl[12]))((IHttpMethodStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Delete([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value);

        [VtblIndex(7)]
        HRESULT get_Get([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value);

        [VtblIndex(8)]
        HRESULT get_Head([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value);

        [VtblIndex(9)]
        HRESULT get_Options([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value);

        [VtblIndex(10)]
        HRESULT get_Patch([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value);

        [VtblIndex(11)]
        HRESULT get_Post([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value);

        [VtblIndex(12)]
        HRESULT get_Put([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpMethod**, int> get_Delete;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpMethod**, int> get_Get;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpMethod**, int> get_Head;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpMethod**, int> get_Options;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpMethod**, int> get_Patch;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpMethod**, int> get_Post;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpMethod**, int> get_Put;
    }
}
