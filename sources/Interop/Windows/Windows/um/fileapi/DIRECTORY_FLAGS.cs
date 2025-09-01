// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DIRECTORY_FLAGS.xml' path='doc/member[@name="DIRECTORY_FLAGS"]/*' />
public enum DIRECTORY_FLAGS
{
    /// <include file='DIRECTORY_FLAGS.xml' path='doc/member[@name="DIRECTORY_FLAGS.DIRECTORY_FLAGS_NONE"]/*' />
    DIRECTORY_FLAGS_NONE = 0,

    /// <include file='DIRECTORY_FLAGS.xml' path='doc/member[@name="DIRECTORY_FLAGS.DIRECTORY_FLAGS_DISALLOW_PATH_REDIRECTS"]/*' />
    DIRECTORY_FLAGS_DISALLOW_PATH_REDIRECTS = 0x000000001,
}
