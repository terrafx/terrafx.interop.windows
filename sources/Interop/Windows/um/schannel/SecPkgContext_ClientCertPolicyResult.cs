// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct SecPkgContext_ClientCertPolicyResult
    {
        [NativeTypeName("HRESULT")]
        public int dwPolicyResult;

        [NativeTypeName("GUID")]
        public Guid guidPolicyId;
    }
}
