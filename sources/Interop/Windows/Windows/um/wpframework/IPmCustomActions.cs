// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IPmCustomActions.xml' path='doc/member[@name="IPmCustomActions"]/*' />
[NativeTypeName("struct IPmCustomActions : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IPmCustomActions : IPmCustomActions.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPmCustomActions*, uint>)(lpVtbl[0]))((IPmCustomActions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPmCustomActions*, uint>)(lpVtbl[1]))((IPmCustomActions*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPmCustomActions.xml' path='doc/member[@name="IPmCustomActions.RunCustomAction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT RunCustomAction([NativeTypeName("PCWSTR")] char* pszFunctionName, [NativeTypeName("PCWSTR")] char* pszFunctionArgs, ICustomActionResultCallback* pCompletionCallbackClass)
    {
        return ((delegate* unmanaged[MemberFunction]<IPmCustomActions*, char*, char*, ICustomActionResultCallback*, int>)(lpVtbl[2]))((IPmCustomActions*)Unsafe.AsPointer(ref this), pszFunctionName, pszFunctionArgs, pCompletionCallbackClass);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT RunCustomAction([NativeTypeName("PCWSTR")] char* pszFunctionName, [NativeTypeName("PCWSTR")] char* pszFunctionArgs, ICustomActionResultCallback* pCompletionCallbackClass);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, ICustomActionResultCallback *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, ICustomActionResultCallback*, int> RunCustomAction;
    }
}
