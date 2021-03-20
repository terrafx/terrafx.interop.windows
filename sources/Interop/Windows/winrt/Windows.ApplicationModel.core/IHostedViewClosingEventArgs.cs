// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D238943C-B24E-4790-ACB5-3E4243C4FF87")]
    [NativeTypeName("struct IHostedViewClosingEventArgs : IInspectable")]
    public unsafe partial struct IHostedViewClosingEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IHostedViewClosingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IHostedViewClosingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHostedViewClosingEventArgs*, uint>)(lpVtbl[1]))((IHostedViewClosingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHostedViewClosingEventArgs*, uint>)(lpVtbl[2]))((IHostedViewClosingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IHostedViewClosingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IHostedViewClosingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IHostedViewClosingEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IHostedViewClosingEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IHostedViewClosingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IHostedViewClosingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
        {
            return ((delegate* unmanaged<IHostedViewClosingEventArgs*, IDeferral**, int>)(lpVtbl[6]))((IHostedViewClosingEventArgs*)Unsafe.AsPointer(ref this), result);
        }
    }
}
