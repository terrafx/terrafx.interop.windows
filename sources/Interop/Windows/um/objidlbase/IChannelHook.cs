// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1008C4A0-7613-11CF-9AF1-0020AF6E72F4")]
    [NativeTypeName("struct IChannelHook : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IChannelHook
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IChannelHook*, Guid*, void**, int>)(lpVtbl[0]))((IChannelHook*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IChannelHook*, uint>)(lpVtbl[1]))((IChannelHook*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IChannelHook*, uint>)(lpVtbl[2]))((IChannelHook*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void ClientGetSize([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize)
        {
            ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint*, void>)(lpVtbl[3]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void ClientFillBuffer([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, void* pDataBuffer)
        {
            ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint*, void*, void>)(lpVtbl[4]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize, pDataBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void ClientNotify([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep, HRESULT hrFault)
        {
            ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint, void*, uint, HRESULT, void>)(lpVtbl[5]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, cbDataSize, pDataBuffer, lDataRep, hrFault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void ServerNotify([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep)
        {
            ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)(lpVtbl[6]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, cbDataSize, pDataBuffer, lDataRep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void ServerGetSize([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, HRESULT hrFault, [NativeTypeName("ULONG *")] uint* pDataSize)
        {
            ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, HRESULT, uint*, void>)(lpVtbl[7]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, hrFault, pDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void ServerFillBuffer([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, void* pDataBuffer, HRESULT hrFault)
        {
            ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint*, void*, HRESULT, void>)(lpVtbl[8]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize, pDataBuffer, hrFault);
        }
    }
}
