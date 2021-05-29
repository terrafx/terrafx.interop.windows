// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SPVOICESTATUS
    {
        [NativeTypeName("ULONG")]
        public uint ulCurrentStream;

        [NativeTypeName("ULONG")]
        public uint ulLastStreamQueued;

        [NativeTypeName("HRESULT")]
        public int hrLastResult;

        [NativeTypeName("DWORD")]
        public uint dwRunningState;

        [NativeTypeName("ULONG")]
        public uint ulInputWordPos;

        [NativeTypeName("ULONG")]
        public uint ulInputWordLen;

        [NativeTypeName("ULONG")]
        public uint ulInputSentPos;

        [NativeTypeName("ULONG")]
        public uint ulInputSentLen;

        [NativeTypeName("LONG")]
        public int lBookmarkId;

        [NativeTypeName("SPPHONEID")]
        public ushort PhonemeId;

        public SPVISEMES VisemeId;

        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        [NativeTypeName("DWORD")]
        public uint dwReserved2;
    }
}
