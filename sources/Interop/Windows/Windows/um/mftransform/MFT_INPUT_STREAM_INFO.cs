// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct MFT_INPUT_STREAM_INFO
    {
        [NativeTypeName("LONGLONG")]
        public long hnsMaxLatency;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint cbMaxLookahead;

        [NativeTypeName("DWORD")]
        public uint cbAlignment;
    }
}
