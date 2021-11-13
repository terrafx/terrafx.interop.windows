// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSChapp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct ENCRYPTED_LM_OWF_PASSWORD
    {
        [NativeTypeName("CYPHER_BLOCK [2]")]
        public _data_e__FixedBuffer data;

        public partial struct _data_e__FixedBuffer
        {
            public CYPHER_BLOCK e0;
            public CYPHER_BLOCK e1;

            public ref CYPHER_BLOCK this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<CYPHER_BLOCK> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }
    }
}
