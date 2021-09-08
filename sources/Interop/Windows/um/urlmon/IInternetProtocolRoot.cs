// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9E3-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetProtocolRoot : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetProtocolRoot
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, Guid*, void**, int>)(lpVtbl[0]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, uint>)(lpVtbl[1]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, uint>)(lpVtbl[2]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("LPCWSTR")] ushort* szUrl, IInternetProtocolSink* pOIProtSink, IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] nuint dwReserved)
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, ushort*, IInternetProtocolSink*, IInternetBindInfo*, uint, nuint, int>)(lpVtbl[3]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Continue(PROTOCOLDATA* pProtocolData)
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, PROTOCOLDATA*, int>)(lpVtbl[4]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Abort([NativeTypeName("HRESULT")] int hrReason, [NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, int, uint, int>)(lpVtbl[5]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), hrReason, dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Terminate([NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, uint, int>)(lpVtbl[6]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Suspend()
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, int>)(lpVtbl[7]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* unmanaged<IInternetProtocolRoot*, int>)(lpVtbl[8]))((IInternetProtocolRoot*)Unsafe.AsPointer(ref this));
        }
    }
}
