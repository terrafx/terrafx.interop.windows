// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7F9185B0-CB92-43C5-80A9-92277A4F7B54")]
    [NativeTypeName("struct IExecuteCommand : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IExecuteCommand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExecuteCommand*, Guid*, void**, int>)(lpVtbl[0]))((IExecuteCommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExecuteCommand*, uint>)(lpVtbl[1]))((IExecuteCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExecuteCommand*, uint>)(lpVtbl[2]))((IExecuteCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetKeyState([NativeTypeName("DWORD")] uint grfKeyState)
        {
            return ((delegate* unmanaged<IExecuteCommand*, uint, int>)(lpVtbl[3]))((IExecuteCommand*)Unsafe.AsPointer(ref this), grfKeyState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetParameters([NativeTypeName("LPCWSTR")] ushort* pszParameters)
        {
            return ((delegate* unmanaged<IExecuteCommand*, ushort*, int>)(lpVtbl[4]))((IExecuteCommand*)Unsafe.AsPointer(ref this), pszParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPosition(POINT pt)
        {
            return ((delegate* unmanaged<IExecuteCommand*, POINT, int>)(lpVtbl[5]))((IExecuteCommand*)Unsafe.AsPointer(ref this), pt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetShowWindow(int nShow)
        {
            return ((delegate* unmanaged<IExecuteCommand*, int, int>)(lpVtbl[6]))((IExecuteCommand*)Unsafe.AsPointer(ref this), nShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetNoShowUI([NativeTypeName("BOOL")] int fNoShowUI)
        {
            return ((delegate* unmanaged<IExecuteCommand*, int, int>)(lpVtbl[7]))((IExecuteCommand*)Unsafe.AsPointer(ref this), fNoShowUI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetDirectory([NativeTypeName("LPCWSTR")] ushort* pszDirectory)
        {
            return ((delegate* unmanaged<IExecuteCommand*, ushort*, int>)(lpVtbl[8]))((IExecuteCommand*)Unsafe.AsPointer(ref this), pszDirectory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Execute()
        {
            return ((delegate* unmanaged<IExecuteCommand*, int>)(lpVtbl[9]))((IExecuteCommand*)Unsafe.AsPointer(ref this));
        }
    }
}
