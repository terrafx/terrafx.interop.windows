// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MFCameraExtrinsics
    {
        [NativeTypeName("UINT32")]
        public uint TransformCount;

        [NativeTypeName("MFCameraExtrinsic_CalibratedTransform [1]")]
        public _CalibratedTransforms_e__FixedBuffer CalibratedTransforms;

        public partial struct _CalibratedTransforms_e__FixedBuffer
        {
            internal MFCameraExtrinsic_CalibratedTransform e0;

            public ref MFCameraExtrinsic_CalibratedTransform this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<MFCameraExtrinsic_CalibratedTransform> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
