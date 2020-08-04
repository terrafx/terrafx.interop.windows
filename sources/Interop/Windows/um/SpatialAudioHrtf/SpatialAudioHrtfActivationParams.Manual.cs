// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SpatialAudioHrtfActivationParams
    {
        [NativeTypeName("const WAVEFORMATEX *")]
        public WAVEFORMATEX* ObjectFormat;

        public AudioObjectType StaticObjectTypeMask;

        [NativeTypeName("UINT32")]
        public uint MinDynamicObjectCount;

        [NativeTypeName("UINT32")]
        public uint MaxDynamicObjectCount;

        public AUDIO_STREAM_CATEGORY Category;

        [NativeTypeName("HANDLE")]
        public IntPtr EventHandle;

        [NativeTypeName("ISpatialAudioObjectRenderStreamNotify *")]
        public ISpatialAudioObjectRenderStreamNotify* NotifyObject;

        [NativeTypeName("SpatialAudioHrtfDistanceDecay *")]
        public SpatialAudioHrtfDistanceDecay* DistanceDecay;

        [NativeTypeName("SpatialAudioHrtfDirectivityUnion *")]
        public SpatialAudioHrtfDirectivityUnion* Directivity;

        [NativeTypeName("SpatialAudioHrtfEnvironmentType *")]
        public SpatialAudioHrtfEnvironmentType* Environment;

        [NativeTypeName("SpatialAudioHrtfOrientation *")]
        public float** Orientation;
    }
}
