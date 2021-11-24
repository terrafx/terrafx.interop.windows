// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT;

public partial struct MLOperatorEdgeDescription
{
    public MLOperatorEdgeType edgeType;

    [NativeTypeName("MLOperatorEdgeDescription::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/MLOperatorAuthor.h:117:5)")]
    public _Anonymous_e__Union Anonymous;

    public ref ulong reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.reserved, 1));
        }
    }

    public ref MLOperatorTensorDataType tensorDataType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.tensorDataType, 1));
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("uint64_t")]
        public ulong reserved;

        [FieldOffset(0)]
        public MLOperatorTensorDataType tensorDataType;
    }
}
