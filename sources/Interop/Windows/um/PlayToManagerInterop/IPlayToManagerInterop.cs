// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PlayToManagerInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("24394699-1F2C-4EB3-8CD7-0EC1DA42A540")]
    [NativeTypeName("struct IPlayToManagerInterop : IInspectable")]
    public unsafe partial struct IPlayToManagerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPlayToManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IPlayToManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPlayToManagerInterop*, uint>)(lpVtbl[1]))((IPlayToManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPlayToManagerInterop*, uint>)(lpVtbl[2]))((IPlayToManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPlayToManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IPlayToManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPlayToManagerInterop*, IntPtr*, int>)(lpVtbl[4]))((IPlayToManagerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPlayToManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IPlayToManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForWindow([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, void** playToManager)
        {
            return ((delegate* unmanaged<IPlayToManagerInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((IPlayToManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, playToManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowPlayToUIForWindow([NativeTypeName("HWND")] IntPtr appWindow)
        {
            return ((delegate* unmanaged<IPlayToManagerInterop*, IntPtr, int>)(lpVtbl[7]))((IPlayToManagerInterop*)Unsafe.AsPointer(ref this), appWindow);
        }
    }
}
