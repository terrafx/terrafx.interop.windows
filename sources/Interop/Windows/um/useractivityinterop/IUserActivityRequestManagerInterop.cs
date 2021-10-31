// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/useractivityinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DD69F876-9699-4715-9095-E37EA30DFA1B")]
    [NativeTypeName("struct IUserActivityRequestManagerInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IUserActivityRequestManagerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUserActivityRequestManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IUserActivityRequestManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserActivityRequestManagerInterop*, uint>)(lpVtbl[1]))((IUserActivityRequestManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserActivityRequestManagerInterop*, uint>)(lpVtbl[2]))((IUserActivityRequestManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserActivityRequestManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IUserActivityRequestManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<IUserActivityRequestManagerInterop*, HSTRING*, int>)(lpVtbl[4]))((IUserActivityRequestManagerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserActivityRequestManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IUserActivityRequestManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetForWindow(HWND window, [NativeTypeName("const IID &")] Guid* iid, void** value)
        {
            return ((delegate* unmanaged<IUserActivityRequestManagerInterop*, HWND, Guid*, void**, int>)(lpVtbl[6]))((IUserActivityRequestManagerInterop*)Unsafe.AsPointer(ref this), window, iid, value);
        }
    }
}
