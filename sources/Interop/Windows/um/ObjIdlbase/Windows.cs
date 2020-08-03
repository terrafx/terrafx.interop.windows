// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("#define COLE_DEFAULT_PRINCIPAL ( ( OLECHAR * )( INT_PTR  )-1 )")]
        public static readonly ushort* COLE_DEFAULT_PRINCIPAL = ((ushort*)((nint)(-1)));

        [NativeTypeName("#define COLE_DEFAULT_AUTHINFO ( ( void * )( INT_PTR  )-1 )")]
        public static readonly void* COLE_DEFAULT_AUTHINFO = ((void*)((nint)(-1)));
    }
}
