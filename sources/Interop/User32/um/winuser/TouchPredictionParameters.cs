// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct TouchPredictionParameters
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("UINT")]
        public uint dwLatency;

        [NativeTypeName("UINT")]
        public uint dwSampleTime;

        [NativeTypeName("UINT")]
        public uint bUseHWTimeStamp;
    }
}
