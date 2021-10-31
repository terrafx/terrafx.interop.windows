// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9E4-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetProtocol : IInternetProtocolRoot")]
    [NativeInheritance("IInternetProtocolRoot")]
    public unsafe partial struct IInternetProtocol
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetProtocol*, Guid*, void**, int>)(lpVtbl[0]))((IInternetProtocol*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetProtocol*, uint>)(lpVtbl[1]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetProtocol*, uint>)(lpVtbl[2]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Start([NativeTypeName("LPCWSTR")] ushort* szUrl, IInternetProtocolSink* pOIProtSink, IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, HANDLE_PTR dwReserved)
        {
            return ((delegate* unmanaged<IInternetProtocol*, ushort*, IInternetProtocolSink*, IInternetBindInfo*, uint, HANDLE_PTR, int>)(lpVtbl[3]))((IInternetProtocol*)Unsafe.AsPointer(ref this), szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Continue(PROTOCOLDATA* pProtocolData)
        {
            return ((delegate* unmanaged<IInternetProtocol*, PROTOCOLDATA*, int>)(lpVtbl[4]))((IInternetProtocol*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Abort(HRESULT hrReason, [NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged<IInternetProtocol*, HRESULT, uint, int>)(lpVtbl[5]))((IInternetProtocol*)Unsafe.AsPointer(ref this), hrReason, dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Terminate([NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged<IInternetProtocol*, uint, int>)(lpVtbl[6]))((IInternetProtocol*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Suspend()
        {
            return ((delegate* unmanaged<IInternetProtocol*, int>)(lpVtbl[7]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Resume()
        {
            return ((delegate* unmanaged<IInternetProtocol*, int>)(lpVtbl[8]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<IInternetProtocol*, void*, uint, uint*, int>)(lpVtbl[9]))((IInternetProtocol*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* unmanaged<IInternetProtocol*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[10]))((IInternetProtocol*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT LockRequest([NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged<IInternetProtocol*, uint, int>)(lpVtbl[11]))((IInternetProtocol*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT UnlockRequest()
        {
            return ((delegate* unmanaged<IInternetProtocol*, int>)(lpVtbl[12]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }
    }
}
