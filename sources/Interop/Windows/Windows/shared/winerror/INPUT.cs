// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct INPUT
{
    /// <include file='INPUT.xml' path='doc/member[@name="INPUT.INPUT_E_OUT_OF_ORDER"]/*' />
    [NativeTypeName("#define INPUT_E_OUT_OF_ORDER _HRESULT_TYPEDEF_(0x80400000L)")]
    public const int INPUT_E_OUT_OF_ORDER = unchecked((int)(0x80400000));

    /// <include file='INPUT.xml' path='doc/member[@name="INPUT.INPUT_E_REENTRANCY"]/*' />
    [NativeTypeName("#define INPUT_E_REENTRANCY _HRESULT_TYPEDEF_(0x80400001L)")]
    public const int INPUT_E_REENTRANCY = unchecked((int)(0x80400001));

    /// <include file='INPUT.xml' path='doc/member[@name="INPUT.INPUT_E_MULTIMODAL"]/*' />
    [NativeTypeName("#define INPUT_E_MULTIMODAL _HRESULT_TYPEDEF_(0x80400002L)")]
    public const int INPUT_E_MULTIMODAL = unchecked((int)(0x80400002));

    /// <include file='INPUT.xml' path='doc/member[@name="INPUT.INPUT_E_PACKET"]/*' />
    [NativeTypeName("#define INPUT_E_PACKET _HRESULT_TYPEDEF_(0x80400003L)")]
    public const int INPUT_E_PACKET = unchecked((int)(0x80400003));

    /// <include file='INPUT.xml' path='doc/member[@name="INPUT.INPUT_E_FRAME"]/*' />
    [NativeTypeName("#define INPUT_E_FRAME _HRESULT_TYPEDEF_(0x80400004L)")]
    public const int INPUT_E_FRAME = unchecked((int)(0x80400004));

    /// <include file='INPUT.xml' path='doc/member[@name="INPUT.INPUT_E_HISTORY"]/*' />
    [NativeTypeName("#define INPUT_E_HISTORY _HRESULT_TYPEDEF_(0x80400005L)")]
    public const int INPUT_E_HISTORY = unchecked((int)(0x80400005));

    /// <include file='INPUT.xml' path='doc/member[@name="INPUT.INPUT_E_DEVICE_INFO"]/*' />
    [NativeTypeName("#define INPUT_E_DEVICE_INFO _HRESULT_TYPEDEF_(0x80400006L)")]
    public const int INPUT_E_DEVICE_INFO = unchecked((int)(0x80400006));

    /// <include file='INPUT.xml' path='doc/member[@name="INPUT.INPUT_E_TRANSFORM"]/*' />
    [NativeTypeName("#define INPUT_E_TRANSFORM _HRESULT_TYPEDEF_(0x80400007L)")]
    public const int INPUT_E_TRANSFORM = unchecked((int)(0x80400007));

    /// <include file='INPUT.xml' path='doc/member[@name="INPUT.INPUT_E_DEVICE_PROPERTY"]/*' />
    [NativeTypeName("#define INPUT_E_DEVICE_PROPERTY _HRESULT_TYPEDEF_(0x80400008L)")]
    public const int INPUT_E_DEVICE_PROPERTY = unchecked((int)(0x80400008));
}
