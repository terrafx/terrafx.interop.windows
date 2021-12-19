// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0"]/*' />
public partial struct KERB_CLOUD_KERBEROS_DEBUG_DATA_V0
{
    public int _bitfield;

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.EnabledByPolicy"]/*' />
    [NativeTypeName("int : 1")]
    public int EnabledByPolicy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _bitfield & 0x1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x1) | (value & 0x1);
        }
    }

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.AsRepCallbackPresent"]/*' />
    [NativeTypeName("int : 1")]
    public int AsRepCallbackPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 1) & 0x1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 1)) | ((value & 0x1) << 1);
        }
    }

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.AsRepCallbackUsed"]/*' />
    [NativeTypeName("int : 1")]
    public int AsRepCallbackUsed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 2) & 0x1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 2)) | ((value & 0x1) << 2);
        }
    }

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.CloudReferralTgtAvailable"]/*' />
    [NativeTypeName("int : 1")]
    public int CloudReferralTgtAvailable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 3) & 0x1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 3)) | ((value & 0x1) << 3);
        }
    }

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.SpnOracleConfigured"]/*' />
    [NativeTypeName("int : 1")]
    public int SpnOracleConfigured
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 4) & 0x1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 4)) | ((value & 0x1) << 4);
        }
    }

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.KdcProxyPresent"]/*' />
    [NativeTypeName("int : 1")]
    public int KdcProxyPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 5) & 0x1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 5)) | ((value & 0x1) << 5);
        }
    }
}
