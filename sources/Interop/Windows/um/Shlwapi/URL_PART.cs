// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum URL_PART
    {
        URL_PART_NONE = 0,
        URL_PART_SCHEME = 1,
        URL_PART_HOSTNAME,
        URL_PART_USERNAME,
        URL_PART_PASSWORD,
        URL_PART_PORT,
        URL_PART_QUERY,
    }
}
