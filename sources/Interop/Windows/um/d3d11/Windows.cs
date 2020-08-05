// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [return: NativeTypeName("UINT")]
        public static uint D3D11CalcSubresource([NativeTypeName("UINT")] uint MipSlice, [NativeTypeName("UINT")] uint ArraySlice, [NativeTypeName("UINT")] uint MipLevels)
        {
            return MipSlice + ArraySlice * MipLevels;
        }

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_MPEG2_MOCOMP = new Guid(0xe6a9f44b, 0x61b0, 0x4563, 0x9e, 0xa4, 0x63, 0xd2, 0xa3, 0xc6, 0xfe, 0x66);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_MPEG2_IDCT = new Guid(0xbf22ad00, 0x03ea, 0x4690, 0x80, 0x77, 0x47, 0x33, 0x46, 0x20, 0x9b, 0x7e);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_MPEG2_VLD = new Guid(0xee27417f, 0x5e28, 0x4e65, 0xbe, 0xea, 0x1d, 0x26, 0xb5, 0x08, 0xad, 0xc9);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_MPEG1_VLD = new Guid(0x6f3ec719, 0x3735, 0x42cc, 0x80, 0x63, 0x65, 0xcc, 0x3c, 0xb3, 0x66, 0x16);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_MPEG2and1_VLD = new Guid(0x86695f12, 0x340e, 0x4f04, 0x9f, 0xd3, 0x92, 0x53, 0xdd, 0x32, 0x74, 0x60);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_H264_MOCOMP_NOFGT = new Guid(0x1b81be64, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_H264_MOCOMP_FGT = new Guid(0x1b81be65, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_H264_IDCT_NOFGT = new Guid(0x1b81be66, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_H264_IDCT_FGT = new Guid(0x1b81be67, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_H264_VLD_NOFGT = new Guid(0x1b81be68, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_H264_VLD_FGT = new Guid(0x1b81be69, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_H264_VLD_WITHFMOASO_NOFGT = new Guid(0xd5f04ff9, 0x3418, 0x45d8, 0x95, 0x61, 0x32, 0xa7, 0x6a, 0xae, 0x2d, 0xdd);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_H264_VLD_STEREO_PROGRESSIVE_NOFGT = new Guid(0xd79be8da, 0x0cf1, 0x4c81, 0xb8, 0x2a, 0x69, 0xa4, 0xe2, 0x36, 0xf4, 0x3d);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_H264_VLD_STEREO_NOFGT = new Guid(0xf9aaccbb, 0xc2b6, 0x4cfc, 0x87, 0x79, 0x57, 0x07, 0xb1, 0x76, 0x05, 0x52);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_H264_VLD_MULTIVIEW_NOFGT = new Guid(0x705b9d82, 0x76cf, 0x49d6, 0xb7, 0xe6, 0xac, 0x88, 0x72, 0xdb, 0x01, 0x3c);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_WMV8_POSTPROC = new Guid(0x1b81be80, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_WMV8_MOCOMP = new Guid(0x1b81be81, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_WMV9_POSTPROC = new Guid(0x1b81be90, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_WMV9_MOCOMP = new Guid(0x1b81be91, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_WMV9_IDCT = new Guid(0x1b81be94, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_VC1_POSTPROC = new Guid(0x1b81beA0, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_VC1_MOCOMP = new Guid(0x1b81beA1, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_VC1_IDCT = new Guid(0x1b81beA2, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_VC1_VLD = new Guid(0x1b81beA3, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_VC1_D2010 = new Guid(0x1b81beA4, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_MPEG4PT2_VLD_SIMPLE = new Guid(0xefd64d74, 0xc9e8, 0x41d7, 0xa5, 0xe9, 0xe9, 0xb0, 0xe3, 0x9f, 0xa3, 0x19);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_NOGMC = new Guid(0xed418a9f, 0x010d, 0x4eda, 0x9a, 0xe3, 0x9a, 0x65, 0x35, 0x8d, 0x8d, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_GMC = new Guid(0xab998b5b, 0x4258, 0x44a9, 0x9f, 0xeb, 0x94, 0xe5, 0x97, 0xa6, 0xba, 0xae);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN = new Guid(0x5b11d51b, 0x2f4c, 0x4452, 0xbc, 0xc3, 0x09, 0xf2, 0xa1, 0x16, 0x0c, 0xc0);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10 = new Guid(0x107af0e0, 0xef1a, 0x4d19, 0xab, 0xa8, 0x67, 0xa1, 0x63, 0x07, 0x3d, 0x13);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_VP9_VLD_PROFILE0 = new Guid(0x463707f8, 0xa1d0, 0x4585, 0x87, 0x6d, 0x83, 0xaa, 0x6d, 0x60, 0xb8, 0x9e);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_VP9_VLD_10BIT_PROFILE2 = new Guid(0xa4c749ef, 0x6ecf, 0x48aa, 0x84, 0x48, 0x50, 0xa7, 0xa1, 0x16, 0x5f, 0xf7);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_PROFILE_VP8_VLD = new Guid(0x90b899ea, 0x3a62, 0x4705, 0x88, 0xb3, 0x8d, 0xf0, 0x4b, 0x27, 0x44, 0xe7);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_CRYPTO_TYPE_AES128_CTR = new Guid(0x9b6bd711, 0x4f74, 0x41c9, 0x9e, 0x7b, 0xb, 0xe2, 0xd7, 0xd9, 0x3b, 0x4f);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_ENCRYPTION_HW_CENC = new Guid(0x89d6ac4f, 0x9f2, 0x4229, 0xb2, 0xcd, 0x37, 0x74, 0xa, 0x6d, 0xfd, 0x81);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CENC = new Guid(0xb0405235, 0xc13d, 0x44f2, 0x9a, 0xe5, 0xdd, 0x48, 0xe0, 0x8e, 0x5b, 0x67);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CBCS = new Guid(0x422d9319, 0x9d21, 0x4bb7, 0x93, 0x71, 0xfa, 0xf5, 0xa8, 0x2c, 0x3e, 0x04);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_KEY_EXCHANGE_HW_PROTECTION = new Guid(0xb1170d8a, 0x628d, 0x4da3, 0xad, 0x3b, 0x82, 0xdd, 0xb0, 0x8b, 0x49, 0x70);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_PROTECTION = new Guid(0xa84eb584, 0xc495, 0x48aa, 0xb9, 0x4d, 0x8b, 0xd2, 0xd6, 0xfb, 0xce, 0x5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE = new Guid(0xbc1b18a5, 0xb1fb, 0x42ab, 0xbd, 0x94, 0xb5, 0x82, 0x8b, 0x4b, 0xf7, 0xbe);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_DEVICE_HANDLE = new Guid(0xec1c539d, 0x8cff, 0x4e2a, 0xbc, 0xc4, 0xf5, 0x69, 0x2f, 0x99, 0xf4, 0x80);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION = new Guid(0x2634499e, 0xd018, 0x4d74, 0xac, 0x17, 0x7f, 0x72, 0x40, 0x59, 0x52, 0x8d);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNT = new Guid(0xdb207b3, 0x9450, 0x46a6, 0x82, 0xde, 0x1b, 0x96, 0xd4, 0x4f, 0x9c, 0xf2);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS = new Guid(0x649bbadb, 0xf0f4, 0x4639, 0xa1, 0x5b, 0x24, 0x39, 0x3f, 0xc3, 0xab, 0xac);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT = new Guid(0x12f0bd6, 0xe662, 0x4474, 0xbe, 0xfd, 0xaa, 0x53, 0xe5, 0x14, 0x3c, 0x6d);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT = new Guid(0x2c042b5e, 0x8c07, 0x46d5, 0xaa, 0xbe, 0x8f, 0x75, 0xcb, 0xad, 0x4c, 0x31);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_OUTPUT_ID = new Guid(0x839ddca3, 0x9b4e, 0x41e4, 0xb0, 0x53, 0x89, 0x2b, 0xd2, 0xa1, 0x1e, 0xe7);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ATTRIBUTES = new Guid(0x6214d9d2, 0x432c, 0x4abb, 0x9f, 0xce, 0x21, 0x6e, 0xea, 0x26, 0x9e, 0x3b);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID_COUNT = new Guid(0xb30f7066, 0x203c, 0x4b07, 0x93, 0xfc, 0xce, 0xaa, 0xfd, 0x61, 0x24, 0x1e);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID = new Guid(0xf83a5958, 0xe986, 0x4bda, 0xbe, 0xb0, 0x41, 0x1f, 0x6a, 0x7a, 0x1, 0xb7);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_QUERY_CURRENT_ENCRYPTION_WHEN_ACCESSIBLE = new Guid(0xec1791c7, 0xdad3, 0x4f15, 0x9e, 0xc3, 0xfa, 0xa9, 0x3d, 0x60, 0xd4, 0xf0);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE = new Guid(0x6114bdb, 0x3523, 0x470a, 0x8d, 0xca, 0xfb, 0xc2, 0x84, 0x51, 0x54, 0xf0);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_CONFIGURE_PROTECTION = new Guid(0x50455658, 0x3f47, 0x4362, 0xbf, 0x99, 0xbf, 0xdf, 0xcd, 0xe9, 0xed, 0x29);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSION = new Guid(0x6346cc54, 0x2cfc, 0x4ad4, 0x82, 0x24, 0xd1, 0x58, 0x37, 0xde, 0x77, 0x0);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE = new Guid(0x772d047, 0x1b40, 0x48e8, 0x9c, 0xa6, 0xb5, 0xf5, 0x10, 0xde, 0x9f, 0x1);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_AUTHENTICATED_CONFIGURE_ENCRYPTION_WHEN_ACCESSIBLE = new Guid(0x41fff286, 0x6ae0, 0x4d43, 0x9d, 0x55, 0xa4, 0x6e, 0x9e, 0xfd, 0x15, 0x8a);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D11_KEY_EXCHANGE_RSAES_OAEP = new Guid(0xc1949895, 0xd72a, 0x4a1d, 0x8e, 0x5d, 0xed, 0x85, 0x7d, 0x17, 0x15, 0x20);

        [DllImport("d3d11", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D11CreateDevice([NativeTypeName("IDXGIAdapter *")] IDXGIAdapter* pAdapter, D3D_DRIVER_TYPE DriverType, [NativeTypeName("HMODULE")] IntPtr Software, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, [NativeTypeName("UINT")] uint FeatureLevels, [NativeTypeName("UINT")] uint SDKVersion, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice, [NativeTypeName("D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevel, [NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppImmediateContext);

        [DllImport("d3d11", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D11CreateDeviceAndSwapChain([NativeTypeName("IDXGIAdapter *")] IDXGIAdapter* pAdapter, D3D_DRIVER_TYPE DriverType, [NativeTypeName("HMODULE")] IntPtr Software, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, [NativeTypeName("UINT")] uint FeatureLevels, [NativeTypeName("UINT")] uint SDKVersion, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, [NativeTypeName("IDXGISwapChain **")] IDXGISwapChain** ppSwapChain, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice, [NativeTypeName("D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevel, [NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppImmediateContext);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11DeviceChild = new Guid(0x1841e5c8, 0x16b0, 0x489b, 0xbc, 0xc8, 0x44, 0xcf, 0xb0, 0xd5, 0xde, 0xae);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11DepthStencilState = new Guid(0x03823efb, 0x8d8f, 0x4e1c, 0x9a, 0xa2, 0xf6, 0x4b, 0xb2, 0xcb, 0xfd, 0xf1);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11BlendState = new Guid(0x75b68faa, 0x347d, 0x4159, 0x8f, 0x45, 0xa0, 0x64, 0x0f, 0x01, 0xcd, 0x9a);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11RasterizerState = new Guid(0x9bb4ab81, 0xab1a, 0x4d8f, 0xb5, 0x06, 0xfc, 0x04, 0x20, 0x0b, 0x6e, 0xe7);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Resource = new Guid(0xdc8e63f3, 0xd12b, 0x4952, 0xb4, 0x7b, 0x5e, 0x45, 0x02, 0x6a, 0x86, 0x2d);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Buffer = new Guid(0x48570b85, 0xd1ee, 0x4fcd, 0xa2, 0x50, 0xeb, 0x35, 0x07, 0x22, 0xb0, 0x37);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Texture1D = new Guid(0xf8fb5c27, 0xc6b3, 0x4f75, 0xa4, 0xc8, 0x43, 0x9a, 0xf2, 0xef, 0x56, 0x4c);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Texture2D = new Guid(0x6f15aaf2, 0xd208, 0x4e89, 0x9a, 0xb4, 0x48, 0x95, 0x35, 0xd3, 0x4f, 0x9c);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Texture3D = new Guid(0x037e866e, 0xf56d, 0x4357, 0xa8, 0xaf, 0x9d, 0xab, 0xbe, 0x6e, 0x25, 0x0e);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11View = new Guid(0x839d1216, 0xbb2e, 0x412b, 0xb7, 0xf4, 0xa9, 0xdb, 0xeb, 0xe0, 0x8e, 0xd1);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11ShaderResourceView = new Guid(0xb0e06fe0, 0x8192, 0x4e1a, 0xb1, 0xca, 0x36, 0xd7, 0x41, 0x47, 0x10, 0xb2);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11RenderTargetView = new Guid(0xdfdba067, 0x0b8d, 0x4865, 0x87, 0x5b, 0xd7, 0xb4, 0x51, 0x6c, 0xc1, 0x64);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11DepthStencilView = new Guid(0x9fdac92a, 0x1876, 0x48c3, 0xaf, 0xad, 0x25, 0xb9, 0x4f, 0x84, 0xa9, 0xb6);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11UnorderedAccessView = new Guid(0x28acf509, 0x7f5c, 0x48f6, 0x86, 0x11, 0xf3, 0x16, 0x01, 0x0a, 0x63, 0x80);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11VertexShader = new Guid(0x3b301d64, 0xd678, 0x4289, 0x88, 0x97, 0x22, 0xf8, 0x92, 0x8b, 0x72, 0xf3);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11HullShader = new Guid(0x8e5c6061, 0x628a, 0x4c8e, 0x82, 0x64, 0xbb, 0xe4, 0x5c, 0xb3, 0xd5, 0xdd);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11DomainShader = new Guid(0xf582c508, 0x0f36, 0x490c, 0x99, 0x77, 0x31, 0xee, 0xce, 0x26, 0x8c, 0xfa);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11GeometryShader = new Guid(0x38325b96, 0xeffb, 0x4022, 0xba, 0x02, 0x2e, 0x79, 0x5b, 0x70, 0x27, 0x5c);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11PixelShader = new Guid(0xea82e40d, 0x51dc, 0x4f33, 0x93, 0xd4, 0xdb, 0x7c, 0x91, 0x25, 0xae, 0x8c);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11ComputeShader = new Guid(0x4f5b196e, 0xc2bd, 0x495e, 0xbd, 0x01, 0x1f, 0xde, 0xd3, 0x8e, 0x49, 0x69);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11InputLayout = new Guid(0xe4819ddc, 0x4cf0, 0x4025, 0xbd, 0x26, 0x5d, 0xe8, 0x2a, 0x3e, 0x07, 0xb7);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11SamplerState = new Guid(0xda6fea51, 0x564c, 0x4487, 0x98, 0x10, 0xf0, 0xd0, 0xf9, 0xb4, 0xe3, 0xa5);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Asynchronous = new Guid(0x4b35d0cd, 0x1e15, 0x4258, 0x9c, 0x98, 0x1b, 0x13, 0x33, 0xf6, 0xdd, 0x3b);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Query = new Guid(0xd6c00747, 0x87b7, 0x425e, 0xb8, 0x4d, 0x44, 0xd1, 0x08, 0x56, 0x0a, 0xfd);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Predicate = new Guid(0x9eb576dd, 0x9f77, 0x4d86, 0x81, 0xaa, 0x8b, 0xab, 0x5f, 0xe4, 0x90, 0xe2);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Counter = new Guid(0x6e8c49fb, 0xa371, 0x4770, 0xb4, 0x40, 0x29, 0x08, 0x60, 0x22, 0xb7, 0x41);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11ClassInstance = new Guid(0xa6cd7faa, 0xb0b7, 0x4a2f, 0x94, 0x36, 0x86, 0x62, 0xa6, 0x57, 0x97, 0xcb);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11ClassLinkage = new Guid(0xddf57cba, 0x9543, 0x46e4, 0xa1, 0x2b, 0xf2, 0x07, 0xa0, 0xfe, 0x7f, 0xed);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11CommandList = new Guid(0xa24bc4d1, 0x769e, 0x43f7, 0x80, 0x13, 0x98, 0xff, 0x56, 0x6c, 0x18, 0xe2);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11DeviceContext = new Guid(0xc0bfa96c, 0xe089, 0x44fb, 0x8e, 0xaf, 0x26, 0xf8, 0x79, 0x61, 0x90, 0xda);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11VideoDecoder = new Guid(0x3C9C5B51, 0x995D, 0x48d1, 0x9B, 0x8D, 0xFA, 0x5C, 0xAE, 0xDE, 0xD6, 0x5C);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11VideoProcessorEnumerator = new Guid(0x31627037, 0x53AB, 0x4200, 0x90, 0x61, 0x05, 0xFA, 0xA9, 0xAB, 0x45, 0xF9);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11VideoProcessor = new Guid(0x1D7B0652, 0x185F, 0x41c6, 0x85, 0xCE, 0x0C, 0x5B, 0xE3, 0xD4, 0xAE, 0x6C);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11AuthenticatedChannel = new Guid(0x3015A308, 0xDCBD, 0x47aa, 0xA7, 0x47, 0x19, 0x24, 0x86, 0xD1, 0x4D, 0x4A);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11CryptoSession = new Guid(0x9B32F9AD, 0xBDCC, 0x40a6, 0xA3, 0x9D, 0xD5, 0xC8, 0x65, 0x84, 0x57, 0x20);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11VideoDecoderOutputView = new Guid(0xC2931AEA, 0x2A85, 0x4f20, 0x86, 0x0F, 0xFB, 0xA1, 0xFD, 0x25, 0x6E, 0x18);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11VideoProcessorInputView = new Guid(0x11EC5A5F, 0x51DC, 0x4945, 0xAB, 0x34, 0x6E, 0x8C, 0x21, 0x30, 0x0E, 0xA5);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11VideoProcessorOutputView = new Guid(0xA048285E, 0x25A9, 0x4527, 0xBD, 0x93, 0xD6, 0x8B, 0x68, 0xC4, 0x42, 0x54);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11VideoContext = new Guid(0x61F21C45, 0x3C0E, 0x4a74, 0x9C, 0xEA, 0x67, 0x10, 0x0D, 0x9A, 0xD5, 0xE4);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11VideoDevice = new Guid(0x10EC4D5B, 0x975A, 0x4689, 0xB9, 0xE4, 0xD0, 0xAA, 0xC3, 0x0F, 0xE3, 0x33);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11Device = new Guid(0xdb6f6ddb, 0xac77, 0x4e88, 0x82, 0x53, 0x81, 0x9d, 0xf9, 0xbb, 0xf1, 0x40);

        [NativeTypeName("#define D3D11_16BIT_INDEX_STRIP_CUT_VALUE ( 0xffff )")]
        public const int D3D11_16BIT_INDEX_STRIP_CUT_VALUE = (0xffff);

        [NativeTypeName("#define D3D11_32BIT_INDEX_STRIP_CUT_VALUE ( 0xffffffff )")]
        public const uint D3D11_32BIT_INDEX_STRIP_CUT_VALUE = (0xffffffff);

        [NativeTypeName("#define D3D11_8BIT_INDEX_STRIP_CUT_VALUE ( 0xff )")]
        public const int D3D11_8BIT_INDEX_STRIP_CUT_VALUE = (0xff);

        [NativeTypeName("#define D3D11_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT ( 9 )")]
        public const int D3D11_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT = (9);

        [NativeTypeName("#define D3D11_CLIP_OR_CULL_DISTANCE_COUNT ( 8 )")]
        public const int D3D11_CLIP_OR_CULL_DISTANCE_COUNT = (8);

        [NativeTypeName("#define D3D11_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT ( 2 )")]
        public const int D3D11_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT = (2);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT ( 14 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT = (14);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS ( 4 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT ( 15 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT = (15);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT ( 16 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT = (16);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT ( 15 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT = (15);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT ( 64 )")]
        public const int D3D11_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT = (64);

        [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT ( 1 )")]
        public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT ( 128 )")]
        public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT = (128);

        [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT ( 128 )")]
        public const int D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT = (128);

        [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_COUNT ( 16 )")]
        public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_COUNT = (16);

        [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT ( 16 )")]
        public const int D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT = (16);

        [NativeTypeName("#define D3D11_COMMONSHADER_SUBROUTINE_NESTING_LIMIT ( 32 )")]
        public const int D3D11_COMMONSHADER_SUBROUTINE_NESTING_LIMIT = (32);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_COUNT ( 4096 )")]
        public const int D3D11_COMMONSHADER_TEMP_REGISTER_COUNT = (4096);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_READS_PER_INST ( 3 )")]
        public const int D3D11_COMMONSHADER_TEMP_REGISTER_READS_PER_INST = (3);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_READ_PORTS ( 3 )")]
        public const int D3D11_COMMONSHADER_TEMP_REGISTER_READ_PORTS = (3);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX ( 10 )")]
        public const int D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX = (10);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN ( -10 )")]
        public const int D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN = (-10);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE ( -8 )")]
        public const int D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE = (-8);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE ( 7 )")]
        public const int D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE = (7);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 256 )")]
        public const int D3D11_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (256);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP ( 64 )")]
        public const int D3D11_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP = (64);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 240 )")]
        public const int D3D11_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (240);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP ( 68 )")]
        public const int D3D11_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP = (68);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 224 )")]
        public const int D3D11_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (224);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP ( 72 )")]
        public const int D3D11_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP = (72);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 208 )")]
        public const int D3D11_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (208);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP ( 76 )")]
        public const int D3D11_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP = (76);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 192 )")]
        public const int D3D11_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (192);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP ( 84 )")]
        public const int D3D11_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP = (84);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 176 )")]
        public const int D3D11_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (176);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP ( 92 )")]
        public const int D3D11_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP = (92);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 160 )")]
        public const int D3D11_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (160);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP ( 100 )")]
        public const int D3D11_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP = (100);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 144 )")]
        public const int D3D11_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (144);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP ( 112 )")]
        public const int D3D11_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP = (112);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 128 )")]
        public const int D3D11_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (128);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP ( 128 )")]
        public const int D3D11_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP = (128);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 112 )")]
        public const int D3D11_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (112);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP ( 144 )")]
        public const int D3D11_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP = (144);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 96 )")]
        public const int D3D11_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (96);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP ( 168 )")]
        public const int D3D11_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP = (168);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 80 )")]
        public const int D3D11_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (80);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP ( 204 )")]
        public const int D3D11_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP = (204);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 64 )")]
        public const int D3D11_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (64);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP ( 256 )")]
        public const int D3D11_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP = (256);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 48 )")]
        public const int D3D11_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (48);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP ( 340 )")]
        public const int D3D11_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP = (340);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 32 )")]
        public const int D3D11_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (32);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP ( 512 )")]
        public const int D3D11_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP = (512);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 16 )")]
        public const int D3D11_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (16);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP ( 768 )")]
        public const int D3D11_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP = (768);

        [NativeTypeName("#define D3D11_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION ( 1 )")]
        public const int D3D11_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION = (1);

        [NativeTypeName("#define D3D11_CS_4_X_RAW_UAV_BYTE_ALIGNMENT ( 256 )")]
        public const int D3D11_CS_4_X_RAW_UAV_BYTE_ALIGNMENT = (256);

        [NativeTypeName("#define D3D11_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP ( 768 )")]
        public const int D3D11_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP = (768);

        [NativeTypeName("#define D3D11_CS_4_X_THREAD_GROUP_MAX_X ( 768 )")]
        public const int D3D11_CS_4_X_THREAD_GROUP_MAX_X = (768);

        [NativeTypeName("#define D3D11_CS_4_X_THREAD_GROUP_MAX_Y ( 768 )")]
        public const int D3D11_CS_4_X_THREAD_GROUP_MAX_Y = (768);

        [NativeTypeName("#define D3D11_CS_4_X_UAV_REGISTER_COUNT ( 1 )")]
        public const int D3D11_CS_4_X_UAV_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION ( 65535 )")]
        public const int D3D11_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION = (65535);

        [NativeTypeName("#define D3D11_CS_TGSM_REGISTER_COUNT ( 8192 )")]
        public const int D3D11_CS_TGSM_REGISTER_COUNT = (8192);

        [NativeTypeName("#define D3D11_CS_TGSM_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D11_CS_TGSM_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D11_CS_TGSM_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_CS_TGSM_RESOURCE_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_CS_TGSM_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_CS_TGSM_RESOURCE_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_CS_THREADGROUPID_REGISTER_COMPONENTS ( 3 )")]
        public const int D3D11_CS_THREADGROUPID_REGISTER_COMPONENTS = (3);

        [NativeTypeName("#define D3D11_CS_THREADGROUPID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_CS_THREADGROUPID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT ( 1 )")]
        public const int D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_CS_THREADIDINGROUP_REGISTER_COMPONENTS ( 3 )")]
        public const int D3D11_CS_THREADIDINGROUP_REGISTER_COMPONENTS = (3);

        [NativeTypeName("#define D3D11_CS_THREADIDINGROUP_REGISTER_COUNT ( 1 )")]
        public const int D3D11_CS_THREADIDINGROUP_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_CS_THREADID_REGISTER_COMPONENTS ( 3 )")]
        public const int D3D11_CS_THREADID_REGISTER_COMPONENTS = (3);

        [NativeTypeName("#define D3D11_CS_THREADID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_CS_THREADID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP ( 1024 )")]
        public const int D3D11_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP = (1024);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_X ( 1024 )")]
        public const int D3D11_CS_THREAD_GROUP_MAX_X = (1024);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_Y ( 1024 )")]
        public const int D3D11_CS_THREAD_GROUP_MAX_Y = (1024);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_Z ( 64 )")]
        public const int D3D11_CS_THREAD_GROUP_MAX_Z = (64);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MIN_X ( 1 )")]
        public const int D3D11_CS_THREAD_GROUP_MIN_X = (1);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MIN_Y ( 1 )")]
        public const int D3D11_CS_THREAD_GROUP_MIN_Y = (1);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MIN_Z ( 1 )")]
        public const int D3D11_CS_THREAD_GROUP_MIN_Z = (1);

        [NativeTypeName("#define D3D11_CS_THREAD_LOCAL_TEMP_REGISTER_POOL ( 16384 )")]
        public const int D3D11_CS_THREAD_LOCAL_TEMP_REGISTER_POOL = (16384);

        [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_ALPHA ( 1.0f )")]
        public const float D3D11_DEFAULT_BLEND_FACTOR_ALPHA = (1.0f);

        [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_BLUE ( 1.0f )")]
        public const float D3D11_DEFAULT_BLEND_FACTOR_BLUE = (1.0f);

        [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_GREEN ( 1.0f )")]
        public const float D3D11_DEFAULT_BLEND_FACTOR_GREEN = (1.0f);

        [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_RED ( 1.0f )")]
        public const float D3D11_DEFAULT_BLEND_FACTOR_RED = (1.0f);

        [NativeTypeName("#define D3D11_DEFAULT_BORDER_COLOR_COMPONENT ( 0.0f )")]
        public const float D3D11_DEFAULT_BORDER_COLOR_COMPONENT = (0.0f);

        [NativeTypeName("#define D3D11_DEFAULT_DEPTH_BIAS ( 0 )")]
        public const int D3D11_DEFAULT_DEPTH_BIAS = (0);

        [NativeTypeName("#define D3D11_DEFAULT_DEPTH_BIAS_CLAMP ( 0.0f )")]
        public const float D3D11_DEFAULT_DEPTH_BIAS_CLAMP = (0.0f);

        [NativeTypeName("#define D3D11_DEFAULT_MAX_ANISOTROPY ( 16 )")]
        public const int D3D11_DEFAULT_MAX_ANISOTROPY = (16);

        [NativeTypeName("#define D3D11_DEFAULT_MIP_LOD_BIAS ( 0.0f )")]
        public const float D3D11_DEFAULT_MIP_LOD_BIAS = (0.0f);

        [NativeTypeName("#define D3D11_DEFAULT_RENDER_TARGET_ARRAY_INDEX ( 0 )")]
        public const int D3D11_DEFAULT_RENDER_TARGET_ARRAY_INDEX = (0);

        [NativeTypeName("#define D3D11_DEFAULT_SAMPLE_MASK ( 0xffffffff )")]
        public const uint D3D11_DEFAULT_SAMPLE_MASK = (0xffffffff);

        [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_ENDX ( 0 )")]
        public const int D3D11_DEFAULT_SCISSOR_ENDX = (0);

        [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_ENDY ( 0 )")]
        public const int D3D11_DEFAULT_SCISSOR_ENDY = (0);

        [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_STARTX ( 0 )")]
        public const int D3D11_DEFAULT_SCISSOR_STARTX = (0);

        [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_STARTY ( 0 )")]
        public const int D3D11_DEFAULT_SCISSOR_STARTY = (0);

        [NativeTypeName("#define D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS ( 0.0f )")]
        public const float D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS = (0.0f);

        [NativeTypeName("#define D3D11_DEFAULT_STENCIL_READ_MASK ( 0xff )")]
        public const int D3D11_DEFAULT_STENCIL_READ_MASK = (0xff);

        [NativeTypeName("#define D3D11_DEFAULT_STENCIL_REFERENCE ( 0 )")]
        public const int D3D11_DEFAULT_STENCIL_REFERENCE = (0);

        [NativeTypeName("#define D3D11_DEFAULT_STENCIL_WRITE_MASK ( 0xff )")]
        public const int D3D11_DEFAULT_STENCIL_WRITE_MASK = (0xff);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX ( 0 )")]
        public const int D3D11_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX = (0);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_HEIGHT ( 0 )")]
        public const int D3D11_DEFAULT_VIEWPORT_HEIGHT = (0);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_MAX_DEPTH ( 0.0f )")]
        public const float D3D11_DEFAULT_VIEWPORT_MAX_DEPTH = (0.0f);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_MIN_DEPTH ( 0.0f )")]
        public const float D3D11_DEFAULT_VIEWPORT_MIN_DEPTH = (0.0f);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_TOPLEFTX ( 0 )")]
        public const int D3D11_DEFAULT_VIEWPORT_TOPLEFTX = (0);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_TOPLEFTY ( 0 )")]
        public const int D3D11_DEFAULT_VIEWPORT_TOPLEFTY = (0);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_WIDTH ( 0 )")]
        public const int D3D11_DEFAULT_VIEWPORT_WIDTH = (0);

        [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS ( 3968 )")]
        public const int D3D11_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = (3968);

        [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS ( 3 )")]
        public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS = (3);

        [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT ( 1 )")]
        public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_DS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_DS_OUTPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_DS_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_FLOAT16_FUSED_TOLERANCE_IN_ULP ( 0.6 )")]
        public const double D3D11_FLOAT16_FUSED_TOLERANCE_IN_ULP = (0.6);

        [NativeTypeName("#define D3D11_FLOAT32_MAX ( 3.402823466e+38f )")]
        public const float D3D11_FLOAT32_MAX = (3.402823466e+38f);

        [NativeTypeName("#define D3D11_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP ( 0.6f )")]
        public const float D3D11_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP = (0.6f);

        [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR ( 2.4f )")]
        public const float D3D11_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR = (2.4f);

        [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_EXPONENT_NUMERATOR ( 1.0f )")]
        public const float D3D11_FLOAT_TO_SRGB_EXPONENT_NUMERATOR = (1.0f);

        [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_OFFSET ( 0.055f )")]
        public const float D3D11_FLOAT_TO_SRGB_OFFSET = (0.055f);

        [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_SCALE_1 ( 12.92f )")]
        public const float D3D11_FLOAT_TO_SRGB_SCALE_1 = (12.92f);

        [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_SCALE_2 ( 1.055f )")]
        public const float D3D11_FLOAT_TO_SRGB_SCALE_2 = (1.055f);

        [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_THRESHOLD ( 0.0031308f )")]
        public const float D3D11_FLOAT_TO_SRGB_THRESHOLD = (0.0031308f);

        [NativeTypeName("#define D3D11_FTOI_INSTRUCTION_MAX_INPUT ( 2147483647.999f )")]
        public const float D3D11_FTOI_INSTRUCTION_MAX_INPUT = (2147483647.999f);

        [NativeTypeName("#define D3D11_FTOI_INSTRUCTION_MIN_INPUT ( -2147483648.999f )")]
        public const float D3D11_FTOI_INSTRUCTION_MIN_INPUT = (-2147483648.999f);

        [NativeTypeName("#define D3D11_FTOU_INSTRUCTION_MAX_INPUT ( 4294967295.999f )")]
        public const float D3D11_FTOU_INSTRUCTION_MAX_INPUT = (4294967295.999f);

        [NativeTypeName("#define D3D11_FTOU_INSTRUCTION_MIN_INPUT ( 0.0f )")]
        public const float D3D11_FTOU_INSTRUCTION_MIN_INPUT = (0.0f);

        [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_READS_PER_INST ( 2 )")]
        public const int D3D11_GS_INPUT_INSTANCE_ID_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_READ_PORTS ( 1 )")]
        public const int D3D11_GS_INPUT_INSTANCE_ID_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_COUNT ( 1 )")]
        public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_GS_INPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_GS_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_GS_INPUT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_GS_INPUT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_VERTICES ( 32 )")]
        public const int D3D11_GS_INPUT_REGISTER_VERTICES = (32);

        [NativeTypeName("#define D3D11_GS_MAX_INSTANCE_COUNT ( 32 )")]
        public const int D3D11_GS_MAX_INSTANCE_COUNT = (32);

        [NativeTypeName("#define D3D11_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES ( 1024 )")]
        public const int D3D11_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES = (1024);

        [NativeTypeName("#define D3D11_GS_OUTPUT_ELEMENTS ( 32 )")]
        public const int D3D11_GS_OUTPUT_ELEMENTS = (32);

        [NativeTypeName("#define D3D11_GS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_GS_OUTPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_GS_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_GS_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_HS_CONTROL_POINT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_HS_CONTROL_POINT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_HS_CONTROL_POINT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND ( 0xffffffff )")]
        public const uint D3D11_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND = (0xffffffff);

        [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND ( 0xffffffff )")]
        public const uint D3D11_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND = (0xffffffff);

        [NativeTypeName("#define D3D11_HS_MAXTESSFACTOR_LOWER_BOUND ( 1.0f )")]
        public const float D3D11_HS_MAXTESSFACTOR_LOWER_BOUND = (1.0f);

        [NativeTypeName("#define D3D11_HS_MAXTESSFACTOR_UPPER_BOUND ( 64.0f )")]
        public const float D3D11_HS_MAXTESSFACTOR_UPPER_BOUND = (64.0f);

        [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS ( 3968 )")]
        public const int D3D11_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = (3968);

        [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS ( 128 )")]
        public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS = (128);

        [NativeTypeName("#define D3D11_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
        public const int D3D11_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES = (0);

        [NativeTypeName("#define D3D11_IA_DEFAULT_PRIMITIVE_TOPOLOGY ( 0 )")]
        public const int D3D11_IA_DEFAULT_PRIMITIVE_TOPOLOGY = (0);

        [NativeTypeName("#define D3D11_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
        public const int D3D11_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES = (0);

        [NativeTypeName("#define D3D11_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT ( 1 )")]
        public const int D3D11_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT = (1);

        [NativeTypeName("#define D3D11_IA_INSTANCE_ID_BIT_COUNT ( 32 )")]
        public const int D3D11_IA_INSTANCE_ID_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_IA_INTEGER_ARITHMETIC_BIT_COUNT ( 32 )")]
        public const int D3D11_IA_INTEGER_ARITHMETIC_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_IA_PATCH_MAX_CONTROL_POINT_COUNT ( 32 )")]
        public const int D3D11_IA_PATCH_MAX_CONTROL_POINT_COUNT = (32);

        [NativeTypeName("#define D3D11_IA_PRIMITIVE_ID_BIT_COUNT ( 32 )")]
        public const int D3D11_IA_PRIMITIVE_ID_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_IA_VERTEX_ID_BIT_COUNT ( 32 )")]
        public const int D3D11_IA_VERTEX_ID_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT ( 32 )")]
        public const int D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT = (32);

        [NativeTypeName("#define D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS ( 128 )")]
        public const int D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS = (128);

        [NativeTypeName("#define D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ( 32 )")]
        public const int D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT = (32);

        [NativeTypeName("#define D3D11_INTEGER_DIVIDE_BY_ZERO_QUOTIENT ( 0xffffffff )")]
        public const uint D3D11_INTEGER_DIVIDE_BY_ZERO_QUOTIENT = (0xffffffff);

        [NativeTypeName("#define D3D11_INTEGER_DIVIDE_BY_ZERO_REMAINDER ( 0xffffffff )")]
        public const uint D3D11_INTEGER_DIVIDE_BY_ZERO_REMAINDER = (0xffffffff);

        [NativeTypeName("#define D3D11_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL ( 0xffffffff )")]
        public const uint D3D11_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL = (0xffffffff);

        [NativeTypeName("#define D3D11_KEEP_UNORDERED_ACCESS_VIEWS ( 0xffffffff )")]
        public const uint D3D11_KEEP_UNORDERED_ACCESS_VIEWS = (0xffffffff);

        [NativeTypeName("#define D3D11_LINEAR_GAMMA ( 1.0f )")]
        public const float D3D11_LINEAR_GAMMA = (1.0f);

        [NativeTypeName("#define D3D11_MAJOR_VERSION ( 11 )")]
        public const int D3D11_MAJOR_VERSION = (11);

        [NativeTypeName("#define D3D11_MAX_BORDER_COLOR_COMPONENT ( 1.0f )")]
        public const float D3D11_MAX_BORDER_COLOR_COMPONENT = (1.0f);

        [NativeTypeName("#define D3D11_MAX_DEPTH ( 1.0f )")]
        public const float D3D11_MAX_DEPTH = (1.0f);

        [NativeTypeName("#define D3D11_MAX_MAXANISOTROPY ( 16 )")]
        public const int D3D11_MAX_MAXANISOTROPY = (16);

        [NativeTypeName("#define D3D11_MAX_MULTISAMPLE_SAMPLE_COUNT ( 32 )")]
        public const int D3D11_MAX_MULTISAMPLE_SAMPLE_COUNT = (32);

        [NativeTypeName("#define D3D11_MAX_POSITION_VALUE ( 3.402823466e+34f )")]
        public const float D3D11_MAX_POSITION_VALUE = (3.402823466e+34f);

        [NativeTypeName("#define D3D11_MAX_TEXTURE_DIMENSION_2_TO_EXP ( 17 )")]
        public const int D3D11_MAX_TEXTURE_DIMENSION_2_TO_EXP = (17);

        [NativeTypeName("#define D3D11_MINOR_VERSION ( 0 )")]
        public const int D3D11_MINOR_VERSION = (0);

        [NativeTypeName("#define D3D11_MIN_BORDER_COLOR_COMPONENT ( 0.0f )")]
        public const float D3D11_MIN_BORDER_COLOR_COMPONENT = (0.0f);

        [NativeTypeName("#define D3D11_MIN_DEPTH ( 0.0f )")]
        public const float D3D11_MIN_DEPTH = (0.0f);

        [NativeTypeName("#define D3D11_MIN_MAXANISOTROPY ( 0 )")]
        public const int D3D11_MIN_MAXANISOTROPY = (0);

        [NativeTypeName("#define D3D11_MIP_LOD_BIAS_MAX ( 15.99f )")]
        public const float D3D11_MIP_LOD_BIAS_MAX = (15.99f);

        [NativeTypeName("#define D3D11_MIP_LOD_BIAS_MIN ( -16.0f )")]
        public const float D3D11_MIP_LOD_BIAS_MIN = (-16.0f);

        [NativeTypeName("#define D3D11_MIP_LOD_FRACTIONAL_BIT_COUNT ( 8 )")]
        public const int D3D11_MIP_LOD_FRACTIONAL_BIT_COUNT = (8);

        [NativeTypeName("#define D3D11_MIP_LOD_RANGE_BIT_COUNT ( 8 )")]
        public const int D3D11_MIP_LOD_RANGE_BIT_COUNT = (8);

        [NativeTypeName("#define D3D11_MULTISAMPLE_ANTIALIAS_LINE_WIDTH ( 1.4f )")]
        public const float D3D11_MULTISAMPLE_ANTIALIAS_LINE_WIDTH = (1.4f);

        [NativeTypeName("#define D3D11_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT ( 0 )")]
        public const int D3D11_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT = (0);

        [NativeTypeName("#define D3D11_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 15 )")]
        public const int D3D11_PIXEL_ADDRESS_RANGE_BIT_COUNT = (15);

        [NativeTypeName("#define D3D11_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 16 )")]
        public const int D3D11_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT = (16);

        [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_PS_CS_UAV_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_COUNT ( 8 )")]
        public const int D3D11_PS_CS_UAV_REGISTER_COUNT = (8);

        [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D11_PS_CS_UAV_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_PS_CS_UAV_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_PS_FRONTFACING_DEFAULT_VALUE ( 0xffffffff )")]
        public const uint D3D11_PS_FRONTFACING_DEFAULT_VALUE = (0xffffffff);

        [NativeTypeName("#define D3D11_PS_FRONTFACING_FALSE_VALUE ( 0 )")]
        public const int D3D11_PS_FRONTFACING_FALSE_VALUE = (0);

        [NativeTypeName("#define D3D11_PS_FRONTFACING_TRUE_VALUE ( 0xffffffff )")]
        public const uint D3D11_PS_FRONTFACING_TRUE_VALUE = (0xffffffff);

        [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_PS_INPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_PS_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_PS_INPUT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_PS_INPUT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.0f )")]
        public const float D3D11_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.0f);

        [NativeTypeName("#define D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_PS_OUTPUT_DEPTH_REGISTER_COUNT ( 1 )")]
        public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_PS_OUTPUT_MASK_REGISTER_COUNT ( 1 )")]
        public const int D3D11_PS_OUTPUT_MASK_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_PS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_PS_OUTPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_PS_OUTPUT_REGISTER_COUNT ( 8 )")]
        public const int D3D11_PS_OUTPUT_REGISTER_COUNT = (8);

        [NativeTypeName("#define D3D11_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.5f )")]
        public const float D3D11_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.5f);

        [NativeTypeName("#define D3D11_RAW_UAV_SRV_BYTE_ALIGNMENT ( 16 )")]
        public const int D3D11_RAW_UAV_SRV_BYTE_ALIGNMENT = (16);

        [NativeTypeName("#define D3D11_REQ_BLEND_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
        public const int D3D11_REQ_BLEND_OBJECT_COUNT_PER_DEVICE = (4096);

        [NativeTypeName("#define D3D11_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP ( 27 )")]
        public const int D3D11_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP = (27);

        [NativeTypeName("#define D3D11_REQ_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
        public const int D3D11_REQ_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

        [NativeTypeName("#define D3D11_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
        public const int D3D11_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE = (4096);

        [NativeTypeName("#define D3D11_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 32 )")]
        public const int D3D11_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (32);

        [NativeTypeName("#define D3D11_REQ_DRAW_VERTEX_COUNT_2_TO_EXP ( 32 )")]
        public const int D3D11_REQ_DRAW_VERTEX_COUNT_2_TO_EXP = (32);

        [NativeTypeName("#define D3D11_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION ( 16384 )")]
        public const int D3D11_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION = (16384);

        [NativeTypeName("#define D3D11_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT ( 1024 )")]
        public const int D3D11_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT = (1024);

        [NativeTypeName("#define D3D11_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
        public const int D3D11_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

        [NativeTypeName("#define D3D11_REQ_MAXANISOTROPY ( 16 )")]
        public const int D3D11_REQ_MAXANISOTROPY = (16);

        [NativeTypeName("#define D3D11_REQ_MIP_LEVELS ( 15 )")]
        public const int D3D11_REQ_MIP_LEVELS = (15);

        [NativeTypeName("#define D3D11_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES ( 2048 )")]
        public const int D3D11_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES = (2048);

        [NativeTypeName("#define D3D11_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
        public const int D3D11_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE = (4096);

        [NativeTypeName("#define D3D11_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH ( 16384 )")]
        public const int D3D11_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH = (16384);

        [NativeTypeName("#define D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM ( 128 )")]
        public const int D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM = (128);

        [NativeTypeName("#define D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM ( 0.25f )")]
        public const float D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM = (0.25f);

        [NativeTypeName("#define D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM ( 2048 )")]
        public const int D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM = (2048);

        [NativeTypeName("#define D3D11_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP ( 20 )")]
        public const int D3D11_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP = (20);

        [NativeTypeName("#define D3D11_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
        public const int D3D11_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE = (4096);

        [NativeTypeName("#define D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION ( 2048 )")]
        public const int D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION = (2048);

        [NativeTypeName("#define D3D11_REQ_TEXTURE1D_U_DIMENSION ( 16384 )")]
        public const int D3D11_REQ_TEXTURE1D_U_DIMENSION = (16384);

        [NativeTypeName("#define D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION ( 2048 )")]
        public const int D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION = (2048);

        [NativeTypeName("#define D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION ( 16384 )")]
        public const int D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION = (16384);

        [NativeTypeName("#define D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION ( 2048 )")]
        public const int D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = (2048);

        [NativeTypeName("#define D3D11_REQ_TEXTURECUBE_DIMENSION ( 16384 )")]
        public const int D3D11_REQ_TEXTURECUBE_DIMENSION = (16384);

        [NativeTypeName("#define D3D11_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL ( 0 )")]
        public const int D3D11_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL = (0);

        [NativeTypeName("#define D3D11_SHADER_MAJOR_VERSION ( 5 )")]
        public const int D3D11_SHADER_MAJOR_VERSION = (5);

        [NativeTypeName("#define D3D11_SHADER_MAX_INSTANCES ( 65535 )")]
        public const int D3D11_SHADER_MAX_INSTANCES = (65535);

        [NativeTypeName("#define D3D11_SHADER_MAX_INTERFACES ( 253 )")]
        public const int D3D11_SHADER_MAX_INTERFACES = (253);

        [NativeTypeName("#define D3D11_SHADER_MAX_INTERFACE_CALL_SITES ( 4096 )")]
        public const int D3D11_SHADER_MAX_INTERFACE_CALL_SITES = (4096);

        [NativeTypeName("#define D3D11_SHADER_MAX_TYPES ( 65535 )")]
        public const int D3D11_SHADER_MAX_TYPES = (65535);

        [NativeTypeName("#define D3D11_SHADER_MINOR_VERSION ( 0 )")]
        public const int D3D11_SHADER_MINOR_VERSION = (0);

        [NativeTypeName("#define D3D11_SHIFT_INSTRUCTION_PAD_VALUE ( 0 )")]
        public const int D3D11_SHIFT_INSTRUCTION_PAD_VALUE = (0);

        [NativeTypeName("#define D3D11_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT ( 5 )")]
        public const int D3D11_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT = (5);

        [NativeTypeName("#define D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ( 8 )")]
        public const int D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT = (8);

        [NativeTypeName("#define D3D11_SO_BUFFER_MAX_STRIDE_IN_BYTES ( 2048 )")]
        public const int D3D11_SO_BUFFER_MAX_STRIDE_IN_BYTES = (2048);

        [NativeTypeName("#define D3D11_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES ( 512 )")]
        public const int D3D11_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES = (512);

        [NativeTypeName("#define D3D11_SO_BUFFER_SLOT_COUNT ( 4 )")]
        public const int D3D11_SO_BUFFER_SLOT_COUNT = (4);

        [NativeTypeName("#define D3D11_SO_DDI_REGISTER_INDEX_DENOTING_GAP ( 0xffffffff )")]
        public const uint D3D11_SO_DDI_REGISTER_INDEX_DENOTING_GAP = (0xffffffff);

        [NativeTypeName("#define D3D11_SO_NO_RASTERIZED_STREAM ( 0xffffffff )")]
        public const uint D3D11_SO_NO_RASTERIZED_STREAM = (0xffffffff);

        [NativeTypeName("#define D3D11_SO_OUTPUT_COMPONENT_COUNT ( 128 )")]
        public const int D3D11_SO_OUTPUT_COMPONENT_COUNT = (128);

        [NativeTypeName("#define D3D11_SO_STREAM_COUNT ( 4 )")]
        public const int D3D11_SO_STREAM_COUNT = (4);

        [NativeTypeName("#define D3D11_SPEC_DATE_DAY ( 16 )")]
        public const int D3D11_SPEC_DATE_DAY = (16);

        [NativeTypeName("#define D3D11_SPEC_DATE_MONTH ( 05 )")]
        public const int D3D11_SPEC_DATE_MONTH = (05);

        [NativeTypeName("#define D3D11_SPEC_DATE_YEAR ( 2011 )")]
        public const int D3D11_SPEC_DATE_YEAR = (2011);

        [NativeTypeName("#define D3D11_SPEC_VERSION ( 1.07 )")]
        public const double D3D11_SPEC_VERSION = (1.07);

        [NativeTypeName("#define D3D11_SRGB_GAMMA ( 2.2f )")]
        public const float D3D11_SRGB_GAMMA = (2.2f);

        [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_DENOMINATOR_1 ( 12.92f )")]
        public const float D3D11_SRGB_TO_FLOAT_DENOMINATOR_1 = (12.92f);

        [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_DENOMINATOR_2 ( 1.055f )")]
        public const float D3D11_SRGB_TO_FLOAT_DENOMINATOR_2 = (1.055f);

        [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_EXPONENT ( 2.4f )")]
        public const float D3D11_SRGB_TO_FLOAT_EXPONENT = (2.4f);

        [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_OFFSET ( 0.055f )")]
        public const float D3D11_SRGB_TO_FLOAT_OFFSET = (0.055f);

        [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_THRESHOLD ( 0.04045f )")]
        public const float D3D11_SRGB_TO_FLOAT_THRESHOLD = (0.04045f);

        [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_TOLERANCE_IN_ULP ( 0.5f )")]
        public const float D3D11_SRGB_TO_FLOAT_TOLERANCE_IN_ULP = (0.5f);

        [NativeTypeName("#define D3D11_STANDARD_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_STANDARD_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_STANDARD_COMPONENT_BIT_COUNT_DOUBLED ( 64 )")]
        public const int D3D11_STANDARD_COMPONENT_BIT_COUNT_DOUBLED = (64);

        [NativeTypeName("#define D3D11_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE ( 4 )")]
        public const int D3D11_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE = (4);

        [NativeTypeName("#define D3D11_STANDARD_PIXEL_COMPONENT_COUNT ( 128 )")]
        public const int D3D11_STANDARD_PIXEL_COMPONENT_COUNT = (128);

        [NativeTypeName("#define D3D11_STANDARD_PIXEL_ELEMENT_COUNT ( 32 )")]
        public const int D3D11_STANDARD_PIXEL_ELEMENT_COUNT = (32);

        [NativeTypeName("#define D3D11_STANDARD_VECTOR_SIZE ( 4 )")]
        public const int D3D11_STANDARD_VECTOR_SIZE = (4);

        [NativeTypeName("#define D3D11_STANDARD_VERTEX_ELEMENT_COUNT ( 32 )")]
        public const int D3D11_STANDARD_VERTEX_ELEMENT_COUNT = (32);

        [NativeTypeName("#define D3D11_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT ( 64 )")]
        public const int D3D11_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT = (64);

        [NativeTypeName("#define D3D11_SUBPIXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
        public const int D3D11_SUBPIXEL_FRACTIONAL_BIT_COUNT = (8);

        [NativeTypeName("#define D3D11_SUBTEXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
        public const int D3D11_SUBTEXEL_FRACTIONAL_BIT_COUNT = (8);

        [NativeTypeName("#define D3D11_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR ( 64 )")]
        public const int D3D11_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR = (64);

        [NativeTypeName("#define D3D11_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR ( 64 )")]
        public const int D3D11_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR = (64);

        [NativeTypeName("#define D3D11_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR ( 63 )")]
        public const int D3D11_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR = (63);

        [NativeTypeName("#define D3D11_TESSELLATOR_MAX_TESSELLATION_FACTOR ( 64 )")]
        public const int D3D11_TESSELLATOR_MAX_TESSELLATION_FACTOR = (64);

        [NativeTypeName("#define D3D11_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR ( 2 )")]
        public const int D3D11_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR = (2);

        [NativeTypeName("#define D3D11_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR ( 1 )")]
        public const int D3D11_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR = (1);

        [NativeTypeName("#define D3D11_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR ( 1 )")]
        public const int D3D11_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR = (1);

        [NativeTypeName("#define D3D11_TEXEL_ADDRESS_RANGE_BIT_COUNT ( 16 )")]
        public const int D3D11_TEXEL_ADDRESS_RANGE_BIT_COUNT = (16);

        [NativeTypeName("#define D3D11_UNBOUND_MEMORY_ACCESS_RESULT ( 0 )")]
        public const int D3D11_UNBOUND_MEMORY_ACCESS_RESULT = (0);

        [NativeTypeName("#define D3D11_VIEWPORT_AND_SCISSORRECT_MAX_INDEX ( 15 )")]
        public const int D3D11_VIEWPORT_AND_SCISSORRECT_MAX_INDEX = (15);

        [NativeTypeName("#define D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ( 16 )")]
        public const int D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE = (16);

        [NativeTypeName("#define D3D11_VIEWPORT_BOUNDS_MAX ( 32767 )")]
        public const int D3D11_VIEWPORT_BOUNDS_MAX = (32767);

        [NativeTypeName("#define D3D11_VIEWPORT_BOUNDS_MIN ( -32768 )")]
        public const int D3D11_VIEWPORT_BOUNDS_MIN = (-32768);

        [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_VS_INPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_VS_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_VS_INPUT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_VS_INPUT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_VS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_VS_OUTPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_VS_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_VS_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT ( 10 )")]
        public const int D3D11_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT = (10);

        [NativeTypeName("#define D3D11_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 25 )")]
        public const int D3D11_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (25);

        [NativeTypeName("#define D3D11_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP ( 25 )")]
        public const int D3D11_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP = (25);

        [NativeTypeName("#define D3D11_1_UAV_SLOT_COUNT ( 64 )")]
        public const int D3D11_1_UAV_SLOT_COUNT = (64);

        [NativeTypeName("#define D3D11_2_TILED_RESOURCE_TILE_SIZE_IN_BYTES ( 65536 )")]
        public const int D3D11_2_TILED_RESOURCE_TILE_SIZE_IN_BYTES = (65536);

        [NativeTypeName("#define D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS ( 4 )")]
        public const int D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_4_VIDEO_DECODER_HISTOGRAM_OFFSET_ALIGNMENT ( 256 )")]
        public const int D3D11_4_VIDEO_DECODER_HISTOGRAM_OFFSET_ALIGNMENT = (256);

        [NativeTypeName("#define _FACD3D11 ( 0x87c )")]
        public const int _FACD3D11 = (0x87c);

        [NativeTypeName("#define _FACD3D11DEBUG ( ( _FACD3D11 + 1 )  )")]
        public const int _FACD3D11DEBUG = (((0x87c) + 1));

        [NativeTypeName("#define D3D11_APPEND_ALIGNED_ELEMENT ( 0xffffffff )")]
        public const uint D3D11_APPEND_ALIGNED_ELEMENT = (0xffffffff);

        [NativeTypeName("#define D3D11_FILTER_REDUCTION_TYPE_MASK ( 0x3 )")]
        public const int D3D11_FILTER_REDUCTION_TYPE_MASK = (0x3);

        [NativeTypeName("#define D3D11_FILTER_REDUCTION_TYPE_SHIFT ( 7 )")]
        public const int D3D11_FILTER_REDUCTION_TYPE_SHIFT = (7);

        [NativeTypeName("#define D3D11_FILTER_TYPE_MASK ( 0x3 )")]
        public const int D3D11_FILTER_TYPE_MASK = (0x3);

        [NativeTypeName("#define D3D11_MIN_FILTER_SHIFT ( 4 )")]
        public const int D3D11_MIN_FILTER_SHIFT = (4);

        [NativeTypeName("#define D3D11_MAG_FILTER_SHIFT ( 2 )")]
        public const int D3D11_MAG_FILTER_SHIFT = (2);

        [NativeTypeName("#define D3D11_MIP_FILTER_SHIFT ( 0 )")]
        public const int D3D11_MIP_FILTER_SHIFT = (0);

        [NativeTypeName("#define D3D11_COMPARISON_FILTERING_BIT ( 0x80 )")]
        public const int D3D11_COMPARISON_FILTERING_BIT = (0x80);

        [NativeTypeName("#define D3D11_ANISOTROPIC_FILTERING_BIT ( 0x40 )")]
        public const int D3D11_ANISOTROPIC_FILTERING_BIT = (0x40);

        [NativeTypeName("#define D3D11_SDK_VERSION ( 7 )")]
        public const int D3D11_SDK_VERSION = (7);
    }
}
