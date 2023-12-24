// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='INewShortcutHookW.xml' path='doc/member[@name="INewShortcutHookW"]/*' />
[Guid("000214F7-0000-0000-C000-000000000046")]
[NativeTypeName("struct INewShortcutHookW : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INewShortcutHookW : INewShortcutHookW.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INewShortcutHookW));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INewShortcutHookW*, Guid*, void**, int>)(lpVtbl[0]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INewShortcutHookW*, uint>)(lpVtbl[1]))((INewShortcutHookW*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INewShortcutHookW*, uint>)(lpVtbl[2]))((INewShortcutHookW*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INewShortcutHookW.xml' path='doc/member[@name="INewShortcutHookW.SetReferent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetReferent([NativeTypeName("PCWSTR")] char* pcszReferent, HWND hwnd)
    {
        return ((delegate* unmanaged[MemberFunction]<INewShortcutHookW*, char*, HWND, int>)(lpVtbl[3]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pcszReferent, hwnd);
    }

    /// <include file='INewShortcutHookW.xml' path='doc/member[@name="INewShortcutHookW.GetReferent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetReferent([NativeTypeName("PWSTR")] char* pszReferent, int cchReferent)
    {
        return ((delegate* unmanaged[MemberFunction]<INewShortcutHookW*, char*, int, int>)(lpVtbl[4]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pszReferent, cchReferent);
    }

    /// <include file='INewShortcutHookW.xml' path='doc/member[@name="INewShortcutHookW.SetFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFolder([NativeTypeName("PCWSTR")] char* pcszFolder)
    {
        return ((delegate* unmanaged[MemberFunction]<INewShortcutHookW*, char*, int>)(lpVtbl[5]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pcszFolder);
    }

    /// <include file='INewShortcutHookW.xml' path='doc/member[@name="INewShortcutHookW.GetFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFolder([NativeTypeName("PWSTR")] char* pszFolder, int cchFolder)
    {
        return ((delegate* unmanaged[MemberFunction]<INewShortcutHookW*, char*, int, int>)(lpVtbl[6]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pszFolder, cchFolder);
    }

    /// <include file='INewShortcutHookW.xml' path='doc/member[@name="INewShortcutHookW.GetName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetName([NativeTypeName("PWSTR")] char* pszName, int cchName)
    {
        return ((delegate* unmanaged[MemberFunction]<INewShortcutHookW*, char*, int, int>)(lpVtbl[7]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pszName, cchName);
    }

    /// <include file='INewShortcutHookW.xml' path='doc/member[@name="INewShortcutHookW.GetExtension"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetExtension([NativeTypeName("PWSTR")] char* pszExtension, int cchExtension)
    {
        return ((delegate* unmanaged[MemberFunction]<INewShortcutHookW*, char*, int, int>)(lpVtbl[8]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pszExtension, cchExtension);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetReferent([NativeTypeName("PCWSTR")] char* pcszReferent, HWND hwnd);

        [VtblIndex(4)]
        HRESULT GetReferent([NativeTypeName("PWSTR")] char* pszReferent, int cchReferent);

        [VtblIndex(5)]
        HRESULT SetFolder([NativeTypeName("PCWSTR")] char* pcszFolder);

        [VtblIndex(6)]
        HRESULT GetFolder([NativeTypeName("PWSTR")] char* pszFolder, int cchFolder);

        [VtblIndex(7)]
        HRESULT GetName([NativeTypeName("PWSTR")] char* pszName, int cchName);

        [VtblIndex(8)]
        HRESULT GetExtension([NativeTypeName("PWSTR")] char* pszExtension, int cchExtension);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PCWSTR, HWND) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, HWND, int> SetReferent;

        [NativeTypeName("HRESULT (PWSTR, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int, int> GetReferent;

        [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetFolder;

        [NativeTypeName("HRESULT (PWSTR, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int, int> GetFolder;

        [NativeTypeName("HRESULT (PWSTR, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int, int> GetName;

        [NativeTypeName("HRESULT (PWSTR, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int, int> GetExtension;
    }
}
