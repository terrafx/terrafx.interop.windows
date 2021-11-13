// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public partial struct TRANSACTION_NOTIFICATION_PROPAGATE_ARGUMENT
    {
        [NativeTypeName("ULONG")]
        public uint PropagationCookie;

        public Guid UOW;

        public Guid TmIdentity;

        [NativeTypeName("ULONG")]
        public uint BufferLength;
    }
}
