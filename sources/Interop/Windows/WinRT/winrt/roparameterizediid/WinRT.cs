// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    public static unsafe partial class WinRT
    {
        [DllImport("api-ms-win-core-winrt-roparameterizediid-l1-1-0", ExactSpelling = true)]
        public static extern HRESULT RoGetParameterizedTypeInstanceIID([NativeTypeName("UINT32")] uint nameElementCount, [NativeTypeName("PCWSTR *")] ushort** nameElements, [NativeTypeName("const IRoMetaDataLocator &")] IRoMetaDataLocator* metaDataLocator, Guid* iid, ROPARAMIIDHANDLE* pExtra);

        [DllImport("combase", ExactSpelling = true)]
        public static extern void RoFreeParameterizedTypeExtra(ROPARAMIIDHANDLE extra);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("PCSTR")]
        public static extern sbyte* RoParameterizedTypeExtraGetTypeSignature(ROPARAMIIDHANDLE extra);
    }
}
