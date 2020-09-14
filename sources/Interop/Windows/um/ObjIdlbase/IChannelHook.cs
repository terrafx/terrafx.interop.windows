// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1008C4A0-7613-11CF-9AF1-0020AF6E72F4")]
    [NativeTypeName("struct IChannelHook : IUnknown")]
    public unsafe partial struct IChannelHook
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IChannelHook*, Guid*, void**, int>)(lpVtbl[0]))((IChannelHook*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IChannelHook*, uint>)(lpVtbl[1]))((IChannelHook*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IChannelHook*, uint>)(lpVtbl[2]))((IChannelHook*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClientGetSize([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize)
        {
            ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint*, void>)(lpVtbl[3]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClientFillBuffer([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, [NativeTypeName("void *")] void* pDataBuffer)
        {
            ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint*, void*, void>)(lpVtbl[4]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize, pDataBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClientNotify([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, [NativeTypeName("void *")] void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep, [NativeTypeName("HRESULT")] int hrFault)
        {
            ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)(lpVtbl[5]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, cbDataSize, pDataBuffer, lDataRep, hrFault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ServerNotify([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, [NativeTypeName("void *")] void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep)
        {
            ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)(lpVtbl[6]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, cbDataSize, pDataBuffer, lDataRep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ServerGetSize([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("HRESULT")] int hrFault, [NativeTypeName("ULONG *")] uint* pDataSize)
        {
            ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, int, uint*, void>)(lpVtbl[7]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, hrFault, pDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ServerFillBuffer([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, [NativeTypeName("void *")] void* pDataBuffer, [NativeTypeName("HRESULT")] int hrFault)
        {
            ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)(lpVtbl[8]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize, pDataBuffer, hrFault);
        }
    }
}
