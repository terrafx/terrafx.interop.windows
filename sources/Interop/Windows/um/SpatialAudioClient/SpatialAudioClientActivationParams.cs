// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct SpatialAudioClientActivationParams
    {
        [NativeTypeName("GUID")]
        public Guid tracingContextId;

        [NativeTypeName("GUID")]
        public Guid appId;

        public int majorVersion;

        public int minorVersion1;

        public int minorVersion2;

        public int minorVersion3;
    }
}
