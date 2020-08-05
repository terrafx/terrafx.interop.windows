// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C8ADBD64-E71E-48A0-A4DE-185C395CD317")]
    [NativeTypeName("struct IAudioCaptureClient : IUnknown")]
    public unsafe partial struct IAudioCaptureClient
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioCaptureClient*, Guid*, void**, int>)(lpVtbl[0]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioCaptureClient*, uint>)(lpVtbl[1]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioCaptureClient*, uint>)(lpVtbl[2]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("BYTE **")] byte** ppData, [NativeTypeName("UINT32 *")] uint* pNumFramesToRead, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("UINT64 *")] ulong* pu64DevicePosition, [NativeTypeName("UINT64 *")] ulong* pu64QPCPosition)
        {
            return ((delegate* stdcall<IAudioCaptureClient*, byte**, uint*, uint*, ulong*, ulong*, int>)(lpVtbl[3]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this), ppData, pNumFramesToRead, pdwFlags, pu64DevicePosition, pu64QPCPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseBuffer([NativeTypeName("UINT32")] uint NumFramesRead)
        {
            return ((delegate* stdcall<IAudioCaptureClient*, uint, int>)(lpVtbl[4]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this), NumFramesRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNextPacketSize([NativeTypeName("UINT32 *")] uint* pNumFramesInNextPacket)
        {
            return ((delegate* stdcall<IAudioCaptureClient*, uint*, int>)(lpVtbl[5]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this), pNumFramesInNextPacket);
        }
    }
}
