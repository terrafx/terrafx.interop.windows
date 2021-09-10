// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("28724C91-DF35-4856-9F76-D6A26413F3DF")]
    [NativeTypeName("struct IAudioAmbisonicsControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioAmbisonicsControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioAmbisonicsControl*, Guid*, void**, int>)(lpVtbl[0]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioAmbisonicsControl*, uint>)(lpVtbl[1]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioAmbisonicsControl*, uint>)(lpVtbl[2]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("const AMBISONICS_PARAMS *")] AMBISONICS_PARAMS* pAmbisonicsParams, [NativeTypeName("UINT32")] uint cbAmbisonicsParams)
        {
            return ((delegate* unmanaged<IAudioAmbisonicsControl*, AMBISONICS_PARAMS*, uint, int>)(lpVtbl[3]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), pAmbisonicsParams, cbAmbisonicsParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetHeadTracking([NativeTypeName("BOOL")] int bEnableHeadTracking)
        {
            return ((delegate* unmanaged<IAudioAmbisonicsControl*, int, int>)(lpVtbl[4]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), bEnableHeadTracking);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetHeadTracking([NativeTypeName("BOOL *")] int* pbEnableHeadTracking)
        {
            return ((delegate* unmanaged<IAudioAmbisonicsControl*, int*, int>)(lpVtbl[5]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), pbEnableHeadTracking);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetRotation(float X, float Y, float Z, float W)
        {
            return ((delegate* unmanaged<IAudioAmbisonicsControl*, float, float, float, float, int>)(lpVtbl[6]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), X, Y, Z, W);
        }
    }
}
