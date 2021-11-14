// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum XmlReadState
    {
        XmlReadState_Initial = 0,
        XmlReadState_Interactive = 1,
        XmlReadState_Error = 2,
        XmlReadState_EndOfFile = 3,
        XmlReadState_Closed = 4,
    }
}
