// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IInternetProtocolSink.xml' path='doc/member[@name="IInternetProtocolSink"]/*' />
[Guid("79EAC9E5-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetProtocolSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetProtocolSink : IInternetProtocolSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocolSink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolSink*, Guid*, void**, int>)(lpVtbl[0]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolSink*, uint>)(lpVtbl[1]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolSink*, uint>)(lpVtbl[2]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInternetProtocolSink.xml' path='doc/member[@name="IInternetProtocolSink.Switch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Switch(PROTOCOLDATA* pProtocolData)
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolSink*, PROTOCOLDATA*, int>)(lpVtbl[3]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), pProtocolData);
    }

    /// <include file='IInternetProtocolSink.xml' path='doc/member[@name="IInternetProtocolSink.ReportProgress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReportProgress([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] char* szStatusText)
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolSink*, uint, char*, int>)(lpVtbl[4]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), ulStatusCode, szStatusText);
    }

    /// <include file='IInternetProtocolSink.xml' path='doc/member[@name="IInternetProtocolSink.ReportData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReportData([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax)
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolSink*, uint, uint, uint, int>)(lpVtbl[5]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), grfBSCF, ulProgress, ulProgressMax);
    }

    /// <include file='IInternetProtocolSink.xml' path='doc/member[@name="IInternetProtocolSink.ReportResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReportResult(HRESULT hrResult, [NativeTypeName("DWORD")] uint dwError, [NativeTypeName("LPCWSTR")] char* szResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolSink*, HRESULT, uint, char*, int>)(lpVtbl[6]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), hrResult, dwError, szResult);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Switch(PROTOCOLDATA* pProtocolData);

        [VtblIndex(4)]
        HRESULT ReportProgress([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] char* szStatusText);

        [VtblIndex(5)]
        HRESULT ReportData([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax);

        [VtblIndex(6)]
        HRESULT ReportResult(HRESULT hrResult, [NativeTypeName("DWORD")] uint dwError, [NativeTypeName("LPCWSTR")] char* szResult);
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

        [NativeTypeName("HRESULT (PROTOCOLDATA *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PROTOCOLDATA*, int> Switch;

        [NativeTypeName("HRESULT (ULONG, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, int> ReportProgress;

        [NativeTypeName("HRESULT (DWORD, ULONG, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, int> ReportData;

        [NativeTypeName("HRESULT (HRESULT, DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, uint, char*, int> ReportResult;
    }
}
