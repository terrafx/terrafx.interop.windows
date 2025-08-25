// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpTransferCodingHeaderValueStatics.xml' path='doc/member[@name="IHttpTransferCodingHeaderValueStatics"]/*' />
[Guid("6AB8892A-1A98-4D32-A906-7470A9875CE5")]
[NativeTypeName("struct IHttpTransferCodingHeaderValueStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpTransferCodingHeaderValueStatics : IHttpTransferCodingHeaderValueStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpTransferCodingHeaderValueStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValueStatics*, Guid*, void**, int>)(lpVtbl[0]))((IHttpTransferCodingHeaderValueStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValueStatics*, uint>)(lpVtbl[1]))((IHttpTransferCodingHeaderValueStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValueStatics*, uint>)(lpVtbl[2]))((IHttpTransferCodingHeaderValueStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValueStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpTransferCodingHeaderValueStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValueStatics*, HSTRING*, int>)(lpVtbl[4]))((IHttpTransferCodingHeaderValueStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValueStatics*, TrustLevel*, int>)(lpVtbl[5]))((IHttpTransferCodingHeaderValueStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpTransferCodingHeaderValueStatics.xml' path='doc/member[@name="IHttpTransferCodingHeaderValueStatics.Parse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Parse(HSTRING input, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValue **")] IHttpTransferCodingHeaderValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValueStatics*, HSTRING, IHttpTransferCodingHeaderValue**, int>)(lpVtbl[6]))((IHttpTransferCodingHeaderValueStatics*)Unsafe.AsPointer(ref this), input, result);
    }

    /// <include file='IHttpTransferCodingHeaderValueStatics.xml' path='doc/member[@name="IHttpTransferCodingHeaderValueStatics.TryParse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryParse(HSTRING input, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValue **")] IHttpTransferCodingHeaderValue** transferCodingHeaderValue, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValueStatics*, HSTRING, IHttpTransferCodingHeaderValue**, byte*, int>)(lpVtbl[7]))((IHttpTransferCodingHeaderValueStatics*)Unsafe.AsPointer(ref this), input, transferCodingHeaderValue, succeeded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Parse(HSTRING input, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValue **")] IHttpTransferCodingHeaderValue** result);

        [VtblIndex(7)]
        HRESULT TryParse(HSTRING input, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValue **")] IHttpTransferCodingHeaderValue** transferCodingHeaderValue, [NativeTypeName("boolean *")] byte* succeeded);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpTransferCodingHeaderValue**, int> Parse;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValue **, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpTransferCodingHeaderValue**, byte*, int> TryParse;
    }
}
