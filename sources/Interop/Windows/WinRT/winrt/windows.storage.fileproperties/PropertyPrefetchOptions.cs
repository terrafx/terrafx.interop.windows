// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PropertyPrefetchOptions.xml' path='doc/member[@name="PropertyPrefetchOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum PropertyPrefetchOptions : uint
{
    /// <include file='PropertyPrefetchOptions.xml' path='doc/member[@name="PropertyPrefetchOptions.PropertyPrefetchOptions_None"]/*' />
    PropertyPrefetchOptions_None = 0,

    /// <include file='PropertyPrefetchOptions.xml' path='doc/member[@name="PropertyPrefetchOptions.PropertyPrefetchOptions_MusicProperties"]/*' />
    PropertyPrefetchOptions_MusicProperties = 0x1,

    /// <include file='PropertyPrefetchOptions.xml' path='doc/member[@name="PropertyPrefetchOptions.PropertyPrefetchOptions_VideoProperties"]/*' />
    PropertyPrefetchOptions_VideoProperties = 0x2,

    /// <include file='PropertyPrefetchOptions.xml' path='doc/member[@name="PropertyPrefetchOptions.PropertyPrefetchOptions_ImageProperties"]/*' />
    PropertyPrefetchOptions_ImageProperties = 0x4,

    /// <include file='PropertyPrefetchOptions.xml' path='doc/member[@name="PropertyPrefetchOptions.PropertyPrefetchOptions_DocumentProperties"]/*' />
    PropertyPrefetchOptions_DocumentProperties = 0x8,

    /// <include file='PropertyPrefetchOptions.xml' path='doc/member[@name="PropertyPrefetchOptions.PropertyPrefetchOptions_BasicProperties"]/*' />
    PropertyPrefetchOptions_BasicProperties = 0x10,
}
