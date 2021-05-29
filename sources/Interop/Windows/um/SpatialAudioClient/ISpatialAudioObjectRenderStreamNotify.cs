// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DDDF83E6-68D7-4C70-883F-A1836AFB4A50")]
    [NativeTypeName("struct ISpatialAudioObjectRenderStreamNotify : IUnknown")]
    public unsafe partial struct ISpatialAudioObjectRenderStreamNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamNotify*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectRenderStreamNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamNotify*, uint>)(lpVtbl[1]))((ISpatialAudioObjectRenderStreamNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamNotify*, uint>)(lpVtbl[2]))((ISpatialAudioObjectRenderStreamNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnAvailableDynamicObjectCountChange(ISpatialAudioObjectRenderStreamBase* sender, [NativeTypeName("LONGLONG")] long hnsComplianceDeadlineTime, [NativeTypeName("UINT32")] uint availableDynamicObjectCountChange)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamNotify*, ISpatialAudioObjectRenderStreamBase*, long, uint, int>)(lpVtbl[3]))((ISpatialAudioObjectRenderStreamNotify*)Unsafe.AsPointer(ref this), sender, hnsComplianceDeadlineTime, availableDynamicObjectCountChange);
        }
    }
}
