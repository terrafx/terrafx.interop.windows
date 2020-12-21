// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDrawClipper : IUnknown")]
    public unsafe partial struct IDirectDrawClipper
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawClipper*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawClipper*, uint>)(lpVtbl[1]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawClipper*, uint>)(lpVtbl[2]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipList([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPRGNDATA")] RGNDATA* param1, [NativeTypeName("LPDWORD")] uint* param2)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawClipper*, RECT*, RGNDATA*, uint*, int>)(lpVtbl[3]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHWnd([NativeTypeName("HWND *")] IntPtr* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawClipper*, IntPtr*, int>)(lpVtbl[4]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawClipper*, IDirectDraw*, uint, int>)(lpVtbl[5]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsClipListChanged([NativeTypeName("BOOL *")] int* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawClipper*, int*, int>)(lpVtbl[6]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClipList([NativeTypeName("LPRGNDATA")] RGNDATA* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawClipper*, RGNDATA*, uint, int>)(lpVtbl[7]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHWnd([NativeTypeName("DWORD")] uint param0, [NativeTypeName("HWND")] IntPtr param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawClipper*, uint, IntPtr, int>)(lpVtbl[8]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0, param1);
        }
    }
}
