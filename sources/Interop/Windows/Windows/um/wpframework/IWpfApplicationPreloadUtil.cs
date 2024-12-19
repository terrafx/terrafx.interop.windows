// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IWpfApplicationPreloadUtil.xml' path='doc/member[@name="IWpfApplicationPreloadUtil"]/*' />
[NativeTypeName("struct IWpfApplicationPreloadUtil : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IWpfApplicationPreloadUtil : IWpfApplicationPreloadUtil.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfApplicationPreloadUtil*, uint>)(lpVtbl[0]))((IWpfApplicationPreloadUtil*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfApplicationPreloadUtil*, uint>)(lpVtbl[1]))((IWpfApplicationPreloadUtil*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWpfApplicationPreloadUtil.xml' path='doc/member[@name="IWpfApplicationPreloadUtil.GetApplicationPreloadInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT GetApplicationPreloadInfo([NativeTypeName("PCWSTR")] char* pszConfigPath, BOOL* pfEnabled, [NativeTypeName("BSTR *")] char** pbstrType, SAFEARRAY** psaPreloadValues)
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfApplicationPreloadUtil*, char*, BOOL*, char**, SAFEARRAY**, int>)(lpVtbl[2]))((IWpfApplicationPreloadUtil*)Unsafe.AsPointer(ref this), pszConfigPath, pfEnabled, pbstrType, psaPreloadValues);
    }

    /// <include file='IWpfApplicationPreloadUtil.xml' path='doc/member[@name="IWpfApplicationPreloadUtil.ReportApplicationPreloadFailure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReportApplicationPreloadFailure([NativeTypeName("PCWSTR")] char* pszConfigPath, HRESULT hrFailureCode, [NativeTypeName("PCWSTR")] char* pszErrorString)
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfApplicationPreloadUtil*, char*, HRESULT, char*, int>)(lpVtbl[3]))((IWpfApplicationPreloadUtil*)Unsafe.AsPointer(ref this), pszConfigPath, hrFailureCode, pszErrorString);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT GetApplicationPreloadInfo([NativeTypeName("PCWSTR")] char* pszConfigPath, BOOL* pfEnabled, [NativeTypeName("BSTR *")] char** pbstrType, SAFEARRAY** psaPreloadValues);

        [VtblIndex(3)]
        HRESULT ReportApplicationPreloadFailure([NativeTypeName("PCWSTR")] char* pszConfigPath, HRESULT hrFailureCode, [NativeTypeName("PCWSTR")] char* pszErrorString);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PCWSTR, BOOL *, BSTR *, SAFEARRAY **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL*, char**, SAFEARRAY**, int> GetApplicationPreloadInfo;

        [NativeTypeName("HRESULT (PCWSTR, HRESULT, PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, HRESULT, char*, int> ReportApplicationPreloadFailure;
    }
}
