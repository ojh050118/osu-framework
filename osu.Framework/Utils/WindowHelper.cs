// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Framework.Graphics.Primitives;
using osu.Framework.Logging;
using osu.Framework.Platform.Windows.WinAPI;

namespace osu.Framework.Utils
{
    public static class WindowHelper
    {
        public static IntPtr SetParentToDesktop(IntPtr windowHandle, WindowParent parent, int x, int y, int width, int height)
        {
            IntPtr progman = User32.FindWindow("progman", null);
            IntPtr result = IntPtr.Zero;
            IntPtr workerw = IntPtr.Zero;
            IntPtr listView = IntPtr.Zero;

            User32.SendMessageTimeout(progman, 0x052C, new IntPtr(0), IntPtr.Zero, 0x0, 1000, out result);
            User32.EnumWindows(new User32.EnumWindowsProc((topHandle, topParamHandle) =>
            {
                IntPtr p = User32.FindWindowEx(topHandle, IntPtr.Zero, "SHELLDLL_DefView", null);

                if (p != IntPtr.Zero)
                {
                    workerw = User32.FindWindowEx(IntPtr.Zero, topHandle, "WorkerW", null);
                    listView = User32.FindWindowEx(p, IntPtr.Zero, "SysListView32", null);
                }

                return true;
            }), IntPtr.Zero);

            switch (parent)
            {
                case WindowParent.Desktop:
                    User32.SetParent(windowHandle, User32.GetDesktopWindow());
                    break;

                case WindowParent.SysListView32:
                    User32.SetParent(windowHandle, listView);
                    break;

                case WindowParent.WorkerW:
                    User32.SetParent(windowHandle, workerw);
                    break;
            }

            var bounds = new RectangleI();

            // foreach (var display in displays)
            // {
            //     screenContainer.Add(createScreen(display, window.AsNonNull().CurrentDisplayBindable.Value.Index));
            //     bounds = RectangleI.Union(bounds, new RectangleI(display.Bounds.X, display.Bounds.Y, display.Bounds.Width, display.Bounds.Height));
            // }
            //
            // screenContainerOffset = bounds.Location;
            //
            // foreach (var box in screenContainer.Children)
            // {
            //     box.Position -= bounds.Location;
            // }
            //
            // screenContainer.Size = bounds.Size;

            uint style = User32.GetWindowLong(windowHandle, User32.GWL_STYLE);
            style &= ~(User32.WS_CAPTION | User32.WS_THICKFRAME | User32.WS_BORDER);

            User32.SetWindowLong(windowHandle, User32.GWL_STYLE, style);
            User32.SetWindowPos(windowHandle, IntPtr.Zero, x + 1920, y, width, height, 0x0040 | 0x0004 | 0x0001 | 0x0010 | 0x0020);

            Logger.Log($"Changed window parent to {parent}! progman: {progman} | workerw: {workerw}");

            switch (parent)
            {
                case WindowParent.Desktop:
                    return User32.GetDesktopWindow();

                case WindowParent.SysListView32:
                    return listView;

                default:
                    return workerw;
            }
        }
    }

    public enum WindowParent
    {
        Desktop,
        SysListView32,
        WorkerW
    }
}
