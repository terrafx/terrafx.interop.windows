// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.D3D11_FILTER_TYPE;
using static TerraFX.Interop.Windows.D3D11_FILTER_REDUCTION_TYPE;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        public const int D3D11_OMAC_SIZE = 16;

        public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG2AND1_VLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x12, 0x5F, 0x69, 0x86,
                    0x0E, 0x34,
                    0x04, 0x4F,
                    0x9F,
                    0xD3,
                    0x92,
                    0x53,
                    0xDD,
                    0x32,
                    0x74,
                    0x60
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static HRESULT MAKE_D3D11_HRESULT(int code) => MAKE_HRESULT(1, unchecked((int)_FACD3D11), code);

        public static HRESULT MAKE_D3D11_STATUS(int code) => MAKE_HRESULT(0, unchecked((int)_FACD3D11), code);

        public static D3D11_FILTER D3D11_ENCODE_BASIC_FILTER(D3D11_FILTER_TYPE min, D3D11_FILTER_TYPE mag, D3D11_FILTER_TYPE mip, D3D11_FILTER_REDUCTION_TYPE reduction)
        {
            return (D3D11_FILTER)((((int)min & D3D11_FILTER_TYPE_MASK) << D3D11_MIN_FILTER_SHIFT)
                                | (((int)mag & D3D11_FILTER_TYPE_MASK) << D3D11_MAG_FILTER_SHIFT)
                                | (((int)mip & D3D11_FILTER_TYPE_MASK) << D3D11_MIP_FILTER_SHIFT)
                                | (((int)reduction & D3D11_FILTER_REDUCTION_TYPE_MASK) << D3D11_FILTER_REDUCTION_TYPE_SHIFT));
        }

        public static D3D11_FILTER D3D11_ENCODE_ANISOTROPIC_FILTER(D3D11_FILTER_REDUCTION_TYPE reduction)
        {
            return (D3D11_FILTER)(D3D11_ANISOTROPIC_FILTERING_BIT
                                | (int)D3D11_ENCODE_BASIC_FILTER(D3D11_FILTER_TYPE_LINEAR, D3D11_FILTER_TYPE_LINEAR, D3D11_FILTER_TYPE_LINEAR, reduction));
        }

        public static D3D11_FILTER_TYPE D3D11_DECODE_MIN_FILTER(D3D11_FILTER D3D11Filter)
        {
            return (D3D11_FILTER_TYPE)(((int)D3D11Filter >> D3D11_MIN_FILTER_SHIFT) & D3D11_FILTER_TYPE_MASK);
        }

        public static D3D11_FILTER_TYPE D3D11_DECODE_MAG_FILTER(D3D11_FILTER D3D11Filter)
        {
            return (D3D11_FILTER_TYPE)(((int)D3D11Filter >> D3D11_MAG_FILTER_SHIFT) & D3D11_FILTER_TYPE_MASK);
        }

        public static D3D11_FILTER_TYPE D3D11_DECODE_MIP_FILTER(D3D11_FILTER D3D11Filter)
        {
            return (D3D11_FILTER_TYPE)(((int)D3D11Filter >> D3D11_MIP_FILTER_SHIFT) & D3D11_FILTER_TYPE_MASK);
        }

        public static D3D11_FILTER_REDUCTION_TYPE D3D11_DECODE_FILTER_REDUCTION(D3D11_FILTER D3D11Filter)
        {
            return (D3D11_FILTER_REDUCTION_TYPE)(((int)D3D11Filter >> D3D11_FILTER_REDUCTION_TYPE_SHIFT) & D3D11_FILTER_REDUCTION_TYPE_MASK);
        }

        public static bool D3D11_DECODE_IS_COMPARISON_FILTER(D3D11_FILTER D3D11Filter)
        {
            return D3D11_DECODE_FILTER_REDUCTION(D3D11Filter) == D3D11_FILTER_REDUCTION_TYPE_COMPARISON;
        }
        public static bool D3D11_DECODE_IS_ANISOTROPIC_FILTER(D3D11_FILTER D3D11Filter)
        {
            return (((int)D3D11Filter & D3D11_ANISOTROPIC_FILTERING_BIT) != 0)
                && (D3D11_FILTER_TYPE_LINEAR == D3D11_DECODE_MIN_FILTER(D3D11Filter))
                && (D3D11_FILTER_TYPE_LINEAR == D3D11_DECODE_MAG_FILTER(D3D11Filter))
                && (D3D11_FILTER_TYPE_LINEAR == D3D11_DECODE_MIP_FILTER(D3D11Filter));
        }
    }
}
