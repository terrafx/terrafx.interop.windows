// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9BA4B1DD-8B0C-48B7-9E7C-2F25857C8DF5")]
    [NativeTypeName("struct IRendezvousSession : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IRendezvousSession
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRendezvousSession*, Guid*, void**, int>)(lpVtbl[0]))((IRendezvousSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRendezvousSession*, uint>)(lpVtbl[1]))((IRendezvousSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRendezvousSession*, uint>)(lpVtbl[2]))((IRendezvousSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_State(RENDEZVOUS_SESSION_STATE* pSessionState)
        {
            return ((delegate* unmanaged<IRendezvousSession*, RENDEZVOUS_SESSION_STATE*, int>)(lpVtbl[3]))((IRendezvousSession*)Unsafe.AsPointer(ref this), pSessionState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_RemoteUser([NativeTypeName("BSTR *")] ushort** bstrUserName)
        {
            return ((delegate* unmanaged<IRendezvousSession*, ushort**, int>)(lpVtbl[4]))((IRendezvousSession*)Unsafe.AsPointer(ref this), bstrUserName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_Flags([NativeTypeName("LONG *")] int* pFlags)
        {
            return ((delegate* unmanaged<IRendezvousSession*, int*, int>)(lpVtbl[5]))((IRendezvousSession*)Unsafe.AsPointer(ref this), pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SendContextData([NativeTypeName("BSTR")] ushort* bstrData)
        {
            return ((delegate* unmanaged<IRendezvousSession*, ushort*, int>)(lpVtbl[6]))((IRendezvousSession*)Unsafe.AsPointer(ref this), bstrData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Terminate(HRESULT hr, [NativeTypeName("BSTR")] ushort* bstrAppData)
        {
            return ((delegate* unmanaged<IRendezvousSession*, HRESULT, ushort*, int>)(lpVtbl[7]))((IRendezvousSession*)Unsafe.AsPointer(ref this), hr, bstrAppData);
        }
    }
}
