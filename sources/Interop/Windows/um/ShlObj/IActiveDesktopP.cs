// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("52502EE0-EC80-11D0-89AB-00C04FC2972D")]
    [NativeTypeName("struct IActiveDesktopP : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IActiveDesktopP : IActiveDesktopP.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IActiveDesktopP*, Guid*, void**, int>)(lpVtbl[0]))((IActiveDesktopP*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IActiveDesktopP*, uint>)(lpVtbl[1]))((IActiveDesktopP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IActiveDesktopP*, uint>)(lpVtbl[2]))((IActiveDesktopP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetSafeMode([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IActiveDesktopP*, uint, int>)(lpVtbl[3]))((IActiveDesktopP*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EnsureUpdateHTML()
        {
            return ((delegate* unmanaged<IActiveDesktopP*, int>)(lpVtbl[4]))((IActiveDesktopP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetScheme([NativeTypeName("PCWSTR")] ushort* pwszSchemeName, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IActiveDesktopP*, ushort*, uint, int>)(lpVtbl[5]))((IActiveDesktopP*)Unsafe.AsPointer(ref this), pwszSchemeName, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetScheme([NativeTypeName("PWSTR")] ushort* pwszSchemeName, [NativeTypeName("DWORD *")] uint* pdwcchBuffer, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IActiveDesktopP*, ushort*, uint*, uint, int>)(lpVtbl[6]))((IActiveDesktopP*)Unsafe.AsPointer(ref this), pwszSchemeName, pdwcchBuffer, dwFlags);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetSafeMode([NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(4)]
            HRESULT EnsureUpdateHTML();

            [VtblIndex(5)]
            HRESULT SetScheme([NativeTypeName("PCWSTR")] ushort* pwszSchemeName, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(6)]
            HRESULT GetScheme([NativeTypeName("PWSTR")] ushort* pwszSchemeName, [NativeTypeName("DWORD *")] uint* pdwcchBuffer, [NativeTypeName("DWORD")] uint dwFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IActiveDesktopP*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IActiveDesktopP*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IActiveDesktopP*, uint> Release;

            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IActiveDesktopP*, uint, int> SetSafeMode;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IActiveDesktopP*, int> EnsureUpdateHTML;

            [NativeTypeName("HRESULT (PCWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IActiveDesktopP*, ushort*, uint, int> SetScheme;

            [NativeTypeName("HRESULT (PWSTR, DWORD *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IActiveDesktopP*, ushort*, uint*, uint, int> GetScheme;
        }
    }
}
