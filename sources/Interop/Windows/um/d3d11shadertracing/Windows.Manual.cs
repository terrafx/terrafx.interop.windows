// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const uint D3D11_TRACE_COMPONENT_X = 0x1;

        public const uint D3D11_TRACE_COMPONENT_Y = 0x2;

        public const uint D3D11_TRACE_COMPONENT_Z = 0x4;

        public const uint D3D11_TRACE_COMPONENT_W = 0x8;

        public const uint D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_WRITES = 0x1;

        public const uint D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_READS = 0x2;

        public const uint D3D11_TRACE_REGISTER_FLAGS_RELATIVE_INDEXING = 0x1;

        public const uint D3D11_TRACE_MISC_GS_EMIT = 0x1;

        public const uint D3D11_TRACE_MISC_GS_CUT = 0x2;

        public const uint D3D11_TRACE_MISC_PS_DISCARD = 0x4;

        public const uint D3D11_TRACE_MISC_GS_EMIT_STREAM = 0x8;

        public const uint D3D11_TRACE_MISC_GS_CUT_STREAM = 0x10;

        public const uint D3D11_TRACE_MISC_HALT = 0x20;

        public const uint D3D11_TRACE_MISC_MESSAGE = 0x40;

        public static readonly Guid IID_ID3D11ShaderTrace = new Guid(0x36B013E6, 0x2811, 0x4845, 0xBA, 0xA7, 0xD6, 0x23, 0xFE, 0x0D, 0xF1, 0x04);

        public static readonly Guid IID_ID3D11ShaderTraceFactory = new Guid(0x1FBAD429, 0x66AB, 0x41CC, 0x96, 0x17, 0x66, 0x7A, 0xC1, 0x0E, 0x44, 0x59);
    }
}
