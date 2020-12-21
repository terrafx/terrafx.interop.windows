// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/useractivityinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1ADE314D-0E0A-40D9-824C-9A088A50059F")]
    [NativeTypeName("struct IUserActivityInterop : IInspectable")]
    public unsafe partial struct IUserActivityInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IUserActivityInterop*, Guid*, void**, int>)(lpVtbl[0]))((IUserActivityInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IUserActivityInterop*, uint>)(lpVtbl[1]))((IUserActivityInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IUserActivityInterop*, uint>)(lpVtbl[2]))((IUserActivityInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged[Stdcall]<IUserActivityInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IUserActivityInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged[Stdcall]<IUserActivityInterop*, IntPtr*, int>)(lpVtbl[4]))((IUserActivityInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IUserActivityInterop*, TrustLevel*, int>)(lpVtbl[5]))((IUserActivityInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSessionForWindow([NativeTypeName("HWND")] IntPtr window, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** value)
        {
            return ((delegate* unmanaged[Stdcall]<IUserActivityInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((IUserActivityInterop*)Unsafe.AsPointer(ref this), window, iid, value);
        }
    }
}
