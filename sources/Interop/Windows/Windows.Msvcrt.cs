// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        internal static void* _new(nuint size)
        {
            void* p = malloc(size);

            if (_unlikely(p == null))
            {
                return _try_new(size, false);
            }

            return p;
        }

        [DllImport("msvcrt", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        private static extern void* malloc(nuint size);

        [DllImport("msvcrt", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        internal static extern void free(void* memblock);

        private static void* _try_new([NativeTypeName("size_t")] nuint size, bool nothrow)
        {
            void* p = null;

            while ((p == null) && _try_new_handler(nothrow))
            {
                p = malloc(size);
            }

            return p;
        }

        private static bool _try_new_handler(bool nothrow)
        {
            delegate* unmanaged[Cdecl]<void> h = std_get_new_handler();

            if (h == null)
            {
                if (!nothrow)
                {
                    // cannot throw in plain C, use exit as we are out of memory anyway.
                    exit(ENOMEM);
                }
                return false;
            }
            else
            {
                h();
                return true;
            }
        }

        private static readonly delegate*<delegate* unmanaged[Cdecl]<void>> std_get_new_handler = &win32_std_get_new_handler;

        [DllImport("msvcrt", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?get_new_handler@std@@YAP6AXXZXZ", ExactSpelling = true)]
        [return: NativeTypeName("std::new_handler")]
        private static extern delegate* unmanaged[Cdecl]<void> win32_std_get_new_handler();

        // out of memory
        private const int ENOMEM = 12;

        private static void exit(int status) => Environment.Exit(status);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool _unlikely(bool x) => x;
    }
}
