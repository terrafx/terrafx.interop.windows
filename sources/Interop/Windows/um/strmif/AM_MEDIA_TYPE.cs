// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AM_MEDIA_TYPE
    {
        [NativeTypeName("GUID")]
        public Guid majortype;

        [NativeTypeName("GUID")]
        public Guid subtype;

        [NativeTypeName("BOOL")]
        public int bFixedSizeSamples;

        [NativeTypeName("BOOL")]
        public int bTemporalCompression;

        [NativeTypeName("ULONG")]
        public uint lSampleSize;

        [NativeTypeName("GUID")]
        public Guid formattype;

        [NativeTypeName("IUnknown *")]
        public IUnknown* pUnk;

        [NativeTypeName("ULONG")]
        public uint cbFormat;

        [NativeTypeName("BYTE *")]
        public byte* pbFormat;
    }
}
