// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("mfplat", EntryPoint = "MFSerializeAttributesToStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFSerializeAttributesToStream([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttr, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("IStream *")] IStream* pStm);

        [DllImport("mfplat", EntryPoint = "MFDeserializeAttributesFromStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFDeserializeAttributesFromStream([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttr, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("IStream *")] IStream* pStm);
    }
}
