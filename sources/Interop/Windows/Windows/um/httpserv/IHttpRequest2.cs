// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpRequest2.xml' path='doc/member[@name="IHttpRequest2"]/*' />
[Guid("D9244AE1-51F8-4AA1-A66D-19277C33E610")]
[NativeTypeName("struct IHttpRequest2 : IHttpRequest")]
[NativeInheritance("IHttpRequest")]
public unsafe partial struct IHttpRequest2 : IHttpRequest2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpRequest2));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpRequest.GetRawHttpRequestConst" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("const HTTP_REQUEST *")]
    public HTTP_REQUEST_V2* GetRawHttpRequestConst()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, HTTP_REQUEST_V2*>)(lpVtbl[0]))((IHttpRequest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpRequest.GetRawHttpRequest" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("HTTP_REQUEST *")]
    public HTTP_REQUEST_V2* GetRawHttpRequest()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, HTTP_REQUEST_V2*>)(lpVtbl[1]))((IHttpRequest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpRequest.GetHeader" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHeader(HTTP_HEADER_ID ulHeaderIndex, ushort* pcchHeaderValue = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, HTTP_HEADER_ID, ushort*, sbyte*>)(lpVtbl[2]))((IHttpRequest2*)Unsafe.AsPointer(ref this), ulHeaderIndex, pcchHeaderValue);
    }

    /// <inheritdoc cref="IHttpRequest.GetHeader" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName, ushort* pcchHeaderValue = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, sbyte*, ushort*, sbyte*>)(lpVtbl[3]))((IHttpRequest2*)Unsafe.AsPointer(ref this), pszHeaderName, pcchHeaderValue);
    }

    /// <inheritdoc cref="IHttpRequest.SetHeader" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetHeader(HTTP_HEADER_ID ulHeaderIndex, [NativeTypeName("PCSTR")] sbyte* pszHeaderValue, ushort cchHeaderValue, BOOL fReplace)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, HTTP_HEADER_ID, sbyte*, ushort, BOOL, int>)(lpVtbl[4]))((IHttpRequest2*)Unsafe.AsPointer(ref this), ulHeaderIndex, pszHeaderValue, cchHeaderValue, fReplace);
    }

    /// <inheritdoc cref="IHttpRequest.SetHeader" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName, [NativeTypeName("PCSTR")] sbyte* pszHeaderValue, ushort cchHeaderValue, BOOL fReplace)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, sbyte*, sbyte*, ushort, BOOL, int>)(lpVtbl[5]))((IHttpRequest2*)Unsafe.AsPointer(ref this), pszHeaderName, pszHeaderValue, cchHeaderValue, fReplace);
    }

    /// <inheritdoc cref="IHttpRequest.DeleteHeader" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteHeader(HTTP_HEADER_ID ulHeaderIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, HTTP_HEADER_ID, int>)(lpVtbl[6]))((IHttpRequest2*)Unsafe.AsPointer(ref this), ulHeaderIndex);
    }

    /// <inheritdoc cref="IHttpRequest.DeleteHeader" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DeleteHeader([NativeTypeName("PCSTR")] sbyte* pszHeaderName)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, sbyte*, int>)(lpVtbl[7]))((IHttpRequest2*)Unsafe.AsPointer(ref this), pszHeaderName);
    }

    /// <inheritdoc cref="IHttpRequest.GetHttpMethod" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetHttpMethod()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, sbyte*>)(lpVtbl[8]))((IHttpRequest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpRequest.SetHttpMethod" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetHttpMethod([NativeTypeName("PCSTR")] sbyte* pszHttpMethod)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, sbyte*, int>)(lpVtbl[9]))((IHttpRequest2*)Unsafe.AsPointer(ref this), pszHttpMethod);
    }

    /// <inheritdoc cref="IHttpRequest.SetUrl" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetUrl([NativeTypeName("PCSTR")] sbyte* pszUrl, [NativeTypeName("DWORD")] uint cchUrl, BOOL fResetQueryString)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, sbyte*, uint, BOOL, int>)(lpVtbl[10]))((IHttpRequest2*)Unsafe.AsPointer(ref this), pszUrl, cchUrl, fResetQueryString);
    }

    /// <inheritdoc cref="IHttpRequest.SetUrl" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetUrl([NativeTypeName("PCWSTR")] char* pszUrl, [NativeTypeName("DWORD")] uint cchUrl, BOOL fResetQueryString)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, char*, uint, BOOL, int>)(lpVtbl[11]))((IHttpRequest2*)Unsafe.AsPointer(ref this), pszUrl, cchUrl, fResetQueryString);
    }

    /// <inheritdoc cref="IHttpRequest.GetUrlChanged" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public BOOL GetUrlChanged()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, int>)(lpVtbl[12]))((IHttpRequest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpRequest.GetForwardedUrl" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetForwardedUrl()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, char*>)(lpVtbl[13]))((IHttpRequest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpRequest.GetLocalAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("PSOCKADDR")]
    public SOCKADDR* GetLocalAddress()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, SOCKADDR*>)(lpVtbl[14]))((IHttpRequest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpRequest.GetRemoteAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [return: NativeTypeName("PSOCKADDR")]
    public SOCKADDR* GetRemoteAddress()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, SOCKADDR*>)(lpVtbl[15]))((IHttpRequest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpRequest.ReadEntityBody" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ReadEntityBody(void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer, BOOL fAsync, [NativeTypeName("DWORD *")] uint* pcbBytesReceived, BOOL* pfCompletionPending = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, void*, uint, BOOL, uint*, BOOL*, int>)(lpVtbl[16]))((IHttpRequest2*)Unsafe.AsPointer(ref this), pvBuffer, cbBuffer, fAsync, pcbBytesReceived, pfCompletionPending);
    }

    /// <inheritdoc cref="IHttpRequest.InsertEntityBody" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT InsertEntityBody(void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, void*, uint, int>)(lpVtbl[17]))((IHttpRequest2*)Unsafe.AsPointer(ref this), pvBuffer, cbBuffer);
    }

    /// <inheritdoc cref="IHttpRequest.GetRemainingEntityBytes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("DWORD")]
    public uint GetRemainingEntityBytes()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, uint>)(lpVtbl[18]))((IHttpRequest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpRequest.GetHttpVersion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void GetHttpVersion(ushort* pMajorVersion, ushort* pMinorVersion)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, ushort*, ushort*, void>)(lpVtbl[19]))((IHttpRequest2*)Unsafe.AsPointer(ref this), pMajorVersion, pMinorVersion);
    }

    /// <inheritdoc cref="IHttpRequest.GetClientCertificate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetClientCertificate(HTTP_SSL_CLIENT_CERT_INFO** ppClientCertInfo, BOOL* pfClientCertNegotiated)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, HTTP_SSL_CLIENT_CERT_INFO**, BOOL*, int>)(lpVtbl[20]))((IHttpRequest2*)Unsafe.AsPointer(ref this), ppClientCertInfo, pfClientCertNegotiated);
    }

    /// <inheritdoc cref="IHttpRequest.NegotiateClientCertificate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT NegotiateClientCertificate(BOOL fAsync, BOOL* pfCompletionPending = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, BOOL, BOOL*, int>)(lpVtbl[21]))((IHttpRequest2*)Unsafe.AsPointer(ref this), fAsync, pfCompletionPending);
    }

    /// <inheritdoc cref="IHttpRequest.GetSiteId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [return: NativeTypeName("DWORD")]
    public uint GetSiteId()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, uint>)(lpVtbl[22]))((IHttpRequest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpRequest.GetHeaderChanges" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetHeaderChanges([NativeTypeName("DWORD")] uint dwOldChangeNumber, [NativeTypeName("DWORD *")] uint* pdwNewChangeNumber, [NativeTypeName("PCSTR[41]")] sbyte** knownHeaderSnapshot, [NativeTypeName("DWORD *")] uint* pdwUnknownHeaderSnapshot, [NativeTypeName("PCSTR **")] sbyte*** ppUnknownHeaderNameSnapshot, [NativeTypeName("PCSTR **")] sbyte*** ppUnknownHeaderValueSnapshot, [NativeTypeName("DWORD[42]")] uint* diffedKnownHeaderIndices, [NativeTypeName("DWORD *")] uint* pdwDiffedUnknownHeaders, [NativeTypeName("DWORD **")] uint** ppDiffedUnknownHeaderIndices)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, uint, uint*, sbyte**, uint*, sbyte***, sbyte***, uint*, uint*, uint**, int>)(lpVtbl[23]))((IHttpRequest2*)Unsafe.AsPointer(ref this), dwOldChangeNumber, pdwNewChangeNumber, knownHeaderSnapshot, pdwUnknownHeaderSnapshot, ppUnknownHeaderNameSnapshot, ppUnknownHeaderValueSnapshot, diffedKnownHeaderIndices, pdwDiffedUnknownHeaders, ppDiffedUnknownHeaderIndices);
    }

    /// <include file='IHttpRequest2.xml' path='doc/member[@name="IHttpRequest2.GetChannelBindingToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetChannelBindingToken([NativeTypeName("PBYTE *")] byte** ppToken, [NativeTypeName("DWORD *")] uint* pTokenSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequest2*, byte**, uint*, int>)(lpVtbl[24]))((IHttpRequest2*)Unsafe.AsPointer(ref this), ppToken, pTokenSize);
    }

    public interface Interface : IHttpRequest.Interface
    {
        [VtblIndex(24)]
        HRESULT GetChannelBindingToken([NativeTypeName("PBYTE *")] byte** ppToken, [NativeTypeName("DWORD *")] uint* pTokenSize);
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

        [NativeTypeName("HRESULT (PBYTE *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte**, uint*, int> GetChannelBindingToken;
    }
}
