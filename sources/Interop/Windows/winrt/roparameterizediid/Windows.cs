// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("api-ms-win-core-winrt-roparameterizediid-l1-1-0", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoGetParameterizedTypeInstanceIID([NativeTypeName("UINT32")] uint nameElementCount, [NativeTypeName("PCWSTR *")] ushort** nameElements, [NativeTypeName("const IRoMetaDataLocator &")] IRoMetaDataLocator* metaDataLocator, [NativeTypeName("GUID *")] Guid* iid, [NativeTypeName("ROPARAMIIDHANDLE *")] IntPtr* pExtra);

        [DllImport("combase", ExactSpelling = true)]
        public static extern void RoFreeParameterizedTypeExtra([NativeTypeName("ROPARAMIIDHANDLE")] IntPtr extra);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("PCSTR")]
        public static extern sbyte* RoParameterizedTypeExtraGetTypeSignature([NativeTypeName("ROPARAMIIDHANDLE")] IntPtr extra);
    }
}
