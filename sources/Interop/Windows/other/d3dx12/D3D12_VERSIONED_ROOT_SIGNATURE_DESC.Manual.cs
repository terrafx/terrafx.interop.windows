// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using static TerraFX.Interop.D3D12_ROOT_SIGNATURE_FLAGS;
using static TerraFX.Interop.D3D_ROOT_SIGNATURE_VERSION;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_VERSIONED_ROOT_SIGNATURE_DESC
    {
        public D3D12_VERSIONED_ROOT_SIGNATURE_DESC([NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC &")] in D3D12_ROOT_SIGNATURE_DESC o)
        {
            this = default;

            Version = D3D_ROOT_SIGNATURE_VERSION_1_0;
            Anonymous.Desc_1_0 = o;
        }

        public D3D12_VERSIONED_ROOT_SIGNATURE_DESC([NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC1 &")] in D3D12_ROOT_SIGNATURE_DESC1 o)
        {
            this = default;

            Version = D3D_ROOT_SIGNATURE_VERSION_1_1;
            Anonymous.Desc_1_1 = o;
        }

        public D3D12_VERSIONED_ROOT_SIGNATURE_DESC([NativeTypeName("UINT")] uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12_ROOT_PARAMETER* _pParameters, [NativeTypeName("UINT")] uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
        {
            Init_1_0(out this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
        }

        public D3D12_VERSIONED_ROOT_SIGNATURE_DESC([NativeTypeName("UINT")] uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters, [NativeTypeName("UINT")] uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
        {
            Init_1_1(out this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
        }

        public static readonly D3D12_VERSIONED_ROOT_SIGNATURE_DESC DEFAULT = new D3D12_VERSIONED_ROOT_SIGNATURE_DESC(0, (D3D12_ROOT_PARAMETER1*)null, 0, null, D3D12_ROOT_SIGNATURE_FLAG_NONE);

        public void Init_1_0([NativeTypeName("UINT")] uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12_ROOT_PARAMETER* _pParameters, [NativeTypeName("UINT")] uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
        {
            Init_1_0(out this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
        }

        public static void Init_1_0([NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")] out D3D12_VERSIONED_ROOT_SIGNATURE_DESC desc, [NativeTypeName("UINT")] uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12_ROOT_PARAMETER* _pParameters, [NativeTypeName("UINT")] uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
        {
            desc = default;

            desc.Version = D3D_ROOT_SIGNATURE_VERSION_1_0;
            desc.Anonymous.Desc_1_0.NumParameters = numParameters;
            desc.Anonymous.Desc_1_0.pParameters = _pParameters;
            desc.Anonymous.Desc_1_0.NumStaticSamplers = numStaticSamplers;
            desc.Anonymous.Desc_1_0.pStaticSamplers = _pStaticSamplers;
            desc.Anonymous.Desc_1_0.Flags = flags;
        }

        public void Init_1_1([NativeTypeName("UINT")] uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters, [NativeTypeName("UINT")] uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
        {
            Init_1_1(out this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
        }

        public static void Init_1_1([NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")] out D3D12_VERSIONED_ROOT_SIGNATURE_DESC desc, [NativeTypeName("UINT")] uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters, [NativeTypeName("UINT")] uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
        {
            desc = default;

            desc.Version = D3D_ROOT_SIGNATURE_VERSION_1_1;
            desc.Anonymous.Desc_1_1.NumParameters = numParameters;
            desc.Anonymous.Desc_1_1.pParameters = _pParameters;
            desc.Anonymous.Desc_1_1.NumStaticSamplers = numStaticSamplers;
            desc.Anonymous.Desc_1_1.pStaticSamplers = _pStaticSamplers;
            desc.Anonymous.Desc_1_1.Flags = flags;
        }
    }
}
