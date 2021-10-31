// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Print3DManagerInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9CA31010-1484-4587-B26B-DDDF9F9CAECD")]
    [NativeTypeName("struct IPrinting3DManagerInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IPrinting3DManagerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPrinting3DManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPrinting3DManagerInterop*, uint>)(lpVtbl[1]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPrinting3DManagerInterop*, uint>)(lpVtbl[2]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPrinting3DManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPrinting3DManagerInterop*, IntPtr*, int>)(lpVtbl[4]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPrinting3DManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetForWindow([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, void** printManager)
        {
            return ((delegate* unmanaged<IPrinting3DManagerInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, printManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ShowPrintUIForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IPrinting3DManagerInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[7]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, asyncOperation);
        }
    }
}
