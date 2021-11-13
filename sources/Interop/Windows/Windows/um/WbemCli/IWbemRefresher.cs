// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("49353C99-516B-11D1-AEA6-00C04FB68820")]
    [NativeTypeName("struct IWbemRefresher : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWbemRefresher : IWbemRefresher.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemRefresher*, Guid*, void**, int>)(lpVtbl[0]))((IWbemRefresher*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemRefresher*, uint>)(lpVtbl[1]))((IWbemRefresher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemRefresher*, uint>)(lpVtbl[2]))((IWbemRefresher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Refresh([NativeTypeName("long")] int lFlags)
        {
            return ((delegate* unmanaged<IWbemRefresher*, int, int>)(lpVtbl[3]))((IWbemRefresher*)Unsafe.AsPointer(ref this), lFlags);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Refresh([NativeTypeName("long")] int lFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemRefresher*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemRefresher*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemRefresher*, uint> Release;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemRefresher*, int, int> Refresh;
        }
    }
}
