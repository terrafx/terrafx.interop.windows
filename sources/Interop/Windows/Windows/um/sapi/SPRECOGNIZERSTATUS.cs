// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SPRECOGNIZERSTATUS.xml' path='doc/member[@name="SPRECOGNIZERSTATUS"]/*' />
public partial struct SPRECOGNIZERSTATUS
{
    /// <include file='SPRECOGNIZERSTATUS.xml' path='doc/member[@name="SPRECOGNIZERSTATUS.AudioStatus"]/*' />
    public SPAUDIOSTATUS AudioStatus;

    /// <include file='SPRECOGNIZERSTATUS.xml' path='doc/member[@name="SPRECOGNIZERSTATUS.ullRecognitionStreamPos"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullRecognitionStreamPos;

    /// <include file='SPRECOGNIZERSTATUS.xml' path='doc/member[@name="SPRECOGNIZERSTATUS.ulStreamNumber"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulStreamNumber;

    /// <include file='SPRECOGNIZERSTATUS.xml' path='doc/member[@name="SPRECOGNIZERSTATUS.ulNumActive"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulNumActive;

    /// <include file='SPRECOGNIZERSTATUS.xml' path='doc/member[@name="SPRECOGNIZERSTATUS.clsidEngine"]/*' />
    [NativeTypeName("CLSID")]
    public Guid clsidEngine;

    /// <include file='SPRECOGNIZERSTATUS.xml' path='doc/member[@name="SPRECOGNIZERSTATUS.cLangIDs"]/*' />
    [NativeTypeName("ULONG")]
    public uint cLangIDs;

    /// <include file='SPRECOGNIZERSTATUS.xml' path='doc/member[@name="SPRECOGNIZERSTATUS.aLangID"]/*' />
    [NativeTypeName("WORD[20]")]
    public _aLangID_e__FixedBuffer aLangID;

    /// <include file='SPRECOGNIZERSTATUS.xml' path='doc/member[@name="SPRECOGNIZERSTATUS.ullRecognitionStreamTime"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullRecognitionStreamTime;

    /// <include file='_aLangID_e__FixedBuffer.xml' path='doc/member[@name="_aLangID_e__FixedBuffer"]/*' />
    [InlineArray(20)]
    public partial struct _aLangID_e__FixedBuffer
    {
        public ushort e0;
    }
}
