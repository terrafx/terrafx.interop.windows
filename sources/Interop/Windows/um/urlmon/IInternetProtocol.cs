// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9E4-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IInternetProtocol
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInternetProtocol*, Guid*, void**, int>)(lpVtbl[0]))((IInternetProtocol*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInternetProtocol*, uint>)(lpVtbl[1]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInternetProtocol*, uint>)(lpVtbl[2]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("LPCWSTR")] ushort* szUrl, [NativeTypeName("IInternetProtocolSink *")] IInternetProtocolSink* pOIProtSink, [NativeTypeName("IInternetBindInfo *")] IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] nuint dwReserved)
        {
            return ((delegate* stdcall<IInternetProtocol*, ushort*, IInternetProtocolSink*, IInternetBindInfo*, uint, nuint, int>)(lpVtbl[3]))((IInternetProtocol*)Unsafe.AsPointer(ref this), szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int Continue([NativeTypeName("PROTOCOLDATA *")] PROTOCOLDATA* pProtocolData)
        {
            return ((delegate* stdcall<IInternetProtocol*, PROTOCOLDATA*, int>)(lpVtbl[4]))((IInternetProtocol*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [return: NativeTypeName("HRESULT")]
        public int Abort([NativeTypeName("HRESULT")] int hrReason, [NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* stdcall<IInternetProtocol*, int, uint, int>)(lpVtbl[5]))((IInternetProtocol*)Unsafe.AsPointer(ref this), hrReason, dwOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int Terminate([NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* stdcall<IInternetProtocol*, uint, int>)(lpVtbl[6]))((IInternetProtocol*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int Suspend()
        {
            return ((delegate* stdcall<IInternetProtocol*, int>)(lpVtbl[7]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* stdcall<IInternetProtocol*, int>)(lpVtbl[8]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* stdcall<IInternetProtocol*, void*, uint, uint*, int>)(lpVtbl[9]))((IInternetProtocol*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* stdcall<IInternetProtocol*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[10]))((IInternetProtocol*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRequest([NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* stdcall<IInternetProtocol*, uint, int>)(lpVtbl[11]))((IInternetProtocol*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockRequest()
        {
            return ((delegate* stdcall<IInternetProtocol*, int>)(lpVtbl[12]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }
    }
}
