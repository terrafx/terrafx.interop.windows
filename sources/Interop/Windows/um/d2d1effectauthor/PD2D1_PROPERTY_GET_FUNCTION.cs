// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Function pointer that gets a property from an effect.</summary>
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("HRESULT")]
    public unsafe delegate int PD2D1_PROPERTY_GET_FUNCTION(IUnknown* effect, [Optional, NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataSize, [NativeTypeName("UINT32")] uint* actualSize = null);
}
