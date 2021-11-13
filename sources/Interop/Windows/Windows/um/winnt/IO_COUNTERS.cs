// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct IO_COUNTERS
    {
        [NativeTypeName("ULONGLONG")]
        public ulong ReadOperationCount;

        [NativeTypeName("ULONGLONG")]
        public ulong WriteOperationCount;

        [NativeTypeName("ULONGLONG")]
        public ulong OtherOperationCount;

        [NativeTypeName("ULONGLONG")]
        public ulong ReadTransferCount;

        [NativeTypeName("ULONGLONG")]
        public ulong WriteTransferCount;

        [NativeTypeName("ULONGLONG")]
        public ulong OtherTransferCount;
    }
}
