// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WiaTransferParams.xml' path='doc/member[@name="WiaTransferParams"]/*' />
public partial struct WiaTransferParams
{
    /// <include file='WiaTransferParams.xml' path='doc/member[@name="WiaTransferParams.lMessage"]/*' />
    [NativeTypeName("LONG")]
    public int lMessage;

    /// <include file='WiaTransferParams.xml' path='doc/member[@name="WiaTransferParams.lPercentComplete"]/*' />
    [NativeTypeName("LONG")]
    public int lPercentComplete;

    /// <include file='WiaTransferParams.xml' path='doc/member[@name="WiaTransferParams.ulTransferredBytes"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ulTransferredBytes;

    /// <include file='WiaTransferParams.xml' path='doc/member[@name="WiaTransferParams.hrErrorStatus"]/*' />
    public HRESULT hrErrorStatus;
}
