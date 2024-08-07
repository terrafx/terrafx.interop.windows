// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_CONTRACT_DESCRIPTION.xml' path='doc/member[@name="WS_CONTRACT_DESCRIPTION"]/*' />
public unsafe partial struct WS_CONTRACT_DESCRIPTION
{
    /// <include file='WS_CONTRACT_DESCRIPTION.xml' path='doc/member[@name="WS_CONTRACT_DESCRIPTION.operationCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint operationCount;

    /// <include file='WS_CONTRACT_DESCRIPTION.xml' path='doc/member[@name="WS_CONTRACT_DESCRIPTION.operations"]/*' />
    public WS_OPERATION_DESCRIPTION** operations;
}
