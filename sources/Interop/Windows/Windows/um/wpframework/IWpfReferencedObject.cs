// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IWpfReferencedObject.xml' path='doc/member[@name="IWpfReferencedObject"]/*' />
public unsafe partial struct IWpfReferencedObject : IWpfReferencedObject.Interface
{
    public void** lpVtbl;

    /// <include file='IWpfReferencedObject.xml' path='doc/member[@name="IWpfReferencedObject.AddRef"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfReferencedObject*, uint>)(lpVtbl[0]))((IWpfReferencedObject*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWpfReferencedObject.xml' path='doc/member[@name="IWpfReferencedObject.Release"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfReferencedObject*, uint>)(lpVtbl[1]))((IWpfReferencedObject*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("ULONG")]
        uint AddRef();

        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        uint Release();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;
    }
}
