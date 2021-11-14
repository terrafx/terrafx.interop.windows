// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct MF_TRANSCODE_SINK_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwVideoStreamID;

        public IMFMediaType* pVideoMediaType;

        [NativeTypeName("DWORD")]
        public uint dwAudioStreamID;

        public IMFMediaType* pAudioMediaType;
    }
}
