// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_METADATA_ENDPOINT
    {
        public WS_ENDPOINT_ADDRESS endpointAddress;

        public IntPtr endpointPolicy;

        public WS_XML_STRING* portName;

        public WS_XML_STRING* serviceName;

        public WS_XML_STRING* serviceNs;

        public WS_XML_STRING* bindingName;

        public WS_XML_STRING* bindingNs;

        public WS_XML_STRING* portTypeName;

        public WS_XML_STRING* portTypeNs;
    }
}
