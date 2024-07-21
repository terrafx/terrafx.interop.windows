// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CompositionBitmapInterpolationMode.xml' path='doc/member[@name="CompositionBitmapInterpolationMode"]/*' />
public enum CompositionBitmapInterpolationMode
{
    /// <include file='CompositionBitmapInterpolationMode.xml' path='doc/member[@name="CompositionBitmapInterpolationMode.CompositionBitmapInterpolationMode_NearestNeighbor"]/*' />
    CompositionBitmapInterpolationMode_NearestNeighbor = 0,

    /// <include file='CompositionBitmapInterpolationMode.xml' path='doc/member[@name="CompositionBitmapInterpolationMode.CompositionBitmapInterpolationMode_Linear"]/*' />
    CompositionBitmapInterpolationMode_Linear = 1,

    /// <include file='CompositionBitmapInterpolationMode.xml' path='doc/member[@name="CompositionBitmapInterpolationMode.CompositionBitmapInterpolationMode_MagLinearMinLinearMipLinear"]/*' />
    CompositionBitmapInterpolationMode_MagLinearMinLinearMipLinear = 2,

    /// <include file='CompositionBitmapInterpolationMode.xml' path='doc/member[@name="CompositionBitmapInterpolationMode.CompositionBitmapInterpolationMode_MagLinearMinLinearMipNearest"]/*' />
    CompositionBitmapInterpolationMode_MagLinearMinLinearMipNearest = 3,

    /// <include file='CompositionBitmapInterpolationMode.xml' path='doc/member[@name="CompositionBitmapInterpolationMode.CompositionBitmapInterpolationMode_MagLinearMinNearestMipLinear"]/*' />
    CompositionBitmapInterpolationMode_MagLinearMinNearestMipLinear = 4,

    /// <include file='CompositionBitmapInterpolationMode.xml' path='doc/member[@name="CompositionBitmapInterpolationMode.CompositionBitmapInterpolationMode_MagLinearMinNearestMipNearest"]/*' />
    CompositionBitmapInterpolationMode_MagLinearMinNearestMipNearest = 5,

    /// <include file='CompositionBitmapInterpolationMode.xml' path='doc/member[@name="CompositionBitmapInterpolationMode.CompositionBitmapInterpolationMode_MagNearestMinLinearMipLinear"]/*' />
    CompositionBitmapInterpolationMode_MagNearestMinLinearMipLinear = 6,

    /// <include file='CompositionBitmapInterpolationMode.xml' path='doc/member[@name="CompositionBitmapInterpolationMode.CompositionBitmapInterpolationMode_MagNearestMinLinearMipNearest"]/*' />
    CompositionBitmapInterpolationMode_MagNearestMinLinearMipNearest = 7,

    /// <include file='CompositionBitmapInterpolationMode.xml' path='doc/member[@name="CompositionBitmapInterpolationMode.CompositionBitmapInterpolationMode_MagNearestMinNearestMipLinear"]/*' />
    CompositionBitmapInterpolationMode_MagNearestMinNearestMipLinear = 8,

    /// <include file='CompositionBitmapInterpolationMode.xml' path='doc/member[@name="CompositionBitmapInterpolationMode.CompositionBitmapInterpolationMode_MagNearestMinNearestMipNearest"]/*' />
    CompositionBitmapInterpolationMode_MagNearestMinNearestMipNearest = 9,
}
