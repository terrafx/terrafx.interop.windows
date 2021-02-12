// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MFPinholeCameraIntrinsics
    {
        [NativeTypeName("UINT32")]
        public uint IntrinsicModelCount;

        [NativeTypeName("MFPinholeCameraIntrinsic_IntrinsicModel [1]")]
        public _IntrinsicModels_e__FixedBuffer IntrinsicModels;

        public partial struct _IntrinsicModels_e__FixedBuffer
        {
            public MFPinholeCameraIntrinsic_IntrinsicModel e0;

            public ref MFPinholeCameraIntrinsic_IntrinsicModel this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<MFPinholeCameraIntrinsic_IntrinsicModel> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
