// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection"]/*' />
[Guid("AF40329B-B544-469B-86B9-AC3D466FEA36")]
[NativeTypeName("struct IHttpRequestHeaderCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpRequestHeaderCollection : IHttpRequestHeaderCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpRequestHeaderCollection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, Guid*, void**, int>)(lpVtbl[0]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, uint>)(lpVtbl[1]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, uint>)(lpVtbl[2]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, HSTRING*, int>)(lpVtbl[4]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, TrustLevel*, int>)(lpVtbl[5]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_Accept"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Accept([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMediaTypeWithQualityHeaderValueCollection **")] IHttpMediaTypeWithQualityHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpMediaTypeWithQualityHeaderValueCollection**, int>)(lpVtbl[6]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_AcceptEncoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AcceptEncoding([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentCodingWithQualityHeaderValueCollection **")] IHttpContentCodingWithQualityHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpContentCodingWithQualityHeaderValueCollection**, int>)(lpVtbl[7]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_AcceptLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AcceptLanguage([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValueCollection **")] IHttpLanguageRangeWithQualityHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpLanguageRangeWithQualityHeaderValueCollection**, int>)(lpVtbl[8]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_Authorization"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Authorization([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **")] IHttpCredentialsHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpCredentialsHeaderValue**, int>)(lpVtbl[9]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.put_Authorization"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Authorization([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue *")] IHttpCredentialsHeaderValue* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpCredentialsHeaderValue*, int>)(lpVtbl[10]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_CacheControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CacheControl([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCacheDirectiveHeaderValueCollection **")] IHttpCacheDirectiveHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpCacheDirectiveHeaderValueCollection**, int>)(lpVtbl[11]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_Connection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Connection([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpConnectionOptionHeaderValueCollection **")] IHttpConnectionOptionHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpConnectionOptionHeaderValueCollection**, int>)(lpVtbl[12]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_Cookie"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Cookie([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValueCollection **")] IHttpCookiePairHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpCookiePairHeaderValueCollection**, int>)(lpVtbl[13]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_Date"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Date([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IReference<DateTime>**, int>)(lpVtbl[14]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.put_Date"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Date([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IReference<DateTime>*, int>)(lpVtbl[15]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_Expect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Expect([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValueCollection **")] IHttpExpectationHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpExpectationHeaderValueCollection**, int>)(lpVtbl[16]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_From"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_From(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, HSTRING*, int>)(lpVtbl[17]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.put_From"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_From(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, HSTRING, int>)(lpVtbl[18]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_Host"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Host([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHostName**, int>)(lpVtbl[19]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.put_Host"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_Host([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHostName*, int>)(lpVtbl[20]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_IfModifiedSince"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_IfModifiedSince([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IReference<DateTime>**, int>)(lpVtbl[21]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.put_IfModifiedSince"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_IfModifiedSince([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IReference<DateTime>*, int>)(lpVtbl[22]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_IfUnmodifiedSince"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_IfUnmodifiedSince([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IReference<DateTime>**, int>)(lpVtbl[23]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.put_IfUnmodifiedSince"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_IfUnmodifiedSince([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IReference<DateTime>*, int>)(lpVtbl[24]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_MaxForwards"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_MaxForwards([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IReference<uint>**, int>)(lpVtbl[25]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.put_MaxForwards"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_MaxForwards([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IReference<uint>*, int>)(lpVtbl[26]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_ProxyAuthorization"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_ProxyAuthorization([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **")] IHttpCredentialsHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpCredentialsHeaderValue**, int>)(lpVtbl[27]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.put_ProxyAuthorization"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_ProxyAuthorization([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue *")] IHttpCredentialsHeaderValue* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpCredentialsHeaderValue*, int>)(lpVtbl[28]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_Referer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_Referer([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IUriRuntimeClass**, int>)(lpVtbl[29]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.put_Referer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_Referer([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IUriRuntimeClass*, int>)(lpVtbl[30]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_TransferEncoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_TransferEncoding([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValueCollection **")] IHttpTransferCodingHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpTransferCodingHeaderValueCollection**, int>)(lpVtbl[31]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.get_UserAgent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_UserAgent([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValueCollection **")] IHttpProductInfoHeaderValueCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, IHttpProductInfoHeaderValueCollection**, int>)(lpVtbl[32]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.Append"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT Append(HSTRING name, HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, HSTRING, HSTRING, int>)(lpVtbl[33]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), name, value);
    }

    /// <include file='IHttpRequestHeaderCollection.xml' path='doc/member[@name="IHttpRequestHeaderCollection.TryAppendWithoutValidation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT TryAppendWithoutValidation(HSTRING name, HSTRING value, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestHeaderCollection*, HSTRING, HSTRING, byte*, int>)(lpVtbl[34]))((IHttpRequestHeaderCollection*)Unsafe.AsPointer(ref this), name, value, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Accept([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMediaTypeWithQualityHeaderValueCollection **")] IHttpMediaTypeWithQualityHeaderValueCollection** value);

        [VtblIndex(7)]
        HRESULT get_AcceptEncoding([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentCodingWithQualityHeaderValueCollection **")] IHttpContentCodingWithQualityHeaderValueCollection** value);

        [VtblIndex(8)]
        HRESULT get_AcceptLanguage([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValueCollection **")] IHttpLanguageRangeWithQualityHeaderValueCollection** value);

        [VtblIndex(9)]
        HRESULT get_Authorization([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **")] IHttpCredentialsHeaderValue** value);

        [VtblIndex(10)]
        HRESULT put_Authorization([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue *")] IHttpCredentialsHeaderValue* value);

        [VtblIndex(11)]
        HRESULT get_CacheControl([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCacheDirectiveHeaderValueCollection **")] IHttpCacheDirectiveHeaderValueCollection** value);

        [VtblIndex(12)]
        HRESULT get_Connection([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpConnectionOptionHeaderValueCollection **")] IHttpConnectionOptionHeaderValueCollection** value);

        [VtblIndex(13)]
        HRESULT get_Cookie([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValueCollection **")] IHttpCookiePairHeaderValueCollection** value);

        [VtblIndex(14)]
        HRESULT get_Date([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(15)]
        HRESULT put_Date([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(16)]
        HRESULT get_Expect([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValueCollection **")] IHttpExpectationHeaderValueCollection** value);

        [VtblIndex(17)]
        HRESULT get_From(HSTRING* value);

        [VtblIndex(18)]
        HRESULT put_From(HSTRING value);

        [VtblIndex(19)]
        HRESULT get_Host([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);

        [VtblIndex(20)]
        HRESULT put_Host([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* value);

        [VtblIndex(21)]
        HRESULT get_IfModifiedSince([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(22)]
        HRESULT put_IfModifiedSince([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(23)]
        HRESULT get_IfUnmodifiedSince([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(24)]
        HRESULT put_IfUnmodifiedSince([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(25)]
        HRESULT get_MaxForwards([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(26)]
        HRESULT put_MaxForwards([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);

        [VtblIndex(27)]
        HRESULT get_ProxyAuthorization([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **")] IHttpCredentialsHeaderValue** value);

        [VtblIndex(28)]
        HRESULT put_ProxyAuthorization([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue *")] IHttpCredentialsHeaderValue* value);

        [VtblIndex(29)]
        HRESULT get_Referer([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(30)]
        HRESULT put_Referer([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(31)]
        HRESULT get_TransferEncoding([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValueCollection **")] IHttpTransferCodingHeaderValueCollection** value);

        [VtblIndex(32)]
        HRESULT get_UserAgent([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValueCollection **")] IHttpProductInfoHeaderValueCollection** value);

        [VtblIndex(33)]
        HRESULT Append(HSTRING name, HSTRING value);

        [VtblIndex(34)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpMediaTypeWithQualityHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpMediaTypeWithQualityHeaderValueCollection**, int> get_Accept;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpContentCodingWithQualityHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpContentCodingWithQualityHeaderValueCollection**, int> get_AcceptEncoding;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpLanguageRangeWithQualityHeaderValueCollection**, int> get_AcceptLanguage;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpCredentialsHeaderValue**, int> get_Authorization;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpCredentialsHeaderValue*, int> put_Authorization;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpCacheDirectiveHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpCacheDirectiveHeaderValueCollection**, int> get_CacheControl;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpConnectionOptionHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpConnectionOptionHeaderValueCollection**, int> get_Connection;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpCookiePairHeaderValueCollection**, int> get_Cookie;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_Date;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_Date;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpExpectationHeaderValueCollection**, int> get_Expect;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_From;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_From;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_Host;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, int> put_Host;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_IfModifiedSince;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_IfModifiedSince;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_IfUnmodifiedSince;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_IfUnmodifiedSince;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_MaxForwards;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_MaxForwards;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpCredentialsHeaderValue**, int> get_ProxyAuthorization;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpCredentialsHeaderValue*, int> put_ProxyAuthorization;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_Referer;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_Referer;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpTransferCodingHeaderValueCollection**, int> get_TransferEncoding;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpProductInfoHeaderValueCollection**, int> get_UserAgent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, int> Append;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, byte*, int> TryAppendWithoutValidation;
    }
}
