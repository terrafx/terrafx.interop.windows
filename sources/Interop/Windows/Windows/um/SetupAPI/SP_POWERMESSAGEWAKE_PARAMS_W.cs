// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_POWERMESSAGEWAKE_PARAMS_W.xml' path='doc/member[@name="SP_POWERMESSAGEWAKE_PARAMS_W"]/*' />
public partial struct SP_POWERMESSAGEWAKE_PARAMS_W
{
    /// <include file='SP_POWERMESSAGEWAKE_PARAMS_W.xml' path='doc/member[@name="SP_POWERMESSAGEWAKE_PARAMS_W.ClassInstallHeader"]/*' />
    public SP_CLASSINSTALL_HEADER ClassInstallHeader;

    /// <include file='SP_POWERMESSAGEWAKE_PARAMS_W.xml' path='doc/member[@name="SP_POWERMESSAGEWAKE_PARAMS_W.PowerMessageWake"]/*' />
    [NativeTypeName("WCHAR[512]")]
    public _PowerMessageWake_e__FixedBuffer PowerMessageWake;

    /// <include file='_PowerMessageWake_e__FixedBuffer.xml' path='doc/member[@name="_PowerMessageWake_e__FixedBuffer"]/*' />
    [InlineArray(512)]
    public partial struct _PowerMessageWake_e__FixedBuffer
    {
        public char e0;
    }
}
