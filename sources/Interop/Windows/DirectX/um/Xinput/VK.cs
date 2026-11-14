// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;

public static partial class VK
{
    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_A"]/*' />
    [NativeTypeName("#define VK_PAD_A 0x5800")]
    public const int VK_PAD_A = 0x5800;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_B"]/*' />
    [NativeTypeName("#define VK_PAD_B 0x5801")]
    public const int VK_PAD_B = 0x5801;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_X"]/*' />
    [NativeTypeName("#define VK_PAD_X 0x5802")]
    public const int VK_PAD_X = 0x5802;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_Y"]/*' />
    [NativeTypeName("#define VK_PAD_Y 0x5803")]
    public const int VK_PAD_Y = 0x5803;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_RSHOULDER"]/*' />
    [NativeTypeName("#define VK_PAD_RSHOULDER 0x5804")]
    public const int VK_PAD_RSHOULDER = 0x5804;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_LSHOULDER"]/*' />
    [NativeTypeName("#define VK_PAD_LSHOULDER 0x5805")]
    public const int VK_PAD_LSHOULDER = 0x5805;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_LTRIGGER"]/*' />
    [NativeTypeName("#define VK_PAD_LTRIGGER 0x5806")]
    public const int VK_PAD_LTRIGGER = 0x5806;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_RTRIGGER"]/*' />
    [NativeTypeName("#define VK_PAD_RTRIGGER 0x5807")]
    public const int VK_PAD_RTRIGGER = 0x5807;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_DPAD_UP"]/*' />
    [NativeTypeName("#define VK_PAD_DPAD_UP 0x5810")]
    public const int VK_PAD_DPAD_UP = 0x5810;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_DPAD_DOWN"]/*' />
    [NativeTypeName("#define VK_PAD_DPAD_DOWN 0x5811")]
    public const int VK_PAD_DPAD_DOWN = 0x5811;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_DPAD_LEFT"]/*' />
    [NativeTypeName("#define VK_PAD_DPAD_LEFT 0x5812")]
    public const int VK_PAD_DPAD_LEFT = 0x5812;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_DPAD_RIGHT"]/*' />
    [NativeTypeName("#define VK_PAD_DPAD_RIGHT 0x5813")]
    public const int VK_PAD_DPAD_RIGHT = 0x5813;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_START"]/*' />
    [NativeTypeName("#define VK_PAD_START 0x5814")]
    public const int VK_PAD_START = 0x5814;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_BACK"]/*' />
    [NativeTypeName("#define VK_PAD_BACK 0x5815")]
    public const int VK_PAD_BACK = 0x5815;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_LTHUMB_PRESS"]/*' />
    [NativeTypeName("#define VK_PAD_LTHUMB_PRESS 0x5816")]
    public const int VK_PAD_LTHUMB_PRESS = 0x5816;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_RTHUMB_PRESS"]/*' />
    [NativeTypeName("#define VK_PAD_RTHUMB_PRESS 0x5817")]
    public const int VK_PAD_RTHUMB_PRESS = 0x5817;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_LTHUMB_UP"]/*' />
    [NativeTypeName("#define VK_PAD_LTHUMB_UP 0x5820")]
    public const int VK_PAD_LTHUMB_UP = 0x5820;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_LTHUMB_DOWN"]/*' />
    [NativeTypeName("#define VK_PAD_LTHUMB_DOWN 0x5821")]
    public const int VK_PAD_LTHUMB_DOWN = 0x5821;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_LTHUMB_RIGHT"]/*' />
    [NativeTypeName("#define VK_PAD_LTHUMB_RIGHT 0x5822")]
    public const int VK_PAD_LTHUMB_RIGHT = 0x5822;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_LTHUMB_LEFT"]/*' />
    [NativeTypeName("#define VK_PAD_LTHUMB_LEFT 0x5823")]
    public const int VK_PAD_LTHUMB_LEFT = 0x5823;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_LTHUMB_UPLEFT"]/*' />
    [NativeTypeName("#define VK_PAD_LTHUMB_UPLEFT 0x5824")]
    public const int VK_PAD_LTHUMB_UPLEFT = 0x5824;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_LTHUMB_UPRIGHT"]/*' />
    [NativeTypeName("#define VK_PAD_LTHUMB_UPRIGHT 0x5825")]
    public const int VK_PAD_LTHUMB_UPRIGHT = 0x5825;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_LTHUMB_DOWNRIGHT"]/*' />
    [NativeTypeName("#define VK_PAD_LTHUMB_DOWNRIGHT 0x5826")]
    public const int VK_PAD_LTHUMB_DOWNRIGHT = 0x5826;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_LTHUMB_DOWNLEFT"]/*' />
    [NativeTypeName("#define VK_PAD_LTHUMB_DOWNLEFT 0x5827")]
    public const int VK_PAD_LTHUMB_DOWNLEFT = 0x5827;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_RTHUMB_UP"]/*' />
    [NativeTypeName("#define VK_PAD_RTHUMB_UP 0x5830")]
    public const int VK_PAD_RTHUMB_UP = 0x5830;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_RTHUMB_DOWN"]/*' />
    [NativeTypeName("#define VK_PAD_RTHUMB_DOWN 0x5831")]
    public const int VK_PAD_RTHUMB_DOWN = 0x5831;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_RTHUMB_RIGHT"]/*' />
    [NativeTypeName("#define VK_PAD_RTHUMB_RIGHT 0x5832")]
    public const int VK_PAD_RTHUMB_RIGHT = 0x5832;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_RTHUMB_LEFT"]/*' />
    [NativeTypeName("#define VK_PAD_RTHUMB_LEFT 0x5833")]
    public const int VK_PAD_RTHUMB_LEFT = 0x5833;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_RTHUMB_UPLEFT"]/*' />
    [NativeTypeName("#define VK_PAD_RTHUMB_UPLEFT 0x5834")]
    public const int VK_PAD_RTHUMB_UPLEFT = 0x5834;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_RTHUMB_UPRIGHT"]/*' />
    [NativeTypeName("#define VK_PAD_RTHUMB_UPRIGHT 0x5835")]
    public const int VK_PAD_RTHUMB_UPRIGHT = 0x5835;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_RTHUMB_DOWNRIGHT"]/*' />
    [NativeTypeName("#define VK_PAD_RTHUMB_DOWNRIGHT 0x5836")]
    public const int VK_PAD_RTHUMB_DOWNRIGHT = 0x5836;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAD_RTHUMB_DOWNLEFT"]/*' />
    [NativeTypeName("#define VK_PAD_RTHUMB_DOWNLEFT 0x5837")]
    public const int VK_PAD_RTHUMB_DOWNLEFT = 0x5837;
}
