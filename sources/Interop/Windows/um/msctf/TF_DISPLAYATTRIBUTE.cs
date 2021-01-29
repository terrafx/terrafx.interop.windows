// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct TF_DISPLAYATTRIBUTE
    {
        public TF_DA_COLOR crText;

        public TF_DA_COLOR crBk;

        public TF_DA_LINESTYLE lsStyle;

        [NativeTypeName("BOOL")]
        public int fBoldLine;

        public TF_DA_COLOR crLine;

        public TF_DA_ATTR_INFO bAttr;
    }
}
