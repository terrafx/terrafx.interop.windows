// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_RECURRENT_NETWORK_DIRECTION.xml' path='doc/member[@name="DML_RECURRENT_NETWORK_DIRECTION"]/*' />
public enum DML_RECURRENT_NETWORK_DIRECTION
{
    /// <include file='DML_RECURRENT_NETWORK_DIRECTION.xml' path='doc/member[@name="DML_RECURRENT_NETWORK_DIRECTION.DML_RECURRENT_NETWORK_DIRECTION_FORWARD"]/*' />
    DML_RECURRENT_NETWORK_DIRECTION_FORWARD,

    /// <include file='DML_RECURRENT_NETWORK_DIRECTION.xml' path='doc/member[@name="DML_RECURRENT_NETWORK_DIRECTION.DML_RECURRENT_NETWORK_DIRECTION_BACKWARD"]/*' />
    DML_RECURRENT_NETWORK_DIRECTION_BACKWARD,

    /// <include file='DML_RECURRENT_NETWORK_DIRECTION.xml' path='doc/member[@name="DML_RECURRENT_NETWORK_DIRECTION.DML_RECURRENT_NETWORK_DIRECTION_BIDIRECTIONAL"]/*' />
    DML_RECURRENT_NETWORK_DIRECTION_BIDIRECTIONAL,
}
