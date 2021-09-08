// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8D715A0-6E5E-11D0-B3F0-00AA003761C5")]
    [NativeTypeName("struct IAMVfwCaptureDialogs : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMVfwCaptureDialogs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMVfwCaptureDialogs*, Guid*, void**, int>)(lpVtbl[0]))((IAMVfwCaptureDialogs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMVfwCaptureDialogs*, uint>)(lpVtbl[1]))((IAMVfwCaptureDialogs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMVfwCaptureDialogs*, uint>)(lpVtbl[2]))((IAMVfwCaptureDialogs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int HasDialog(int iDialog)
        {
            return ((delegate* unmanaged<IAMVfwCaptureDialogs*, int, int>)(lpVtbl[3]))((IAMVfwCaptureDialogs*)Unsafe.AsPointer(ref this), iDialog);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ShowDialog(int iDialog, [NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<IAMVfwCaptureDialogs*, int, IntPtr, int>)(lpVtbl[4]))((IAMVfwCaptureDialogs*)Unsafe.AsPointer(ref this), iDialog, hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SendDriverMessage(int iDialog, int uMsg, [NativeTypeName("long")] int dw1, [NativeTypeName("long")] int dw2)
        {
            return ((delegate* unmanaged<IAMVfwCaptureDialogs*, int, int, int, int, int>)(lpVtbl[5]))((IAMVfwCaptureDialogs*)Unsafe.AsPointer(ref this), iDialog, uMsg, dw1, dw2);
        }
    }
}
