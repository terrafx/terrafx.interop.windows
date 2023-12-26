// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmsEncodedLength.xml' path='doc/member[@name="SmsEncodedLength"]/*' />
public partial struct SmsEncodedLength
{
    /// <include file='SmsEncodedLength.xml' path='doc/member[@name="SmsEncodedLength.SegmentCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint SegmentCount;

    /// <include file='SmsEncodedLength.xml' path='doc/member[@name="SmsEncodedLength.CharacterCountLastSegment"]/*' />
    [NativeTypeName("UINT32")]
    public uint CharacterCountLastSegment;

    /// <include file='SmsEncodedLength.xml' path='doc/member[@name="SmsEncodedLength.CharactersPerSegment"]/*' />
    [NativeTypeName("UINT32")]
    public uint CharactersPerSegment;

    /// <include file='SmsEncodedLength.xml' path='doc/member[@name="SmsEncodedLength.ByteCountLastSegment"]/*' />
    [NativeTypeName("UINT32")]
    public uint ByteCountLastSegment;

    /// <include file='SmsEncodedLength.xml' path='doc/member[@name="SmsEncodedLength.BytesPerSegment"]/*' />
    [NativeTypeName("UINT32")]
    public uint BytesPerSegment;
}
