// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MOVESIZE_OPERATION.xml' path='doc/member[@name="MOVESIZE_OPERATION"]/*' />
public enum MOVESIZE_OPERATION
{
    /// <include file='MOVESIZE_OPERATION.xml' path='doc/member[@name="MOVESIZE_OPERATION.MSO_SIZE_LEFT"]/*' />
    MSO_SIZE_LEFT = 1,

    /// <include file='MOVESIZE_OPERATION.xml' path='doc/member[@name="MOVESIZE_OPERATION.MSO_SIZE_RIGHT"]/*' />
    MSO_SIZE_RIGHT = 2,

    /// <include file='MOVESIZE_OPERATION.xml' path='doc/member[@name="MOVESIZE_OPERATION.MSO_SIZE_TOP"]/*' />
    MSO_SIZE_TOP = 3,

    /// <include file='MOVESIZE_OPERATION.xml' path='doc/member[@name="MOVESIZE_OPERATION.MSO_SIZE_TOPLEFT"]/*' />
    MSO_SIZE_TOPLEFT = 4,

    /// <include file='MOVESIZE_OPERATION.xml' path='doc/member[@name="MOVESIZE_OPERATION.MSO_SIZE_TOPRIGHT"]/*' />
    MSO_SIZE_TOPRIGHT = 5,

    /// <include file='MOVESIZE_OPERATION.xml' path='doc/member[@name="MOVESIZE_OPERATION.MSO_SIZE_BOTTOM"]/*' />
    MSO_SIZE_BOTTOM = 6,

    /// <include file='MOVESIZE_OPERATION.xml' path='doc/member[@name="MOVESIZE_OPERATION.MSO_SIZE_BOTTOMLEFT"]/*' />
    MSO_SIZE_BOTTOMLEFT = 7,

    /// <include file='MOVESIZE_OPERATION.xml' path='doc/member[@name="MOVESIZE_OPERATION.MSO_SIZE_BOTTOMRIGHT"]/*' />
    MSO_SIZE_BOTTOMRIGHT = 8,

    /// <include file='MOVESIZE_OPERATION.xml' path='doc/member[@name="MOVESIZE_OPERATION.MSO_MOVE"]/*' />
    MSO_MOVE = 9,
}
