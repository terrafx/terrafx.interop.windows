// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WS_SSL_TRANSPORT_SECURITY_BINDING_CONSTRAINT
    {
        public WS_SECURITY_BINDING_CONSTRAINT bindingConstraint;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WebServices.h:6172:5)")]
        public _out_e__Struct @out;

        public partial struct _out_e__Struct
        {
            public BOOL clientCertCredentialRequired;
        }
    }
}
