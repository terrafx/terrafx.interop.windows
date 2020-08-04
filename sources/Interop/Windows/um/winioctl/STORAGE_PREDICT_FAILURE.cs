// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct STORAGE_PREDICT_FAILURE
    {
        [NativeTypeName("DWORD")]
        public uint PredictFailure;

        [NativeTypeName("BYTE [512]")]
        public fixed byte VendorSpecific[512];
    }
}
