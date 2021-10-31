// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct TVINSERTSTRUCTW
    {
        public HTREEITEM hParent;

        public HTREEITEM hInsertAfter;

        [NativeTypeName("tagTVINSERTSTRUCTW::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/CommCtrl.h:5011:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref TVITEMEXW itemex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.itemex, 1));
            }
        }

        public ref TVITEMW item
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.item, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public TVITEMEXW itemex;

            [FieldOffset(0)]
            public TVITEMW item;
        }
    }
}
