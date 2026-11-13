// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDDEInitializer.xml' path='doc/member[@name="IDDEInitializer"]/*' />
[Guid("30DC931F-33FC-4FFD-A168-942258CF3CA4")]
[NativeTypeName("struct IDDEInitializer : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IDDEInitializer : IDDEInitializer.Interface, INativeGuid
{
    /// <include file='IDDEInitializer.xml' path='doc/member[@name="IDDEInitializer.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDDEInitializer);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDDEInitializer*, Guid*, void**, int>)(lpVtbl[0]))((IDDEInitializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDDEInitializer*, uint>)(lpVtbl[1]))((IDDEInitializer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDDEInitializer*, uint>)(lpVtbl[2]))((IDDEInitializer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDDEInitializer.xml' path='doc/member[@name="IDDEInitializer.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize([NativeTypeName("LPCWSTR")] char* fileExtensionOrProtocol, CreateProcessMethod method, [NativeTypeName("LPCWSTR")] char* currentDirectory, IShellItem* execTarget, IUnknown* site, [NativeTypeName("LPCWSTR")] char* application, [NativeTypeName("LPCWSTR")] char* targetFile, [NativeTypeName("LPCWSTR")] char* arguments, [NativeTypeName("LPCWSTR")] char* verb)
    {
        return ((delegate* unmanaged[MemberFunction]<IDDEInitializer*, char*, CreateProcessMethod, char*, IShellItem*, IUnknown*, char*, char*, char*, char*, int>)(lpVtbl[3]))((IDDEInitializer*)Unsafe.AsPointer(ref this), fileExtensionOrProtocol, method, currentDirectory, execTarget, site, application, targetFile, arguments, verb);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize([NativeTypeName("LPCWSTR")] char* fileExtensionOrProtocol, CreateProcessMethod method, [NativeTypeName("LPCWSTR")] char* currentDirectory, IShellItem* execTarget, IUnknown* site, [NativeTypeName("LPCWSTR")] char* application, [NativeTypeName("LPCWSTR")] char* targetFile, [NativeTypeName("LPCWSTR")] char* arguments, [NativeTypeName("LPCWSTR")] char* verb);
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

        [NativeTypeName("HRESULT (LPCWSTR, CreateProcessMethod, LPCWSTR, IShellItem *, IUnknown *, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, CreateProcessMethod, char*, IShellItem*, IUnknown*, char*, char*, char*, char*, int> Initialize;
    }
}
