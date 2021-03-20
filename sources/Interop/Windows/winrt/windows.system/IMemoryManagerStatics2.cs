// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6EEE351F-6D62-423F-9479-B01F9C9F7669")]
    [NativeTypeName("struct IMemoryManagerStatics2 : IInspectable")]
    public unsafe partial struct IMemoryManagerStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMemoryManagerStatics2*, uint>)(lpVtbl[1]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMemoryManagerStatics2*, uint>)(lpVtbl[2]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics2*, IntPtr*, int>)(lpVtbl[4]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAppMemoryReport([NativeTypeName("ABI::Windows::System::IAppMemoryReport **")] IAppMemoryReport** memoryReport)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics2*, IAppMemoryReport**, int>)(lpVtbl[6]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this), memoryReport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProcessMemoryReport([NativeTypeName("ABI::Windows::System::IProcessMemoryReport **")] IProcessMemoryReport** memoryReport)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics2*, IProcessMemoryReport**, int>)(lpVtbl[7]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this), memoryReport);
        }
    }
}
