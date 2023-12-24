// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SFVM_HELPTOPIC_DATA.xml' path='doc/member[@name="SFVM_HELPTOPIC_DATA"]/*' />
public partial struct SFVM_HELPTOPIC_DATA
{
    /// <include file='SFVM_HELPTOPIC_DATA.xml' path='doc/member[@name="SFVM_HELPTOPIC_DATA.wszHelpFile"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _wszHelpFile_e__FixedBuffer wszHelpFile;

    /// <include file='SFVM_HELPTOPIC_DATA.xml' path='doc/member[@name="SFVM_HELPTOPIC_DATA.wszHelpTopic"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _wszHelpTopic_e__FixedBuffer wszHelpTopic;

    /// <include file='_wszHelpFile_e__FixedBuffer.xml' path='doc/member[@name="_wszHelpFile_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _wszHelpFile_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_wszHelpTopic_e__FixedBuffer.xml' path='doc/member[@name="_wszHelpTopic_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _wszHelpTopic_e__FixedBuffer
    {
        public char e0;
    }
}
