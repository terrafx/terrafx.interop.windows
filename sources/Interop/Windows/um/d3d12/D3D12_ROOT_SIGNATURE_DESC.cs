// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D12_ROOT_SIGNATURE_FLAGS;

namespace TerraFX.Interop
{
    public unsafe struct D3D12_ROOT_SIGNATURE_DESC
    {
        public static readonly D3D12_ROOT_SIGNATURE_DESC DEFAULT = new D3D12_ROOT_SIGNATURE_DESC(0, null, 0, null, D3D12_ROOT_SIGNATURE_FLAG_NONE);

        [NativeTypeName("UINT")]
        public uint NumParameters;

        [NativeTypeName("D3D12_ROOT_PARAMETER[]")]
        public D3D12_ROOT_PARAMETER* pParameters;

        [NativeTypeName("UINT")]
        public uint NumStaticSamplers;

        [NativeTypeName("D3D12_STATIC_SAMPLER_DESC[]")]
        public D3D12_STATIC_SAMPLER_DESC* pStaticSamplers;

        public D3D12_ROOT_SIGNATURE_FLAGS Flags;

        public D3D12_ROOT_SIGNATURE_DESC(uint numParameters, D3D12_ROOT_PARAMETER* _pParameters, uint numStaticSamplers = 0, D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
        {
            fixed (D3D12_ROOT_SIGNATURE_DESC* pThis = &this)
            {
                Init(pThis, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
            }
        }

        public static void Init(D3D12_ROOT_SIGNATURE_DESC* desc, uint numParameters, D3D12_ROOT_PARAMETER* _pParameters, uint numStaticSamplers = 0, D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
        {
            desc->NumParameters = numParameters;
            desc->pParameters = _pParameters;
            desc->NumStaticSamplers = numStaticSamplers;
            desc->pStaticSamplers = _pStaticSamplers;
            desc->Flags = flags;
        }

        public void Init(uint numParameters, D3D12_ROOT_PARAMETER* _pParameters, uint numStaticSamplers = 0, D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
        {
            fixed (D3D12_ROOT_SIGNATURE_DESC* pThis = &this)
            {
                Init(pThis, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
            }
        }
    }
}
