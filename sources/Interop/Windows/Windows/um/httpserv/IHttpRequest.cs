// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest"]/*' />
[Guid("E8698F7E-576E-4CAC-A309-67435355FAEF")]
public unsafe partial struct IHttpRequest : IHttpRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpRequest));

    public void** lpVtbl;

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetRawHttpRequestConst"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("const HTTP_REQUEST *")]
    public HTTP_REQUEST_V2* GetRawHttpRequestConst()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, HTTP_REQUEST_V2*>)(lpVtbl[0]))((IHttpRequest*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetRawHttpRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("HTTP_REQUEST *")]
    public HTTP_REQUEST_V2* GetRawHttpRequest()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, HTTP_REQUEST_V2*>)(lpVtbl[1]))((IHttpRequest*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetHeader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHeader(HTTP_HEADER_ID ulHeaderIndex, ushort* pcchHeaderValue = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, HTTP_HEADER_ID, ushort*, sbyte*>)(lpVtbl[2]))((IHttpRequest*)Unsafe.AsPointer(ref this), ulHeaderIndex, pcchHeaderValue);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetHeader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName, ushort* pcchHeaderValue = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, sbyte*, ushort*, sbyte*>)(lpVtbl[3]))((IHttpRequest*)Unsafe.AsPointer(ref this), pszHeaderName, pcchHeaderValue);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.SetHeader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetHeader(HTTP_HEADER_ID ulHeaderIndex, [NativeTypeName("PCSTR")] sbyte* pszHeaderValue, ushort cchHeaderValue, BOOL fReplace)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, HTTP_HEADER_ID, sbyte*, ushort, BOOL, int>)(lpVtbl[4]))((IHttpRequest*)Unsafe.AsPointer(ref this), ulHeaderIndex, pszHeaderValue, cchHeaderValue, fReplace);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.SetHeader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName, [NativeTypeName("PCSTR")] sbyte* pszHeaderValue, ushort cchHeaderValue, BOOL fReplace)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, sbyte*, sbyte*, ushort, BOOL, int>)(lpVtbl[5]))((IHttpRequest*)Unsafe.AsPointer(ref this), pszHeaderName, pszHeaderValue, cchHeaderValue, fReplace);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.DeleteHeader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteHeader(HTTP_HEADER_ID ulHeaderIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, HTTP_HEADER_ID, int>)(lpVtbl[6]))((IHttpRequest*)Unsafe.AsPointer(ref this), ulHeaderIndex);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.DeleteHeader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DeleteHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, sbyte*, int>)(lpVtbl[7]))((IHttpRequest*)Unsafe.AsPointer(ref this), pszHeaderName);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetHttpMethod"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHttpMethod()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, sbyte*>)(lpVtbl[8]))((IHttpRequest*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.SetHttpMethod"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetHttpMethod([NativeTypeName("PCSTR")] sbyte* pszHttpMethod)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, sbyte*, int>)(lpVtbl[9]))((IHttpRequest*)Unsafe.AsPointer(ref this), pszHttpMethod);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.SetUrl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetUrl([NativeTypeName("PCSTR")] sbyte* pszUrl, [NativeTypeName("DWORD")] uint cchUrl, BOOL fResetQueryString)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, sbyte*, uint, BOOL, int>)(lpVtbl[10]))((IHttpRequest*)Unsafe.AsPointer(ref this), pszUrl, cchUrl, fResetQueryString);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.SetUrl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetUrl([NativeTypeName("PCWSTR")] char* pszUrl, [NativeTypeName("DWORD")] uint cchUrl, BOOL fResetQueryString)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, char*, uint, BOOL, int>)(lpVtbl[11]))((IHttpRequest*)Unsafe.AsPointer(ref this), pszUrl, cchUrl, fResetQueryString);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetUrlChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public BOOL GetUrlChanged()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, int>)(lpVtbl[12]))((IHttpRequest*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetForwardedUrl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetForwardedUrl()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, char*>)(lpVtbl[13]))((IHttpRequest*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetLocalAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("PSOCKADDR")]
    public SOCKADDR* GetLocalAddress()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, SOCKADDR*>)(lpVtbl[14]))((IHttpRequest*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetRemoteAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [return: NativeTypeName("PSOCKADDR")]
    public SOCKADDR* GetRemoteAddress()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, SOCKADDR*>)(lpVtbl[15]))((IHttpRequest*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.ReadEntityBody"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ReadEntityBody(void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer, BOOL fAsync, [NativeTypeName("DWORD *")] uint* pcbBytesReceived, BOOL* pfCompletionPending = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, void*, uint, BOOL, uint*, BOOL*, int>)(lpVtbl[16]))((IHttpRequest*)Unsafe.AsPointer(ref this), pvBuffer, cbBuffer, fAsync, pcbBytesReceived, pfCompletionPending);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.InsertEntityBody"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT InsertEntityBody(void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, void*, uint, int>)(lpVtbl[17]))((IHttpRequest*)Unsafe.AsPointer(ref this), pvBuffer, cbBuffer);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetRemainingEntityBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("DWORD")]
    public uint GetRemainingEntityBytes()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, uint>)(lpVtbl[18]))((IHttpRequest*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetHttpVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void GetHttpVersion(ushort* pMajorVersion, ushort* pMinorVersion)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpRequest*, ushort*, ushort*, void>)(lpVtbl[19]))((IHttpRequest*)Unsafe.AsPointer(ref this), pMajorVersion, pMinorVersion);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetClientCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetClientCertificate(HTTP_SSL_CLIENT_CERT_INFO** ppClientCertInfo, BOOL* pfClientCertNegotiated)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, HTTP_SSL_CLIENT_CERT_INFO**, BOOL*, int>)(lpVtbl[20]))((IHttpRequest*)Unsafe.AsPointer(ref this), ppClientCertInfo, pfClientCertNegotiated);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.NegotiateClientCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT NegotiateClientCertificate(BOOL fAsync, BOOL* pfCompletionPending = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, BOOL, BOOL*, int>)(lpVtbl[21]))((IHttpRequest*)Unsafe.AsPointer(ref this), fAsync, pfCompletionPending);
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetSiteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [return: NativeTypeName("DWORD")]
    public uint GetSiteId()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, uint>)(lpVtbl[22]))((IHttpRequest*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpRequest.xml' path='doc/member[@name="IHttpRequest.GetHeaderChanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetHeaderChanges([NativeTypeName("DWORD")] uint dwOldChangeNumber, [NativeTypeName("DWORD *")] uint* pdwNewChangeNumber, [NativeTypeName("PCSTR[41]")] sbyte** knownHeaderSnapshot, [NativeTypeName("DWORD *")] uint* pdwUnknownHeaderSnapshot, [NativeTypeName("PCSTR **")] sbyte*** ppUnknownHeaderNameSnapshot, [NativeTypeName("PCSTR **")] sbyte*** ppUnknownHeaderValueSnapshot, [NativeTypeName("DWORD[42]")] uint* diffedKnownHeaderIndices, [NativeTypeName("DWORD *")] uint* pdwDiffedUnknownHeaders, [NativeTypeName("DWORD **")] uint** ppDiffedUnknownHeaderIndices)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest*, uint, uint*, sbyte**, uint*, sbyte***, sbyte***, uint*, uint*, uint**, int>)(lpVtbl[23]))((IHttpRequest*)Unsafe.AsPointer(ref this), dwOldChangeNumber, pdwNewChangeNumber, knownHeaderSnapshot, pdwUnknownHeaderSnapshot, ppUnknownHeaderNameSnapshot, ppUnknownHeaderValueSnapshot, diffedKnownHeaderIndices, pdwDiffedUnknownHeaders, ppDiffedUnknownHeaderIndices);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("const HTTP_REQUEST *")]
        HTTP_REQUEST_V2* GetRawHttpRequestConst();

        [VtblIndex(1)]
        [return: NativeTypeName("HTTP_REQUEST *")]
        HTTP_REQUEST_V2* GetRawHttpRequest();

        [VtblIndex(2)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetHeader(HTTP_HEADER_ID ulHeaderIndex, ushort* pcchHeaderValue = null);

        [VtblIndex(3)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName, ushort* pcchHeaderValue = null);

        [VtblIndex(4)]
        HRESULT SetHeader(HTTP_HEADER_ID ulHeaderIndex, [NativeTypeName("PCSTR")] sbyte* pszHeaderValue, ushort cchHeaderValue, BOOL fReplace);

        [VtblIndex(5)]
        HRESULT SetHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName, [NativeTypeName("PCSTR")] sbyte* pszHeaderValue, ushort cchHeaderValue, BOOL fReplace);

        [VtblIndex(6)]
        HRESULT DeleteHeader(HTTP_HEADER_ID ulHeaderIndex);

        [VtblIndex(7)]
        HRESULT DeleteHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName);

        [VtblIndex(8)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetHttpMethod();

        [VtblIndex(9)]
        HRESULT SetHttpMethod([NativeTypeName("PCSTR")] sbyte* pszHttpMethod);

        [VtblIndex(10)]
        HRESULT SetUrl([NativeTypeName("PCSTR")] sbyte* pszUrl, [NativeTypeName("DWORD")] uint cchUrl, BOOL fResetQueryString);

        [VtblIndex(11)]
        HRESULT SetUrl([NativeTypeName("PCWSTR")] char* pszUrl, [NativeTypeName("DWORD")] uint cchUrl, BOOL fResetQueryString);

        [VtblIndex(12)]
        BOOL GetUrlChanged();

        [VtblIndex(13)]
        [return: NativeTypeName("PCWSTR")]
        char* GetForwardedUrl();

        [VtblIndex(14)]
        [return: NativeTypeName("PSOCKADDR")]
        SOCKADDR* GetLocalAddress();

        [VtblIndex(15)]
        [return: NativeTypeName("PSOCKADDR")]
        SOCKADDR* GetRemoteAddress();

        [VtblIndex(16)]
        HRESULT ReadEntityBody(void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer, BOOL fAsync, [NativeTypeName("DWORD *")] uint* pcbBytesReceived, BOOL* pfCompletionPending = null);

        [VtblIndex(17)]
        HRESULT InsertEntityBody(void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer);

        [VtblIndex(18)]
        [return: NativeTypeName("DWORD")]
        uint GetRemainingEntityBytes();

        [VtblIndex(19)]
        void GetHttpVersion(ushort* pMajorVersion, ushort* pMinorVersion);

        [VtblIndex(20)]
        HRESULT GetClientCertificate(HTTP_SSL_CLIENT_CERT_INFO** ppClientCertInfo, BOOL* pfClientCertNegotiated);

        [VtblIndex(21)]
        HRESULT NegotiateClientCertificate(BOOL fAsync, BOOL* pfCompletionPending = null);

        [VtblIndex(22)]
        [return: NativeTypeName("DWORD")]
        uint GetSiteId();

        [VtblIndex(23)]
        HRESULT GetHeaderChanges([NativeTypeName("DWORD")] uint dwOldChangeNumber, [NativeTypeName("DWORD *")] uint* pdwNewChangeNumber, [NativeTypeName("PCSTR[41]")] sbyte** knownHeaderSnapshot, [NativeTypeName("DWORD *")] uint* pdwUnknownHeaderSnapshot, [NativeTypeName("PCSTR **")] sbyte*** ppUnknownHeaderNameSnapshot, [NativeTypeName("PCSTR **")] sbyte*** ppUnknownHeaderValueSnapshot, [NativeTypeName("DWORD[42]")] uint* diffedKnownHeaderIndices, [NativeTypeName("DWORD *")] uint* pdwDiffedUnknownHeaders, [NativeTypeName("DWORD **")] uint** ppDiffedUnknownHeaderIndices);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("const HTTP_REQUEST *() const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_REQUEST_V2*> GetRawHttpRequestConst;

        [NativeTypeName("HTTP_REQUEST *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_REQUEST_V2*> GetRawHttpRequest1;

        [NativeTypeName("PCSTR (HTTP_HEADER_ID, USHORT *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_HEADER_ID, ushort*, sbyte*> GetHeader;

        [NativeTypeName("PCSTR (PCSTR, USHORT *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, ushort*, sbyte*> GetHeader1;

        [NativeTypeName("HRESULT (HTTP_HEADER_ID, PCSTR, USHORT, BOOL)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_HEADER_ID, sbyte*, ushort, BOOL, int> SetHeader;

        [NativeTypeName("HRESULT (PCSTR, PCSTR, USHORT, BOOL)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, sbyte*, ushort, BOOL, int> SetHeader1;

        [NativeTypeName("HRESULT (HTTP_HEADER_ID)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_HEADER_ID, int> DeleteHeader;

        [NativeTypeName("HRESULT (PCSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int> DeleteHeader1;

        [NativeTypeName("PCSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*> GetHttpMethod;

        [NativeTypeName("HRESULT (PCSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int> SetHttpMethod;

        [NativeTypeName("HRESULT (PCSTR, DWORD, BOOL)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, uint, BOOL, int> SetUrl;

        [NativeTypeName("HRESULT (PCWSTR, DWORD, BOOL)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, BOOL, int> SetUrl1;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> GetUrlChanged;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetForwardedUrl;

        [NativeTypeName("PSOCKADDR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SOCKADDR*> GetLocalAddress;

        [NativeTypeName("PSOCKADDR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SOCKADDR*> GetRemoteAddress;

        [NativeTypeName("HRESULT (void *, DWORD, BOOL, DWORD *, BOOL *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, BOOL, uint*, BOOL*, int> ReadEntityBody;

        [NativeTypeName("HRESULT (void *, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, int> InsertEntityBody;

        [NativeTypeName("DWORD ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetRemainingEntityBytes;

        [NativeTypeName("void (USHORT *, USHORT *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, ushort*, void> GetHttpVersion;

        [NativeTypeName("HRESULT (HTTP_SSL_CLIENT_CERT_INFO **, BOOL *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_SSL_CLIENT_CERT_INFO**, BOOL*, int> GetClientCertificate;

        [NativeTypeName("HRESULT (BOOL, BOOL *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, BOOL*, int> NegotiateClientCertificate;

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetSiteId;

        [NativeTypeName("HRESULT (DWORD, DWORD *, PCSTR *, DWORD *, PCSTR **, PCSTR **, DWORD *, DWORD *, DWORD **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, sbyte**, uint*, sbyte***, sbyte***, uint*, uint*, uint**, int> GetHeaderChanges;
    }
}
