// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.DirectX;

[Guid("7D9ACA56-CB68-4807-B632-B137352E8596")]
public unsafe partial struct FXReverb : INativeGuid
{
    /// <include file='FXReverb.xml' path='doc/member[@name="FXReverb.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in CLSID_FXReverb);

    /// <include file='FXReverb.xml' path='doc/member[@name="FXReverb.FXREVERB_MIN_DIFFUSION"]/*' />
    [NativeTypeName("#define FXREVERB_MIN_DIFFUSION 0.0f")]
    public const float FXREVERB_MIN_DIFFUSION = 0.0f;

    /// <include file='FXReverb.xml' path='doc/member[@name="FXReverb.FXREVERB_MAX_DIFFUSION"]/*' />
    [NativeTypeName("#define FXREVERB_MAX_DIFFUSION 1.0f")]
    public const float FXREVERB_MAX_DIFFUSION = 1.0f;

    /// <include file='FXReverb.xml' path='doc/member[@name="FXReverb.FXREVERB_DEFAULT_DIFFUSION"]/*' />
    [NativeTypeName("#define FXREVERB_DEFAULT_DIFFUSION 0.9f")]
    public const float FXREVERB_DEFAULT_DIFFUSION = 0.9f;

    /// <include file='FXReverb.xml' path='doc/member[@name="FXReverb.FXREVERB_MIN_ROOMSIZE"]/*' />
    [NativeTypeName("#define FXREVERB_MIN_ROOMSIZE 0.0001f")]
    public const float FXREVERB_MIN_ROOMSIZE = 0.0001f;

    /// <include file='FXReverb.xml' path='doc/member[@name="FXReverb.FXREVERB_MAX_ROOMSIZE"]/*' />
    [NativeTypeName("#define FXREVERB_MAX_ROOMSIZE 1.0f")]
    public const float FXREVERB_MAX_ROOMSIZE = 1.0f;

    /// <include file='FXReverb.xml' path='doc/member[@name="FXReverb.FXREVERB_DEFAULT_ROOMSIZE"]/*' />
    [NativeTypeName("#define FXREVERB_DEFAULT_ROOMSIZE 0.6f")]
    public const float FXREVERB_DEFAULT_ROOMSIZE = 0.6f;
}
