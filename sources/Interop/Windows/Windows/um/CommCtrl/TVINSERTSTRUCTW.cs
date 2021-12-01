// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='TVINSERTSTRUCTW.xml' path='doc/member[@name="TVINSERTSTRUCTW"]/*' />
public partial struct TVINSERTSTRUCTW
{
    /// <include file='TVINSERTSTRUCTW.xml' path='doc/member[@name="TVINSERTSTRUCTW.hParent"]/*' />
    public HTREEITEM hParent;

    /// <include file='TVINSERTSTRUCTW.xml' path='doc/member[@name="TVINSERTSTRUCTW.hInsertAfter"]/*' />
    public HTREEITEM hInsertAfter;

    /// <include file='TVINSERTSTRUCTW.xml' path='doc/member[@name="TVINSERTSTRUCTW.Anonymous"]/*' />
    [NativeTypeName("tagTVINSERTSTRUCTW::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/CommCtrl.h:5011:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.itemex"]/*' />
    public ref TVITEMEXW itemex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.itemex, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.item"]/*' />
    public ref TVITEMW item
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.item, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.itemex"]/*' />
        [FieldOffset(0)]
        public TVITEMEXW itemex;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.item"]/*' />
        [FieldOffset(0)]
        public TVITEMW item;
    }
}
