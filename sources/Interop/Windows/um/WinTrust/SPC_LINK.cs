// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SPC_LINK
    {
        [NativeTypeName("DWORD")]
        public uint dwLinkChoice;

        [NativeTypeName("SPC_LINK_::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinTrust.h:1280:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref ushort* pwszUrl
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pwszUrl;
                }
            }
        }

        public ref SPC_SERIALIZED_OBJECT Moniker
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Moniker, 1));
            }
        }

        public ref ushort* pwszFile
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pwszFile;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pwszUrl;

            [FieldOffset(0)]
            public SPC_SERIALIZED_OBJECT Moniker;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pwszFile;
        }
    }
}
