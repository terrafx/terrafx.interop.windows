// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devpropdef.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const uint DEVPROP_TYPEMOD_ARRAY = 0x00001000;

        public const uint DEVPROP_TYPEMOD_LIST = 0x00002000;

        public const uint DEVPROP_TYPE_EMPTY = 0x00000000;

        public const uint DEVPROP_TYPE_NULL = 0x00000001;

        public const uint DEVPROP_TYPE_SBYTE = 0x00000002;

        public const uint DEVPROP_TYPE_BYTE = 0x00000003;

        public const uint DEVPROP_TYPE_INT16 = 0x00000004;

        public const uint DEVPROP_TYPE_UINT16 = 0x00000005;

        public const uint DEVPROP_TYPE_INT32 = 0x00000006;

        public const uint DEVPROP_TYPE_UINT32 = 0x00000007;

        public const uint DEVPROP_TYPE_INT64 = 0x00000008;

        public const uint DEVPROP_TYPE_UINT64 = 0x00000009;

        public const uint DEVPROP_TYPE_FLOAT = 0x0000000A;

        public const uint DEVPROP_TYPE_DOUBLE = 0x0000000B;

        public const uint DEVPROP_TYPE_DECIMAL = 0x0000000C;

        public const uint DEVPROP_TYPE_GUID = 0x0000000D;

        public const uint DEVPROP_TYPE_CURRENCY = 0x0000000E;

        public const uint DEVPROP_TYPE_DATE = 0x0000000F;

        public const uint DEVPROP_TYPE_FILETIME = 0x00000010;

        public const uint DEVPROP_TYPE_BOOLEAN = 0x00000011;

        public const uint DEVPROP_TYPE_STRING = 0x00000012;

        public const uint DEVPROP_TYPE_STRING_LIST = DEVPROP_TYPE_STRING | DEVPROP_TYPEMOD_LIST;

        public const uint DEVPROP_TYPE_SECURITY_DESCRIPTOR = 0x00000013;

        public const uint DEVPROP_TYPE_SECURITY_DESCRIPTOR_STRING = 0x00000014;

        public const uint DEVPROP_TYPE_DEVPROPKEY = 0x00000015;

        public const uint DEVPROP_TYPE_DEVPROPTYPE = 0x00000016;

        public const uint DEVPROP_TYPE_BINARY = DEVPROP_TYPE_BYTE | DEVPROP_TYPEMOD_ARRAY;

        public const uint DEVPROP_TYPE_ERROR = 0x00000017;

        public const uint DEVPROP_TYPE_NTSTATUS = 0x00000018;

        public const uint DEVPROP_TYPE_STRING_INDIRECT = 0x00000019;

        public const uint MAX_DEVPROP_TYPE = 0x00000019;

        public const uint MAX_DEVPROP_TYPEMOD = 0x00002000;

        public const uint DEVPROP_MASK_TYPE = 0x00000FFF;

        public const uint DEVPROP_MASK_TYPEMOD = 0x0000F000;

        public const sbyte DEVPROP_TRUE = -1;

        public const sbyte DEVPROP_FALSE = 0;

        public const int DEVPROPID_FIRST_USABLE = 2;
    }
}
