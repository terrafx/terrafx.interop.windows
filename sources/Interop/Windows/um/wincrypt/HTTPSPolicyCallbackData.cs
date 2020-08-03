// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct HTTPSPolicyCallbackData
    {
        [NativeTypeName("_HTTPSPolicyCallbackData::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:20164:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint cbStruct => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cbStruct, 1));

        public ref uint cbSize => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cbSize, 1));

        [NativeTypeName("DWORD")]
        public uint dwAuthType;

        [NativeTypeName("DWORD")]
        public uint fdwChecks;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszServerName;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint cbStruct;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint cbSize;
        }
    }
}
