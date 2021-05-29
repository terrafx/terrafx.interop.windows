// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CCE0B8F2-8D4D-4EFB-A8CF-3D6ECF1C30E0")]
    [NativeTypeName("struct ISpatialAudioObjectBase : IUnknown")]
    public unsafe partial struct ISpatialAudioObjectBase
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectBase*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectBase*, uint>)(lpVtbl[1]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectBase*, uint>)(lpVtbl[2]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("BYTE **")] byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectBase*, byte**, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this), buffer, bufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectBase*, uint, int>)(lpVtbl[4]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this), frameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsActive([NativeTypeName("BOOL *")] int* isActive)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectBase*, int*, int>)(lpVtbl[5]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this), isActive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioObjectType(AudioObjectType* audioObjectType)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectBase*, AudioObjectType*, int>)(lpVtbl[6]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this), audioObjectType);
        }
    }
}
