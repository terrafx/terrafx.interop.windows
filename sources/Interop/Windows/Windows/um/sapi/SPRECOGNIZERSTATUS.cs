// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SPRECOGNIZERSTATUS
    {
        public SPAUDIOSTATUS AudioStatus;

        [NativeTypeName("ULONGLONG")]
        public ulong ullRecognitionStreamPos;

        [NativeTypeName("ULONG")]
        public uint ulStreamNumber;

        [NativeTypeName("ULONG")]
        public uint ulNumActive;

        [NativeTypeName("CLSID")]
        public Guid clsidEngine;

        [NativeTypeName("ULONG")]
        public uint cLangIDs;

        [NativeTypeName("WORD [20]")]
        public fixed ushort aLangID[20];

        [NativeTypeName("ULONGLONG")]
        public ulong ullRecognitionStreamTime;
    }
}
