// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WS_NETPIPE_URL
    {
        public WS_URL url;

        public WS_STRING host;

        [NativeTypeName("USHORT")]
        public ushort port;

        public WS_STRING portAsString;

        public WS_STRING path;

        public WS_STRING query;

        public WS_STRING fragment;
    }
}
