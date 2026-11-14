// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIDBAM
{
    /// <include file='DIDBAM.xml' path='doc/member[@name="DIDBAM.DIDBAM_DEFAULT"]/*' />
    [NativeTypeName("#define DIDBAM_DEFAULT 0x00000000")]
    public const int DIDBAM_DEFAULT = 0x00000000;

    /// <include file='DIDBAM.xml' path='doc/member[@name="DIDBAM.DIDBAM_PRESERVE"]/*' />
    [NativeTypeName("#define DIDBAM_PRESERVE 0x00000001")]
    public const int DIDBAM_PRESERVE = 0x00000001;

    /// <include file='DIDBAM.xml' path='doc/member[@name="DIDBAM.DIDBAM_INITIALIZE"]/*' />
    [NativeTypeName("#define DIDBAM_INITIALIZE 0x00000002")]
    public const int DIDBAM_INITIALIZE = 0x00000002;

    /// <include file='DIDBAM.xml' path='doc/member[@name="DIDBAM.DIDBAM_HWDEFAULTS"]/*' />
    [NativeTypeName("#define DIDBAM_HWDEFAULTS 0x00000004")]
    public const int DIDBAM_HWDEFAULTS = 0x00000004;
}
