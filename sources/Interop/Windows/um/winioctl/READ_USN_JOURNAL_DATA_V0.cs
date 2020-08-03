// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct READ_USN_JOURNAL_DATA_V0
    {
        [NativeTypeName("USN")]
        public long StartUsn;

        [NativeTypeName("DWORD")]
        public uint ReasonMask;

        [NativeTypeName("DWORD")]
        public uint ReturnOnlyOnClose;

        [NativeTypeName("DWORDLONG")]
        public ulong Timeout;

        [NativeTypeName("DWORDLONG")]
        public ulong BytesToWaitFor;

        [NativeTypeName("DWORDLONG")]
        public ulong UsnJournalID;
    }
}
