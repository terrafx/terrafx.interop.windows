// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B22754E2-4574-11D1-9888-006097DEACF9")]
    [NativeTypeName("struct IADesktopP2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IADesktopP2 : IADesktopP2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IADesktopP2*, Guid*, void**, int>)(lpVtbl[0]))((IADesktopP2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IADesktopP2*, uint>)(lpVtbl[1]))((IADesktopP2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IADesktopP2*, uint>)(lpVtbl[2]))((IADesktopP2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ReReadWallpaper()
        {
            return ((delegate* unmanaged<IADesktopP2*, int>)(lpVtbl[3]))((IADesktopP2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetADObjectFlags([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD")] uint dwMask)
        {
            return ((delegate* unmanaged<IADesktopP2*, uint*, uint, int>)(lpVtbl[4]))((IADesktopP2*)Unsafe.AsPointer(ref this), pdwFlags, dwMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT UpdateAllDesktopSubscriptions()
        {
            return ((delegate* unmanaged<IADesktopP2*, int>)(lpVtbl[5]))((IADesktopP2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT MakeDynamicChanges(IOleObject* pOleObj)
        {
            return ((delegate* unmanaged<IADesktopP2*, IOleObject*, int>)(lpVtbl[6]))((IADesktopP2*)Unsafe.AsPointer(ref this), pOleObj);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT ReReadWallpaper();

            [VtblIndex(4)]
            HRESULT GetADObjectFlags([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD")] uint dwMask);

            [VtblIndex(5)]
            HRESULT UpdateAllDesktopSubscriptions();

            [VtblIndex(6)]
            HRESULT MakeDynamicChanges(IOleObject* pOleObj);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IADesktopP2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IADesktopP2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IADesktopP2*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IADesktopP2*, int> ReReadWallpaper;

            [NativeTypeName("HRESULT (DWORD *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IADesktopP2*, uint*, uint, int> GetADObjectFlags;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IADesktopP2*, int> UpdateAllDesktopSubscriptions;

            [NativeTypeName("HRESULT (IOleObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IADesktopP2*, IOleObject*, int> MakeDynamicChanges;
        }
    }
}
