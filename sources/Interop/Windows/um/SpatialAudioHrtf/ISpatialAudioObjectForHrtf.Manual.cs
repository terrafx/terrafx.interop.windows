// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct ISpatialAudioObjectForHrtf
    {
        [return: NativeTypeName("HRESULT")]
        public int SetOrientation([NativeTypeName("const SpatialAudioHrtfOrientation *")] float** orientation)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForHrtf*, float**, int>)(lpVtbl[9]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), orientation);
        }
    }
}
