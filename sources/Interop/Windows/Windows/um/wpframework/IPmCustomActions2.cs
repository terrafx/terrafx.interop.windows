// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IPmCustomActions2.xml' path='doc/member[@name="IPmCustomActions2"]/*' />
[NativeTypeName("struct IPmCustomActions2 : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IPmCustomActions2 : IPmCustomActions2.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPmCustomActions2*, uint>)(lpVtbl[0]))((IPmCustomActions2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPmCustomActions2*, uint>)(lpVtbl[1]))((IPmCustomActions2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPmCustomActions2.xml' path='doc/member[@name="IPmCustomActions2.RegisterCustomActionCallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT RegisterCustomActionCallback([NativeTypeName("PCWSTR")] char* pszFunctionName, [NativeTypeName("PCWSTR")] char* pszFunctionArgs, ICustomAction2ResultCallback* pCompletionCallbackClass)
    {
        return ((delegate* unmanaged[MemberFunction]<IPmCustomActions2*, char*, char*, ICustomAction2ResultCallback*, int>)(lpVtbl[2]))((IPmCustomActions2*)Unsafe.AsPointer(ref this), pszFunctionName, pszFunctionArgs, pCompletionCallbackClass);
    }

    /// <include file='IPmCustomActions2.xml' path='doc/member[@name="IPmCustomActions2.UnregisterCustomActionCallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UnregisterCustomActionCallback([NativeTypeName("PCWSTR")] char* pszFunctionName)
    {
        return ((delegate* unmanaged[MemberFunction]<IPmCustomActions2*, char*, int>)(lpVtbl[3]))((IPmCustomActions2*)Unsafe.AsPointer(ref this), pszFunctionName);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT RegisterCustomActionCallback([NativeTypeName("PCWSTR")] char* pszFunctionName, [NativeTypeName("PCWSTR")] char* pszFunctionArgs, ICustomAction2ResultCallback* pCompletionCallbackClass);

        [VtblIndex(3)]
        HRESULT UnregisterCustomActionCallback([NativeTypeName("PCWSTR")] char* pszFunctionName);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, ICustomAction2ResultCallback *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, ICustomAction2ResultCallback*, int> RegisterCustomActionCallback;

        [NativeTypeName("HRESULT (PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> UnregisterCustomActionCallback;
    }
}
