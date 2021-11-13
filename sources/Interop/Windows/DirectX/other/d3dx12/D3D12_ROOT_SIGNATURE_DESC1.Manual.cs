// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.DirectX.D3D12_ROOT_SIGNATURE_FLAGS;

namespace TerraFX.Interop.DirectX
{
    public unsafe partial struct D3D12_ROOT_SIGNATURE_DESC1 : IEquatable<D3D12_ROOT_SIGNATURE_DESC1>
    {
        public D3D12_ROOT_SIGNATURE_DESC1(uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters, uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
        {
            Init(out this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
        }

        public static ref readonly D3D12_ROOT_SIGNATURE_DESC1 DEFAULT
        {
            get
            {
                ReadOnlySpan<byte> data;

                if (Environment.Is64BitProcess)
                {
                    data = new byte[] {
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00
                    };
                }
                else
                {
                    data = new byte[] {
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00
                    };
                }

                Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_ROOT_SIGNATURE_DESC1>());
                return ref Unsafe.As<byte, D3D12_ROOT_SIGNATURE_DESC1>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static bool operator ==(D3D12_ROOT_SIGNATURE_DESC1 left, D3D12_ROOT_SIGNATURE_DESC1 right)
        {
            return (left.NumParameters == right.NumParameters)
                && (left.pParameters == right.pParameters)
                && (left.NumStaticSamplers == right.NumStaticSamplers)
                && (left.pStaticSamplers == right.pStaticSamplers)
                && (left.Flags == right.Flags);
        }

        public static bool operator !=(D3D12_ROOT_SIGNATURE_DESC1 left, D3D12_ROOT_SIGNATURE_DESC1 right)
            => !(left == right);

        public void Init(uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters, uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
        {
            Init(out this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
        }

        public static void Init([NativeTypeName("D3D12_ROOT_SIGNATURE_DESC1 &")] out D3D12_ROOT_SIGNATURE_DESC1 desc, uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters, uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
        {
            desc.NumParameters = numParameters;
            desc.pParameters = _pParameters;
            desc.NumStaticSamplers = numStaticSamplers;
            desc.pStaticSamplers = _pStaticSamplers;
            desc.Flags = flags;
        }

        public bool Equals(D3D12_ROOT_SIGNATURE_DESC1 other)
        {
            return this == other;
        }

        public override bool Equals(object? obj) => (obj is D3D12_ROOT_SIGNATURE_DESC1 other) && Equals(other);

        public override int GetHashCode() => HashCode.Combine(NumParameters, (nuint)pParameters, NumStaticSamplers, (nuint)pStaticSamplers, Flags);
    }
}
