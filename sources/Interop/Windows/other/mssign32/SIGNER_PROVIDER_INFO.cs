// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SIGNER_PROVIDER_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("LPCWSTR")]
        public ushort* pwszProviderName;

        [NativeTypeName("DWORD")]
        public uint dwProviderType;

        [NativeTypeName("DWORD")]
        public uint dwKeySpec;

        [NativeTypeName("DWORD")]
        public uint dwPvkChoice;

        [NativeTypeName("_SIGNER_PROVIDER_INFO::(anonymous union at ./mssign32.h:74:9)")]
        public _Anonymous_e__Union Anonymous;

        public ref ushort* pwszPvkFileName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pwszPvkFileName;
                }
            }
        }

        public ref ushort* pwszKeyContainer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pwszKeyContainer;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pwszPvkFileName;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pwszKeyContainer;
        }
    }
}
