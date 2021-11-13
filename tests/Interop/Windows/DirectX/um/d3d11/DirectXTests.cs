// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX.UnitTests
{
    /// <summary>Provides validation of the <see cref="DirectX" /> class.</summary>
    public static unsafe partial class DirectXTests
    {
        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_MPEG2_MOCOMP" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_MPEG2_MOCOMPTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_MPEG2_MOCOMP, Is.EqualTo(new Guid(0xe6a9f44b, 0x61b0, 0x4563, 0x9e, 0xa4, 0x63, 0xd2, 0xa3, 0xc6, 0xfe, 0x66)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_MPEG2_IDCT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_MPEG2_IDCTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_MPEG2_IDCT, Is.EqualTo(new Guid(0xbf22ad00, 0x03ea, 0x4690, 0x80, 0x77, 0x47, 0x33, 0x46, 0x20, 0x9b, 0x7e)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_MPEG2_VLD" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_MPEG2_VLDTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_MPEG2_VLD, Is.EqualTo(new Guid(0xee27417f, 0x5e28, 0x4e65, 0xbe, 0xea, 0x1d, 0x26, 0xb5, 0x08, 0xad, 0xc9)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_MPEG1_VLD" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_MPEG1_VLDTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_MPEG1_VLD, Is.EqualTo(new Guid(0x6f3ec719, 0x3735, 0x42cc, 0x80, 0x63, 0x65, 0xcc, 0x3c, 0xb3, 0x66, 0x16)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_MPEG2and1_VLD" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_MPEG2and1_VLDTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_MPEG2and1_VLD, Is.EqualTo(new Guid(0x86695f12, 0x340e, 0x4f04, 0x9f, 0xd3, 0x92, 0x53, 0xdd, 0x32, 0x74, 0x60)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_H264_MOCOMP_NOFGT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_H264_MOCOMP_NOFGTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_H264_MOCOMP_NOFGT, Is.EqualTo(new Guid(0x1b81be64, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_H264_MOCOMP_FGT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_H264_MOCOMP_FGTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_H264_MOCOMP_FGT, Is.EqualTo(new Guid(0x1b81be65, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_H264_IDCT_NOFGT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_H264_IDCT_NOFGTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_H264_IDCT_NOFGT, Is.EqualTo(new Guid(0x1b81be66, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_H264_IDCT_FGT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_H264_IDCT_FGTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_H264_IDCT_FGT, Is.EqualTo(new Guid(0x1b81be67, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_H264_VLD_NOFGT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_H264_VLD_NOFGTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_H264_VLD_NOFGT, Is.EqualTo(new Guid(0x1b81be68, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_H264_VLD_FGT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_H264_VLD_FGTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_H264_VLD_FGT, Is.EqualTo(new Guid(0x1b81be69, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_H264_VLD_WITHFMOASO_NOFGT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_H264_VLD_WITHFMOASO_NOFGTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_H264_VLD_WITHFMOASO_NOFGT, Is.EqualTo(new Guid(0xd5f04ff9, 0x3418, 0x45d8, 0x95, 0x61, 0x32, 0xa7, 0x6a, 0xae, 0x2d, 0xdd)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_H264_VLD_STEREO_PROGRESSIVE_NOFGT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_H264_VLD_STEREO_PROGRESSIVE_NOFGTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_H264_VLD_STEREO_PROGRESSIVE_NOFGT, Is.EqualTo(new Guid(0xd79be8da, 0x0cf1, 0x4c81, 0xb8, 0x2a, 0x69, 0xa4, 0xe2, 0x36, 0xf4, 0x3d)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_H264_VLD_STEREO_NOFGT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_H264_VLD_STEREO_NOFGTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_H264_VLD_STEREO_NOFGT, Is.EqualTo(new Guid(0xf9aaccbb, 0xc2b6, 0x4cfc, 0x87, 0x79, 0x57, 0x07, 0xb1, 0x76, 0x05, 0x52)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_H264_VLD_MULTIVIEW_NOFGT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_H264_VLD_MULTIVIEW_NOFGTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_H264_VLD_MULTIVIEW_NOFGT, Is.EqualTo(new Guid(0x705b9d82, 0x76cf, 0x49d6, 0xb7, 0xe6, 0xac, 0x88, 0x72, 0xdb, 0x01, 0x3c)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_WMV8_POSTPROC" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_WMV8_POSTPROCTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_WMV8_POSTPROC, Is.EqualTo(new Guid(0x1b81be80, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_WMV8_MOCOMP" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_WMV8_MOCOMPTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_WMV8_MOCOMP, Is.EqualTo(new Guid(0x1b81be81, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_WMV9_POSTPROC" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_WMV9_POSTPROCTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_WMV9_POSTPROC, Is.EqualTo(new Guid(0x1b81be90, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_WMV9_MOCOMP" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_WMV9_MOCOMPTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_WMV9_MOCOMP, Is.EqualTo(new Guid(0x1b81be91, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_WMV9_IDCT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_WMV9_IDCTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_WMV9_IDCT, Is.EqualTo(new Guid(0x1b81be94, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_VC1_POSTPROC" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_VC1_POSTPROCTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_VC1_POSTPROC, Is.EqualTo(new Guid(0x1b81beA0, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_VC1_MOCOMP" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_VC1_MOCOMPTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_VC1_MOCOMP, Is.EqualTo(new Guid(0x1b81beA1, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_VC1_IDCT" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_VC1_IDCTTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_VC1_IDCT, Is.EqualTo(new Guid(0x1b81beA2, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_VC1_VLD" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_VC1_VLDTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_VC1_VLD, Is.EqualTo(new Guid(0x1b81beA3, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_VC1_D2010" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_VC1_D2010Test()
        {
            Assert.That(D3D11_DECODER_PROFILE_VC1_D2010, Is.EqualTo(new Guid(0x1b81beA4, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_MPEG4PT2_VLD_SIMPLE" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_MPEG4PT2_VLD_SIMPLETest()
        {
            Assert.That(D3D11_DECODER_PROFILE_MPEG4PT2_VLD_SIMPLE, Is.EqualTo(new Guid(0xefd64d74, 0xc9e8, 0x41d7, 0xa5, 0xe9, 0xe9, 0xb0, 0xe3, 0x9f, 0xa3, 0x19)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_NOGMC" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_NOGMCTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_NOGMC, Is.EqualTo(new Guid(0xed418a9f, 0x010d, 0x4eda, 0x9a, 0xe3, 0x9a, 0x65, 0x35, 0x8d, 0x8d, 0x2e)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_GMC" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_GMCTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_MPEG4PT2_VLD_ADVSIMPLE_GMC, Is.EqualTo(new Guid(0xab998b5b, 0x4258, 0x44a9, 0x9f, 0xeb, 0x94, 0xe5, 0x97, 0xa6, 0xba, 0xae)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_HEVC_VLD_MAIN" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_HEVC_VLD_MAINTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_HEVC_VLD_MAIN, Is.EqualTo(new Guid(0x5b11d51b, 0x2f4c, 0x4452, 0xbc, 0xc3, 0x09, 0xf2, 0xa1, 0x16, 0x0c, 0xc0)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10Test()
        {
            Assert.That(D3D11_DECODER_PROFILE_HEVC_VLD_MAIN10, Is.EqualTo(new Guid(0x107af0e0, 0xef1a, 0x4d19, 0xab, 0xa8, 0x67, 0xa1, 0x63, 0x07, 0x3d, 0x13)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_VP9_VLD_PROFILE0" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_VP9_VLD_PROFILE0Test()
        {
            Assert.That(D3D11_DECODER_PROFILE_VP9_VLD_PROFILE0, Is.EqualTo(new Guid(0x463707f8, 0xa1d0, 0x4585, 0x87, 0x6d, 0x83, 0xaa, 0x6d, 0x60, 0xb8, 0x9e)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_VP9_VLD_10BIT_PROFILE2" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_VP9_VLD_10BIT_PROFILE2Test()
        {
            Assert.That(D3D11_DECODER_PROFILE_VP9_VLD_10BIT_PROFILE2, Is.EqualTo(new Guid(0xa4c749ef, 0x6ecf, 0x48aa, 0x84, 0x48, 0x50, 0xa7, 0xa1, 0x16, 0x5f, 0xf7)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_VP8_VLD" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_VP8_VLDTest()
        {
            Assert.That(D3D11_DECODER_PROFILE_VP8_VLD, Is.EqualTo(new Guid(0x90b899ea, 0x3a62, 0x4705, 0x88, 0xb3, 0x8d, 0xf0, 0x4b, 0x27, 0x44, 0xe7)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_AV1_VLD_PROFILE0" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_AV1_VLD_PROFILE0Test()
        {
            Assert.That(D3D11_DECODER_PROFILE_AV1_VLD_PROFILE0, Is.EqualTo(new Guid(0xb8be4ccb, 0xcf53, 0x46ba, 0x8d, 0x59, 0xd6, 0xb8, 0xa6, 0xda, 0x5d, 0x2a)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_AV1_VLD_PROFILE1" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_AV1_VLD_PROFILE1Test()
        {
            Assert.That(D3D11_DECODER_PROFILE_AV1_VLD_PROFILE1, Is.EqualTo(new Guid(0x6936ff0f, 0x45b1, 0x4163, 0x9c, 0xc1, 0x64, 0x6e, 0xf6, 0x94, 0x61, 0x08)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_AV1_VLD_PROFILE2" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_AV1_VLD_PROFILE2Test()
        {
            Assert.That(D3D11_DECODER_PROFILE_AV1_VLD_PROFILE2, Is.EqualTo(new Guid(0x0c5f2aa1, 0xe541, 0x4089, 0xbb, 0x7b, 0x98, 0x11, 0x0a, 0x19, 0xd7, 0xc8)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_AV1_VLD_12BIT_PROFILE2" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_AV1_VLD_12BIT_PROFILE2Test()
        {
            Assert.That(D3D11_DECODER_PROFILE_AV1_VLD_12BIT_PROFILE2, Is.EqualTo(new Guid(0x17127009, 0xa00f, 0x4ce1, 0x99, 0x4e, 0xbf, 0x40, 0x81, 0xf6, 0xf3, 0xf0)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_PROFILE_AV1_VLD_12BIT_PROFILE2_420" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_PROFILE_AV1_VLD_12BIT_PROFILE2_420Test()
        {
            Assert.That(D3D11_DECODER_PROFILE_AV1_VLD_12BIT_PROFILE2_420, Is.EqualTo(new Guid(0x2d80bed6, 0x9cac, 0x4835, 0x9e, 0x91, 0x32, 0x7b, 0xbc, 0x4f, 0x9e, 0xe8)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_CRYPTO_TYPE_AES128_CTR" /> property is correct.</summary>
        [Test]
        public static void D3D11_CRYPTO_TYPE_AES128_CTRTest()
        {
            Assert.That(D3D11_CRYPTO_TYPE_AES128_CTR, Is.EqualTo(new Guid(0x9b6bd711, 0x4f74, 0x41c9, 0x9e, 0x7b, 0xb, 0xe2, 0xd7, 0xd9, 0x3b, 0x4f)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_ENCRYPTION_HW_CENC" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_ENCRYPTION_HW_CENCTest()
        {
            Assert.That(D3D11_DECODER_ENCRYPTION_HW_CENC, Is.EqualTo(new Guid(0x89d6ac4f, 0x9f2, 0x4229, 0xb2, 0xcd, 0x37, 0x74, 0xa, 0x6d, 0xfd, 0x81)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CENC" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CENCTest()
        {
            Assert.That(D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CENC, Is.EqualTo(new Guid(0xb0405235, 0xc13d, 0x44f2, 0x9a, 0xe5, 0xdd, 0x48, 0xe0, 0x8e, 0x5b, 0x67)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CBCS" /> property is correct.</summary>
        [Test]
        public static void D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CBCSTest()
        {
            Assert.That(D3D11_DECODER_BITSTREAM_ENCRYPTION_TYPE_CBCS, Is.EqualTo(new Guid(0x422d9319, 0x9d21, 0x4bb7, 0x93, 0x71, 0xfa, 0xf5, 0xa8, 0x2c, 0x3e, 0x04)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_KEY_EXCHANGE_HW_PROTECTION" /> property is correct.</summary>
        [Test]
        public static void D3D11_KEY_EXCHANGE_HW_PROTECTIONTest()
        {
            Assert.That(D3D11_KEY_EXCHANGE_HW_PROTECTION, Is.EqualTo(new Guid(0xb1170d8a, 0x628d, 0x4da3, 0xad, 0x3b, 0x82, 0xdd, 0xb0, 0x8b, 0x49, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_PROTECTION" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_PROTECTIONTest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_PROTECTION, Is.EqualTo(new Guid(0xa84eb584, 0xc495, 0x48aa, 0xb9, 0x4d, 0x8b, 0xd2, 0xd6, 0xfb, 0xce, 0x5)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPETest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE, Is.EqualTo(new Guid(0xbc1b18a5, 0xb1fb, 0x42ab, 0xbd, 0x94, 0xb5, 0x82, 0x8b, 0x4b, 0xf7, 0xbe)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_DEVICE_HANDLE" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_DEVICE_HANDLETest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_DEVICE_HANDLE, Is.EqualTo(new Guid(0xec1c539d, 0x8cff, 0x4e2a, 0xbc, 0xc4, 0xf5, 0x69, 0x2f, 0x99, 0xf4, 0x80)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSIONTest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION, Is.EqualTo(new Guid(0x2634499e, 0xd018, 0x4d74, 0xac, 0x17, 0x7f, 0x72, 0x40, 0x59, 0x52, 0x8d)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNT" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNTTest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNT, Is.EqualTo(new Guid(0xdb207b3, 0x9450, 0x46a6, 0x82, 0xde, 0x1b, 0x96, 0xd4, 0x4f, 0x9c, 0xf2)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESSTest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS, Is.EqualTo(new Guid(0x649bbadb, 0xf0f4, 0x4639, 0xa1, 0x5b, 0x24, 0x39, 0x3f, 0xc3, 0xab, 0xac)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNTTest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT, Is.EqualTo(new Guid(0x12f0bd6, 0xe662, 0x4474, 0xbe, 0xfd, 0xaa, 0x53, 0xe5, 0x14, 0x3c, 0x6d)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNTTest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT, Is.EqualTo(new Guid(0x2c042b5e, 0x8c07, 0x46d5, 0xaa, 0xbe, 0x8f, 0x75, 0xcb, 0xad, 0x4c, 0x31)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_OUTPUT_IDTest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_OUTPUT_ID, Is.EqualTo(new Guid(0x839ddca3, 0x9b4e, 0x41e4, 0xb0, 0x53, 0x89, 0x2b, 0xd2, 0xa1, 0x1e, 0xe7)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ATTRIBUTES" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ATTRIBUTESTest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ATTRIBUTES, Is.EqualTo(new Guid(0x6214d9d2, 0x432c, 0x4abb, 0x9f, 0xce, 0x21, 0x6e, 0xea, 0x26, 0x9e, 0x3b)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID_COUNT" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID_COUNTTest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID_COUNT, Is.EqualTo(new Guid(0xb30f7066, 0x203c, 0x4b07, 0x93, 0xfc, 0xce, 0xaa, 0xfd, 0x61, 0x24, 0x1e)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUIDTest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_ENCRYPTION_WHEN_ACCESSIBLE_GUID, Is.EqualTo(new Guid(0xf83a5958, 0xe986, 0x4bda, 0xbe, 0xb0, 0x41, 0x1f, 0x6a, 0x7a, 0x1, 0xb7)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_QUERY_CURRENT_ENCRYPTION_WHEN_ACCESSIBLE" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_QUERY_CURRENT_ENCRYPTION_WHEN_ACCESSIBLETest()
        {
            Assert.That(D3D11_AUTHENTICATED_QUERY_CURRENT_ENCRYPTION_WHEN_ACCESSIBLE, Is.EqualTo(new Guid(0xec1791c7, 0xdad3, 0x4f15, 0x9e, 0xc3, 0xfa, 0xa9, 0x3d, 0x60, 0xd4, 0xf0)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_CONFIGURE_INITIALIZETest()
        {
            Assert.That(D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE, Is.EqualTo(new Guid(0x6114bdb, 0x3523, 0x470a, 0x8d, 0xca, 0xfb, 0xc2, 0x84, 0x51, 0x54, 0xf0)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_CONFIGURE_PROTECTION" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_CONFIGURE_PROTECTIONTest()
        {
            Assert.That(D3D11_AUTHENTICATED_CONFIGURE_PROTECTION, Is.EqualTo(new Guid(0x50455658, 0x3f47, 0x4362, 0xbf, 0x99, 0xbf, 0xdf, 0xcd, 0xe9, 0xed, 0x29)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSION" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSIONTest()
        {
            Assert.That(D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSION, Is.EqualTo(new Guid(0x6346cc54, 0x2cfc, 0x4ad4, 0x82, 0x24, 0xd1, 0x58, 0x37, 0xde, 0x77, 0x0)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCETest()
        {
            Assert.That(D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE, Is.EqualTo(new Guid(0x772d047, 0x1b40, 0x48e8, 0x9c, 0xa6, 0xb5, 0xf5, 0x10, 0xde, 0x9f, 0x1)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_AUTHENTICATED_CONFIGURE_ENCRYPTION_WHEN_ACCESSIBLE" /> property is correct.</summary>
        [Test]
        public static void D3D11_AUTHENTICATED_CONFIGURE_ENCRYPTION_WHEN_ACCESSIBLETest()
        {
            Assert.That(D3D11_AUTHENTICATED_CONFIGURE_ENCRYPTION_WHEN_ACCESSIBLE, Is.EqualTo(new Guid(0x41fff286, 0x6ae0, 0x4d43, 0x9d, 0x55, 0xa4, 0x6e, 0x9e, 0xfd, 0x15, 0x8a)));
        }

        /// <summary>Validates that the value of the <see cref="D3D11_KEY_EXCHANGE_RSAES_OAEP" /> property is correct.</summary>
        [Test]
        public static void D3D11_KEY_EXCHANGE_RSAES_OAEPTest()
        {
            Assert.That(D3D11_KEY_EXCHANGE_RSAES_OAEP, Is.EqualTo(new Guid(0xc1949895, 0xd72a, 0x4a1d, 0x8e, 0x5d, 0xed, 0x85, 0x7d, 0x17, 0x15, 0x20)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11DeviceChild" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11DeviceChildTest()
        {
            Assert.That(IID_ID3D11DeviceChild, Is.EqualTo(new Guid(0x1841e5c8, 0x16b0, 0x489b, 0xbc, 0xc8, 0x44, 0xcf, 0xb0, 0xd5, 0xde, 0xae)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11DepthStencilState" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11DepthStencilStateTest()
        {
            Assert.That(IID_ID3D11DepthStencilState, Is.EqualTo(new Guid(0x03823efb, 0x8d8f, 0x4e1c, 0x9a, 0xa2, 0xf6, 0x4b, 0xb2, 0xcb, 0xfd, 0xf1)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11BlendState" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11BlendStateTest()
        {
            Assert.That(IID_ID3D11BlendState, Is.EqualTo(new Guid(0x75b68faa, 0x347d, 0x4159, 0x8f, 0x45, 0xa0, 0x64, 0x0f, 0x01, 0xcd, 0x9a)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11RasterizerState" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11RasterizerStateTest()
        {
            Assert.That(IID_ID3D11RasterizerState, Is.EqualTo(new Guid(0x9bb4ab81, 0xab1a, 0x4d8f, 0xb5, 0x06, 0xfc, 0x04, 0x20, 0x0b, 0x6e, 0xe7)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11Resource" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11ResourceTest()
        {
            Assert.That(IID_ID3D11Resource, Is.EqualTo(new Guid(0xdc8e63f3, 0xd12b, 0x4952, 0xb4, 0x7b, 0x5e, 0x45, 0x02, 0x6a, 0x86, 0x2d)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11Buffer" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11BufferTest()
        {
            Assert.That(IID_ID3D11Buffer, Is.EqualTo(new Guid(0x48570b85, 0xd1ee, 0x4fcd, 0xa2, 0x50, 0xeb, 0x35, 0x07, 0x22, 0xb0, 0x37)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11Texture1D" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11Texture1DTest()
        {
            Assert.That(IID_ID3D11Texture1D, Is.EqualTo(new Guid(0xf8fb5c27, 0xc6b3, 0x4f75, 0xa4, 0xc8, 0x43, 0x9a, 0xf2, 0xef, 0x56, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11Texture2D" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11Texture2DTest()
        {
            Assert.That(IID_ID3D11Texture2D, Is.EqualTo(new Guid(0x6f15aaf2, 0xd208, 0x4e89, 0x9a, 0xb4, 0x48, 0x95, 0x35, 0xd3, 0x4f, 0x9c)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11Texture3D" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11Texture3DTest()
        {
            Assert.That(IID_ID3D11Texture3D, Is.EqualTo(new Guid(0x037e866e, 0xf56d, 0x4357, 0xa8, 0xaf, 0x9d, 0xab, 0xbe, 0x6e, 0x25, 0x0e)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11View" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11ViewTest()
        {
            Assert.That(IID_ID3D11View, Is.EqualTo(new Guid(0x839d1216, 0xbb2e, 0x412b, 0xb7, 0xf4, 0xa9, 0xdb, 0xeb, 0xe0, 0x8e, 0xd1)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11ShaderResourceView" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11ShaderResourceViewTest()
        {
            Assert.That(IID_ID3D11ShaderResourceView, Is.EqualTo(new Guid(0xb0e06fe0, 0x8192, 0x4e1a, 0xb1, 0xca, 0x36, 0xd7, 0x41, 0x47, 0x10, 0xb2)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11RenderTargetView" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11RenderTargetViewTest()
        {
            Assert.That(IID_ID3D11RenderTargetView, Is.EqualTo(new Guid(0xdfdba067, 0x0b8d, 0x4865, 0x87, 0x5b, 0xd7, 0xb4, 0x51, 0x6c, 0xc1, 0x64)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11DepthStencilView" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11DepthStencilViewTest()
        {
            Assert.That(IID_ID3D11DepthStencilView, Is.EqualTo(new Guid(0x9fdac92a, 0x1876, 0x48c3, 0xaf, 0xad, 0x25, 0xb9, 0x4f, 0x84, 0xa9, 0xb6)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11UnorderedAccessView" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11UnorderedAccessViewTest()
        {
            Assert.That(IID_ID3D11UnorderedAccessView, Is.EqualTo(new Guid(0x28acf509, 0x7f5c, 0x48f6, 0x86, 0x11, 0xf3, 0x16, 0x01, 0x0a, 0x63, 0x80)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11VertexShader" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11VertexShaderTest()
        {
            Assert.That(IID_ID3D11VertexShader, Is.EqualTo(new Guid(0x3b301d64, 0xd678, 0x4289, 0x88, 0x97, 0x22, 0xf8, 0x92, 0x8b, 0x72, 0xf3)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11HullShader" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11HullShaderTest()
        {
            Assert.That(IID_ID3D11HullShader, Is.EqualTo(new Guid(0x8e5c6061, 0x628a, 0x4c8e, 0x82, 0x64, 0xbb, 0xe4, 0x5c, 0xb3, 0xd5, 0xdd)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11DomainShader" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11DomainShaderTest()
        {
            Assert.That(IID_ID3D11DomainShader, Is.EqualTo(new Guid(0xf582c508, 0x0f36, 0x490c, 0x99, 0x77, 0x31, 0xee, 0xce, 0x26, 0x8c, 0xfa)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11GeometryShader" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11GeometryShaderTest()
        {
            Assert.That(IID_ID3D11GeometryShader, Is.EqualTo(new Guid(0x38325b96, 0xeffb, 0x4022, 0xba, 0x02, 0x2e, 0x79, 0x5b, 0x70, 0x27, 0x5c)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11PixelShader" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11PixelShaderTest()
        {
            Assert.That(IID_ID3D11PixelShader, Is.EqualTo(new Guid(0xea82e40d, 0x51dc, 0x4f33, 0x93, 0xd4, 0xdb, 0x7c, 0x91, 0x25, 0xae, 0x8c)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11ComputeShader" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11ComputeShaderTest()
        {
            Assert.That(IID_ID3D11ComputeShader, Is.EqualTo(new Guid(0x4f5b196e, 0xc2bd, 0x495e, 0xbd, 0x01, 0x1f, 0xde, 0xd3, 0x8e, 0x49, 0x69)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11InputLayout" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11InputLayoutTest()
        {
            Assert.That(IID_ID3D11InputLayout, Is.EqualTo(new Guid(0xe4819ddc, 0x4cf0, 0x4025, 0xbd, 0x26, 0x5d, 0xe8, 0x2a, 0x3e, 0x07, 0xb7)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11SamplerState" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11SamplerStateTest()
        {
            Assert.That(IID_ID3D11SamplerState, Is.EqualTo(new Guid(0xda6fea51, 0x564c, 0x4487, 0x98, 0x10, 0xf0, 0xd0, 0xf9, 0xb4, 0xe3, 0xa5)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11Asynchronous" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11AsynchronousTest()
        {
            Assert.That(IID_ID3D11Asynchronous, Is.EqualTo(new Guid(0x4b35d0cd, 0x1e15, 0x4258, 0x9c, 0x98, 0x1b, 0x13, 0x33, 0xf6, 0xdd, 0x3b)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11Query" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11QueryTest()
        {
            Assert.That(IID_ID3D11Query, Is.EqualTo(new Guid(0xd6c00747, 0x87b7, 0x425e, 0xb8, 0x4d, 0x44, 0xd1, 0x08, 0x56, 0x0a, 0xfd)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11Predicate" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11PredicateTest()
        {
            Assert.That(IID_ID3D11Predicate, Is.EqualTo(new Guid(0x9eb576dd, 0x9f77, 0x4d86, 0x81, 0xaa, 0x8b, 0xab, 0x5f, 0xe4, 0x90, 0xe2)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11Counter" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11CounterTest()
        {
            Assert.That(IID_ID3D11Counter, Is.EqualTo(new Guid(0x6e8c49fb, 0xa371, 0x4770, 0xb4, 0x40, 0x29, 0x08, 0x60, 0x22, 0xb7, 0x41)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11ClassInstance" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11ClassInstanceTest()
        {
            Assert.That(IID_ID3D11ClassInstance, Is.EqualTo(new Guid(0xa6cd7faa, 0xb0b7, 0x4a2f, 0x94, 0x36, 0x86, 0x62, 0xa6, 0x57, 0x97, 0xcb)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11ClassLinkage" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11ClassLinkageTest()
        {
            Assert.That(IID_ID3D11ClassLinkage, Is.EqualTo(new Guid(0xddf57cba, 0x9543, 0x46e4, 0xa1, 0x2b, 0xf2, 0x07, 0xa0, 0xfe, 0x7f, 0xed)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11CommandList" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11CommandListTest()
        {
            Assert.That(IID_ID3D11CommandList, Is.EqualTo(new Guid(0xa24bc4d1, 0x769e, 0x43f7, 0x80, 0x13, 0x98, 0xff, 0x56, 0x6c, 0x18, 0xe2)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11DeviceContext" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11DeviceContextTest()
        {
            Assert.That(IID_ID3D11DeviceContext, Is.EqualTo(new Guid(0xc0bfa96c, 0xe089, 0x44fb, 0x8e, 0xaf, 0x26, 0xf8, 0x79, 0x61, 0x90, 0xda)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11VideoDecoder" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11VideoDecoderTest()
        {
            Assert.That(IID_ID3D11VideoDecoder, Is.EqualTo(new Guid(0x3C9C5B51, 0x995D, 0x48d1, 0x9B, 0x8D, 0xFA, 0x5C, 0xAE, 0xDE, 0xD6, 0x5C)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11VideoProcessorEnumerator" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11VideoProcessorEnumeratorTest()
        {
            Assert.That(IID_ID3D11VideoProcessorEnumerator, Is.EqualTo(new Guid(0x31627037, 0x53AB, 0x4200, 0x90, 0x61, 0x05, 0xFA, 0xA9, 0xAB, 0x45, 0xF9)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11VideoProcessor" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11VideoProcessorTest()
        {
            Assert.That(IID_ID3D11VideoProcessor, Is.EqualTo(new Guid(0x1D7B0652, 0x185F, 0x41c6, 0x85, 0xCE, 0x0C, 0x5B, 0xE3, 0xD4, 0xAE, 0x6C)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11AuthenticatedChannel" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11AuthenticatedChannelTest()
        {
            Assert.That(IID_ID3D11AuthenticatedChannel, Is.EqualTo(new Guid(0x3015A308, 0xDCBD, 0x47aa, 0xA7, 0x47, 0x19, 0x24, 0x86, 0xD1, 0x4D, 0x4A)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11CryptoSession" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11CryptoSessionTest()
        {
            Assert.That(IID_ID3D11CryptoSession, Is.EqualTo(new Guid(0x9B32F9AD, 0xBDCC, 0x40a6, 0xA3, 0x9D, 0xD5, 0xC8, 0x65, 0x84, 0x57, 0x20)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11VideoDecoderOutputView" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11VideoDecoderOutputViewTest()
        {
            Assert.That(IID_ID3D11VideoDecoderOutputView, Is.EqualTo(new Guid(0xC2931AEA, 0x2A85, 0x4f20, 0x86, 0x0F, 0xFB, 0xA1, 0xFD, 0x25, 0x6E, 0x18)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11VideoProcessorInputView" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11VideoProcessorInputViewTest()
        {
            Assert.That(IID_ID3D11VideoProcessorInputView, Is.EqualTo(new Guid(0x11EC5A5F, 0x51DC, 0x4945, 0xAB, 0x34, 0x6E, 0x8C, 0x21, 0x30, 0x0E, 0xA5)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11VideoProcessorOutputView" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11VideoProcessorOutputViewTest()
        {
            Assert.That(IID_ID3D11VideoProcessorOutputView, Is.EqualTo(new Guid(0xA048285E, 0x25A9, 0x4527, 0xBD, 0x93, 0xD6, 0x8B, 0x68, 0xC4, 0x42, 0x54)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11VideoContext" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11VideoContextTest()
        {
            Assert.That(IID_ID3D11VideoContext, Is.EqualTo(new Guid(0x61F21C45, 0x3C0E, 0x4a74, 0x9C, 0xEA, 0x67, 0x10, 0x0D, 0x9A, 0xD5, 0xE4)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11VideoDevice" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11VideoDeviceTest()
        {
            Assert.That(IID_ID3D11VideoDevice, Is.EqualTo(new Guid(0x10EC4D5B, 0x975A, 0x4689, 0xB9, 0xE4, 0xD0, 0xAA, 0xC3, 0x0F, 0xE3, 0x33)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D11Device" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D11DeviceTest()
        {
            Assert.That(IID_ID3D11Device, Is.EqualTo(new Guid(0xdb6f6ddb, 0xac77, 0x4e88, 0x82, 0x53, 0x81, 0x9d, 0xf9, 0xbb, 0xf1, 0x40)));
        }
    }
}
