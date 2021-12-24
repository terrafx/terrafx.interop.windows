// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

/// <include file='MatrixOrder.xml' path='doc/member[@name="MatrixOrder"]/*' />
public enum MatrixOrder
{
    /// <include file='MatrixOrder.xml' path='doc/member[@name="MatrixOrder.MatrixOrderPrepend"]/*' />
    MatrixOrderPrepend = 0,

    /// <include file='MatrixOrder.xml' path='doc/member[@name="MatrixOrder.MatrixOrderAppend"]/*' />
    MatrixOrderAppend = 1,
}
