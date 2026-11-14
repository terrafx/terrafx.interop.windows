// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.OLECMDID;

namespace TerraFX.Interop.Windows;

public static partial class MSOCMDID
{
    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_OPEN"]/*' />
    [NativeTypeName("#define MSOCMDID_OPEN OLECMDID_OPEN")]
    public const OLECMDID MSOCMDID_OPEN = OLECMDID_OPEN;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_NEW"]/*' />
    [NativeTypeName("#define MSOCMDID_NEW OLECMDID_NEW")]
    public const OLECMDID MSOCMDID_NEW = OLECMDID_NEW;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_SAVE"]/*' />
    [NativeTypeName("#define MSOCMDID_SAVE OLECMDID_SAVE")]
    public const OLECMDID MSOCMDID_SAVE = OLECMDID_SAVE;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_SAVEAS"]/*' />
    [NativeTypeName("#define MSOCMDID_SAVEAS OLECMDID_SAVEAS")]
    public const OLECMDID MSOCMDID_SAVEAS = OLECMDID_SAVEAS;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_SAVECOPYAS"]/*' />
    [NativeTypeName("#define MSOCMDID_SAVECOPYAS OLECMDID_SAVECOPYAS")]
    public const OLECMDID MSOCMDID_SAVECOPYAS = OLECMDID_SAVECOPYAS;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_PRINT"]/*' />
    [NativeTypeName("#define MSOCMDID_PRINT OLECMDID_PRINT")]
    public const OLECMDID MSOCMDID_PRINT = OLECMDID_PRINT;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_PRINTPREVIEW"]/*' />
    [NativeTypeName("#define MSOCMDID_PRINTPREVIEW OLECMDID_PRINTPREVIEW")]
    public const OLECMDID MSOCMDID_PRINTPREVIEW = OLECMDID_PRINTPREVIEW;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_PAGESETUP"]/*' />
    [NativeTypeName("#define MSOCMDID_PAGESETUP OLECMDID_PAGESETUP")]
    public const OLECMDID MSOCMDID_PAGESETUP = OLECMDID_PAGESETUP;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_SPELL"]/*' />
    [NativeTypeName("#define MSOCMDID_SPELL OLECMDID_SPELL")]
    public const OLECMDID MSOCMDID_SPELL = OLECMDID_SPELL;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_PROPERTIES"]/*' />
    [NativeTypeName("#define MSOCMDID_PROPERTIES OLECMDID_PROPERTIES")]
    public const OLECMDID MSOCMDID_PROPERTIES = OLECMDID_PROPERTIES;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_CUT"]/*' />
    [NativeTypeName("#define MSOCMDID_CUT OLECMDID_CUT")]
    public const OLECMDID MSOCMDID_CUT = OLECMDID_CUT;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_COPY"]/*' />
    [NativeTypeName("#define MSOCMDID_COPY OLECMDID_COPY")]
    public const OLECMDID MSOCMDID_COPY = OLECMDID_COPY;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_PASTE"]/*' />
    [NativeTypeName("#define MSOCMDID_PASTE OLECMDID_PASTE")]
    public const OLECMDID MSOCMDID_PASTE = OLECMDID_PASTE;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_PASTESPECIAL"]/*' />
    [NativeTypeName("#define MSOCMDID_PASTESPECIAL OLECMDID_PASTESPECIAL")]
    public const OLECMDID MSOCMDID_PASTESPECIAL = OLECMDID_PASTESPECIAL;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_UNDO"]/*' />
    [NativeTypeName("#define MSOCMDID_UNDO OLECMDID_UNDO")]
    public const OLECMDID MSOCMDID_UNDO = OLECMDID_UNDO;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_REDO"]/*' />
    [NativeTypeName("#define MSOCMDID_REDO OLECMDID_REDO")]
    public const OLECMDID MSOCMDID_REDO = OLECMDID_REDO;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_SELECTALL"]/*' />
    [NativeTypeName("#define MSOCMDID_SELECTALL OLECMDID_SELECTALL")]
    public const OLECMDID MSOCMDID_SELECTALL = OLECMDID_SELECTALL;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_CLEARSELECTION"]/*' />
    [NativeTypeName("#define MSOCMDID_CLEARSELECTION OLECMDID_CLEARSELECTION")]
    public const OLECMDID MSOCMDID_CLEARSELECTION = OLECMDID_CLEARSELECTION;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_ZOOM"]/*' />
    [NativeTypeName("#define MSOCMDID_ZOOM OLECMDID_ZOOM")]
    public const OLECMDID MSOCMDID_ZOOM = OLECMDID_ZOOM;

    /// <include file='MSOCMDID.xml' path='doc/member[@name="MSOCMDID.MSOCMDID_GETZOOMRANGE"]/*' />
    [NativeTypeName("#define MSOCMDID_GETZOOMRANGE OLECMDID_GETZOOMRANGE")]
    public const OLECMDID MSOCMDID_GETZOOMRANGE = OLECMDID_GETZOOMRANGE;
}
