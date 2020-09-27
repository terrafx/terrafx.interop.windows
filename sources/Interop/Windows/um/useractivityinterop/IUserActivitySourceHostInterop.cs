// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/useractivityinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C15DF8BC-8844-487A-B85B-7578E0F61419")]
    [NativeTypeName("struct IUserActivitySourceHostInterop : IInspectable")]
    public unsafe partial struct IUserActivitySourceHostInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUserActivitySourceHostInterop*, Guid*, void**, int>)(lpVtbl[0]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserActivitySourceHostInterop*, uint>)(lpVtbl[1]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserActivitySourceHostInterop*, uint>)(lpVtbl[2]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserActivitySourceHostInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUserActivitySourceHostInterop*, IntPtr*, int>)(lpVtbl[4]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserActivitySourceHostInterop*, TrustLevel*, int>)(lpVtbl[5]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetActivitySourceHost([NativeTypeName("HSTRING")] IntPtr activitySourceHost)
        {
            return ((delegate* unmanaged<IUserActivitySourceHostInterop*, IntPtr, int>)(lpVtbl[6]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this), activitySourceHost);
        }
    }
}
