// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDrawPalette : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectDrawPalette
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectDrawPalette*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectDrawPalette*, uint>)(lpVtbl[1]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectDrawPalette*, uint>)(lpVtbl[2]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCaps([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged<IDirectDrawPalette*, uint*, int>)(lpVtbl[3]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetEntries([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param3)
        {
            return ((delegate* unmanaged<IDirectDrawPalette*, uint, uint, uint, PALETTEENTRY*, int>)(lpVtbl[4]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param2)
        {
            return ((delegate* unmanaged<IDirectDrawPalette*, IDirectDraw*, uint, PALETTEENTRY*, int>)(lpVtbl[5]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetEntries([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param3)
        {
            return ((delegate* unmanaged<IDirectDrawPalette*, uint, uint, uint, PALETTEENTRY*, int>)(lpVtbl[6]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }
    }
}
