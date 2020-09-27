// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PrintManagerInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C5435A42-8D43-4E7B-A68A-EF311E392087")]
    [NativeTypeName("struct IPrintManagerInterop : IInspectable")]
    public unsafe partial struct IPrintManagerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPrintManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPrintManagerInterop*, uint>)(lpVtbl[1]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPrintManagerInterop*, uint>)(lpVtbl[2]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPrintManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPrintManagerInterop*, IntPtr*, int>)(lpVtbl[4]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPrintManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForWindow([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** printManager)
        {
            return ((delegate* unmanaged<IPrintManagerInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, printManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowPrintUIForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** asyncOperation)
        {
            return ((delegate* unmanaged<IPrintManagerInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[7]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, asyncOperation);
        }
    }
}
