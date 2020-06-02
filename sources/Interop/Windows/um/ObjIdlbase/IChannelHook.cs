// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1008C4A0-7613-11CF-9AF1-0020AF6E72F4")]
    public unsafe partial struct IChannelHook
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IChannelHook*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IChannelHook*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IChannelHook*)Unsafe.AsPointer(ref this));
        }

        public void ClientGetSize([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize)
        {
            lpVtbl->ClientGetSize((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize);
        }

        public void ClientFillBuffer([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, [NativeTypeName("void *")] void* pDataBuffer)
        {
            lpVtbl->ClientFillBuffer((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize, pDataBuffer);
        }

        public void ClientNotify([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, [NativeTypeName("void *")] void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep, [NativeTypeName("HRESULT")] int hrFault)
        {
            lpVtbl->ClientNotify((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, cbDataSize, pDataBuffer, lDataRep, hrFault);
        }

        public void ServerNotify([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, [NativeTypeName("void *")] void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep)
        {
            lpVtbl->ServerNotify((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, cbDataSize, pDataBuffer, lDataRep);
        }

        public void ServerGetSize([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("HRESULT")] int hrFault, [NativeTypeName("ULONG *")] uint* pDataSize)
        {
            lpVtbl->ServerGetSize((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, hrFault, pDataSize);
        }

        public void ServerFillBuffer([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, [NativeTypeName("void *")] void* pDataBuffer, [NativeTypeName("HRESULT")] int hrFault)
        {
            lpVtbl->ServerFillBuffer((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize, pDataBuffer, hrFault);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IChannelHook*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IChannelHook*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IChannelHook*, uint> Release;

            [NativeTypeName("void (const GUID &, const IID &, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IChannelHook*, Guid*, Guid*, uint*, void> ClientGetSize;

            [NativeTypeName("void (const GUID &, const IID &, ULONG *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<IChannelHook*, Guid*, Guid*, uint*, void*, void> ClientFillBuffer;

            [NativeTypeName("void (const GUID &, const IID &, ULONG, void *, DWORD, HRESULT) __attribute__((stdcall))")]
            public delegate* stdcall<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void> ClientNotify;

            [NativeTypeName("void (const GUID &, const IID &, ULONG, void *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IChannelHook*, Guid*, Guid*, uint, void*, uint, void> ServerNotify;

            [NativeTypeName("void (const GUID &, const IID &, HRESULT, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IChannelHook*, Guid*, Guid*, int, uint*, void> ServerGetSize;

            [NativeTypeName("void (const GUID &, const IID &, ULONG *, void *, HRESULT) __attribute__((stdcall))")]
            public delegate* stdcall<IChannelHook*, Guid*, Guid*, uint*, void*, int, void> ServerFillBuffer;
        }
    }
}
