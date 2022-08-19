using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori39_User32.dll
{
    class GlobalKeyBoard
    {
        public GlobalKeyBoard()
        {
            khp = new keyboardHookProc(hookproc);
        }
        
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);
        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);
        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref keyboardHookStruct IParam);
        [DllImport("user32.dll")]
        static extern short GetKeyState(int nCode);
        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string IpFileName);   // 라이브러리 등록


        public delegate int keyboardHookProc(int code, int vParam, ref keyboardHookStruct iParam); // callback delegate
        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;
        // 정의 되어 있는 상수 값
        const int VK_SHIFT = 0x10;
        const int VK_CONTROL = 0x11;
        const int VK_MENU = 0x12;

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;
        const int WM_SYSKEYDOWN = 0x104;

        const int WM_SYSKEYUP = 0x105;

        private keyboardHookProc khp;

        public void hook()
        {
            IntPtr hinstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, khp, hinstance, 0);
        }

        private void unhook()
        {
            UnhookWindowsHookEx(hhook);
        }
        IntPtr hhook = IntPtr.Zero;

        public int hookproc(int code, int vParam, ref keyboardHookStruct iParam)
        {
            Thread.Sleep(300);
            if (code >= 0)
            {
                Keys key = (Keys)iParam.vkCode;
                if ((GetKeyState(VK_CONTROL) & 0x80) != 0)
                {
                    key |= Keys.Control; ;
                }
                if ((GetKeyState(VK_MENU) & 0x80) != 0)
                {
                    key |= Keys.Alt; ;
                }
                if ((GetKeyState(VK_SHIFT) & 0x80) != 0)
                {
                    key |= Keys.Shift;
                }

                KeyEventArgs kea = new KeyEventArgs(key);
                if ((vParam == WM_KEYDOWN || vParam == WM_SYSKEYDOWN) && KeyDown != null )
                {
                    KeyDown(this, kea);
                }
                else if ((vParam == WM_KEYUP || vParam == WM_SYSKEYUP) && KeyUp != null )
                {
                    KeyUp(this, kea);
                }
                if (kea.Handled)
                {
                    return 1;
                }
            }
            return CallNextHookEx(hhook, code, vParam, ref iParam);
        }
   
    }
}
