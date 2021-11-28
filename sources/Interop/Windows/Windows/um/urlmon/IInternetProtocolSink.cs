// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("79EAC9E5-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetProtocolSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetProtocolSink : IInternetProtocolSink.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetProtocolSink*, Guid*, void**, int>)(lpVtbl[0]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInternetProtocolSink*, uint>)(lpVtbl[1]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetProtocolSink*, uint>)(lpVtbl[2]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Switch(PROTOCOLDATA* pProtocolData)
    {
        return ((delegate* unmanaged<IInternetProtocolSink*, PROTOCOLDATA*, int>)(lpVtbl[3]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), pProtocolData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReportProgress([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText)
    {
        return ((delegate* unmanaged<IInternetProtocolSink*, uint, ushort*, int>)(lpVtbl[4]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), ulStatusCode, szStatusText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReportData([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax)
    {
        return ((delegate* unmanaged<IInternetProtocolSink*, uint, uint, uint, int>)(lpVtbl[5]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), grfBSCF, ulProgress, ulProgressMax);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReportResult(HRESULT hrResult, [NativeTypeName("DWORD")] uint dwError, [NativeTypeName("LPCWSTR")] ushort* szResult)
    {
        return ((delegate* unmanaged<IInternetProtocolSink*, HRESULT, uint, ushort*, int>)(lpVtbl[6]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), hrResult, dwError, szResult);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Switch(PROTOCOLDATA* pProtocolData);

        [VtblIndex(4)]
        HRESULT ReportProgress([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText);

        [VtblIndex(5)]
        HRESULT ReportData([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax);

        [VtblIndex(6)]
        HRESULT ReportResult(HRESULT hrResult, [NativeTypeName("DWORD")] uint dwError, [NativeTypeName("LPCWSTR")] ushort* szResult);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PROTOCOLDATA *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROTOCOLDATA*, int> Switch;

        [NativeTypeName("HRESULT (ULONG, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> ReportProgress;

        [NativeTypeName("HRESULT (DWORD, ULONG, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> ReportData;

        [NativeTypeName("HRESULT (HRESULT, DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, uint, ushort*, int> ReportResult;
    }
}
