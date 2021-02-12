// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E2CD4A63-2B72-4D48-B739-95E4765195BA")]
    [NativeTypeName("struct IAccStore : IUnknown")]
    public unsafe partial struct IAccStore
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAccStore*, Guid*, void**, int>)(lpVtbl[0]))((IAccStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAccStore*, uint>)(lpVtbl[1]))((IAccStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAccStore*, uint>)(lpVtbl[2]))((IAccStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Register([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return ((delegate* unmanaged<IAccStore*, Guid*, IUnknown*, int>)(lpVtbl[3]))((IAccStore*)Unsafe.AsPointer(ref this), riid, punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unregister([NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return ((delegate* unmanaged<IAccStore*, IUnknown*, int>)(lpVtbl[4]))((IAccStore*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDocuments([NativeTypeName("IEnumUnknown **")] IEnumUnknown** enumUnknown)
        {
            return ((delegate* unmanaged<IAccStore*, IEnumUnknown**, int>)(lpVtbl[5]))((IAccStore*)Unsafe.AsPointer(ref this), enumUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LookupByHWND([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown **")] IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IAccStore*, IntPtr, Guid*, IUnknown**, int>)(lpVtbl[6]))((IAccStore*)Unsafe.AsPointer(ref this), hWnd, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LookupByPoint(POINT pt, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown **")] IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IAccStore*, POINT, Guid*, IUnknown**, int>)(lpVtbl[7]))((IAccStore*)Unsafe.AsPointer(ref this), pt, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDocumentFocus([NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return ((delegate* unmanaged<IAccStore*, IUnknown*, int>)(lpVtbl[8]))((IAccStore*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFocused([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown **")] IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IAccStore*, Guid*, IUnknown**, int>)(lpVtbl[9]))((IAccStore*)Unsafe.AsPointer(ref this), riid, ppunk);
        }
    }
}
