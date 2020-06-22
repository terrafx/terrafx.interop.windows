// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_MEDIAKEYSESSION_MESSAGETYPE
    {
        MF_MEDIAKEYSESSION_MESSAGETYPE_LICENSE_REQUEST = 0,
        MF_MEDIAKEYSESSION_MESSAGETYPE_LICENSE_RENEWAL = 1,
        MF_MEDIAKEYSESSION_MESSAGETYPE_LICENSE_RELEASE = 2,
        MF_MEDIAKEYSESSION_MESSAGETYPE_INDIVIDUALIZATION_REQUEST = 3,
    }
}
