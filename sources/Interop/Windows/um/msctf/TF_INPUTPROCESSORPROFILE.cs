// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct TF_INPUTPROCESSORPROFILE
    {
        [NativeTypeName("DWORD")]
        public uint dwProfileType;

        [NativeTypeName("LANGID")]
        public ushort langid;

        [NativeTypeName("CLSID")]
        public Guid clsid;

        [NativeTypeName("GUID")]
        public Guid guidProfile;

        [NativeTypeName("GUID")]
        public Guid catid;

        public HKL hklSubstitute;

        [NativeTypeName("DWORD")]
        public uint dwCaps;

        public HKL hkl;

        [NativeTypeName("DWORD")]
        public uint dwFlags;
    }
}
