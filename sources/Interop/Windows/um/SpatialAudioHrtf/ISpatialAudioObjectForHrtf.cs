// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D7436ADE-1978-4E14-ABA0-555BD8EB83B4")]
    [NativeTypeName("struct ISpatialAudioObjectForHrtf : ISpatialAudioObjectBase")]
    public unsafe partial struct ISpatialAudioObjectForHrtf
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, uint>)(lpVtbl[1]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, uint>)(lpVtbl[2]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("BYTE **")] byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, byte**, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), buffer, bufferLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, uint, int>)(lpVtbl[4]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), frameCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsActive([NativeTypeName("BOOL *")] int* isActive)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, int*, int>)(lpVtbl[5]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), isActive);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAudioObjectType([NativeTypeName("AudioObjectType *")] AudioObjectType* audioObjectType)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, AudioObjectType*, int>)(lpVtbl[6]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), audioObjectType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPosition(float x, float y, float z)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, float, float, float, int>)(lpVtbl[7]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), x, y, z);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGain(float gain)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, float, int>)(lpVtbl[8]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), gain);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEnvironment(SpatialAudioHrtfEnvironmentType environment)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, SpatialAudioHrtfEnvironmentType, int>)(lpVtbl[9]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), environment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDistanceDecay([NativeTypeName("SpatialAudioHrtfDistanceDecay *")] SpatialAudioHrtfDistanceDecay* distanceDecay)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, SpatialAudioHrtfDistanceDecay*, int>)(lpVtbl[10]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), distanceDecay);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDirectivity([NativeTypeName("SpatialAudioHrtfDirectivityUnion *")] SpatialAudioHrtfDirectivityUnion* directivity)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, SpatialAudioHrtfDirectivityUnion*, int>)(lpVtbl[11]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), directivity);
        }
    }
}
