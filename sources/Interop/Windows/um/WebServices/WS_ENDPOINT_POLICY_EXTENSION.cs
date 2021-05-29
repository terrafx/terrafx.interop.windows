// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_ENDPOINT_POLICY_EXTENSION
    {
        public WS_POLICY_EXTENSION policyExtension;

        public WS_XML_STRING* assertionName;

        public WS_XML_STRING* assertionNs;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WebServices.h:6349:5)")]
        public _out_e__Struct @out;

        public partial struct _out_e__Struct
        {
            [NativeTypeName("WS_XML_BUFFER *")]
            public IntPtr assertionValue;
        }
    }
}
