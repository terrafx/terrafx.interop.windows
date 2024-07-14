// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WINTRUST_DETACHED_SIG_INFO.xml' path='doc/member[@name="WINTRUST_DETACHED_SIG_INFO"]/*' />
public unsafe partial struct WINTRUST_DETACHED_SIG_INFO
{
    /// <include file='WINTRUST_DETACHED_SIG_INFO.xml' path='doc/member[@name="WINTRUST_DETACHED_SIG_INFO.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='WINTRUST_DETACHED_SIG_INFO.xml' path='doc/member[@name="WINTRUST_DETACHED_SIG_INFO.dwUnionChoice"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwUnionChoice;

    /// <include file='WINTRUST_DETACHED_SIG_INFO.xml' path='doc/member[@name="WINTRUST_DETACHED_SIG_INFO.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_WinTrust_L268_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pDetachedSigHandles"]/*' />
    [UnscopedRef]
    public ref WINTRUST_DETACHED_SIG_FILE_HANDLES* pDetachedSigHandles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pDetachedSigHandles;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pDetachedSigBlobs"]/*' />
    [UnscopedRef]
    public ref WINTRUST_DETACHED_SIG_BLOBS* pDetachedSigBlobs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pDetachedSigBlobs;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pDetachedSigHandles"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_DETACHED_SIG_HANDLES_ *")]
        public WINTRUST_DETACHED_SIG_FILE_HANDLES* pDetachedSigHandles;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pDetachedSigBlobs"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_DETACHED_SIG_BLOBS_ *")]
        public WINTRUST_DETACHED_SIG_BLOBS* pDetachedSigBlobs;
    }
}
