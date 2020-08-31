// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5CB31C05-61FF-418F-AFDA-CAAF41421A38")]
    [NativeTypeName("struct IMFMediaKeys : IUnknown")]
    public unsafe partial struct IMFMediaKeys
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaKeys*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaKeys*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaKeys*, uint>)(lpVtbl[1]))((IMFMediaKeys*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaKeys*, uint>)(lpVtbl[2]))((IMFMediaKeys*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSession([NativeTypeName("BSTR")] ushort* mimeType, [NativeTypeName("const BYTE *")] byte* initData, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("const BYTE *")] byte* customData, [NativeTypeName("DWORD")] uint cbCustomData, [NativeTypeName("IMFMediaKeySessionNotify *")] IMFMediaKeySessionNotify* notify, [NativeTypeName("IMFMediaKeySession **")] IMFMediaKeySession** ppSession)
        {
            return ((delegate* stdcall<IMFMediaKeys*, ushort*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)(lpVtbl[3]))((IMFMediaKeys*)Unsafe.AsPointer(ref this), mimeType, initData, cb, customData, cbCustomData, notify, ppSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeySystem([NativeTypeName("BSTR *")] ushort** keySystem)
        {
            return ((delegate* stdcall<IMFMediaKeys*, ushort**, int>)(lpVtbl[4]))((IMFMediaKeys*)Unsafe.AsPointer(ref this), keySystem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* stdcall<IMFMediaKeys*, int>)(lpVtbl[5]))((IMFMediaKeys*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSuspendNotify([NativeTypeName("IMFCdmSuspendNotify **")] IMFCdmSuspendNotify** notify)
        {
            return ((delegate* stdcall<IMFMediaKeys*, IMFCdmSuspendNotify**, int>)(lpVtbl[6]))((IMFMediaKeys*)Unsafe.AsPointer(ref this), notify);
        }
    }
}
