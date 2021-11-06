// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("91956D21-9276-11D1-921A-006097DF5BD4")]
    [NativeTypeName("struct ICurrentWorkingDirectory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICurrentWorkingDirectory : ICurrentWorkingDirectory.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICurrentWorkingDirectory*, Guid*, void**, int>)(lpVtbl[0]))((ICurrentWorkingDirectory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICurrentWorkingDirectory*, uint>)(lpVtbl[1]))((ICurrentWorkingDirectory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICurrentWorkingDirectory*, uint>)(lpVtbl[2]))((ICurrentWorkingDirectory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDirectory([NativeTypeName("PWSTR")] ushort* pwzPath, [NativeTypeName("DWORD")] uint cchSize)
        {
            return ((delegate* unmanaged<ICurrentWorkingDirectory*, ushort*, uint, int>)(lpVtbl[3]))((ICurrentWorkingDirectory*)Unsafe.AsPointer(ref this), pwzPath, cchSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetDirectory([NativeTypeName("PCWSTR")] ushort* pwzPath)
        {
            return ((delegate* unmanaged<ICurrentWorkingDirectory*, ushort*, int>)(lpVtbl[4]))((ICurrentWorkingDirectory*)Unsafe.AsPointer(ref this), pwzPath);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetDirectory([NativeTypeName("PWSTR")] ushort* pwzPath, [NativeTypeName("DWORD")] uint cchSize);

            [VtblIndex(4)]
            HRESULT SetDirectory([NativeTypeName("PCWSTR")] ushort* pwzPath);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICurrentWorkingDirectory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICurrentWorkingDirectory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICurrentWorkingDirectory*, uint> Release;

            [NativeTypeName("HRESULT (PWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ICurrentWorkingDirectory*, ushort*, uint, int> GetDirectory;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ICurrentWorkingDirectory*, ushort*, int> SetDirectory;
        }
    }
}
