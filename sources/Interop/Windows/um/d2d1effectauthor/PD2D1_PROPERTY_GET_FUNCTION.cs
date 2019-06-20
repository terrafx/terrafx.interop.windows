// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Function pointer that gets a property from an effect.</summary>
    [SuppressUnmanagedCodeSecurity]
    [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
    [return: NativeTypeName("HRESULT")]
    public /* static */ unsafe delegate int PD2D1_PROPERTY_GET_FUNCTION(
        [In] IUnknown* effect,
        [Out, Optional, NativeTypeName("BYTE[]")] byte* data,
        [In, NativeTypeName("UINT32")] uint dataSize,
        [Out, NativeTypeName("UINT32")] uint* actualSize = null
    );
}
