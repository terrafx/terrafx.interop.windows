// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9E3-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetProtocolRoot : IUnknown")]
    public unsafe partial struct IInternetProtocolRoot
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, Guid*, void**, int>)(lpVtbl[0]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, uint>)(lpVtbl[1]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, uint>)(lpVtbl[2]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("LPCWSTR")] ushort* szUrl, [NativeTypeName("IInternetProtocolSink *")] IInternetProtocolSink* pOIProtSink, [NativeTypeName("IInternetBindInfo *")] IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] nuint dwReserved)
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, ushort*, IInternetProtocolSink*, IInternetBindInfo*, uint, nuint, int>)(lpVtbl[3]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Continue([NativeTypeName("PROTOCOLDATA *")] PROTOCOLDATA* pProtocolData)
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, PROTOCOLDATA*, int>)(lpVtbl[4]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Abort([NativeTypeName("HRESULT")] int hrReason, [NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, int, uint, int>)(lpVtbl[5]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), hrReason, dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Terminate([NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, uint, int>)(lpVtbl[6]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Suspend()
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, int>)(lpVtbl[7]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, int>)(lpVtbl[8]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this));
        }
    }
}
