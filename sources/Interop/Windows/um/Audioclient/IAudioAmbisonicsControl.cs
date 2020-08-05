// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("28724C91-DF35-4856-9F76-D6A26413F3DF")]
    [NativeTypeName("struct IAudioAmbisonicsControl : IUnknown")]
    public unsafe partial struct IAudioAmbisonicsControl
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioAmbisonicsControl*, Guid*, void**, int>)(lpVtbl[0]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioAmbisonicsControl*, uint>)(lpVtbl[1]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioAmbisonicsControl*, uint>)(lpVtbl[2]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("const AMBISONICS_PARAMS *")] AMBISONICS_PARAMS* pAmbisonicsParams, [NativeTypeName("UINT32")] uint cbAmbisonicsParams)
        {
            return ((delegate* stdcall<IAudioAmbisonicsControl*, AMBISONICS_PARAMS*, uint, int>)(lpVtbl[3]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), pAmbisonicsParams, cbAmbisonicsParams);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHeadTracking([NativeTypeName("BOOL")] int bEnableHeadTracking)
        {
            return ((delegate* stdcall<IAudioAmbisonicsControl*, int, int>)(lpVtbl[4]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), bEnableHeadTracking);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHeadTracking([NativeTypeName("BOOL *")] int* pbEnableHeadTracking)
        {
            return ((delegate* stdcall<IAudioAmbisonicsControl*, int*, int>)(lpVtbl[5]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), pbEnableHeadTracking);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(float X, float Y, float Z, float W)
        {
            return ((delegate* stdcall<IAudioAmbisonicsControl*, float, float, float, float, int>)(lpVtbl[6]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), X, Y, Z, W);
        }
    }
}
