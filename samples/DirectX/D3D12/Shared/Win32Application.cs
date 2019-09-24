// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from Win32Application.h in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop;
using static TerraFX.Interop.User32;
using static TerraFX.Interop.Windows;

namespace TerraFX.Samples.DirectX.D3D12
{
    public static unsafe class Win32Application
    {
        private static readonly WNDPROC s_wndProc = WindowProc;
        private static readonly IntPtr s_wndProcHandle = Marshal.GetFunctionPointerForDelegate(s_wndProc);

        private static IntPtr s_hwnd;

        public static IntPtr Hwnd
        {
            get
            {
                return s_hwnd;
            }
        }

        public static int Run(DXSample pSample, IntPtr hInstance, int nCmdShow)
        {
            // Parse the command line parameters
            pSample.ParseCommandLineArgs(Environment.GetCommandLineArgs());

            fixed (char* lpszClassName = "DXSampleClass")
            fixed (char* lpWindowName = pSample.Title)
            {
                // Initialize the window class.
                var windowClass = new WNDCLASSEX {
                    cbSize = (uint)sizeof(WNDCLASSEX),
                    style = CS_HREDRAW | CS_VREDRAW,
                    lpfnWndProc = s_wndProcHandle,
                    hInstance = hInstance,
                    hCursor = LoadCursor(IntPtr.Zero, (ushort*)IDC_ARROW),
                    lpszClassName = (ushort*)lpszClassName
                };
                RegisterClassEx(&windowClass);

                var windowRect = new RECT {
                    right = unchecked((int)pSample.Width),
                    bottom = unchecked((int)pSample.Height)
                };
                AdjustWindowRect(&windowRect, WS_OVERLAPPEDWINDOW, FALSE);

                // Create the window and store a handle to it.
                s_hwnd = CreateWindowEx(
                    0,
                    windowClass.lpszClassName,
                    (ushort*)lpWindowName,
                    WS_OVERLAPPEDWINDOW,
                    CW_USEDEFAULT,
                    CW_USEDEFAULT,
                    windowRect.right - windowRect.left,
                    windowRect.bottom - windowRect.top,
                    IntPtr.Zero,                            // We have no parent window.
                    IntPtr.Zero,                            // We aren't using menus.
                    hInstance,
                    ((IntPtr)GCHandle.Alloc(pSample)).ToPointer()
                );
            }

            // Initialize the sample. OnInit is defined in each child-implementation of DXSample.
            pSample.OnInit();

            ShowWindow(s_hwnd, nCmdShow);

            // Main sample loop.
            MSG msg;

            do
            {
                // Process any messages in the queue.
                if (PeekMessage(&msg, IntPtr.Zero, 0, 0, PM_REMOVE) != 0)
                {
                    TranslateMessage(&msg);
                    DispatchMessage(&msg);
                }
            }
            while (msg.message != WM_QUIT);

            pSample.OnDestroy();

            // Return this part of the WM_QUIT message to Windows.
            return (int)msg.wParam;
        }

        // Main message handler for the sample
        private static IntPtr WindowProc(IntPtr hWnd, uint message, UIntPtr wParam, IntPtr lParam)
        {
            var handle = GetWindowLongPtr(hWnd, GWLP_USERDATA);
            var pSample = (handle != IntPtr.Zero) ? (DXSample?)GCHandle.FromIntPtr(handle).Target : null;

            switch (message)
            {
                case WM_CREATE:
                {
                    // Save the DXSample* passed in to CreateWindow.
                    var pCreateStruct = (CREATESTRUCT*)lParam;
                    SetWindowLongPtr(hWnd, GWLP_USERDATA, (IntPtr)pCreateStruct->lpCreateParams);
                }
                return IntPtr.Zero;

                case WM_KEYDOWN:
                {
                    pSample?.OnKeyDown((byte)wParam);
                    return IntPtr.Zero;
                }

                case WM_KEYUP:
                {
                    pSample?.OnKeyUp((byte)wParam);
                    return IntPtr.Zero;
                }

                case WM_PAINT:
                {
                    if (pSample != null)
                    {
                        pSample.OnUpdate();
                        pSample.OnRender();
                    }
                    return IntPtr.Zero;
                }

                case WM_DESTROY:
                {
                    PostQuitMessage(0);
                    return IntPtr.Zero;
                }
            }

            // Handle any messages the switch statement didn't.
            return DefWindowProc(hWnd, message, wParam, lParam);
        }
    }
}
