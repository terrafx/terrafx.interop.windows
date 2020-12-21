// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DDE28967-521B-46E5-8F00-BD6F2BC8AB1D")]
    [NativeTypeName("struct ISpatialAudioObject : ISpatialAudioObjectBase")]
    public unsafe partial struct ISpatialAudioObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObject*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioObject*, uint>)(lpVtbl[1]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioObject*, uint>)(lpVtbl[2]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("BYTE **")] byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioObject*, byte**, uint*, int>)(lpVtbl[3]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), buffer, bufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
        {
            return ((delegate* unmanaged<ISpatialAudioObject*, uint, int>)(lpVtbl[4]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), frameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsActive([NativeTypeName("BOOL *")] int* isActive)
        {
            return ((delegate* unmanaged<ISpatialAudioObject*, int*, int>)(lpVtbl[5]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), isActive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioObjectType([NativeTypeName("AudioObjectType *")] AudioObjectType* audioObjectType)
        {
            return ((delegate* unmanaged<ISpatialAudioObject*, AudioObjectType*, int>)(lpVtbl[6]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), audioObjectType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPosition(float x, float y, float z)
        {
            return ((delegate* unmanaged<ISpatialAudioObject*, float, float, float, int>)(lpVtbl[7]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVolume(float volume)
        {
            return ((delegate* unmanaged<ISpatialAudioObject*, float, int>)(lpVtbl[8]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), volume);
        }
    }
}
