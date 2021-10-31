// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public partial struct InstanceHandle
    {
        public static explicit operator InstanceHandle(long value) => new InstanceHandle((ulong)(value));

        public static explicit operator long(InstanceHandle value) => (long)(value.Value);
    }
}
