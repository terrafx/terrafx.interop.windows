// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection"]/*' />
[Guid("7A990969-FA3F-41ED-AAC6-BF957975C16B")]
[NativeTypeName("struct IHttpResponseHeaderCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpResponseHeaderCollection : IHttpResponseHeaderCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpResponseHeaderCollection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, Guid*, void**, int>)(lpVtbl[0]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, uint>)(lpVtbl[1]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, uint>)(lpVtbl[2]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, HSTRING*, int>)(lpVtbl[4]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, TrustLevel*, int>)(lpVtbl[5]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.get_Age"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Age([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IReference<TimeSpan>**, int>)(lpVtbl[6]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.put_Age"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Age([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IReference<TimeSpan>*, int>)(lpVtbl[7]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.get_Allow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Allow([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMethodHeaderValueCollection **")] IHttpMethodHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IHttpMethodHeaderValueCollection**, int>)(lpVtbl[8]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.get_CacheControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CacheControl([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCacheDirectiveHeaderValueCollection **")] IHttpCacheDirectiveHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IHttpCacheDirectiveHeaderValueCollection**, int>)(lpVtbl[9]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.get_Connection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Connection([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpConnectionOptionHeaderValueCollection **")] IHttpConnectionOptionHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IHttpConnectionOptionHeaderValueCollection**, int>)(lpVtbl[10]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.get_Date"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Date([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IReference<DateTime>**, int>)(lpVtbl[11]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.put_Date"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Date([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IReference<DateTime>*, int>)(lpVtbl[12]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.get_Location"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Location([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IUriRuntimeClass**, int>)(lpVtbl[13]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.put_Location"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Location([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IUriRuntimeClass*, int>)(lpVtbl[14]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.get_ProxyAuthenticate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ProxyAuthenticate([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValueCollection **")] IHttpChallengeHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IHttpChallengeHeaderValueCollection**, int>)(lpVtbl[15]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.get_RetryAfter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_RetryAfter([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue **")] IHttpDateOrDeltaHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IHttpDateOrDeltaHeaderValue**, int>)(lpVtbl[16]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.put_RetryAfter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_RetryAfter([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue *")] IHttpDateOrDeltaHeaderValue* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IHttpDateOrDeltaHeaderValue*, int>)(lpVtbl[17]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.get_TransferEncoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_TransferEncoding([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValueCollection **")] IHttpTransferCodingHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IHttpTransferCodingHeaderValueCollection**, int>)(lpVtbl[18]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.get_WwwAuthenticate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_WwwAuthenticate([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValueCollection **")] IHttpChallengeHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, IHttpChallengeHeaderValueCollection**, int>)(lpVtbl[19]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.Append"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT Append(HSTRING name, HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, HSTRING, HSTRING, int>)(lpVtbl[20]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), name, value);
    }

    /// <include file='IHttpResponseHeaderCollection.xml' path='doc/member[@name="IHttpResponseHeaderCollection.TryAppendWithoutValidation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT TryAppendWithoutValidation(HSTRING name, HSTRING value, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseHeaderCollection*, HSTRING, HSTRING, byte*, int>)(lpVtbl[21]))((IHttpResponseHeaderCollection*)Unsafe.AsPointer(ref this), name, value, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Age([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(7)]
        HRESULT put_Age([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(8)]
        HRESULT get_Allow([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMethodHeaderValueCollection **")] IHttpMethodHeaderValueCollection** value);

        [VtblIndex(9)]
        HRESULT get_CacheControl([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCacheDirectiveHeaderValueCollection **")] IHttpCacheDirectiveHeaderValueCollection** value);

        [VtblIndex(10)]
        HRESULT get_Connection([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpConnectionOptionHeaderValueCollection **")] IHttpConnectionOptionHeaderValueCollection** value);

        [VtblIndex(11)]
        HRESULT get_Date([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(12)]
        HRESULT put_Date([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(13)]
        HRESULT get_Location([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(14)]
        HRESULT put_Location([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(15)]
        HRESULT get_ProxyAuthenticate([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValueCollection **")] IHttpChallengeHeaderValueCollection** value);

        [VtblIndex(16)]
        HRESULT get_RetryAfter([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue **")] IHttpDateOrDeltaHeaderValue** value);

        [VtblIndex(17)]
        HRESULT put_RetryAfter([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue *")] IHttpDateOrDeltaHeaderValue* value);

        [VtblIndex(18)]
        HRESULT get_TransferEncoding([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValueCollection **")] IHttpTransferCodingHeaderValueCollection** value);

        [VtblIndex(19)]
        HRESULT get_WwwAuthenticate([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValueCollection **")] IHttpChallengeHeaderValueCollection** value);

        [VtblIndex(20)]
        HRESULT Append(HSTRING name, HSTRING value);

        [VtblIndex(21)]
        HRESULT TryAppendWithoutValidation(HSTRING name, HSTRING value, [NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_Age;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_Age;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpMethodHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpMethodHeaderValueCollection**, int> get_Allow;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpCacheDirectiveHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpCacheDirectiveHeaderValueCollection**, int> get_CacheControl;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpConnectionOptionHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpConnectionOptionHeaderValueCollection**, int> get_Connection;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_Date;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_Date;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_Location;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_Location;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpChallengeHeaderValueCollection**, int> get_ProxyAuthenticate;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpDateOrDeltaHeaderValue**, int> get_RetryAfter;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpDateOrDeltaHeaderValue*, int> put_RetryAfter;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpTransferCodingHeaderValueCollection**, int> get_TransferEncoding;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpChallengeHeaderValueCollection**, int> get_WwwAuthenticate;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, int> Append;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, byte*, int> TryAppendWithoutValidation;
    }
}
