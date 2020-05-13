// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct EXCEPTION_REGISTRATION_RECORD
    {
        [NativeTypeName("struct _EXCEPTION_REGISTRATION_RECORD *")]
        public EXCEPTION_REGISTRATION_RECORD* Next;

        [NativeTypeName("PEXCEPTION_ROUTINE")]
        public IntPtr* Handler;
    }
}
