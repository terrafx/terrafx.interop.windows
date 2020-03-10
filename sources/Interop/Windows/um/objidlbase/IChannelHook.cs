// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.18362.0
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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IChannelHook* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IChannelHook* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IChannelHook* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ClientGetSize(IChannelHook* pThis, [NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ClientFillBuffer(IChannelHook* pThis, [NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, [NativeTypeName("void *")] void* pDataBuffer);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ClientNotify(IChannelHook* pThis, [NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, [NativeTypeName("void *")] void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep, [NativeTypeName("HRESULT")] int hrFault);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ServerNotify(IChannelHook* pThis, [NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, [NativeTypeName("void *")] void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ServerGetSize(IChannelHook* pThis, [NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("HRESULT")] int hrFault, [NativeTypeName("ULONG *")] uint* pDataSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ServerFillBuffer(IChannelHook* pThis, [NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, [NativeTypeName("void *")] void* pDataBuffer, [NativeTypeName("HRESULT")] int hrFault);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IChannelHook*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IChannelHook*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IChannelHook*)Unsafe.AsPointer(ref this));
        }

        public void ClientGetSize([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize)
        {
            Marshal.GetDelegateForFunctionPointer<_ClientGetSize>(lpVtbl->ClientGetSize)((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize);
        }

        public void ClientFillBuffer([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, [NativeTypeName("void *")] void* pDataBuffer)
        {
            Marshal.GetDelegateForFunctionPointer<_ClientFillBuffer>(lpVtbl->ClientFillBuffer)((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize, pDataBuffer);
        }

        public void ClientNotify([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, [NativeTypeName("void *")] void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep, [NativeTypeName("HRESULT")] int hrFault)
        {
            Marshal.GetDelegateForFunctionPointer<_ClientNotify>(lpVtbl->ClientNotify)((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, cbDataSize, pDataBuffer, lDataRep, hrFault);
        }

        public void ServerNotify([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, [NativeTypeName("void *")] void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep)
        {
            Marshal.GetDelegateForFunctionPointer<_ServerNotify>(lpVtbl->ServerNotify)((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, cbDataSize, pDataBuffer, lDataRep);
        }

        public void ServerGetSize([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("HRESULT")] int hrFault, [NativeTypeName("ULONG *")] uint* pDataSize)
        {
            Marshal.GetDelegateForFunctionPointer<_ServerGetSize>(lpVtbl->ServerGetSize)((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, hrFault, pDataSize);
        }

        public void ServerFillBuffer([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, [NativeTypeName("void *")] void* pDataBuffer, [NativeTypeName("HRESULT")] int hrFault)
        {
            Marshal.GetDelegateForFunctionPointer<_ServerFillBuffer>(lpVtbl->ServerFillBuffer)((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize, pDataBuffer, hrFault);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (const GUID &, const IID &, ULONG *) __attribute__((stdcall))")]
            public IntPtr ClientGetSize;

            [NativeTypeName("void (const GUID &, const IID &, ULONG *, void *) __attribute__((stdcall))")]
            public IntPtr ClientFillBuffer;

            [NativeTypeName("void (const GUID &, const IID &, ULONG, void *, DWORD, HRESULT) __attribute__((stdcall))")]
            public IntPtr ClientNotify;

            [NativeTypeName("void (const GUID &, const IID &, ULONG, void *, DWORD) __attribute__((stdcall))")]
            public IntPtr ServerNotify;

            [NativeTypeName("void (const GUID &, const IID &, HRESULT, ULONG *) __attribute__((stdcall))")]
            public IntPtr ServerGetSize;

            [NativeTypeName("void (const GUID &, const IID &, ULONG *, void *, HRESULT) __attribute__((stdcall))")]
            public IntPtr ServerFillBuffer;
        }
    }
}
